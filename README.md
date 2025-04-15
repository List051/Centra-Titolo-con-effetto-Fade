# ModUtility - Fade & Form Manager per WinForms VB.NET

`ModUtility` è un modulo utile per la gestione semplificata dell'apertura dei `Form` in un'applicazione WinForms con effetto dissolvenza (fade) sul titolo e gestione automatica del contenuto all'interno di un `Panel`.

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

Assicurati che `ModUtility.vb` sia incluso nel tuo progetto o in una libreria referenziata.

### 2. Struttura base del `Form` principale

Nel `Form` principale (`FormMain`, per esempio), assicurati di avere:

```vbnet
' Panel che ospita i Form secondari
Private WithEvents PanelBody As New Panel With {
    .Dock = DockStyle.Fill,
    .Name = "PanelBody"
}

' Pannello personalizzato per il titolo
Private pnlTitoloPers As New Panel With {
    .Dock = DockStyle.Top,
    .Height = 50,
    .BackColor = Color.SteelBlue,
    .Name = "pnlTitoloPers"
}


💡 Versione alternativa (completa)

Se il tuo form ha un pannello con un nome personalizzato (ad esempio PanelPluto), puoi usare la versione completa del metodo:

ModUtility.ApriFormFade(New Form3(), Me, PanelPluto)

Parametri:

    New Form3() → il form che vuoi aprire

    Me → il form attuale (quello da cui chiami)

    PanelPluto → il pannello dove vuoi caricare Form3
	
	
### Esempio 

```vbnet
Imports ModUtility

Public Class MainForm

    Private Sub btnApriForm_Click(sender As Object, e As EventArgs) Handles btnApriForm.Click
        ModUtility.ApriFormFade(New FormClienti()) ' con effetto dissolvenza
    End Sub

End Class

### Esempio Demo

```vbnet

