Imports System.Diagnostics
Imports System.Environment
Imports System.IO

Public Class DesktopAssistant

#Region "Global Variables"

    Public AppData As String = GetFolderPath(SpecialFolder.LocalApplicationData) & "\Desktop Assistant"
    Public Settings As String = AppData & "\settings.dat"
    Public AddrFile As String = AppData & "\addrbook.dat"

    Dim SW As StreamWriter
    Dim SR As StreamReader

    Public CloseToTray As Boolean = True

    ' Get a handle to an application window.
    Declare Auto Function FindWindow Lib "USER32.DLL" ( _
        ByVal lpClassName As String, _
        ByVal lpWindowName As String) As IntPtr

    ' Activate an application window.
    Declare Auto Function SetForegroundWindow Lib "USER32.DLL" _
        (ByVal hWnd As IntPtr) As Boolean

    Private Delegate Sub delUpdate()
    Private Finished As New delUpdate(AddressOf UpdateText)
    Dim Results, Args As String

    Dim Mode As Int16
    Dim StatusText = New String() {"", "AWAY", "LUNCH", "OFF"}
    Dim Header As String = "Desktop Assistant "

    Dim ElapsedTime As Integer = 0
    Dim ActionTime As Integer = 0

    Public RefreshTime As Integer = 10 * 60
    Public AwayTime As Integer = 15 * 60
    Public LunchTime As Integer = 30 * 60

    Dim time As String = ""
    Dim auto As Boolean = False

    Public Username As String = "username"
    Public RTpass As String = "******"
    Public PMpass As String = "******"

    Public AddressBook As New Dictionary(Of String, String)
    Public EditName As String
    Public EditNumber As String

#Region "SQLCMDs"
    Public NSSCopy As New Dictionary(Of String, String)

    Dim CheckAttached As String = "SQLCMD -S .\SQLEXPRESS -Q " & """" & "SELECT name FROM sys.databases" & """"
    Dim ViewAdminRoles As String = "SQLCMD -S .\SQLEXPRESS -Q " & """" & "EXEC sp_helpsrvrolemember" & """"
    Dim AttachDataBase As String = "SQLCMD -S .\SQLEXPRESS -Q " & """" & "CREATE DATABASE [Nestle] ON " & _
                                   "( FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\Nestle.mdf' ), " & _
                                   "( FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\Nestle_log.ldf' ) " & _
                                   "FOR ATTACH ;" & """" & "/d master"
    Dim AttachDataBaseMGMT As String = "SQLCMD -S .\SQLEXPRESS -Q " & """" & "CREATE DATABASE [NSSManagementOfflineDB] ON " & _
                                   "( FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\NSSManagementOfflineDB.mdf' ), " & _
                                   "( FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\NSSManagementOfflineDB_log.ldf' ) " & _
                                   "FOR ATTACH ;" & """" & "/d master"
    Dim DropDataBase As String = "SQLCMD -S .\SQLEXPRESS -Q " & """" & "DROP database Nestle" & """"
    Dim DropDataBaseMGMT As String = "SQLCMD -S .\SQLEXPRESS -Q " & """" & "DROP database NSSManagementOfflineDB" & """"

#End Region


#End Region

