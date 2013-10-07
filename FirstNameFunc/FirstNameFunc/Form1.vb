Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text
        txtFirstName.Text = FirstName(name)
    End Sub

    Function FirstName(ByVal name As String) As String

        Dim firstspace As Integer
        firstspace = name.IndexOf(" ")

        Dim fName As String
        fName = name.Substring(0, firstspace)

        Return fName

    End Function

End Class
