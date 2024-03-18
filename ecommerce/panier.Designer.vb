<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class panier
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        lepanier = New CheckedListBox()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        bntAffichierPanier = New Guna.UI2.WinForms.Guna2Button()
        btnSuprimerDuPanier = New Guna.UI2.WinForms.Guna2Button()
        commander = New Guna.UI2.WinForms.Guna2Button()
        voirProduit = New Guna.UI2.WinForms.Guna2Button()
        jour = New CheckedListBox()
        mettreAjour = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' lepanier
        ' 
        lepanier.FormattingEnabled = True
        lepanier.Location = New Point(226, 177)
        lepanier.Name = "lepanier"
        lepanier.Size = New Size(757, 180)
        lepanier.TabIndex = 0
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.Location = New Point(332, 42)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(569, 108)
        Guna2HtmlLabel1.TabIndex = 2
        Guna2HtmlLabel1.Text = "VOTRE PANIER"
        ' 
        ' bntAffichierPanier
        ' 
        bntAffichierPanier.CustomizableEdges = CustomizableEdges1
        bntAffichierPanier.DisabledState.BorderColor = Color.DarkGray
        bntAffichierPanier.DisabledState.CustomBorderColor = Color.DarkGray
        bntAffichierPanier.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        bntAffichierPanier.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        bntAffichierPanier.Font = New Font("Segoe UI", 9F)
        bntAffichierPanier.ForeColor = Color.White
        bntAffichierPanier.Location = New Point(1003, 171)
        bntAffichierPanier.Name = "bntAffichierPanier"
        bntAffichierPanier.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        bntAffichierPanier.Size = New Size(192, 56)
        bntAffichierPanier.TabIndex = 3
        bntAffichierPanier.Text = "AFFICHER PANIER"
        ' 
        ' btnSuprimerDuPanier
        ' 
        btnSuprimerDuPanier.CustomizableEdges = CustomizableEdges3
        btnSuprimerDuPanier.DisabledState.BorderColor = Color.DarkGray
        btnSuprimerDuPanier.DisabledState.CustomBorderColor = Color.DarkGray
        btnSuprimerDuPanier.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSuprimerDuPanier.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSuprimerDuPanier.Font = New Font("Segoe UI", 9F)
        btnSuprimerDuPanier.ForeColor = Color.White
        btnSuprimerDuPanier.Location = New Point(1003, 233)
        btnSuprimerDuPanier.Name = "btnSuprimerDuPanier"
        btnSuprimerDuPanier.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnSuprimerDuPanier.Size = New Size(192, 56)
        btnSuprimerDuPanier.TabIndex = 3
        btnSuprimerDuPanier.Text = "SUPRIMER"
        ' 
        ' commander
        ' 
        commander.CustomizableEdges = CustomizableEdges5
        commander.DisabledState.BorderColor = Color.DarkGray
        commander.DisabledState.CustomBorderColor = Color.DarkGray
        commander.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        commander.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        commander.Font = New Font("Segoe UI", 9F)
        commander.ForeColor = Color.White
        commander.Location = New Point(1003, 301)
        commander.Name = "commander"
        commander.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        commander.Size = New Size(192, 56)
        commander.TabIndex = 3
        commander.Text = "COMMENDER"
        ' 
        ' voirProduit
        ' 
        voirProduit.CustomizableEdges = CustomizableEdges7
        voirProduit.DisabledState.BorderColor = Color.DarkGray
        voirProduit.DisabledState.CustomBorderColor = Color.DarkGray
        voirProduit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        voirProduit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        voirProduit.Font = New Font("Segoe UI", 9F)
        voirProduit.ForeColor = Color.White
        voirProduit.Location = New Point(993, 447)
        voirProduit.Name = "voirProduit"
        voirProduit.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        voirProduit.Size = New Size(202, 56)
        voirProduit.TabIndex = 5
        voirProduit.Text = "VOIR LES PRODUITS"
        ' 
        ' jour
        ' 
        jour.FormattingEnabled = True
        jour.Location = New Point(226, 447)
        jour.Name = "jour"
        jour.Size = New Size(757, 180)
        jour.TabIndex = 0
        ' 
        ' mettreAjour
        ' 
        mettreAjour.CustomizableEdges = CustomizableEdges9
        mettreAjour.DisabledState.BorderColor = Color.DarkGray
        mettreAjour.DisabledState.CustomBorderColor = Color.DarkGray
        mettreAjour.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        mettreAjour.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        mettreAjour.Font = New Font("Segoe UI", 9F)
        mettreAjour.ForeColor = Color.White
        mettreAjour.Location = New Point(993, 521)
        mettreAjour.Name = "mettreAjour"
        mettreAjour.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        mettreAjour.Size = New Size(202, 56)
        mettreAjour.TabIndex = 6
        mettreAjour.Text = "METTRE A JOUR"
        ' 
        ' panier
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1217, 762)
        Controls.Add(mettreAjour)
        Controls.Add(voirProduit)
        Controls.Add(commander)
        Controls.Add(btnSuprimerDuPanier)
        Controls.Add(bntAffichierPanier)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(jour)
        Controls.Add(lepanier)
        Name = "panier"
        Text = "panier"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lepanier As CheckedListBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents bntAffichierPanier As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSuprimerDuPanier As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents commander As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents voirProduit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents jour As CheckedListBox
    Friend WithEvents mettreAjour As Guna.UI2.WinForms.Guna2Button
End Class
