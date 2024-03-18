<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class connection
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        inscrire = New LinkLabel()
        connecter = New Guna.UI2.WinForms.Guna2Button()
        mdpC = New Guna.UI2.WinForms.Guna2TextBox()
        UserNameC = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2CustomGradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.Controls.Add(inscrire)
        Guna2CustomGradientPanel1.Controls.Add(connecter)
        Guna2CustomGradientPanel1.Controls.Add(mdpC)
        Guna2CustomGradientPanel1.Controls.Add(UserNameC)
        Guna2CustomGradientPanel1.Controls.Add(Guna2HtmlLabel3)
        Guna2CustomGradientPanel1.Controls.Add(Guna2HtmlLabel2)
        Guna2CustomGradientPanel1.Controls.Add(Guna2HtmlLabel1)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges7
        Guna2CustomGradientPanel1.Location = New Point(110, 80)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2CustomGradientPanel1.Size = New Size(982, 654)
        Guna2CustomGradientPanel1.TabIndex = 0
        ' 
        ' inscrire
        ' 
        inscrire.AutoSize = True
        inscrire.Location = New Point(693, 527)
        inscrire.Name = "inscrire"
        inscrire.Size = New Size(128, 20)
        inscrire.TabIndex = 3
        inscrire.TabStop = True
        inscrire.Text = "je cree un compte"
        ' 
        ' connecter
        ' 
        connecter.CustomizableEdges = CustomizableEdges1
        connecter.DisabledState.BorderColor = Color.DarkGray
        connecter.DisabledState.CustomBorderColor = Color.DarkGray
        connecter.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        connecter.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        connecter.Font = New Font("Segoe UI", 9F)
        connecter.ForeColor = Color.White
        connecter.Location = New Point(650, 439)
        connecter.Name = "connecter"
        connecter.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        connecter.Size = New Size(225, 43)
        connecter.TabIndex = 2
        connecter.Text = "CONNEXION"
        ' 
        ' mdpC
        ' 
        mdpC.CustomizableEdges = CustomizableEdges3
        mdpC.DefaultText = ""
        mdpC.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        mdpC.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        mdpC.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        mdpC.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        mdpC.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        mdpC.Font = New Font("Segoe UI", 9F)
        mdpC.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        mdpC.Location = New Point(565, 370)
        mdpC.Margin = New Padding(3, 4, 3, 4)
        mdpC.Name = "mdpC"
        mdpC.PasswordChar = "*"c
        mdpC.PlaceholderForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        mdpC.PlaceholderText = "PASSWORD"
        mdpC.SelectedText = ""
        mdpC.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        mdpC.Size = New Size(399, 49)
        mdpC.TabIndex = 1
        ' 
        ' UserNameC
        ' 
        UserNameC.CustomizableEdges = CustomizableEdges5
        UserNameC.DefaultText = ""
        UserNameC.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        UserNameC.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        UserNameC.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        UserNameC.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        UserNameC.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        UserNameC.Font = New Font("Segoe UI", 9F)
        UserNameC.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        UserNameC.Location = New Point(565, 231)
        UserNameC.Margin = New Padding(3, 4, 3, 4)
        UserNameC.Name = "UserNameC"
        UserNameC.PasswordChar = ChrW(0)
        UserNameC.PlaceholderForeColor = Color.Red
        UserNameC.PlaceholderText = "USERNAME"
        UserNameC.SelectedText = ""
        UserNameC.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        UserNameC.Size = New Size(399, 49)
        UserNameC.TabIndex = 1
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Location = New Point(565, 341)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(104, 22)
        Guna2HtmlLabel3.TabIndex = 0
        Guna2HtmlLabel3.Text = "MOT DE PASSE"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Location = New Point(565, 202)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(128, 22)
        Guna2HtmlLabel2.TabIndex = 0
        Guna2HtmlLabel2.Text = "NOM UTILISATEUR"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Location = New Point(336, 49)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(253, 22)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "CONNECTEZ VOUS A VOTRE COMPTE"
        ' 
        ' connection
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1189, 754)
        Controls.Add(Guna2CustomGradientPanel1)
        Name = "connection"
        Text = "connection"
        Guna2CustomGradientPanel1.ResumeLayout(False)
        Guna2CustomGradientPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents mdpC As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UserNameC As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents connecter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents inscrire As LinkLabel
End Class
