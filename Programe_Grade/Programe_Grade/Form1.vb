Public Class Form1
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If String.IsNullOrEmpty(txt_score1.Text) Or String.IsNullOrEmpty(txt_score2.Text) Then
            MessageBox.Show("กรุณากรอกตัวเลข")
            txt_score1.Text = ""
            txt_score2.Text = ""
        Else
            Dim s1, s2, total As Single
            s1 = txt_score1.Text
            s2 = txt_score2.Text
            total = s1 + s2
            txt_total.Text = total

            If total >= 80 And total <= 100 Then
                txt_grade.Text = " GRADE 4 "
            ElseIf total >= 70 And total <= 79 Then
                txt_grade.Text = " GRADE 3 "
            ElseIf total >= 70 And total <= 69 Then
                txt_grade.Text = " GRADE 2 "
            ElseIf total >= 70 And total <= 59 Then
                txt_grade.Text = " GRADE 1 "
            ElseIf total >= 70 And total <= 49 Then
                txt_grade.Text = " GRADE 0 "
            Else
                txt_grade.Text = " ERROR "


            End If
        End If

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_score1.Text = ""
        txt_score2.Text = ""
        txt_total.Text = ""
        txt_grade.Text = ""
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Dim bt_Exit As MsgBoxResult
        bt_Exit = MsgBox("จบการทำงานใช่หรือไม่ ?", MsgBoxStyle.YesNo, "จบการทำงาน")
        If bt_Exit = MsgBoxResult.Yes Then
            MsgBox("เลิกการทำงาน.....", MsgBoxStyle.Exclamation, "จบการทำงาน")
            Application.Exit()
    End Sub
End Class
