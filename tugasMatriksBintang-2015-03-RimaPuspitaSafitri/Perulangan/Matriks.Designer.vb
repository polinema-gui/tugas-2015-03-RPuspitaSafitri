<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matriks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_matrik1 = New System.Windows.Forms.Label()
        Me.Tbox_matrik1 = New System.Windows.Forms.TextBox()
        Me.Lbl_operasi = New System.Windows.Forms.Label()
        Me.Combo_operasi = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbox_matrik2 = New System.Windows.Forms.TextBox()
        Me.Tbox_Hasil = New System.Windows.Forms.TextBox()
        Me.Lbl_hasil = New System.Windows.Forms.Label()
        Me.button_proses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_matrik1
        '
        Me.Lbl_matrik1.AutoSize = True
        Me.Lbl_matrik1.Location = New System.Drawing.Point(13, 23)
        Me.Lbl_matrik1.Name = "Lbl_matrik1"
        Me.Lbl_matrik1.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_matrik1.TabIndex = 0
        Me.Lbl_matrik1.Text = "Matrik1"
        '
        'Tbox_matrik1
        '
        Me.Tbox_matrik1.Location = New System.Drawing.Point(61, 20)
        Me.Tbox_matrik1.Multiline = True
        Me.Tbox_matrik1.Name = "Tbox_matrik1"
        Me.Tbox_matrik1.Size = New System.Drawing.Size(368, 76)
        Me.Tbox_matrik1.TabIndex = 1
        '
        'Lbl_operasi
        '
        Me.Lbl_operasi.AutoSize = True
        Me.Lbl_operasi.Location = New System.Drawing.Point(12, 121)
        Me.Lbl_operasi.Name = "Lbl_operasi"
        Me.Lbl_operasi.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_operasi.TabIndex = 2
        Me.Lbl_operasi.Text = "Operasi"
        '
        'Combo_operasi
        '
        Me.Combo_operasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_operasi.FormattingEnabled = True
        Me.Combo_operasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.Combo_operasi.Location = New System.Drawing.Point(61, 118)
        Me.Combo_operasi.Name = "Combo_operasi"
        Me.Combo_operasi.Size = New System.Drawing.Size(368, 21)
        Me.Combo_operasi.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Matrik 2"
        '
        'Tbox_matrik2
        '
        Me.Tbox_matrik2.Location = New System.Drawing.Point(61, 165)
        Me.Tbox_matrik2.Multiline = True
        Me.Tbox_matrik2.Name = "Tbox_matrik2"
        Me.Tbox_matrik2.Size = New System.Drawing.Size(368, 76)
        Me.Tbox_matrik2.TabIndex = 5
        '
        'Tbox_Hasil
        '
        Me.Tbox_Hasil.Location = New System.Drawing.Point(61, 260)
        Me.Tbox_Hasil.Multiline = True
        Me.Tbox_Hasil.Name = "Tbox_Hasil"
        Me.Tbox_Hasil.Size = New System.Drawing.Size(368, 76)
        Me.Tbox_Hasil.TabIndex = 6
        '
        'Lbl_hasil
        '
        Me.Lbl_hasil.AutoSize = True
        Me.Lbl_hasil.Location = New System.Drawing.Point(12, 263)
        Me.Lbl_hasil.Name = "Lbl_hasil"
        Me.Lbl_hasil.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_hasil.TabIndex = 7
        Me.Lbl_hasil.Text = "Hasil"
        '
        'button_proses
        '
        Me.button_proses.Location = New System.Drawing.Point(307, 351)
        Me.button_proses.Name = "button_proses"
        Me.button_proses.Size = New System.Drawing.Size(122, 23)
        Me.button_proses.TabIndex = 8
        Me.button_proses.Text = "Proses"
        Me.button_proses.UseVisualStyleBackColor = True
        '
        'Matriks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.button_proses)
        Me.Controls.Add(Me.Lbl_hasil)
        Me.Controls.Add(Me.Tbox_Hasil)
        Me.Controls.Add(Me.Tbox_matrik2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Combo_operasi)
        Me.Controls.Add(Me.Lbl_operasi)
        Me.Controls.Add(Me.Tbox_matrik1)
        Me.Controls.Add(Me.Lbl_matrik1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Matriks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_matrik1 As System.Windows.Forms.Label
    Friend WithEvents Tbox_matrik1 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_operasi As System.Windows.Forms.Label
    Friend WithEvents Combo_operasi As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tbox_matrik2 As System.Windows.Forms.TextBox
    Friend WithEvents Tbox_Hasil As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_hasil As System.Windows.Forms.Label
    Friend WithEvents button_proses As System.Windows.Forms.Button
End Class
