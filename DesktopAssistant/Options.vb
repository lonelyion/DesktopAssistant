Imports System.IO

Public Class Options
    Dim SW As StreamWriter

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        DesktopAssistant.AwayTime = tbAway.Text * 60
        DesktopAssistant.LunchTime = tbLunch.Text * 60

        DesktopAssistant.Username = tbUsername.Text
        DesktopAssistant.RTpass = tbRT.Text
        DesktopAssistant.PMpass = tbPM.Text
        DesktopAssistant.CloseToTray = cbTray.Checked
        

        SW = File.CreateText(DesktopAssistant.Settings)

        SW.WriteLine(tbUsername.Text) ' write Username
        SW.WriteLine(tbRT.Text) ' write RT Password
        SW.WriteLine(tbPM.Text) ' write PM Password

        SW.WriteLine(DesktopAssistant.AwayTime)    ' write Away Time
        SW.WriteLine(DesktopAssistant.LunchTime)   ' write Lunch Time

        SW.WriteLine(DesktopAssistant.CloseToTray) ' write Close To Tray

        SW.Close()

        Me.Close()
    End Sub

    Private Sub Options_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbAway.Text = DesktopAssistant.AwayTime / 60
        tbLunch.Text = DesktopAssistant.LunchTime / 60
        cbTray.Checked = DesktopAssistant.CloseToTray

        tbUsername.Text = DesktopAssistant.Username
        tbPM.Text = DesktopAssistant.PMpass
        tbRT.Text = DesktopAssistant.RTpass
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class