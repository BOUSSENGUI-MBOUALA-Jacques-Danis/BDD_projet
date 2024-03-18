
Imports MySql.Data.MySqlClient

Public Class Inscription
    Dim connection As New MySqlConnection("server = localhost;port=3306;username =root;password=root;database=ecommerce_projet")

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles connect.LinkClicked
        Connexion.Show()
        Me.Hide()
    End Sub

    Private Sub inscrip_Click(sender As Object, e As EventArgs) Handles inscrip.Click

        Dim nomComplet As String = nom.Text
        Dim nomUtilisateur As String = nomUser.Text
        Dim numeroCarte As String = numCarte.Text
        Dim motDePasse As String = mdpUser.Text


        Try

            connection.Open()
            MessageBox.Show("Bravo")
        Catch ex As Exception
            MessageBox.Show("erreur")
        End Try


    End Sub
End Class