<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bintang
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
        Me.Lbl_pola = New System.Windows.Forms.Label()
        Me.Lbl_baris = New System.Windows.Forms.Label()
        Me.Tbox_baris = New System.Windows.Forms.TextBox()
        Me.button_proses = New System.Windows.Forms.Button()
        Me.Tbox_hasil = New System.Windows.Forms.TextBox()
        Me.Combo_pola = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Lbl_pola
        '
        Me.Lbl_pola.AutoSize = True
        Me.Lbl_pola.Location = New System.Drawing.Point(13, 19)
        Me.Lbl_pola.Name = "Lbl_pola"
        Me.Lbl_pola.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_pola.TabIndex = 1
        Me.Lbl_pola.Text = "Pola :"
        '
        'Lbl_baris
        '
        Me.Lbl_baris.AutoSize = True
        Me.Lbl_baris.Location = New System.Drawing.Point(13, 65)
        Me.Lbl_baris.Name = "Lbl_baris"
        Me.Lbl_baris.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_baris.TabIndex = 2
        Me.Lbl_baris.Text = "Baris :"
        '
        'Tbox_baris
        '
        Me.Tbox_baris.Location = New System.Drawing.Point(53, 62)
        Me.Tbox_baris.Name = "Tbox_baris"
        Me.Tbox_baris.Size = New System.Drawing.Size(266, 20)
        Me.Tbox_baris.TabIndex = 3
        '
        'button_proses
        '
        Me.button_proses.Location = New System.Drawing.Point(325, 60)
        Me.button_proses.Name = "button_proses"
        Me.button_proses.Size = New System.Drawing.Size(114, 23)
        Me.button_proses.TabIndex = 4
        Me.button_proses.Text = "Proses"
        Me.button_proses.UseVisualStyleBackColor = True
        '
        'Tbox_hasil
        '
        Me.Tbox_hasil.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbox_hasil.Location = New System.Drawing.Point(16, 108)
        Me.Tbox_hasil.Multiline = True
        Me.Tbox_hasil.Name = "Tbox_hasil"
        Me.Tbox_hasil.Size = New System.Drawing.Size(423, 305)
        Me.Tbox_hasil.TabIndex = 5
        '
        'Combo_pola
        '
        Me.Combo_pola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_pola.FormattingEnabled = True
        Me.Combo_pola.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.Combo_pola.Location = New System.Drawing.Point(53, 11)
        Me.Combo_pola.Name = "Combo_pola"
        Me.Combo_pola.Size = New System.Drawing.Size(386, 21)
        Me.Combo_pola.TabIndex = 2
        '
        'Bintang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.Combo_pola)
        Me.Controls.Add(Me.Tbox_hasil)
        Me.Controls.Add(Me.button_proses)
        Me.Controls.Add(Me.Tbox_baris)
        Me.Controls.Add(Me.Lbl_baris)
        Me.Controls.Add(Me.Lbl_pola)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Bintang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_pola As System.Windows.Forms.Label
    Friend WithEvents Lbl_baris As System.Windows.Forms.Label
    Friend WithEvents Tbox_baris As System.Windows.Forms.TextBox
    Friend WithEvents button_proses As System.Windows.Forms.Button
    Friend WithEvents Tbox_hasil As System.Windows.Forms.TextBox
    Friend WithEvents Combo_pola As System.Windows.Forms.ComboBox
End Class
