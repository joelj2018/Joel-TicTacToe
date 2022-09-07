Public Class frmTicTacToe
    Private Sub frmTicTacToe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTurn2.Visible = False


        Dim play1 As String
        Dim play2 As String

        txtPlayer1.Enabled = False
        txtPlayer2.Enabled = False
        play1 = frmHome.txtPlay1.Text
        play2 = frmHome.txtPlay2.Text

        txtPlayer1.Text = play1
        txtPlayer2.Text = play2

        lblturn1.Text = play1 + lblturn1.Text
        lblTurn2.Text = play2 + lblTurn2.Text
    End Sub

    Private Sub win_chances()

        'Player 1 (x) Win Chances
        If (Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X") Then
            MsgBox("Congratulations Player 1, You Win!", MsgBoxStyle.Information, "Win")
            lblWin1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        ElseIf (Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X") Then
            MsgBox("Congratulations Player 1, You Win!", MsgBoxStyle.Information, "Win")
            lblWin1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        ElseIf (Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X") Then
            MsgBox("Congratulations Player 1, You Win!", MsgBoxStyle.Information, "Win")
            lblWin1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        ElseIf (Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X") Then
            MsgBox("Congratulations Player 1, You Win!", MsgBoxStyle.Information, "Win")
            lblWin1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        ElseIf (Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X") Then
            MsgBox("Congratulations Player 1, You Win!", MsgBoxStyle.Information, "Win")
            lblWin1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        ElseIf (Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X") Then
            MsgBox("Congratulations Player 1, You Win!", MsgBoxStyle.Information, "Win")
            lblWin1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        ElseIf (Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X") Then
            MsgBox("Congratulations Player 1, You Win!", MsgBoxStyle.Information, "Win")
            lblWin1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        ElseIf (Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X") Then
            MsgBox("Congratulations Player 1, You Win!", MsgBoxStyle.Information, "Win")
            lblWin1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
            'Player 2 (o) win chances
        ElseIf (Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O") Then
            MsgBox("Congratulations Player 2, You Win!", MsgBoxStyle.Information, "Win")
            lblWin2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        ElseIf (Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O") Then
            MsgBox("Congratulations Player 2, You Win!", MsgBoxStyle.Information, "Win")
            lblWin2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        ElseIf (Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O") Then
            MsgBox("Congratulations Player 2, You Win!", MsgBoxStyle.Information, "Win")
            lblWin2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        ElseIf (Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O") Then
            MsgBox("Congratulations Player 2, You Win!", MsgBoxStyle.Information, "Win")
            lblWin2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        ElseIf (Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O") Then
            MsgBox("Congratulations Player 2, You Win!", MsgBoxStyle.Information, "Win")
            lblWin2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        ElseIf (Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O") Then
            MsgBox("Congratulations Player 2, You Win!", MsgBoxStyle.Information, "Win")
            lblWin2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        ElseIf (Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O") Then
            MsgBox("Congratulations Player 2, You Win!", MsgBoxStyle.Information, "Win")
            lblWin2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        ElseIf (Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O") Then
            MsgBox("Congratulations Player 2, You Win!", MsgBoxStyle.Information, "Win")
            lblWin2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Call reset()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lblturn1.Visible = True Then
            Button1.Text = "X"
            win_chances()
            draw_check()
            lblturn1.Visible = False
            lblTurn2.Visible = True
            GoTo 50000
        ElseIf lblTurn2.Visible = True Then
            Button1.Text = "O"
            win_chances()
            draw_check()
            lblturn1.Visible = True
            lblTurn2.Visible = False
            GoTo 50000
        End If
50000:  Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If lblturn1.Visible = True Then
            Button2.Text = "X"
            win_chances()
            draw_check()
            lblturn1.Visible = False
            lblTurn2.Visible = True
            GoTo 50000
        ElseIf lblTurn2.Visible = True Then
            Button2.Text = "O"
            win_chances()
            draw_check()
            lblturn1.Visible = True
            lblTurn2.Visible = False
            GoTo 50000
        End If
50000:  Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lblturn1.Visible = True Then
            Button3.Text = "X"
            win_chances()
            draw_check()
            lblturn1.Visible = False
            lblTurn2.Visible = True
            GoTo 50000
        ElseIf lblTurn2.Visible = True Then
            Button3.Text = "O"
            win_chances()
            draw_check()
            lblturn1.Visible = True
            lblTurn2.Visible = False
            GoTo 50000
        End If
50000:  Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If lblturn1.Visible = True Then
            Button4.Text = "X"
            win_chances()
            draw_check()
            lblturn1.Visible = False
            lblTurn2.Visible = True
            GoTo 50000
        ElseIf lblTurn2.Visible = True Then
            Button4.Text = "O"
            win_chances()
            draw_check()
            lblturn1.Visible = True
            lblTurn2.Visible = False
            GoTo 50000
        End If
50000:  Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If lblturn1.Visible = True Then
            Button5.Text = "X"
            win_chances()
            draw_check()
            lblturn1.Visible = False
            lblTurn2.Visible = True
            GoTo 50000
        ElseIf lblTurn2.Visible = True Then
            Button5.Text = "O"
            win_chances()
            draw_check()
            lblturn1.Visible = True
            lblTurn2.Visible = False
            GoTo 50000
        End If
50000:  Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If lblturn1.Visible = True Then
            Button6.Text = "X"
            win_chances()
            draw_check()
            lblturn1.Visible = False
            lblTurn2.Visible = True
            GoTo 50000
        ElseIf lblTurn2.Visible = True Then
            Button6.Text = "O"
            win_chances()
            draw_check()
            lblturn1.Visible = True
            lblTurn2.Visible = False
            GoTo 50000
        End If
50000:  Button6.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If lblturn1.Visible = True Then
            Button7.Text = "X"
            win_chances()
            draw_check()
            lblturn1.Visible = False
            lblTurn2.Visible = True
            GoTo 50000
        ElseIf lblTurn2.Visible = True Then
            Button7.Text = "O"
            win_chances()
            draw_check()
            lblturn1.Visible = True
            lblTurn2.Visible = False
            GoTo 50000
        End If
50000:  Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If lblturn1.Visible = True Then
            Button8.Text = "X"
            win_chances()
            draw_check()
            lblturn1.Visible = False
            lblTurn2.Visible = True
            GoTo 50000
        ElseIf lblTurn2.Visible = True Then
            Button8.Text = "O"
            win_chances()
            draw_check()
            lblturn1.Visible = True
            lblTurn2.Visible = False
            GoTo 50000
        End If
50000:  Button8.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If lblturn1.Visible = True Then
            Button9.Text = "X"
            win_chances()
            draw_check()
            lblturn1.Visible = False
            lblTurn2.Visible = True
            GoTo 50000
        ElseIf lblTurn2.Visible = True Then
            Button9.Text = "O"
            win_chances()
            draw_check()
            lblturn1.Visible = True
            lblTurn2.Visible = False
            GoTo 50000
        End If
50000:  Button9.Enabled = False
    End Sub
    Dim win As Boolean

    Sub draw_check()
        If Button1.Text <> "" And Button2.Text <> "" And Button3.Text <> "" And Button4.Text <> "" And Button5.Text <> "" And Button6.Text <> "" And Button7.Text <> "" And Button8.Text <> "" And Button9.Text <> "" Then
            MsgBox("It's a Draw!", MsgBoxStyle.Information, "Draw")
            lblTie.Text += 1
            Call reset()
        End If
    End Sub


    Private Sub reset()
        Button1.Text = ""
        Button1.Enabled = True
        Button2.Text = ""
        Button2.Enabled = True
        Button3.Text = ""
        Button3.Enabled = True
        Button4.Text = ""
        Button4.Enabled = True
        Button5.Text = ""
        Button5.Enabled = True
        Button6.Text = ""
        Button6.Enabled = True
        Button7.Text = ""
        Button7.Enabled = True
        Button8.Text = ""
        Button8.Enabled = True
        Button9.Text = ""
        Button9.Enabled = True
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call reset()
        lblWin1.Text = 0
        lblWin2.Text = 0
        lblTie.Text = 0
    End Sub

    Private Sub btnQuitGame_Click(sender As Object, e As EventArgs) Handles btnQuitGame.Click
        Me.Close()
        My.Computer.Audio.Play(My.Resources.Shuffle, AudioPlayMode.BackgroundLoop)
        frmHome.Show()
    End Sub

    Private Sub btnResetwithdiffplayers_Click(sender As Object, e As EventArgs) Handles btnResetwithdiffplayers.Click
        Call reset()
        lblWin1.Text = 0
        lblWin2.Text = 0
        lblTie.Text = 0
        Me.Hide()
        frmHome.Show()
        My.Computer.Audio.Play(My.Resources.Shuffle, AudioPlayMode.BackgroundLoop)
        MsgBox("Change the names for Player 1 And Player 2, then hit Play")
    End Sub

End Class