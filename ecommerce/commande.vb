Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Commande
    Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=ecommerce_projet"

    Private Sub Commander_Click(sender As Object, e As EventArgs) Handles commander.Click
        Try
            ' Appeler la procédure stockée RecupererPanier
            RecupererPanier()

            ' Appeler la procédure stockée CalculerSommePrixPanier
            CalculerSommePrixPanier()

            ' Appeler la procédure stockée InsererCommandeAutomatique
            Dim dateCommande As Date = InsererCommandeAutomatique()

            ' Afficher la date dans la zone de texte
            If dateCommande <> Date.MinValue Then
                dat.Text = dateCommande.ToString("yyyy-MM-dd")
            Else
                MessageBox.Show("Erreur lors de l'insertion de la commande automatique.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Vous pouvez également ajouter le code pour afficher les résultats dans la ListBox txtListeCommande ici
        Catch ex As Exception
            MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RecupererPanier()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Appeler la procédure stockée RecuperPanier
            Using command As New MySqlCommand("RecuperPanier", connection)
                command.CommandType = CommandType.StoredProcedure

                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Effacer les éléments actuels dans la ListBox
                    txtListeCommande.Items.Clear()

                    ' Lire les résultats de la procédure stockée
                    While reader.Read()
                        ' Ajouter chaque résultat à la ListBox
                        txtListeCommande.Items.Add($"Nom: {reader("nomArticle")}, Prix: {reader("prixArticle")}")
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub CalculerSommePrixPanier()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Appeler la procédure stockée CalculerSommePrixPanier
            Using command As New MySqlCommand("CalculerSommePrixPanier", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Ajouter un paramètre OUT pour récupérer la somme
                command.Parameters.Add(New MySqlParameter("@p_sommePrix", MySqlDbType.Decimal))
                command.Parameters("@p_sommePrix").Direction = ParameterDirection.Output

                command.ExecuteNonQuery()

                ' Récupérer la somme depuis le paramètre OUT
                Dim sommePrix As Decimal = Convert.ToDecimal(command.Parameters("@p_sommePrix").Value)

                ' Afficher la somme
                MessageBox.Show($"La somme à payer est : {sommePrix}", "Somme du Prix", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
    End Sub

    Private Function InsererCommandeAutomatique() As Date
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Appeler la procédure stockée InsererCommandeAutomatique
            Using command As New MySqlCommand("InsererCommandeAutomatique", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Ajouter un paramètre OUT pour récupérer la date
                command.Parameters.Add(New MySqlParameter("@p_dateCommande", MySqlDbType.Date))
                command.Parameters("@p_dateCommande").Direction = ParameterDirection.Output

                command.ExecuteNonQuery()

                ' Récupérer la date depuis le paramètre OUT
                Dim dateCommande As Date = Convert.ToDateTime(command.Parameters("@p_dateCommande").Value)

                Return dateCommande
            End Using
        End Using
    End Function
End Class
