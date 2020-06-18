Imports MySql.Data.MySqlClient
Imports System
Imports System.Text.RegularExpressions
Public Class affichePostes
    Public nomservice As String
    Public numposte As String
    Private Sub affichePoste_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'on instancie un objet connexion pour remplir les collections
        Dim maConnexion As New Connexion
        maConnexion.remplirServices()
        cbService.DrawMode = DrawMode.OwnerDrawVariable
        lblPostes.Visible = False
        tbPostes.Visible = False
        lstPostes.Visible = False
        LabelServ.Visible = True
    End Sub
    Private Sub cbService_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbService.SelectedIndexChanged
        'rendre visible les deux contrôles suivants
        lblPostes.Visible = True
        tbPostes.Visible = True
        lstPostes.Visible = True
        LabelServ.Visible = False

        Dim idServiceCherché As String
        'on récupère le nom du service sélectionné
        Dim GETidServiceCherché As DataRowView = DirectCast(cbService.SelectedItem, DataRowView)
        'on stocke la valeur "IdService" sélectionné dans une variable
        idServiceCherché = GETidServiceCherché("numService")
        nomservice = GETidServiceCherché("nomservice")

        'remise à blanc du textbox d'affichage des postes
        '......
        tbPostes.Text = ""
        lstPostes.Items.Clear()
        tbCompo.Text = ""

        ' Affichage de tous les postes du service sélectionné.
        '.........
        Dim maConnexion As New Connexion
        maConnexion.remplirPostes()

    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        'Affiche la fenetre de vérification pour quitter
        Dim Reponse As DialogResult
        Reponse = MessageBox.Show("Voulez-vous vraiment quitter l'application  ?", "Au revoir", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Reponse = DialogResult.Yes Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        'Affiche la fenetre de vérification pour quitter
        Dim Reponse As DialogResult
        Reponse = MessageBox.Show("Voulez-vous vraiment quitter l'application  ?", "Au revoir", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Reponse = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub lstPostes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPostes.SelectedIndexChanged
        'Quand un poste est sélectionner dans la listebox
        tbCompo.Text = ""
        postenum()
        Dim maConnexion As New Connexion
        maConnexion.remplirCompo1()
        maConnexion.remplirCompo2()
        maConnexion.remplirChoix()
        maConnexion.remplirComment()

    End Sub

    Private Sub AProposDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposDeToolStripMenuItem.Click
        'ouvre l'apropos
        Apropos.Show()
    End Sub

    Private Sub ComposantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComposantToolStripMenuItem.Click
        'Affiche les composants
        If ComposantToolStripMenuItem.Checked = True Then
            tbCompo.Visible = True
        Else
            tbCompo.Visible = False
        End If
    End Sub
    Private Sub cbservice_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cbService.DrawItem
        'Pour la combobox multicolonne
        e.DrawBackground()
        Dim drv As DataRowView = DirectCast(cbService.Items(e.Index), DataRowView)

        Dim numservice As String = drv("numservice").ToString()
        Dim nomservice As String = drv("nomservice").ToString()

        Dim c1 As Rectangle = e.Bounds
        c1.Width = c1.Width / 2

        Using sb As New SolidBrush(Color.Black)
            e.Graphics.DrawString(numservice, e.Font, sb, c1)
        End Using

        Dim c2 As Rectangle = e.Bounds
        c2.X = e.Bounds.Width / 4
        c2.Width = c2.Width / 1

        Using sb As New SolidBrush(Color.Black)
            e.Graphics.DrawString(nomservice, e.Font, sb, c2)
        End Using

    End Sub

    Private Sub AjouterUnCommentaireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterUnCommentaireToolStripMenuItem.Click
        'Affiche les composants
        If AjouterUnCommentaireToolStripMenuItem.Checked = True Then
            tbcomment.Visible = True
            btnEnreg.Visible = True
        Else
            tbcomment.Visible = False
            btnEnreg.Visible = False
        End If
    End Sub

    Private Sub btnEnreg_Click(sender As Object, e As EventArgs) Handles btnEnreg.Click
        Dim maConnexion As New Connexion
        maConnexion.enregistrercomment()
        'Affiche la fenetre de vérification pour l'enregistrement
        Dim Reponse As DialogResult
        Reponse = MessageBox.Show("Voulez avez bien enregistrer", "Validation", _
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub postenum()
        Dim posteselect As String = Me.lstPostes.SelectedItem
        Dim poste As String = String.Empty

        Dim match = Regex.Match(posteselect, "^Poste (.*?)$")
        If match.Success Then
            poste = match.Groups(1).Value
        End If
        numposte = poste
    End Sub
End Class