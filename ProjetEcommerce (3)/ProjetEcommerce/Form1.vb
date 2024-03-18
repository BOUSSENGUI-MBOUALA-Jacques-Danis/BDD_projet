Public Class Form1
    Private dernierBoutonActif As Guna.UI2.WinForms.Guna2Button


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pour pouvoir scroller
        'InitializeComponent()
        'Me.AutoScroll = True
        Guna2Button1.PerformClick()
    End Sub



    'Pour que le bouton activer reste lumineux
    Private Sub ActiverBouton(sender As Object)
        ' Désactive le dernier bouton actif
        If dernierBoutonActif IsNot Nothing Then
            dernierBoutonActif.Checked = False
        End If
        ' Active le nouveau bouton
        Dim boutonActuel As Guna.UI2.WinForms.Guna2Button = DirectCast(sender, Guna.UI2.WinForms.Guna2Button)
        boutonActuel.Checked = True
        ' Met à jour la référence au dernier bouton actif
        dernierBoutonActif = boutonActuel
    End Sub




    '--------------- POUR OUVRIR LES DIFFERENTES FENETRES SELON LE BOUTON CLIQUE
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ActiverBouton(sender)
        Dim accueilInterface As New AccuieilUsers()
        Guna2Panel5.Controls.Clear()
        Guna2Panel5.Controls.Add(accueilInterface)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ActiverBouton(sender)
        Dim produitsInterface As New produitsUsers()
        Guna2Panel5.Controls.Clear()
        Guna2Panel5.Controls.Add(produitsInterface)
    End Sub


End Class
