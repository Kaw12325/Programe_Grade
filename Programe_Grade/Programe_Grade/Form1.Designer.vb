<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.txt_score2 = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_grade = New System.Windows.Forms.TextBox()
        Me.txt_score1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_exit.Location = New System.Drawing.Point(534, 238)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(166, 73)
        Me.btn_exit.TabIndex = 12
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_clear.Location = New System.Drawing.Point(321, 238)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(166, 73)
        Me.btn_clear.TabIndex = 13
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_ok.Location = New System.Drawing.Point(117, 238)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(166, 73)
        Me.btn_ok.TabIndex = 14
        Me.btn_ok.Text = "Sum"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'txt_score2
        '
        Me.txt_score2.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_score2.Location = New System.Drawing.Point(323, 159)
        Me.txt_score2.Multiline = True
        Me.txt_score2.Name = "txt_score2"
        Me.txt_score2.Size = New System.Drawing.Size(200, 47)
        Me.txt_score2.TabIndex = 8
        Me.txt_score2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_total.Location = New System.Drawing.Point(177, 424)
        Me.txt_total.Multiline = True
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(185, 52)
        Me.txt_total.TabIndex = 9
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_grade
        '
        Me.txt_grade.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_grade.Location = New System.Drawing.Point(471, 424)
        Me.txt_grade.Multiline = True
        Me.txt_grade.Name = "txt_grade"
        Me.txt_grade.Size = New System.Drawing.Size(202, 52)
        Me.txt_grade.TabIndex = 10
        Me.txt_grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_score1
        '
        Me.txt_score1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_score1.Location = New System.Drawing.Point(323, 59)
        Me.txt_score1.Multiline = True
        Me.txt_score1.Name = "txt_score1"
        Me.txt_score1.Size = New System.Drawing.Size(200, 50)
        Me.txt_score1.TabIndex = 11
        Me.txt_score1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(100, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 70)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "คะแนนครั้งที่ 2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(100, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 70)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "คะแนนครั้งที่ 1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(177, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 70)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "คะแนนรวม"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(471, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 70)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ผลการเรียน"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(323, -25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 70)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "โปรแกรมตัดเกรด"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.txt_score2)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_grade)
        Me.Controls.Add(Me.txt_score1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_ok As Button
    Friend WithEvents txt_score2 As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_grade As TextBox
    Friend WithEvents txt_score1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
End Class
