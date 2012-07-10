<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesktopAssistant
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DesktopAssistant))
        Me.gbMode = New System.Windows.Forms.GroupBox()
        Me.rbLunch = New System.Windows.Forms.RadioButton()
        Me.rbOff = New System.Windows.Forms.RadioButton()
        Me.rbDefault = New System.Windows.Forms.RadioButton()
        Me.rbAway = New System.Windows.Forms.RadioButton()
        Me.tmrWatch = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbStatus = New System.Windows.Forms.TextBox()
        Me.cmStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LogInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AwayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LunchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.tMode = New System.Windows.Forms.TabPage()
        Me.btnRT = New System.Windows.Forms.Button()
        Me.btnPM = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.tsProgress = New System.Windows.Forms.ProgressBar()
        Me.tbTime = New System.Windows.Forms.TextBox()
        Me.tSupport = New System.Windows.Forms.TabPage()
        Me.SupportTab = New System.Windows.Forms.TabControl()
        Me.tDirectory = New System.Windows.Forms.TabPage()
        Me.btnHang = New System.Windows.Forms.Button()
        Me.btnHold = New System.Windows.Forms.Button()
        Me.gbDir = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cbDirectory = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPhoneNumber = New System.Windows.Forms.TextBox()
        Me.btnConference = New System.Windows.Forms.Button()
        Me.btnCallDir = New System.Windows.Forms.Button()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.tNATO = New System.Windows.Forms.TabPage()
        Me.tbNATO = New System.Windows.Forms.TextBox()
        Me.tNSS = New System.Windows.Forms.TabPage()
        Me.NSSTab = New System.Windows.Forms.TabControl()
        Me.tClip = New System.Windows.Forms.TabPage()
        Me.cbNSSCopy = New System.Windows.Forms.ComboBox()
        Me.txtPaste = New System.Windows.Forms.TextBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.tUser = New System.Windows.Forms.TabPage()
        Me.txtConsole = New System.Windows.Forms.TextBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.tKellogg = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tProxy = New System.Windows.Forms.TabPage()
        Me.gbProxyKCAN = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.gbProxyKUSA = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbAutoScript = New System.Windows.Forms.TextBox()
        Me.tbPort = New System.Windows.Forms.TextBox()
        Me.tbProxy = New System.Windows.Forms.TextBox()
        Me.tLog = New System.Windows.Forms.TabPage()
        Me.gbLog = New System.Windows.Forms.GroupBox()
        Me.tbLog = New System.Windows.Forms.TextBox()
        Me.tmrOff = New System.Windows.Forms.Timer(Me.components)
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.gbMode.SuspendLayout()
        Me.cmStrip.SuspendLayout()
        Me.Tab.SuspendLayout()
        Me.tMode.SuspendLayout()
        Me.tSupport.SuspendLayout()
        Me.SupportTab.SuspendLayout()
        Me.tDirectory.SuspendLayout()
        Me.gbDir.SuspendLayout()
        Me.tNATO.SuspendLayout()
        Me.tNSS.SuspendLayout()
        Me.NSSTab.SuspendLayout()
        Me.tClip.SuspendLayout()
        Me.tUser.SuspendLayout()
        Me.tKellogg.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tProxy.SuspendLayout()
        Me.gbProxyKCAN.SuspendLayout()
        Me.gbProxyKUSA.SuspendLayout()
        Me.tLog.SuspendLayout()
        Me.gbLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMode
        '
        Me.gbMode.Controls.Add(Me.rbLunch)
        Me.gbMode.Controls.Add(Me.rbOff)
        Me.gbMode.Controls.Add(Me.rbDefault)
        Me.gbMode.Controls.Add(Me.rbAway)
        Me.gbMode.Location = New System.Drawing.Point(8, 6)
        Me.gbMode.Name = "gbMode"
        Me.gbMode.Size = New System.Drawing.Size(270, 108)
        Me.gbMode.TabIndex = 0
        Me.gbMode.TabStop = False
        Me.gbMode.Text = "Mode"
        '
        'rbLunch
        '
        Me.rbLunch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbLunch.AutoSize = True
        Me.rbLunch.Location = New System.Drawing.Point(6, 62)
        Me.rbLunch.Name = "rbLunch"
        Me.rbLunch.Size = New System.Drawing.Size(55, 17)
        Me.rbLunch.TabIndex = 0
        Me.rbLunch.Text = "Lunch"
        Me.rbLunch.UseVisualStyleBackColor = True
        '
        'rbOff
        '
        Me.rbOff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbOff.AutoSize = True
        Me.rbOff.Location = New System.Drawing.Point(6, 85)
        Me.rbOff.Name = "rbOff"
        Me.rbOff.Size = New System.Drawing.Size(43, 17)
        Me.rbOff.TabIndex = 0
        Me.rbOff.Text = "Off"
        Me.rbOff.UseVisualStyleBackColor = True
        '
        'rbDefault
        '
        Me.rbDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDefault.AutoSize = True
        Me.rbDefault.Checked = True
        Me.rbDefault.Location = New System.Drawing.Point(6, 16)
        Me.rbDefault.Name = "rbDefault"
        Me.rbDefault.Size = New System.Drawing.Size(79, 17)
        Me.rbDefault.TabIndex = 0
        Me.rbDefault.TabStop = True
        Me.rbDefault.Text = "Logged In"
        Me.rbDefault.UseVisualStyleBackColor = True
        '
        'rbAway
        '
        Me.rbAway.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbAway.AutoSize = True
        Me.rbAway.Location = New System.Drawing.Point(6, 39)
        Me.rbAway.Name = "rbAway"
        Me.rbAway.Size = New System.Drawing.Size(109, 17)
        Me.rbAway.TabIndex = 0
        Me.rbAway.Text = "Away From Desk"
        Me.rbAway.UseVisualStyleBackColor = True
        '
        'tmrWatch
        '
        Me.tmrWatch.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ShoreTel Status:"
        '
        'tbStatus
        '
        Me.tbStatus.Location = New System.Drawing.Point(116, 120)
        Me.tbStatus.Name = "tbStatus"
        Me.tbStatus.ReadOnly = True
        Me.tbStatus.Size = New System.Drawing.Size(99, 20)
        Me.tbStatus.TabIndex = 2
        Me.tbStatus.Text = "STATUS"
        Me.tbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmStrip
        '
        Me.cmStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogInToolStripMenuItem, Me.AwayToolStripMenuItem, Me.LunchToolStripMenuItem, Me.OffToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.cmStrip.Name = "cmStrip"
        Me.cmStrip.Size = New System.Drawing.Size(108, 120)
        '
        'LogInToolStripMenuItem
        '
        Me.LogInToolStripMenuItem.Name = "LogInToolStripMenuItem"
        Me.LogInToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.LogInToolStripMenuItem.Text = "&Log In"
        '
        'AwayToolStripMenuItem
        '
        Me.AwayToolStripMenuItem.Name = "AwayToolStripMenuItem"
        Me.AwayToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AwayToolStripMenuItem.Text = "&Away"
        '
        'LunchToolStripMenuItem
        '
        Me.LunchToolStripMenuItem.Name = "LunchToolStripMenuItem"
        Me.LunchToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.LunchToolStripMenuItem.Text = "&Lunch"
        '
        'OffToolStripMenuItem
        '
        Me.OffToolStripMenuItem.Name = "OffToolStripMenuItem"
        Me.OffToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.OffToolStripMenuItem.Text = "&Off"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(104, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'nIcon
        '
        Me.nIcon.Icon = CType(resources.GetObject("nIcon.Icon"), System.Drawing.Icon)
        Me.nIcon.Text = "ShoreTel Assistant"
        Me.nIcon.Visible = True
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.tMode)
        Me.Tab.Controls.Add(Me.tSupport)
        Me.Tab.Controls.Add(Me.tNSS)
        Me.Tab.Controls.Add(Me.tKellogg)
        Me.Tab.Controls.Add(Me.tLog)
        Me.Tab.Dock = System.Windows.Forms.DockStyle.Top
        Me.Tab.Location = New System.Drawing.Point(0, 0)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(294, 266)
        Me.Tab.TabIndex = 1
        '
        'tMode
        '
        Me.tMode.Controls.Add(Me.btnRT)
        Me.tMode.Controls.Add(Me.btnPM)
        Me.tMode.Controls.Add(Me.btnOptions)
        Me.tMode.Controls.Add(Me.tsProgress)
        Me.tMode.Controls.Add(Me.gbMode)
        Me.tMode.Controls.Add(Me.Label1)
        Me.tMode.Controls.Add(Me.tbTime)
        Me.tMode.Controls.Add(Me.tbStatus)
        Me.tMode.Location = New System.Drawing.Point(4, 22)
        Me.tMode.Name = "tMode"
        Me.tMode.Padding = New System.Windows.Forms.Padding(3)
        Me.tMode.Size = New System.Drawing.Size(286, 240)
        Me.tMode.TabIndex = 0
        Me.tMode.Text = "ShoreTel"
        Me.tMode.UseVisualStyleBackColor = True
        '
        'btnRT
        '
        Me.btnRT.Location = New System.Drawing.Point(25, 209)
        Me.btnRT.Name = "btnRT"
        Me.btnRT.Size = New System.Drawing.Size(75, 23)
        Me.btnRT.TabIndex = 4
        Me.btnRT.Text = "Launch RT"
        Me.btnRT.UseVisualStyleBackColor = True
        '
        'btnPM
        '
        Me.btnPM.Location = New System.Drawing.Point(106, 209)
        Me.btnPM.Name = "btnPM"
        Me.btnPM.Size = New System.Drawing.Size(75, 23)
        Me.btnPM.TabIndex = 4
        Me.btnPM.Text = "Launch PM"
        Me.btnPM.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.Location = New System.Drawing.Point(187, 209)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(75, 23)
        Me.btnOptions.TabIndex = 4
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'tsProgress
        '
        Me.tsProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.tsProgress.Location = New System.Drawing.Point(8, 146)
        Me.tsProgress.Name = "tsProgress"
        Me.tsProgress.Size = New System.Drawing.Size(270, 23)
        Me.tsProgress.Step = 1
        Me.tsProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.tsProgress.TabIndex = 3
        '
        'tbTime
        '
        Me.tbTime.Location = New System.Drawing.Point(221, 120)
        Me.tbTime.Name = "tbTime"
        Me.tbTime.ReadOnly = True
        Me.tbTime.Size = New System.Drawing.Size(57, 20)
        Me.tbTime.TabIndex = 2
        Me.tbTime.Text = "00:00"
        Me.tbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tSupport
        '
        Me.tSupport.Controls.Add(Me.SupportTab)
        Me.tSupport.Location = New System.Drawing.Point(4, 22)
        Me.tSupport.Name = "tSupport"
        Me.tSupport.Padding = New System.Windows.Forms.Padding(3)
        Me.tSupport.Size = New System.Drawing.Size(286, 240)
        Me.tSupport.TabIndex = 5
        Me.tSupport.Text = "Support"
        Me.tSupport.UseVisualStyleBackColor = True
        '
        'SupportTab
        '
        Me.SupportTab.Controls.Add(Me.tDirectory)
        Me.SupportTab.Controls.Add(Me.tNATO)
        Me.SupportTab.Location = New System.Drawing.Point(8, 6)
        Me.SupportTab.Name = "SupportTab"
        Me.SupportTab.SelectedIndex = 0
        Me.SupportTab.Size = New System.Drawing.Size(270, 226)
        Me.SupportTab.TabIndex = 1
        '
        'tDirectory
        '
        Me.tDirectory.Controls.Add(Me.btnHang)
        Me.tDirectory.Controls.Add(Me.btnHold)
        Me.tDirectory.Controls.Add(Me.gbDir)
        Me.tDirectory.Controls.Add(Me.Label4)
        Me.tDirectory.Controls.Add(Me.tbPhoneNumber)
        Me.tDirectory.Controls.Add(Me.btnConference)
        Me.tDirectory.Controls.Add(Me.btnCallDir)
        Me.tDirectory.Controls.Add(Me.btnTransfer)
        Me.tDirectory.Location = New System.Drawing.Point(4, 22)
        Me.tDirectory.Name = "tDirectory"
        Me.tDirectory.Padding = New System.Windows.Forms.Padding(3)
        Me.tDirectory.Size = New System.Drawing.Size(262, 200)
        Me.tDirectory.TabIndex = 1
        Me.tDirectory.Text = "Directory"
        Me.tDirectory.UseVisualStyleBackColor = True
        '
        'btnHang
        '
        Me.btnHang.BackColor = System.Drawing.Color.Crimson
        Me.btnHang.Location = New System.Drawing.Point(181, 62)
        Me.btnHang.Name = "btnHang"
        Me.btnHang.Size = New System.Drawing.Size(75, 23)
        Me.btnHang.TabIndex = 9
        Me.btnHang.Text = "Hang Up"
        Me.btnHang.UseVisualStyleBackColor = False
        '
        'btnHold
        '
        Me.btnHold.BackColor = System.Drawing.Color.Gold
        Me.btnHold.Location = New System.Drawing.Point(181, 33)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(75, 23)
        Me.btnHold.TabIndex = 9
        Me.btnHold.Text = "Hold"
        Me.btnHold.UseVisualStyleBackColor = False
        '
        'gbDir
        '
        Me.gbDir.Controls.Add(Me.btnEdit)
        Me.gbDir.Controls.Add(Me.btnRemove)
        Me.gbDir.Controls.Add(Me.btnAdd)
        Me.gbDir.Controls.Add(Me.cbDirectory)
        Me.gbDir.Location = New System.Drawing.Point(9, 118)
        Me.gbDir.Name = "gbDir"
        Me.gbDir.Size = New System.Drawing.Size(247, 75)
        Me.gbDir.TabIndex = 8
        Me.gbDir.TabStop = False
        Me.gbDir.Text = "Address Book"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(86, 46)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(6, 46)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cbDirectory
        '
        Me.cbDirectory.FormattingEnabled = True
        Me.cbDirectory.Location = New System.Drawing.Point(6, 19)
        Me.cbDirectory.Name = "cbDirectory"
        Me.cbDirectory.Size = New System.Drawing.Size(235, 21)
        Me.cbDirectory.Sorted = True
        Me.cbDirectory.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dial:"
        '
        'tbPhoneNumber
        '
        Me.tbPhoneNumber.Location = New System.Drawing.Point(49, 8)
        Me.tbPhoneNumber.Name = "tbPhoneNumber"
        Me.tbPhoneNumber.Size = New System.Drawing.Size(126, 20)
        Me.tbPhoneNumber.TabIndex = 5
        '
        'btnConference
        '
        Me.btnConference.Location = New System.Drawing.Point(100, 62)
        Me.btnConference.Name = "btnConference"
        Me.btnConference.Size = New System.Drawing.Size(75, 23)
        Me.btnConference.TabIndex = 4
        Me.btnConference.Text = "Conference"
        Me.btnConference.UseVisualStyleBackColor = True
        '
        'btnCallDir
        '
        Me.btnCallDir.BackColor = System.Drawing.Color.PaleGreen
        Me.btnCallDir.Location = New System.Drawing.Point(181, 6)
        Me.btnCallDir.Name = "btnCallDir"
        Me.btnCallDir.Size = New System.Drawing.Size(75, 23)
        Me.btnCallDir.TabIndex = 3
        Me.btnCallDir.Text = "Call"
        Me.btnCallDir.UseVisualStyleBackColor = False
        '
        'btnTransfer
        '
        Me.btnTransfer.Location = New System.Drawing.Point(100, 33)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(75, 23)
        Me.btnTransfer.TabIndex = 2
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'tNATO
        '
        Me.tNATO.Controls.Add(Me.tbNATO)
        Me.tNATO.Location = New System.Drawing.Point(4, 22)
        Me.tNATO.Name = "tNATO"
        Me.tNATO.Padding = New System.Windows.Forms.Padding(3)
        Me.tNATO.Size = New System.Drawing.Size(262, 200)
        Me.tNATO.TabIndex = 0
        Me.tNATO.Text = "Phonetic Alphabet"
        Me.tNATO.UseVisualStyleBackColor = True
        '
        'tbNATO
        '
        Me.tbNATO.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNATO.Location = New System.Drawing.Point(6, 6)
        Me.tbNATO.Multiline = True
        Me.tbNATO.Name = "tbNATO"
        Me.tbNATO.ReadOnly = True
        Me.tbNATO.Size = New System.Drawing.Size(250, 188)
        Me.tbNATO.TabIndex = 0
        Me.tbNATO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tNSS
        '
        Me.tNSS.Controls.Add(Me.NSSTab)
        Me.tNSS.Location = New System.Drawing.Point(4, 22)
        Me.tNSS.Name = "tNSS"
        Me.tNSS.Padding = New System.Windows.Forms.Padding(3)
        Me.tNSS.Size = New System.Drawing.Size(286, 240)
        Me.tNSS.TabIndex = 4
        Me.tNSS.Text = "NSS"
        Me.tNSS.UseVisualStyleBackColor = True
        '
        'NSSTab
        '
        Me.NSSTab.Controls.Add(Me.tClip)
        Me.NSSTab.Controls.Add(Me.tUser)
        Me.NSSTab.Location = New System.Drawing.Point(8, 6)
        Me.NSSTab.Name = "NSSTab"
        Me.NSSTab.SelectedIndex = 0
        Me.NSSTab.Size = New System.Drawing.Size(270, 226)
        Me.NSSTab.TabIndex = 0
        '
        'tClip
        '
        Me.tClip.Controls.Add(Me.cbNSSCopy)
        Me.tClip.Controls.Add(Me.txtPaste)
        Me.tClip.Controls.Add(Me.btnCopy)
        Me.tClip.Location = New System.Drawing.Point(4, 22)
        Me.tClip.Name = "tClip"
        Me.tClip.Padding = New System.Windows.Forms.Padding(3)
        Me.tClip.Size = New System.Drawing.Size(262, 200)
        Me.tClip.TabIndex = 0
        Me.tClip.Text = "SQLCMD"
        Me.tClip.UseVisualStyleBackColor = True
        '
        'cbNSSCopy
        '
        Me.cbNSSCopy.FormattingEnabled = True
        Me.cbNSSCopy.Location = New System.Drawing.Point(7, 7)
        Me.cbNSSCopy.Name = "cbNSSCopy"
        Me.cbNSSCopy.Size = New System.Drawing.Size(249, 21)
        Me.cbNSSCopy.TabIndex = 9013
        '
        'txtPaste
        '
        Me.txtPaste.BackColor = System.Drawing.SystemColors.Control
        Me.txtPaste.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaste.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPaste.Location = New System.Drawing.Point(7, 63)
        Me.txtPaste.Multiline = True
        Me.txtPaste.Name = "txtPaste"
        Me.txtPaste.ReadOnly = True
        Me.txtPaste.Size = New System.Drawing.Size(249, 131)
        Me.txtPaste.TabIndex = 9012
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(131, 34)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(125, 23)
        Me.btnCopy.TabIndex = 9011
        Me.btnCopy.Text = "Copy to Clipboard"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'tUser
        '
        Me.tUser.Controls.Add(Me.txtConsole)
        Me.tUser.Controls.Add(Me.btnRun)
        Me.tUser.Controls.Add(Me.Label2)
        Me.tUser.Controls.Add(Me.txtPass)
        Me.tUser.Controls.Add(Me.Label3)
        Me.tUser.Controls.Add(Me.txtUser)
        Me.tUser.Location = New System.Drawing.Point(4, 22)
        Me.tUser.Name = "tUser"
        Me.tUser.Padding = New System.Windows.Forms.Padding(3)
        Me.tUser.Size = New System.Drawing.Size(262, 200)
        Me.tUser.TabIndex = 1
        Me.tUser.Text = "Change User"
        Me.tUser.UseVisualStyleBackColor = True
        '
        'txtConsole
        '
        Me.txtConsole.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsole.Location = New System.Drawing.Point(11, 58)
        Me.txtConsole.Multiline = True
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.ReadOnly = True
        Me.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConsole.Size = New System.Drawing.Size(242, 136)
        Me.txtConsole.TabIndex = 9012
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(197, 9)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(39, 39)
        Me.btnRun.TabIndex = 9011
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 9008
        Me.Label2.Text = "Username:"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(91, 32)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 9010
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 9007
        Me.Label3.Text = "Password:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(91, 6)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 9009
        '
        'tKellogg
        '
        Me.tKellogg.Controls.Add(Me.TabControl1)
        Me.tKellogg.Location = New System.Drawing.Point(4, 22)
        Me.tKellogg.Name = "tKellogg"
        Me.tKellogg.Padding = New System.Windows.Forms.Padding(3)
        Me.tKellogg.Size = New System.Drawing.Size(286, 240)
        Me.tKellogg.TabIndex = 6
        Me.tKellogg.Text = "Kellogg"
        Me.tKellogg.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tProxy)
        Me.TabControl1.Location = New System.Drawing.Point(8, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(270, 226)
        Me.TabControl1.TabIndex = 0
        '
        'tProxy
        '
        Me.tProxy.Controls.Add(Me.gbProxyKCAN)
        Me.tProxy.Controls.Add(Me.gbProxyKUSA)
        Me.tProxy.Location = New System.Drawing.Point(4, 22)
        Me.tProxy.Name = "tProxy"
        Me.tProxy.Padding = New System.Windows.Forms.Padding(3)
        Me.tProxy.Size = New System.Drawing.Size(262, 200)
        Me.tProxy.TabIndex = 0
        Me.tProxy.Text = "Proxy Settings"
        Me.tProxy.UseVisualStyleBackColor = True
        '
        'gbProxyKCAN
        '
        Me.gbProxyKCAN.Controls.Add(Me.Label11)
        Me.gbProxyKCAN.Controls.Add(Me.Label10)
        Me.gbProxyKCAN.Controls.Add(Me.Label8)
        Me.gbProxyKCAN.Controls.Add(Me.TextBox1)
        Me.gbProxyKCAN.Controls.Add(Me.Label9)
        Me.gbProxyKCAN.Controls.Add(Me.TextBox2)
        Me.gbProxyKCAN.Controls.Add(Me.TextBox3)
        Me.gbProxyKCAN.Location = New System.Drawing.Point(6, 112)
        Me.gbProxyKCAN.Name = "gbProxyKCAN"
        Me.gbProxyKCAN.Size = New System.Drawing.Size(250, 82)
        Me.gbProxyKCAN.TabIndex = 3
        Me.gbProxyKCAN.TabStop = False
        Me.gbProxyKCAN.Text = "KCAN (ISM)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "UN: CAKID | PW: Win Logon"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(167, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Domain"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(213, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Port"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(216, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(28, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "CA"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Proxy Server Address"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(216, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(28, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "80"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(6, 32)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(204, 20)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = "proxy1.us.kellogg.com"
        '
        'gbProxyKUSA
        '
        Me.gbProxyKUSA.Controls.Add(Me.Label7)
        Me.gbProxyKUSA.Controls.Add(Me.Label6)
        Me.gbProxyKUSA.Controls.Add(Me.Label5)
        Me.gbProxyKUSA.Controls.Add(Me.tbAutoScript)
        Me.gbProxyKUSA.Controls.Add(Me.tbPort)
        Me.gbProxyKUSA.Controls.Add(Me.tbProxy)
        Me.gbProxyKUSA.Location = New System.Drawing.Point(6, 6)
        Me.gbProxyKUSA.Name = "gbProxyKUSA"
        Me.gbProxyKUSA.Size = New System.Drawing.Size(250, 100)
        Me.gbProxyKUSA.TabIndex = 3
        Me.gbProxyKUSA.TabStop = False
        Me.gbProxyKUSA.Text = "KUSA (IE)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(213, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Port"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Proxy Server Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Automatic Configuration Script"
        '
        'tbAutoScript
        '
        Me.tbAutoScript.Location = New System.Drawing.Point(6, 32)
        Me.tbAutoScript.Name = "tbAutoScript"
        Me.tbAutoScript.ReadOnly = True
        Me.tbAutoScript.Size = New System.Drawing.Size(238, 20)
        Me.tbAutoScript.TabIndex = 0
        Me.tbAutoScript.Text = "http://intranet.kellogg.com/kellogg/ie6/Standard/INS/install.ins"
        '
        'tbPort
        '
        Me.tbPort.Location = New System.Drawing.Point(216, 71)
        Me.tbPort.Name = "tbPort"
        Me.tbPort.ReadOnly = True
        Me.tbPort.Size = New System.Drawing.Size(28, 20)
        Me.tbPort.TabIndex = 2
        Me.tbPort.Text = "80"
        Me.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbProxy
        '
        Me.tbProxy.Location = New System.Drawing.Point(6, 71)
        Me.tbProxy.Name = "tbProxy"
        Me.tbProxy.ReadOnly = True
        Me.tbProxy.Size = New System.Drawing.Size(204, 20)
        Me.tbProxy.TabIndex = 0
        Me.tbProxy.Text = "proxy1.us.kellogg.com"
        '
        'tLog
        '
        Me.tLog.Controls.Add(Me.gbLog)
        Me.tLog.Location = New System.Drawing.Point(4, 22)
        Me.tLog.Name = "tLog"
        Me.tLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tLog.Size = New System.Drawing.Size(286, 240)
        Me.tLog.TabIndex = 1
        Me.tLog.Text = "Log"
        Me.tLog.UseVisualStyleBackColor = True
        '
        'gbLog
        '
        Me.gbLog.Controls.Add(Me.tbLog)
        Me.gbLog.Location = New System.Drawing.Point(9, 7)
        Me.gbLog.Name = "gbLog"
        Me.gbLog.Size = New System.Drawing.Size(269, 225)
        Me.gbLog.TabIndex = 0
        Me.gbLog.TabStop = False
        Me.gbLog.Text = "Log"
        '
        'tbLog
        '
        Me.tbLog.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLog.Location = New System.Drawing.Point(6, 19)
        Me.tbLog.Multiline = True
        Me.tbLog.Name = "tbLog"
        Me.tbLog.ReadOnly = True
        Me.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbLog.Size = New System.Drawing.Size(257, 200)
        Me.tbLog.TabIndex = 0
        '
        'tmrOff
        '
        Me.tmrOff.Interval = 1000
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(166, 46)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'DesktopAssistant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 266)
        Me.Controls.Add(Me.Tab)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DesktopAssistant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desktop Assistant"
        Me.TopMost = True
        Me.gbMode.ResumeLayout(False)
        Me.gbMode.PerformLayout()
        Me.cmStrip.ResumeLayout(False)
        Me.Tab.ResumeLayout(False)
        Me.tMode.ResumeLayout(False)
        Me.tMode.PerformLayout()
        Me.tSupport.ResumeLayout(False)
        Me.SupportTab.ResumeLayout(False)
        Me.tDirectory.ResumeLayout(False)
        Me.tDirectory.PerformLayout()
        Me.gbDir.ResumeLayout(False)
        Me.tNATO.ResumeLayout(False)
        Me.tNATO.PerformLayout()
        Me.tNSS.ResumeLayout(False)
        Me.NSSTab.ResumeLayout(False)
        Me.tClip.ResumeLayout(False)
        Me.tClip.PerformLayout()
        Me.tUser.ResumeLayout(False)
        Me.tUser.PerformLayout()
        Me.tKellogg.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tProxy.ResumeLayout(False)
        Me.gbProxyKCAN.ResumeLayout(False)
        Me.gbProxyKCAN.PerformLayout()
        Me.gbProxyKUSA.ResumeLayout(False)
        Me.gbProxyKUSA.PerformLayout()
        Me.tLog.ResumeLayout(False)
        Me.gbLog.ResumeLayout(False)
        Me.gbLog.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbMode As System.Windows.Forms.GroupBox
    Friend WithEvents rbLunch As System.Windows.Forms.RadioButton
    Friend WithEvents rbOff As System.Windows.Forms.RadioButton
    Friend WithEvents rbAway As System.Windows.Forms.RadioButton
    Friend WithEvents tmrWatch As System.Windows.Forms.Timer
    Friend WithEvents rbDefault As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbStatus As System.Windows.Forms.TextBox
    Friend WithEvents cmStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents LogInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AwayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LunchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tab As System.Windows.Forms.TabControl
    Friend WithEvents tMode As System.Windows.Forms.TabPage
    Friend WithEvents tLog As System.Windows.Forms.TabPage
    Friend WithEvents gbLog As System.Windows.Forms.GroupBox
    Friend WithEvents tbLog As System.Windows.Forms.TextBox
    Friend WithEvents tmrOff As System.Windows.Forms.Timer
    Friend WithEvents tsProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents tNSS As System.Windows.Forms.TabPage
    Friend WithEvents NSSTab As System.Windows.Forms.TabControl
    Friend WithEvents tClip As System.Windows.Forms.TabPage
    Friend WithEvents tUser As System.Windows.Forms.TabPage
    Friend WithEvents txtPaste As System.Windows.Forms.TextBox
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents txtConsole As System.Windows.Forms.TextBox
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents tbTime As System.Windows.Forms.TextBox
    Friend WithEvents tSupport As System.Windows.Forms.TabPage
    Friend WithEvents tbNATO As System.Windows.Forms.TextBox
    Friend WithEvents btnRT As System.Windows.Forms.Button
    Friend WithEvents btnPM As System.Windows.Forms.Button
    Friend WithEvents SupportTab As System.Windows.Forms.TabControl
    Friend WithEvents tNATO As System.Windows.Forms.TabPage
    Friend WithEvents tDirectory As System.Windows.Forms.TabPage
    Friend WithEvents cbDirectory As System.Windows.Forms.ComboBox
    Friend WithEvents btnCallDir As System.Windows.Forms.Button
    Friend WithEvents btnTransfer As System.Windows.Forms.Button
    Friend WithEvents btnConference As System.Windows.Forms.Button
    Friend WithEvents tbPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents gbDir As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnHold As System.Windows.Forms.Button
    Friend WithEvents btnHang As System.Windows.Forms.Button
    Friend WithEvents tKellogg As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tProxy As System.Windows.Forms.TabPage
    Friend WithEvents tbAutoScript As System.Windows.Forms.TextBox
    Friend WithEvents tbProxy As System.Windows.Forms.TextBox
    Friend WithEvents gbProxyKUSA As System.Windows.Forms.GroupBox
    Friend WithEvents tbPort As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbProxyKCAN As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents cbNSSCopy As System.Windows.Forms.ComboBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button

End Class
