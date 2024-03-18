Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class panier
    Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=ecommerce_projet"

    Private Sub bntAffichierPanier_Click(sender As Object, e As EventArgs) Handles bntAffichierPanier.Click
        ChargerPanier()
    End Sub

    Private Sub btnSuprimerDuPanier_Click(sender As Object, e As EventArgs) Handles btnSuprimerDuPanier.Click
        SupprimerArticleDuPanier()
    End Sub



    Private Sub voirProduit_Click_1(sender As Object, e As EventArgs) Handles voirProduit.Click
        ChargerProduits()
    End Sub

    Private Sub ChargerPanier()
        Try
            Using newConnection As New MySqlConnection(connectionString)
                newConnection.Open()

                Dim command As New MySqlCommand("SELECT CONCAT('Nom: ', nomArticle, ', Prix: ', prixArticle) AS DisplayText FROM panier", newConnection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    lepanier.Items.Clear()
                    While reader.Read()
                        lepanier.Items.Add(reader("DisplayText").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement du panier : " & ex.Message)
        End Try
    End Sub

    Private Sub SupprimerArticleDuPanier()
        If lepanier.SelectedIndex >= 0 Then
            Try
                Using newConnection As New MySqlConnection(connectionString)
                    newConnection.Open()

                    Dim selectedItem As String = lepanier.SelectedItem.ToString()

                    Dim match As Match = Regex.Match(selectedItem, "Nom: (.+), Prix: (.+)")
                    If match.Success Then
                        Dim nomArticle As String = match.Groups(1).Value
                        Dim prixArticle As Decimal
                        If Decimal.TryParse(match.Groups(2).Value, prixArticle) Then
                            Dim command As New MySqlCommand("supprimerArticleDuPanier", newConnection)
                            command.CommandType = CommandType.StoredProcedure

                            command.Parameters.AddWithValue("@p_nomArticle", nomArticle)
                            command.Parameters.AddWithValue("@p_prixArticle", prixArticle)

                            command.ExecuteNonQuery()

                            ChargerPanier()

                            MessageBox.Show("L'article a été supprimé du panier avec succès.")
                        Else
                            MessageBox.Show("Erreur lors de la conversion du prix de l'article.")
                        End If
                    Else
                        MessageBox.Show("Format d'article non reconnu.")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Erreur MySQL lors de la suppression de l'article : " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Erreur lors de la suppression de l'article : " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ChargerProduits()
        jour.Items.Clear()

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand("CALL RecuperProduit()", connection)
                    Using reader = command.ExecuteReader
                        While reader.Read
                            jour.Items.Add(reader("nomProduit").ToString & " - " & reader("prix").ToString)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Erreur lors de l'exécution de la procédure stockée : " & ex.Message)
        End Try
    End Sub

    Private Sub commander_Click(sender As Object, e As EventArgs) Handles commander.Click
        commande.Show()
        Me.Hide()

    End Sub
End Class
