﻿Public Class Form1
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If String.IsNullOrEmpty(txt_score1.Text) Or String.IsNullOrEmpty(txt_score2.Text) Then
            MessageBox.Show("กรุณากรอกตัวเลข")
            txt_score1.Text = ""
            txt_score2.Text = ""
        Else



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
End Class