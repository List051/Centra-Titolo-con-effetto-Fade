# ModFormFade

![NuGet](https://img.shields.io/nuget/v/ModFormFade?style=flat-square)
![Downloads](https://img.shields.io/nuget/dt/ModFormFade?style=flat-square)

## ✨ Funzionalità Libreria ModFormFade

🎬 **Demo Video:** [Guarda su YouTube](https://youtu.be/-Bmwirt68pI)

## ✨ Funzionalità Libreria CentraTitolo

🎬 **Demo Video:** [Guarda su YouTube](https://youtu.be/VXmUhjv854g)


# ModUtility - Fade & Form Manager per WinForms VB.NET

`ModUtility` è un modulo utile per la gestione semplificata dell'apertura dei `Form` in un'applicazione WinForms con effetto dissolvenza (fade) sul titolo e gestione automatica del contenuto all'interno di un `Panel`.
Nel progetto è inclusa la libreria ModFormFade.dll
---

## ✨ Funzionalità

- **FadeControl**: applica un effetto dissolvenza in entrata/uscita su qualsiasi `Control`
- **ApriFormFade**: apre un `Form` dentro un `Panel` con dissolvenza del titolo
- **CloseOpenForm**: chiude eventuale form già aperto nel `PanelBody`

---

## 📦 Requisiti

- VB.NET (Windows Forms)
- Controlli presenti nel `Form`:
  - Un `Panel` chiamato `PanelBody`
  - Un controllo (di solito `Panel`) chiamato `pnlTitoloPers`

---

## 🧑‍💻 Utilizzo

### 1. Import del modulo

Assicurati che `ModUtility` sia incluso nel tuo progetto o in una libreria referenziata.

### 2. Struttura base del `Form` principale

Nel `Form` principale (`Form1`, per esempio), assicurati di avere:

```vbnet
Imports CentraTitolo
Imports ModFormFade

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmTitolo.CTitolo(Me, "Menu Principale")
    End Sub

    Private Sub BtnApriForm2_Click(sender As Object, e As EventArgs) Handles BtnApriForm2.Click

        ModUtility.ApriFormFade(New Form2()) ' con effetto dissolvenza

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ModUtility.ApriFormFade(New Form3()) ' con effetto dissolvenza

    End Sub

End Class


💡 Versione alternativa (completa)

Se il tuo form ha un pannello con un nome personalizzato (ad esempio PanelPluto), puoi usare la versione completa del metodo:

ModUtility.ApriFormFade(New Form3(), Me, PanelPluto)

Parametri:

    New Form3() → il form che vuoi aprire

    Me → il form attuale (quello da cui chiami)

    PanelPluto → il pannello dove vuoi caricare Form3
	
	
### Esempio 

```vbnet
Imports ModFormFade

Public Class MainForm

    Private Sub btnApriForm_Click(sender As Object, e As EventArgs) Handles btnApriForm.Click
        ModUtility.ApriFormFade(New FormClienti()) ' con effetto dissolvenza
    End Sub

End Class



