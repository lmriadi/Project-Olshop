<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHu
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
        Me.DVUser = New System.Windows.Forms.DataGridView()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnlogOut = New System.Windows.Forms.Button()
        CType(Me.DVUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DVUser
        '
        Me.DVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVUser.Location = New System.Drawing.Point(2, 1)
        Me.DVUser.Name = "DVUser"
        Me.DVUser.Size = New System.Drawing.Size(491, 150)
        Me.DVUser.TabIndex = 0
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(561, 57)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(185, 23)
        Me.BtnCari.TabIndex = 1
        Me.BtnCari.Text = "Mau Cari Barang???"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(115, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Lihat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Riwayat Pembelian"
        '
        'BtnlogOut
        '
        Me.BtnlogOut.Location = New System.Drawing.Point(701, 298)
        Me.BtnlogOut.Name = "BtnlogOut"
        Me.BtnlogOut.Size = New System.Drawing.Size(75, 23)
        Me.BtnlogOut.TabIndex = 6
        Me.BtnlogOut.Text = "Log Out"
        Me.BtnlogOut.UseVisualStyleBackColor = True
        '
        'FormHu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 333)
        Me.Controls.Add(Me.BtnlogOut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.DVUser)
        Me.Name = "FormHu"
        Me.Text = "Halaman Utama"
        CType(Me.DVUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DVUser As DataGridView
    Friend WithEvents BtnCari As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnlogOut As Button
End Class