#Region "Form Load and Initialize"

    ' initialize on load
    Private Sub ShoreTelAssistant_Load _
        (sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' if /AppData/Desktop Assistant <> Exist, Create
        If Not System.IO.Directory.Exists(AppData) Then
            System.IO.Directory.CreateDirectory(AppData)
            Dim FS As FileStream = File.Create(Settings)
            FS.Close()
            FS = File.Create(AddrFile)
            FS.Close()

            AddressBook.Add("Cami Flores", "122")
            AddressBook.Add("Mark Schmidt", "127")
            AddressBook.Add("Jeremy Lopez", "156")
            AddressBook.Add("Don Bowman", "192")
            AddressBook.Add("Poorna Kadiresan", "194")
            AddressBook.Add("Sandi Pratt", "327")
            AddressBook.Add("Afterhours", "329")
            AddressBook.Add("Tracy Caraway", "330")
            AddressBook.Add("Lew Houston", "331")
            AddressBook.Add("Sally Zheng", "332")
            AddressBook.Add("Sarah Pardee", "333")
            AddressBook.Add("Nestle Help Desk", "8009426828")

            SaveAddressBook()

            MsgBox("Please review options and enter passwords.", MsgBoxStyle.Information, "First Time User")
            Options.ShowDialog()
        Else
            SR = File.OpenText(Settings)

            ' Read Username
            Username = SR.ReadLine

            ' Read Passwords
            RTpass = SR.ReadLine
            PMpass = SR.ReadLine

            ' Read Settings
            AwayTime = SR.ReadLine
            LunchTime = SR.ReadLine
            CloseToTray = Boolean.TryParse(SR.ReadLine, CloseToTray)

            SR.Close()

            ' Read Address Book

            SR = File.OpenText(AddrFile)
            Dim i As Int16 = 1
            Dim k As String = ""
            Dim v As String = ""

            Do While SR.Peek <> -1
                If i > 0 Then
                    k = SR.ReadLine
                ElseIf i < 0 Then
                    v = SR.ReadLine
                    AddressBook.Add(k, v)
                End If

                i *= -1
            Loop
            SR.Close()
        End If

        tbNATO.Text = My.Resources.NATO

        ' iterate through AddressBook, add Key to cbDirectory
        For Each pair In AddressBook
            cbDirectory.Items.Add(pair.Key)
        Next

        cbDirectory.SelectedIndex = 0

        NSSCopy.Add("Check Attached Databases", CheckAttached)
        NSSCopy.Add("View Admin Roles", ViewAdminRoles)
        NSSCopy.Add("ATTACH Salesrep Database", AttachDataBase)
        NSSCopy.Add("ATTACH Management Database", AttachDataBaseMGMT)
        NSSCopy.Add("DROP Salesrep Database", DropDataBase)
        NSSCopy.Add("DROP Management Database", DropDataBaseMGMT)

        For Each pair In NSSCopy
            cbNSSCopy.Items.Add(pair.Key)
        Next

    End Sub

#End Region

#Region "Radio Buttons"

    ' Logged In
    Private Sub rbDefault_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbDefault.CheckedChanged
        If rbDefault.Checked Then
            ' log
            If Not auto And time <> "" Then
                tbLog.Text &= DateAndTime.TimeString & " Manual Login at " & time & vbNewLine
                auto = False
            End If

            ResetAction()
            Updater(0)
            STAutomate(Mode)

        End If
    End Sub

    ' Away
    Private Sub rbAway_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbAway.CheckedChanged
        If rbAway.Checked Then
            ResetAction()
            Updater(1)
            STAutomate(Mode)

            ActionTime = AwayTime
            Action()
        End If
    End Sub

    ' Lunch
    Private Sub rbLunch_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbLunch.CheckedChanged
        If rbLunch.Checked Then
            ResetAction()
            Updater(2)
            STAutomate(Mode)

            ActionTime = LunchTime
            Action()
        End If
    End Sub

    ' Off
    Private Sub rbOff_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbOff.CheckedChanged
        If rbOff.Checked Then
            ResetAction()
            Updater(3)
            STAutomate(Mode)

            tmrOff.Enabled = True
            tmrOff.Start()
        Else
            tmrOff.Stop()
            tmrOff.Enabled = False
        End If
    End Sub

#End Region

#Region "Nestle Tab"

#Region "Copy Paste"

    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click
        Dim paste As String = ""

        ' get value from key
        paste = NSSCopy.Item(cbNSSCopy.SelectedItem)
        'copy contents of paste to clipboard
        Clipboard.SetText(paste)
        txtPaste.Text = paste
    End Sub
#End Region

#Region "Change User Batch"
    Private Sub btnRun_Click(sender As System.Object, e As System.EventArgs) Handles btnRun.Click
        'ensure uname and pword are not null or empty
        If String.IsNullOrWhiteSpace(txtUser.Text) Or String.IsNullOrWhiteSpace(txtPass.Text) Then
            MsgBox("Username and Password cannot be blank", MsgBoxStyle.OkOnly)
        Else 'run batch file
            Args = txtUser.Text & " " & txtPass.Text

            Dim CMDThread As New Threading.Thread(AddressOf CMDAutomate)
            CMDThread.Start()

        End If

    End Sub

    Private Sub UpdateText()
        txtConsole.Text = Results
    End Sub

    Private Sub CMDAutomate()
        Dim proc As New Process
        Dim info As New System.Diagnostics.ProcessStartInfo

        'create write location, fetch content
        Dim fname As String = "c:\windows\temp\user.bat"
        Dim content As String = My.Resources.user

        'write file to c:\windows\temp
        My.Computer.FileSystem.WriteAllText(fname, content, False, System.Text.Encoding.ASCII)

        'proc.info
        With info
            .FileName = fname
            .Arguments = Args
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .UseShellExecute = False 'required to redirect
            .CreateNoWindow = True 'creates no cmd window
        End With

        proc.StartInfo = info
        proc.Start() 'start user.bat

        SW = proc.StandardInput
        SR = proc.StandardOutput

        SW.WriteLine("exit") 'returns results of command window
        Results = SR.ReadToEnd 'returns results of the command window

        SW.Close()
        SR.Close()

        'delete c:\windows\temp\user.bat from machine
        My.Computer.FileSystem.DeleteFile(fname)

        'invokes Finished delegate, which updates textbox with the results text
        Invoke(Finished)

    End Sub
#End Region

#End Region

#Region "Methods"

    Private Sub Updater(ByVal m As Int16)
        Mode = m
        Me.Text = Header & StatusText(Mode)

        ' log
        If m <> 0 Then
            tbLog.Text &= DateAndTime.TimeString & " Mode Changed to " & StatusText(Mode) & vbNewLine
        End If
    End Sub

    Private Sub Action()
        tsProgress.Maximum = ActionTime
        tmrWatch.Enabled = True
        tmrWatch.Start()
    End Sub

    Private Sub ResetAction()
        tmrWatch.Stop()
        tmrWatch.Enabled = False
        ElapsedTime = 0
        tsProgress.Value = 0
        tbTime.Text = "00:00"
    End Sub

    ' Send a series of key presses to the application
    Private Sub STAutomate(ByVal opt As Integer, Optional ByVal num As String = "")
        ' get a handle to the application. the window class
        ' and window name were obtained use the Spy++ tool

        Dim apphandle As IntPtr =
            FindWindow("WindowsForms10.Window.8.app.0.3ce0bb8", "329 - ShoreTel Communicator")

        ' verify that app is a running process
        If apphandle = IntPtr.Zero Then
            MsgBox("Application is not running")
            Return
        End If

        ' make app the foreground app and send it keystrokes
        SetForegroundWindow(apphandle)
        SetForegroundWindow(apphandle)

        Dim key As String = ""
        If opt = 0 Then ' login to shoretel
            key = "%^i"
            tbStatus.Text = "SIGNED IN"
            tbStatus.BackColor = Color.PaleGreen
        ElseIf opt < 4 Then ' logout of shoretel
            key = "%^o"
            tbStatus.Text = "SIGNED OUT"
            tbStatus.BackColor = Color.Crimson
        ElseIf opt = 4 Then ' call number
            key = num & "{ENTER}"
        ElseIf opt = 5 Then 'no enter
            key = num
        End If

        SendKeys.SendWait(key)

    End Sub

    Private Sub SaveAddressBook()
        SW = File.CreateText(AddrFile)
        For Each pair In AddressBook
            SW.WriteLine(pair.Key)
            SW.WriteLine(pair.Value)
        Next
        SW.Close()
    End Sub

    ' Loops for a specificied period of time (milliseconds)
    Private Sub Wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

#End Region

#Region "nIcon Region"
    Private Sub nIcon_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles nIcon.MouseDoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            'nIcon.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub nIcon_MouseRightClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles nIcon.MouseClick
        If (e.Button = Windows.Forms.MouseButtons.Right) Then
            cmStrip.Show(Cursor.Position)
        End If
    End Sub

#End Region

#Region "Tool Strip Menu"

    Private Sub LogInToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogInToolStripMenuItem.Click
        rbDefault.Checked = True
    End Sub

    Private Sub AwayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AwayToolStripMenuItem.Click
        rbAway.Checked = True
    End Sub

    Private Sub LunchToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LunchToolStripMenuItem.Click
        rbLunch.Checked = True
    End Sub

    Private Sub OffToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OffToolStripMenuItem.Click
        rbOff.Checked = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        CloseToTray = False
        Me.Close()
    End Sub

    Private Sub ShoreTelAssistant_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If CloseToTray Then
            Try
                e.Cancel = True
                Me.Visible = False
                nIcon.Visible = True
                'nIcon.ShowBalloonTip(1, "ShoreTel Assistant", _
                '                    "Application has not been closed. It has been moved to the tray", ToolTipIcon.Info)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If



    End Sub

#End Region

#Region "Timers"

    Private Sub tmrWatch_Tick(sender As System.Object, e As System.EventArgs) Handles tmrWatch.Tick
        ElapsedTime += 1
        tsProgress.PerformStep()

        ' computer minutes:seconds from elapsed time
        Dim tmp As Integer
        tmp = Int(ElapsedTime / 60)
        If tmp < 10 Then
            time = "0" & tmp & ":"
        Else
            time = tmp & ":"
        End If

        tmp = Int(ElapsedTime Mod 60)
        If tmp < 10 Then
            time &= "0" & tmp
        Else
            time &= tmp
        End If

        tbTime.Text = time

        If ElapsedTime = ActionTime Then
            ResetAction()

            tbLog.Text &= DateAndTime.TimeString & " Logged In Automatically" & vbNewLine
            auto = True
            rbDefault.Checked = True
        End If

    End Sub

    Private Sub tmrOff_Tick(sender As System.Object, e As System.EventArgs) Handles tmrOff.Tick
        If DateTime.Now.Hour = 13 Then
            tbLog.Text &= DateAndTime.TimeString & " Logged In Automatically" & vbNewLine
            auto = True
            rbDefault.Checked = True
        End If
    End Sub

#End Region

#Region "Support Tab"

#Region "Directory"

    Dim number As String

    Private Sub cbDirectory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbDirectory.SelectedIndexChanged
        number = AddressBook.Item(cbDirectory.SelectedItem)
        tbPhoneNumber.Text = number
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        AddContact.ShowDialog()

        ' Save Address Book to Disk
        SaveAddressBook()
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        AddressBook.Remove(cbDirectory.SelectedItem)
        tbLog.Text &= DateAndTime.TimeString & " Removed " & cbDirectory.SelectedItem & " from Address Book" & vbNewLine
        cbDirectory.Items.Remove(cbDirectory.SelectedItem)

        SaveAddressBook()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        EditName = cbDirectory.SelectedItem
        EditNumber = AddressBook.Item(EditName)

        AddContact.Edit = True

        AddContact.ShowDialog()
    End Sub

#End Region

#Region "Dialer"

    Private Sub btnCallDir_Click(sender As System.Object, e As System.EventArgs) Handles btnCallDir.Click
        tbLog.Text &= DateAndTime.TimeString & " Dialing " & tbPhoneNumber.Text & vbNewLine
        STAutomate(4, tbPhoneNumber.Text)
    End Sub

    Private Sub btnHold_Click(sender As System.Object, e As System.EventArgs) Handles btnHold.Click
        STAutomate(5, "^h")
    End Sub

    Private Sub btnHang_Click(sender As System.Object, e As System.EventArgs) Handles btnHang.Click
        STAutomate(5, "^u")
    End Sub

    Private Sub btnTransfer_Click(sender As System.Object, e As System.EventArgs) Handles btnTransfer.Click
        STAutomate(4, "^t" & number)
    End Sub

    Private Sub btnConference_Click(sender As System.Object, e As System.EventArgs) Handles btnConference.Click
        STAutomate(4, "^j" & number)
    End Sub

#End Region

#End Region

#Region "Buttons"
    Dim login As String = ""

    ' launch RT website, copy password to clipboard
    Private Sub btnRT_Click(sender As System.Object, e As System.EventArgs) Handles btnRT.Click
        login = Username & "{TAB}" & RTpass & "{ENTER}"
        System.Diagnostics.Process.Start("http://rt.inside.rw3.com/")
        Wait(1000)
        SendKeys.Send(login)
    End Sub

    ' launch PM website, copy password to clipboard
    Private Sub btnPM_Click(sender As System.Object, e As System.EventArgs) Handles btnPM.Click
        login = Username & "{TAB}" & PMpass & "{ENTER}"
        System.Diagnostics.Process.Start("http://projectmanager.rw3.com/")
        Wait(1000)
        SendKeys.Send(login)
    End Sub

    ' open Options form
    Private Sub btnOptions_Click(sender As System.Object, e As System.EventArgs) Handles btnOptions.Click
        Options.ShowDialog()
    End Sub

#End Region


End Class
