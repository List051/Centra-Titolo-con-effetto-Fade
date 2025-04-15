'Imports ModUtility

'Public Class MainForm

'    Private Sub btnApriForm_Click(sender As Object, e As EventArgs) Handles btnApriForm.Click
'        ModUtility.ApriFormFade(New FormClienti()) ' con effetto dissolvenza
'    End Sub

'End Class




'ModFormFade\
'│
'├── ModFormFade.vbproj      ' La libreria
'├── ModUtility.vb           ' La classe con i metodi Shared
'│
'├── ExampleApp\             ' Progetto di esempio
'│   ├── ExampleApp.vbproj
'│   ├── FormMain.vb         ' Form principale con Panel e Button
'│   ├── FormDemo.vb         ' Form che viene caricato con fade
'│   └── ...
'└── README.md


'Imports ModFormFade

'Public Class FormMain
'    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' Aggiunge i controlli dinamicamente
'        Me.Controls.Add(PanelBody)
'        Me.Controls.Add(pnlTitoloPers)
'        Me.Controls.Add(btnApri)
'    End Sub

'    Private WithEvents PanelBody As New Panel With {
'        .Dock = DockStyle.Fill,
'        .Name = "PanelBody"
'    }

'    Private pnlTitoloPers As New Panel With {
'        .Dock = DockStyle.Top,
'        .Height = 40,
'        .BackColor = Color.DarkSlateGray,
'        .Name = "pnlTitoloPers"
'    }

'    Private btnApri As New Button With {
'        .Text = "Apri Demo",
'        .Dock = DockStyle.Top
'    }

'    Private Sub btnApri_Click(sender As Object, e As EventArgs) Handles btnApri.Click
'        ModUtility.ApriFormFade(New FormDemo(), Me, PanelBody)
'    End Sub
'End Class

'Public Class FormDemo
'    Inherits Form

'    Public Sub New()
'        Me.BackColor = Color.LightGreen
'        Dim lbl As New Label With {
'            .Text = "Ciao dal FormDemo!",
'            .Dock = DockStyle.Fill,
'            .TextAlign = ContentAlignment.MiddleCenter,
'            .Font = New Font("Segoe UI", 18, FontStyle.Bold)
'        }
'        Me.Controls.Add(lbl)
'    End Sub
'End Class


