<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class commande
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        commander = New Guna.UI2.WinForms.Guna2Button()
        txtListeCommande = New ListBox()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        dat = New ListBox()
        SuspendLayout()
        ' 
        ' commander
        ' 
        commander.CustomizableEdges = CustomizableEdges3
        commander.DisabledState.BorderColor = Color.DarkGray
        commander.DisabledState.CustomBorderColor = Color.DarkGray
        commander.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        commander.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        commander.Font = New Font("Segoe UI", 9F)
        commander.ForeColor = Color.White
        commander.Location = New Point(501, 474)
        commander.Name = "commander"
        commander.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        commander.Size = New Size(225, 56)
        commander.TabIndex = 1
        commander.Text = "COMMENDER"
        ' 
        ' txtListeCommande
        ' 
        txtListeCommande.FormattingEnabled = True
        txtListeCommande.Location = New Point(327, 258)
        txtListeCommande.Name = "txtListeCommande"
        txtListeCommande.Size = New Size(574, 164)
        txtListeCommande.TabIndex = 2
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.Location = New Point(213, 60)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(767, 108)
        Guna2HtmlLabel1.TabIndex = 3
        Guna2HtmlLabel1.Text = "VOTRE COMMANDE"
        ' 
        ' dat
        ' 
        dat.FormattingEnabled = True
        dat.Location = New Point(907, 258)
        dat.Name = "dat"
        dat.Size = New Size(141, 64)
        dat.TabIndex = 2
        ' 
        ' commande
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1233, 743)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(dat)
        Controls.Add(txtListeCommande)
        Controls.Add(commander)
        Name = "commande"
        Text = "miseAjourvb"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents commander As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtListeCommande As ListBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dat As ListBox
End Class
