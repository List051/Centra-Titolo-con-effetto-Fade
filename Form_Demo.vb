'Imports ModUtility

'Public Class Form1

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
'│   ├── Form1.vb         ' Form principale con Panel e Button
'│   ├── Form2.vb         ' Form che viene caricato con fade
'│   └── Form3.vb         ' Form che viene caricato con fade
'└── README.md

```vbnet

Imports CentraTitolo
Imports ModFormFade

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmTitolo.CTitolo(Me, "Menu Principale")   ' Inserire anche nel Form2 e Form3
    End Sub

    Private Sub BtnApriForm2_Click(sender As Object, e As EventArgs) Handles BtnApriForm2.Click

        ModUtility.ApriFormFade(New Form2()) ' con effetto dissolvenza

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ModUtility.ApriFormFade(New Form3()) ' con effetto dissolvenza

    End Sub

End Class



