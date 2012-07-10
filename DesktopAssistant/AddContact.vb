Public Class AddContact
    Public Edit As Boolean = False

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If Edit Then
            ' do something
        Else
            If String.IsNullOrWhiteSpace(tbName.Text) Or String.IsNullOrWhiteSpace(tbNumber.Text) Then
                MsgBox("Name and Number must be filled out.")
            ElseIf DesktopAssistant.AddressBook.ContainsKey(tbName.Text) Then
                MsgBox("Contact already exists in Address Book")
            Else
                DesktopAssistant.AddressBook.Add(tbName.Text, tbNumber.Text)
                DesktopAssistant.cbDirectory.Items.Add(tbName.Text)
                DesktopAssistant.tbLog.Text &= DateAndTime.TimeString & " Added " & tbName.Text & " to Address Book" & vbNewLine
            End If
        End If

        Edit = False
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub AddContact_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Edit Then
            tbName.Text = DesktopAssistant.EditName
            tbNumber.Text = DesktopAssistant.EditNumber
        Else
            tbName.Text = ""
            tbNumber.Text = ""
        End If
    End Sub
End Class