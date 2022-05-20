<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_spesaTotale
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
        Me.lbl_totSpesa = New System.Windows.Forms.Label()
        Me.btn_esci = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_totSpesa
        '
        Me.lbl_totSpesa.AutoSize = True
        Me.lbl_totSpesa.Location = New System.Drawing.Point(87, 150)
        Me.lbl_totSpesa.Name = "lbl_totSpesa"
        Me.lbl_totSpesa.Size = New System.Drawing.Size(0, 15)
        Me.lbl_totSpesa.TabIndex = 0
        '
        'btn_esci
        '
        Me.btn_esci.Location = New System.Drawing.Point(359, 311)
        Me.btn_esci.Name = "btn_esci"
        Me.btn_esci.Size = New System.Drawing.Size(75, 23)
        Me.btn_esci.TabIndex = 1
        Me.btn_esci.Text = "Esci"
        Me.btn_esci.UseVisualStyleBackColor = True
        '
        'frm_spesaTotale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 346)
        Me.Controls.Add(Me.btn_esci)
        Me.Controls.Add(Me.lbl_totSpesa)
        Me.Name = "frm_spesaTotale"
        Me.Text = "Spesa totale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_totSpesa As Label
    Friend WithEvents btn_esci As Button
End Class
