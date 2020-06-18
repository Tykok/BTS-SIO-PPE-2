<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class affichePostes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(affichePostes))
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.tbPostes = New System.Windows.Forms.TextBox()
        Me.lblPostes = New System.Windows.Forms.Label()
        Me.cbService = New System.Windows.Forms.ComboBox()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.lstPostes = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComposantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnCommentaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbCompo = New System.Windows.Forms.TextBox()
        Me.lbTitre = New System.Windows.Forms.Label()
        Me.LabelServ = New System.Windows.Forms.Label()
        Me.LabelChoix = New System.Windows.Forms.Label()
        Me.btnEnreg = New System.Windows.Forms.Button()
        Me.tbcomment = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuitter
        '
        Me.btnQuitter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.ForeColor = System.Drawing.Color.Red
        Me.btnQuitter.Location = New System.Drawing.Point(436, 481)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(83, 31)
        Me.btnQuitter.TabIndex = 0
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'tbPostes
        '
        Me.tbPostes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbPostes.Location = New System.Drawing.Point(245, 266)
        Me.tbPostes.Multiline = True
        Me.tbPostes.Name = "tbPostes"
        Me.tbPostes.ReadOnly = True
        Me.tbPostes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbPostes.Size = New System.Drawing.Size(165, 95)
        Me.tbPostes.TabIndex = 4
        Me.tbPostes.Visible = False
        '
        'lblPostes
        '
        Me.lblPostes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPostes.AutoSize = True
        Me.lblPostes.BackColor = System.Drawing.Color.Transparent
        Me.lblPostes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostes.Location = New System.Drawing.Point(241, 243)
        Me.lblPostes.Name = "lblPostes"
        Me.lblPostes.Size = New System.Drawing.Size(345, 20)
        Me.lblPostes.TabIndex = 3
        Me.lblPostes.Text = "Liste des postes présents dans ce service"
        Me.lblPostes.Visible = False
        '
        'cbService
        '
        Me.cbService.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbService.BackColor = System.Drawing.SystemColors.Window
        Me.cbService.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbService.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbService.FormattingEnabled = True
        Me.cbService.Location = New System.Drawing.Point(245, 212)
        Me.cbService.Name = "cbService"
        Me.cbService.Size = New System.Drawing.Size(180, 28)
        Me.cbService.TabIndex = 2
        '
        'lblServices
        '
        Me.lblServices.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblServices.AutoSize = True
        Me.lblServices.BackColor = System.Drawing.Color.Transparent
        Me.lblServices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServices.Location = New System.Drawing.Point(241, 189)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(184, 20)
        Me.lblServices.TabIndex = 1
        Me.lblServices.Text = "Choisissez un Service"
        '
        'lstPostes
        '
        Me.lstPostes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstPostes.FormattingEnabled = True
        Me.lstPostes.Location = New System.Drawing.Point(416, 266)
        Me.lstPostes.Name = "lstPostes"
        Me.lstPostes.Size = New System.Drawing.Size(167, 95)
        Me.lstPostes.TabIndex = 5
        Me.lstPostes.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(88, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComposantToolStripMenuItem, Me.AjouterUnCommentaireToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionToolStripMenuItem.Text = "&Option"
        '
        'ComposantToolStripMenuItem
        '
        Me.ComposantToolStripMenuItem.CheckOnClick = True
        Me.ComposantToolStripMenuItem.Name = "ComposantToolStripMenuItem"
        Me.ComposantToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ComposantToolStripMenuItem.Text = "Afficher les composants"
        '
        'AjouterUnCommentaireToolStripMenuItem
        '
        Me.AjouterUnCommentaireToolStripMenuItem.CheckOnClick = True
        Me.AjouterUnCommentaireToolStripMenuItem.Name = "AjouterUnCommentaireToolStripMenuItem"
        Me.AjouterUnCommentaireToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AjouterUnCommentaireToolStripMenuItem.Text = "Ajouter un commentaire"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AProposDeToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'AProposDeToolStripMenuItem
        '
        Me.AProposDeToolStripMenuItem.Name = "AProposDeToolStripMenuItem"
        Me.AProposDeToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AProposDeToolStripMenuItem.Text = "A propos de"
        '
        'tbCompo
        '
        Me.tbCompo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbCompo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCompo.Location = New System.Drawing.Point(589, 266)
        Me.tbCompo.Multiline = True
        Me.tbCompo.Name = "tbCompo"
        Me.tbCompo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbCompo.Size = New System.Drawing.Size(180, 94)
        Me.tbCompo.TabIndex = 7
        Me.tbCompo.Visible = False
        '
        'lbTitre
        '
        Me.lbTitre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lbTitre.AutoSize = True
        Me.lbTitre.BackColor = System.Drawing.Color.Transparent
        Me.lbTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitre.ForeColor = System.Drawing.Color.Red
        Me.lbTitre.Location = New System.Drawing.Point(342, 9)
        Me.lbTitre.Name = "lbTitre"
        Me.lbTitre.Size = New System.Drawing.Size(392, 24)
        Me.lbTitre.TabIndex = 8
        Me.lbTitre.Text = "Maison des Sports de la Region Réunion"
        '
        'LabelServ
        '
        Me.LabelServ.AutoSize = True
        Me.LabelServ.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelServ.Location = New System.Drawing.Point(431, 215)
        Me.LabelServ.Name = "LabelServ"
        Me.LabelServ.Size = New System.Drawing.Size(289, 25)
        Me.LabelServ.TabIndex = 9
        Me.LabelServ.Text = "Veuillez choisir un service"
        '
        'LabelChoix
        '
        Me.LabelChoix.AutoSize = True
        Me.LabelChoix.BackColor = System.Drawing.Color.Transparent
        Me.LabelChoix.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChoix.Location = New System.Drawing.Point(12, 37)
        Me.LabelChoix.Name = "LabelChoix"
        Me.LabelChoix.Size = New System.Drawing.Size(151, 31)
        Me.LabelChoix.TabIndex = 10
        Me.LabelChoix.Text = "Bienvenue"
        '
        'btnEnreg
        '
        Me.btnEnreg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEnreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnreg.ForeColor = System.Drawing.Color.Red
        Me.btnEnreg.Location = New System.Drawing.Point(648, 481)
        Me.btnEnreg.Name = "btnEnreg"
        Me.btnEnreg.Size = New System.Drawing.Size(121, 31)
        Me.btnEnreg.TabIndex = 12
        Me.btnEnreg.Text = "Enregistrer"
        Me.btnEnreg.UseVisualStyleBackColor = True
        Me.btnEnreg.Visible = False
        '
        'tbcomment
        '
        Me.tbcomment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcomment.Location = New System.Drawing.Point(245, 367)
        Me.tbcomment.Name = "tbcomment"
        Me.tbcomment.Size = New System.Drawing.Size(524, 96)
        Me.tbcomment.TabIndex = 13
        Me.tbcomment.Text = ""
        Me.tbcomment.Visible = False
        '
        'affichePostes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 583)
        Me.Controls.Add(Me.tbcomment)
        Me.Controls.Add(Me.btnEnreg)
        Me.Controls.Add(Me.LabelChoix)
        Me.Controls.Add(Me.LabelServ)
        Me.Controls.Add(Me.lbTitre)
        Me.Controls.Add(Me.tbCompo)
        Me.Controls.Add(Me.lstPostes)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.tbPostes)
        Me.Controls.Add(Me.lblPostes)
        Me.Controls.Add(Me.cbService)
        Me.Controls.Add(Me.lblServices)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "affichePostes"
        Me.Text = "Gestion du service"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents tbPostes As System.Windows.Forms.TextBox
    Friend WithEvents lblPostes As System.Windows.Forms.Label
    Friend WithEvents cbService As System.Windows.Forms.ComboBox
    Friend WithEvents lblServices As System.Windows.Forms.Label
    Friend WithEvents lstPostes As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbCompo As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AProposDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComposantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbTitre As System.Windows.Forms.Label
    Friend WithEvents LabelServ As System.Windows.Forms.Label
    Friend WithEvents LabelChoix As System.Windows.Forms.Label
    Friend WithEvents AjouterUnCommentaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEnreg As System.Windows.Forms.Button
    Friend WithEvents tbcomment As System.Windows.Forms.RichTextBox

End Class
