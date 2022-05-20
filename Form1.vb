Public Class frm_spesaTotale
    Private Sub frm_spesaTotale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numProd, cont As Byte
        Dim prezzo, tot As Single
        numProd = Val(InputBox("Quanti prodotti sono stato acquistati?", "input"))
        tot = 0
        cont = 1
        Do While cont <= numProd
            prezzo = Val(InputBox("inserisci il prezzo", CStr(cont) & "° prodotto"))
            tot = tot + prezzo
            cont = cont + 1
        Loop
        lbl_totSpesa.Text = "Importo totale della spesa: " & CStr(tot)
    End Sub

    Private Sub btn_esci_Click(sender As Object, e As EventArgs) Handles btn_esci.Click
        End
    End Sub
End Class
