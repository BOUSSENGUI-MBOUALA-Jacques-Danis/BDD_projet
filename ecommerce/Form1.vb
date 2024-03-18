Imports MySql.Data.MySqlClient

Public Class Form1

    Dim connection As String = "server=localhost;port=3306;username=root;password=;database=ecommerce_projet"

    Private Sub enregistrer_Click(sender As Object, e As EventArgs) Handles enregistrer.Click
        Dim nomComplet As String = nom.Text
        Dim nomUtilisateur As String = nameUser.Text
        Dim numeroCarte As String = numCarte.Text
        Dim motDePasse As String = mdpUser.Text

        ' Vérification si tous les champs sont remplis
        If String.IsNullOrWhiteSpace(nomComplet) OrElse String.IsNullOrWhiteSpace(nomUtilisateur) OrElse String.IsNullOrWhiteSpace(numeroCarte) OrElse String.IsNullOrWhiteSpace(motDePasse) Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Arrête l'exécution de la méthode si un champ est vide
        End If

        Try
            Using conn As New MySqlConnection(connection)
                conn.Open()

                Using cmd As New MySqlCommand("InsertClient", conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    ' Paramètres de la procédure stockée
                    cmd.Parameters.AddWithValue("@p_nomClient", nomComplet)
                    cmd.Parameters.AddWithValue("@p_usernameClient", nomUtilisateur)
                    cmd.Parameters.AddWithValue("@p_numCarte", numeroCarte)
                    cmd.Parameters.AddWithValue("@p_mdpClient", motDePasse)

                    ' Exécution de la procédure stockée
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Enregistré avec succès")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        End Try
    End Sub

    Private Sub seConnecter_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles seConnecter.LinkClicked
        Dim connectionForm As New connection()
        connectionForm.Show()
        Me.Hide()
    End Sub

End Class
