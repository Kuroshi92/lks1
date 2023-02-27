<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSupplier
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_namasup = New System.Windows.Forms.TextBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.txt_notlp = New System.Windows.Forms.TextBox()
        Me.txt_norekening = New System.Windows.Forms.TextBox()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_kosongkan = New System.Windows.Forms.Button()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.CB_Bank = New System.Windows.Forms.ComboBox()
        Me.ID = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(298, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Data Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(49, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Supplier :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(49, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(49, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No Telepon :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(49, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama Bank :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(49, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "No Rekening :"
        '
        'txt_namasup
        '
        Me.txt_namasup.Location = New System.Drawing.Point(243, 79)
        Me.txt_namasup.Name = "txt_namasup"
        Me.txt_namasup.Size = New System.Drawing.Size(209, 27)
        Me.txt_namasup.TabIndex = 6
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(243, 125)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(209, 27)
        Me.txt_alamat.TabIndex = 7
        '
        'txt_notlp
        '
        Me.txt_notlp.Location = New System.Drawing.Point(243, 174)
        Me.txt_notlp.Name = "txt_notlp"
        Me.txt_notlp.Size = New System.Drawing.Size(209, 27)
        Me.txt_notlp.TabIndex = 8
        '
        'txt_norekening
        '
        Me.txt_norekening.Location = New System.Drawing.Point(243, 265)
        Me.txt_norekening.Name = "txt_norekening"
        Me.txt_norekening.Size = New System.Drawing.Size(205, 27)
        Me.txt_norekening.TabIndex = 10
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(34, 323)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(94, 29)
        Me.btn_input.TabIndex = 11
        Me.btn_input.Text = "Input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(531, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(350, 361)
        Me.DataGridView1.TabIndex = 12
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(158, 323)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(94, 29)
        Me.btn_edit.TabIndex = 13
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(284, 323)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(94, 29)
        Me.btn_hapus.TabIndex = 14
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_kosongkan
        '
        Me.btn_kosongkan.Location = New System.Drawing.Point(414, 323)
        Me.btn_kosongkan.Name = "btn_kosongkan"
        Me.btn_kosongkan.Size = New System.Drawing.Size(94, 29)
        Me.btn_kosongkan.TabIndex = 15
        Me.btn_kosongkan.Text = "Kosongkan"
        Me.btn_kosongkan.UseVisualStyleBackColor = True
        '
        'btn_kembali
        '
        Me.btn_kembali.Location = New System.Drawing.Point(12, 409)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(94, 29)
        Me.btn_kembali.TabIndex = 16
        Me.btn_kembali.Text = "Kembali"
        Me.btn_kembali.UseVisualStyleBackColor = True
        '
        'CB_Bank
        '
        Me.CB_Bank.FormattingEnabled = True
        Me.CB_Bank.Items.AddRange(New Object() {"Mandiri", "BCA", "BRI", "BNI", "Gopay", "QRIS", "Dana"})
        Me.CB_Bank.Location = New System.Drawing.Point(243, 219)
        Me.CB_Bank.Name = "CB_Bank"
        Me.CB_Bank.Size = New System.Drawing.Size(205, 28)
        Me.CB_Bank.TabIndex = 17
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(2, -1)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(21, 27)
        Me.ID.TabIndex = 18
        '
        'FSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(893, 450)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.CB_Bank)
        Me.Controls.Add(Me.btn_kembali)
        Me.Controls.Add(Me.btn_kosongkan)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_input)
        Me.Controls.Add(Me.txt_norekening)
        Me.Controls.Add(Me.txt_notlp)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.txt_namasup)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FSupplier"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_namasup As TextBox
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents txt_notlp As TextBox
    Friend WithEvents txt_norekening As TextBox
    Friend WithEvents btn_input As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_kosongkan As Button
    Friend WithEvents btn_kembali As Button
    Friend WithEvents CB_Bank As ComboBox
    Friend WithEvents ID As TextBox
End Class
