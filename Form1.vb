'Programmer: ArRionne Hickson
'Date: 8 May 2023
'Program: Personal Shopper App
'Purpose: 

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load initial images for shoes
        picShoe.Image = My.Resources.red
        picShoe.Image = My.Resources.black
        picShoe.Image = My.Resources.brown1
    End Sub

    Private Sub radRed_CheckedChanged(sender As Object, e As EventArgs) Handles radRed.CheckedChanged
        ' Red sneakers selected
        picShoe.Image = My.Resources.red
    End Sub

    Private Sub radBlack_CheckedChanged(sender As Object, e As EventArgs) Handles radBlack.CheckedChanged
        ' Black loafers selected
        picShoe.Image = My.Resources.black
    End Sub

    Private Sub radBrown_CheckedChanged(sender As Object, e As EventArgs) Handles radBrown.CheckedChanged
        ' Brown boots selected
        picShoe.Image = My.Resources.brown1
    End Sub

    Private Sub radPickup_CheckedChanged(sender As Object, e As EventArgs) Handles radPickup.CheckedChanged
        ' Pick up in store selected
        lblResults.Text = "You selected Pick up in store."
    End Sub

    Private Sub radDeliver_CheckedChanged(sender As Object, e As EventArgs) Handles radDeliver.CheckedChanged
        ' Home delivery selected
        lblResults.Text = "You selected Home delivery."
    End Sub

End Class