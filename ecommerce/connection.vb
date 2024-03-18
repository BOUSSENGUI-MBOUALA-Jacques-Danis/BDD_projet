Imports MySql.Data.MySqlClient

Public Class connection
    Dim connection As String = "server=localhost;port=3306;username=root;password=;database=ecommerce_projet"
    Private Sub inscrire_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles inscrire.LinkClicked
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub connecter_Click(sender As Object, e As EventArgs) Handles connecter.Click



        Dim nomUser As String = UserNameC.Text
        Dim mdp As String = mdpC.Text


        Try
            Using conn As New MySqlConnection(connection)
                conn.Open()

                ' Vérification des identifiants dans la base de données
                Dim query As String = "SELECT COUNT(*) FROM client WHERE usernameClient = @nomUser AND mdpClient = @mdp"
                Using cmdCheck As New MySqlCommand(query, conn)
                    cmdCheck.Parameters.AddWithValue("@nomUser", nomUser)
                    cmdCheck.Parameters.AddWithValue("@mdp", mdp)

                    Dim result As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                    If result > 0 Then
                        ' Identifiants valides, naviguer vers la fenêtre d'accueil
                        Dim accueilForm As New acceuil()
                        accueilForm.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Identifiants incorrects.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        End Try


    End Sub
End Class