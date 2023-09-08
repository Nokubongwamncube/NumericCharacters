Public Class Form1
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim phonenumber As String

        phonenumber = txtPhone.Text

        If IsNumeric(txtPhone.Text) Then
            MsgBox("call " & phonenumber)

        Else
            MsgBox(" enter number only!")


        End If



    End Sub
End Class
