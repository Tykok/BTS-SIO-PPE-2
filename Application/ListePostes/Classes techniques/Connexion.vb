Imports MySql.Data.MySqlClient
Public Class Connexion
    Dim dt As New DataTable
    Private m_Connexion As MySqlConnection
    Private Sub ouvrir()
        'Définir une chaîne de connexion
        Dim ChaineConnexion As String
        'chaine de connexion sur le serveur local de Wamp
        ChaineConnexion = "server=localhost;user=root;database=ppe2;port=3306;password=;"
        'ChaineConnexion = "server=localhost;user=root;database=ppe2;port=3306;password=131517;"
        ' Instancier la connexion
        m_Connexion = New MySqlConnection(ChaineConnexion)

        'Ouvrir la connexion
        Try
            m_Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub
    Private Sub fermer()
        'Fermer la connexion
        Try
            m_Connexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub remplirServices()

        ' ouverture connexion
        ouvrir()

        'Requete pour les Service
        Dim requete As String = " select * from service "
        Dim cmd As New MySqlCommand(requete, m_Connexion)
        Dim adapter As New MySqlDataAdapter(cmd)
        adapter.Fill(dt)

        affichePostes.cbService.DisplayMember = "numservice"
        affichePostes.cbService.DataSource = dt
    End Sub
    Public Sub remplirPostes()

        ' ouverture connexion
        ouvrir()

        ' requète qui va chercher les tuples
        Dim requete As String = " select idposte from poste where numservice = ?service "

        'Instancier un objet Command
        Dim cmd As New MySqlCommand
        With cmd
            'Paramétrer la commande
            .Connection = m_Connexion
            .CommandText = requete
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("?service", affichePostes.cbService.SelectedIndex + 1)
        End With

        'créer l'objet qui reçoit le résultat de la requête
        Dim rdr As MySqlDataReader = cmd.ExecuteReader()
        'parcourir la table résultat
        While rdr.Read
            ' Remplir la liste Des Postes
            affichePostes.lstPostes.Items.Add("Poste " & rdr.GetString(0))
            affichePostes.tbPostes.Text &= "Poste " & rdr.GetString(0) & vbCrLf
        End While

        'fermer la connexion
        fermer()

    End Sub

    Public Sub remplirCompo1()

        ' ouverture connexion
        ouvrir()

        ' requète qui va chercher les tuples
        Dim requete As String = " select marque, processeur, taillememoire, disquedur, ip ,cartegraphique from poste where poste.idposte = ?poste"

        'Instancier un objet Command
        Dim cmd As New MySqlCommand
        With cmd
            'Paramétrer la commande
            .Connection = m_Connexion
            .CommandText = requete
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("?poste", affichePostes.numposte)
        End With

        'créer l'objet qui reçoit le résultat de la requête
        Dim rdr As MySqlDataReader = cmd.ExecuteReader()
        'parcourir la table résultat
        While rdr.Read
            ' Remplir la liste des Composant
            affichePostes.tbCompo.Text = "Marque : " & rdr.GetString(0) & vbCrLf & "Processeur : " & rdr.GetString(1) & vbCrLf & "Taille Memoire : " & rdr.GetString(2) & vbCrLf & "Disque dur : " & rdr.GetString(3) & vbCrLf & "IP : " & rdr.GetString(4) & vbCrLf & "Carte Graphique : " & rdr.GetString(5) & vbCrLf
        End While
        'fermer la connexion
        fermer()

    End Sub
    Public Sub remplirCompo2()

        ' ouverture connexion
        ouvrir()

        ' requète qui va chercher les tuples
        Dim requete As String = " select editeur ,version ,licence from logiciel inner join installer on logiciel.idlogiciel = installer.idlogiciel where installer.idposte = ?poste"

        'Instancier un objet Command
        Dim cmd As New MySqlCommand
        With cmd
            'Paramétrer la commande
            .Connection = m_Connexion
            .CommandText = requete
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("?poste", affichePostes.numposte)
        End With

        'créer l'objet qui reçoit le résultat de la requête
        Dim rdr As MySqlDataReader = cmd.ExecuteReader()
        'parcourir la table résultat
        If rdr.FieldCount = 0 Then
            rdr.Close()
        Else
            affichePostes.tbCompo.Text = affichePostes.tbCompo.Text + "- Logiciel -"
            While rdr.Read
                ' Remplir la liste des Composant part logiciel
                affichePostes.tbCompo.Text &= vbCrLf & "Editeur : " & rdr.GetString(0) & vbCrLf & "Version : " & rdr.GetString(1) & vbCrLf & "Licence : " & rdr.GetString(2) & vbCrLf
            End While
        End If
        'fermer la connexion
        fermer()

    End Sub
    Public Sub remplirChoix()
        ' Montrer le service et le poste sélectionner
        affichePostes.LabelChoix.Text = "Vous êtes sur le service " & affichePostes.nomservice & " et sur " & affichePostes.lstPostes.SelectedItem

    End Sub
    Public Sub enregistrercomment()

        ' ouverture connexion
        ouvrir()

        ' requète qui va chercher les tuples
        Dim requete As String = " update poste set commentaire = ?comment where idposte = ?poste"

        'Instancier un objet Command
        Dim cmd As New MySqlCommand
        With cmd
            'Paramétrer la commande
            .Connection = m_Connexion
            .CommandText = requete
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("?comment", affichePostes.tbcomment.Text)
            .Parameters.AddWithValue("?poste", affichePostes.numposte)
        End With

        'créer l'objet qui reçoit le résultat de la requête
        Dim rdr As MySqlDataReader = cmd.ExecuteReader()

        'fermer la connexion
        fermer()

    End Sub
    Public Sub remplirComment()

        ' ouverture connexion
        ouvrir()

        ' requète qui va chercher les tuples
        Dim requete As String = " select commentaire from poste where idposte = ?poste"

        'Instancier un objet Command
        Dim cmd As New MySqlCommand
        With cmd
            'Paramétrer la commande
            .Connection = m_Connexion
            .CommandText = requete
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("?poste", affichePostes.numposte)
        End With

        'créer l'objet qui reçoit le résultat de la requête
        Dim rdr As MySqlDataReader = cmd.ExecuteReader()
        'parcourir la table résultat
        If rdr.FieldCount = 0 Then
            rdr.Close()
        Else
            While rdr.Read
                ' Remplir la liste des Composant part logiciel
                affichePostes.tbcomment.Text = rdr.GetString(0)
            End While
        End If
        'fermer la connexion
        fermer()

    End Sub
End Class
