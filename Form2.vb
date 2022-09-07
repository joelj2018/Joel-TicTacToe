Public Class frmInstructions
    Private Sub btnBackHome_Click(sender As Object, e As EventArgs) Handles btnBackHome.Click
        Me.Close()
        My.Computer.Audio.Play(My.Resources.Shuffle, AudioPlayMode.BackgroundLoop)
        frmHome.Show()
    End Sub

    Private Sub frmInstructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Shuffle, AudioPlayMode.BackgroundLoop)
    End Sub


End Class