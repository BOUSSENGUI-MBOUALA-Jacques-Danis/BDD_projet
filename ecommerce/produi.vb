Imports System.Text
Imports MySql.Data.MySqlClient

Public Class produi
    Dim connections As String = "server=localhost;port=3306;username=root;password=;database=ecommerce_projet"

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        Dim recherche As String = txtRecherche.Text.Trim()

        If recherche <> "" Then
            Try
                Using connection As New MySqlConnection(connections)
                    connection.Open()

                    Dim query As String = "SELECT * FROM produit WHERE nomProduit LIKE @Recherche"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Recherche", "%" & recherche & "%")

                        Using reader As MySqlDataReader = command.ExecuteReader()
                            If reader.HasRows Then
                                Dim resultStringBuilder As New StringBuilder()

                                While reader.Read()
                                    resultStringBuilder.AppendLine("---------ARTICLE TROUVE--------")
                                    resultStringBuilder.AppendLine("Nom du produit: " & reader("nomProduit"))
                                    resultStringBuilder.AppendLine("Prix: " & reader("prix"))
                                    resultStringBuilder.AppendLine("-----------")
                                End While

                                laResultat.Text = resultStringBuilder.ToString()
                                'panelResultat.Visible = True ' Afficher le Panel'
                            Else
                                MessageBox.Show("Aucun résultat trouvé.")
                                'panelResultat.Visible = False ' Masquer le Panel
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Erreur lors de la recherche: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Veuillez entrer un terme de recherche.")
        End If
    End Sub

    Public nombreAppuis As Integer = 0
    Private Sub p1_Click(sender As Object, e As EventArgs) Handles p1.Click
        If nombreAppuis < 4 Then
            nombreAppuis += 1
            nombreArticle.Text = nombreAppuis.ToString()

            Using connection As New MySqlConnection(connections)
                connection.Open()
                Using command As New MySqlCommand("InsertIntoPanier", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_nomArticle", "Chapeau noir happie")
                    command.Parameters.AddWithValue("@p_prixArticle", 54500)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Else
            MessageBox.Show("VOTRE PANIER SUPPORTE 4 ARTICLE PAS PLUS: VOIR LE PANIER.")
        End If
    End Sub

    Private Sub p2_Click(sender As Object, e As EventArgs) Handles p2.Click
        If nombreAppuis < 4 Then
            nombreAppuis += 1
            nombreArticle.Text = nombreAppuis.ToString()

            Using connection As New MySqlConnection(connections)
                connection.Open()
                Using command As New MySqlCommand("InsertIntoPanier", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_nomArticle", "Botine mal coral")
                    command.Parameters.AddWithValue("@p_prixArticle", 199999)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Else
            MessageBox.Show("VOTRE PANIER SUPPORTE 4 ARTICLE PAS PLUS: VOIR LE PANIER.")
        End If
    End Sub

    Private Sub p3_Click(sender As Object, e As EventArgs) Handles p3.Click
        If nombreAppuis < 4 Then
            nombreAppuis += 1
            nombreArticle.Text = nombreAppuis.ToString()

            Using connection As New MySqlConnection(connections)
                connection.Open()
                Using command As New MySqlCommand("InsertIntoPanier", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_nomArticle", "Costar punk")
                    command.Parameters.AddWithValue("@p_prixArticle", 320999)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Else
            MessageBox.Show("VOTRE PANIER SUPPORTE 4 ARTICLE PAS PLUS: VOIR LE PANIER.")
        End If
    End Sub

    Private Sub p4_Click(sender As Object, e As EventArgs) Handles p4.Click
        If nombreAppuis < 4 Then
            nombreAppuis += 1
            nombreArticle.Text = nombreAppuis.ToString()

            Using connection As New MySqlConnection(connections)
                connection.Open()
                Using command As New MySqlCommand("InsertIntoPanier", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_nomArticle", "Combinaison en jean str")
                    command.Parameters.AddWithValue("@p_prixArticle", 99999)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Else
            MessageBox.Show("VOTRE PANIER SUPPORTE 4 ARTICLE PAS PLUS: VOIR LE PANIER.")
        End If
    End Sub
    Private Sub p5_Click(sender As Object, e As EventArgs) Handles p5.Click
        If nombreAppuis < 4 Then
            nombreAppuis += 1
            nombreArticle.Text = nombreAppuis.ToString()

            Using connection As New MySqlConnection(connections)
                connection.Open()
                Using command As New MySqlCommand("InsertIntoPanier", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_nomArticle", "Capuche oversize")
                    command.Parameters.AddWithValue("@p_prixArticle", 15000)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Else
            MessageBox.Show("VOTRE PANIER SUPPORTE 4 ARTICLE PAS PLUS: VOIR LE PANIER.")
        End If
    End Sub

    Private Sub p6_Click(sender As Object, e As EventArgs) Handles p6.Click
        If nombreAppuis < 4 Then
            nombreAppuis += 1
            nombreArticle.Text = nombreAppuis.ToString()

            Using connection As New MySqlConnection(connections)
                connection.Open()
                Using command As New MySqlCommand("InsertIntoPanier", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_nomArticle", "Ensemble tailleur mixte")
                    command.Parameters.AddWithValue("@p_prixArticle", 510000)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Else
            MessageBox.Show("VOTRE PANIER SUPPORTE 4 ARTICLE PAS PLUS: VOIR LE PANIER.")
        End If
    End Sub

    Private Sub p7_Click(sender As Object, e As EventArgs) Handles p7.Click
        If nombreAppuis < 4 Then
            nombreAppuis += 1
            nombreArticle.Text = nombreAppuis.ToString()

            Using connection As New MySqlConnection(connections)
                connection.Open()
                Using command As New MySqlCommand("InsertIntoPanier", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_nomArticle", "Robe classy")
                    command.Parameters.AddWithValue("@p_prixArticle", 75000)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Else
            MessageBox.Show("VOTRE PANIER SUPPORTE 4 ARTICLE PAS PLUS: VOIR LE PANIER.")
        End If
    End Sub

    Private Sub panier_Click(sender As Object, e As EventArgs) Handles panier.Click

        Dim panierForm As New panier()
        panierForm.Show()
        Me.Hide()
    End Sub
End Class
