Imports MySql.Data.MySqlClient

Public Class loginForm
    Dim connection As New MySqlConnection

    Private Sub Connect()
        connection.ConnectionString = "server=localhost; userid=vladrares10; password=romania@_10; database=devbase;"
        connection.Open()
        MsgBox("You are connected to the database !")
    End Sub



    Private Sub loginBTN_Click(sender As Object, e As EventArgs) Handles loginBTN.Click
        menuForm.Show()
        Connect()
    End Sub
End Class