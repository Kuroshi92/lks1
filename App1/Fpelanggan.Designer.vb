<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fpelanggan
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
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_notlp = New System.Windows.Forms.TextBox()
        Me.cb_jk = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_kosongkan = New System.Windows.Forms.Button()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(347, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MintCream
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(31, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.MintCream
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(31, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.MintCream
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(31, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No Telepon :"
        '
        'txt_nama
        '
        Me.txt_nama.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_nama.Location = New System.Drawing.Point(160, 53)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(260, 27)
        Me.txt_nama.TabIndex = 4
        '
        'txt_notlp
        '
        Me.txt_notlp.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_notlp.Location = New System.Drawing.Point(160, 163)
        Me.txt_notlp.Name = "txt_notlp"
        Me.txt_notlp.Size = New System.Drawing.Size(260, 27)
        Me.txt_notlp.TabIndex = 6
        '
        'cb_jk
        '
        Me.cb_jk.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cb_jk.FormattingEnabled = True
        Me.cb_jk.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cb_jk.Location = New System.Drawing.Point(160, 108)
        Me.cb_jk.Name = "cb_jk"
        Me.cb_jk.Size = New System.Drawing.Size(206, 28)
        Me.cb_jk.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MintCream
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(31, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Alamat :"
        '
        'txt_alamat
        '
        Me.txt_alamat.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_alamat.Location = New System.Drawing.Point(160, 209)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(260, 116)
        Me.txt_alamat.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(552, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(236, 377)
        Me.DataGridView1.TabIndex = 10
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(440, 129)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(94, 29)
        Me.btn_input.TabIndex = 11
        Me.btn_input.Text = "Input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(313, 354)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(94, 29)
        Me.btn_hapus.TabIndex = 12
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(440, 268)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(94, 29)
        Me.btn_edit.TabIndex = 13
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_kosongkan
        '
        Me.btn_kosongkan.Location = New System.Drawing.Point(160, 354)
        Me.btn_kosongkan.Name = "btn_kosongkan"
        Me.btn_kosongkan.Size = New System.Drawing.Size(94, 29)
        Me.btn_kosongkan.TabIndex = 14
        Me.btn_kosongkan.Text = "Kosongkan"
        Me.btn_kosongkan.UseVisualStyleBackColor = True
        '
        'btn_kembali
        '
        Me.btn_kembali.Location = New System.Drawing.Point(12, 408)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(94, 29)
        Me.btn_kembali.TabIndex = 15
        Me.btn_kembali.Text = "< Kembali"
        Me.btn_kembali.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(-1, -6)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(16, 27)
        Me.ID.TabIndex = 16
        '
        'Fpelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.btn_kembali)
        Me.Controls.Add(Me.btn_kosongkan)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_input)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_jk)
        Me.Controls.Add(Me.txt_notlp)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Fpelanggan"
        Me.Text = "Fpelanggan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_notlp As TextBox
    Friend WithEvents cb_jk As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_input As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_kosongkan As Button
    Friend WithEvents btn_kembali As Button
    Friend WithEvents ID As TextBox
End Class
