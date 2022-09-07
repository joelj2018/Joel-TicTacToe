Public Class frmHome
    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        frmInstructions.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome to Joel's Tic Tac Toe Game! Remember to press the instructions button to read the rules and other information before you play the game!", MsgBoxStyle.Information, "Welcome!")


    End Sub

    Private Sub btnTICTACTOE_Click(sender As Object, e As EventArgs) Handles btnTICTACTOE.Click
        If txtPlay1.Text = "" Or txtPlay2.Text = "" Then
            MsgBox("Please enter both of the player names")
        Else
            frmTicTacToe.Show()
            Me.Hide()
        End If

        My.Computer.Audio.Play(My.Resources.Shuffle, AudioPlayMode.BackgroundLoop)
    End Sub
End Class
