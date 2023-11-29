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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.txtKM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConcerttoKM = New System.Windows.Forms.Button()
        Me.btnConcerttoMiles = New System.Windows.Forms.Button()
        Me.bntReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Tai Le", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(222, 59)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(299, 47)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Distance Convert"
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(143, 194)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(127, 20)
        Me.txtMiles.TabIndex = 1
        '
        'txtKM
        '
        Me.txtKM.Location = New System.Drawing.Point(428, 194)
        Me.txtKM.Name = "txtKM"
        Me.txtKM.Size = New System.Drawing.Size(127, 20)
        Me.txtKM.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(138, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Miles"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(423, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kilometers"
        '
        'btnConcerttoKM
        '
        Me.btnConcerttoKM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConcerttoKM.Location = New System.Drawing.Point(143, 242)
        Me.btnConcerttoKM.Name = "btnConcerttoKM"
        Me.btnConcerttoKM.Size = New System.Drawing.Size(141, 37)
        Me.btnConcerttoKM.TabIndex = 5
        Me.btnConcerttoKM.Text = "Convert to KM"
        Me.btnConcerttoKM.UseVisualStyleBackColor = True
        '
        'btnConcerttoMiles
        '
        Me.btnConcerttoMiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConcerttoMiles.Location = New System.Drawing.Point(428, 242)
        Me.btnConcerttoMiles.Name = "btnConcerttoMiles"
        Me.btnConcerttoMiles.Size = New System.Drawing.Size(164, 37)
        Me.btnConcerttoMiles.TabIndex = 6
        Me.btnConcerttoMiles.Text = "Convert to Miles"
        Me.btnConcerttoMiles.UseVisualStyleBackColor = True
        '
        'bntReset
        '
        Me.bntReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntReset.Location = New System.Drawing.Point(428, 384)
        Me.bntReset.Name = "bntReset"
        Me.bntReset.Size = New System.Drawing.Size(141, 37)
        Me.bntReset.TabIndex = 7
        Me.bntReset.Text = "Reset"
        Me.bntReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 450)
        Me.Controls.Add(Me.bntReset)
        Me.Controls.Add(Me.btnConcerttoMiles)
        Me.Controls.Add(Me.btnConcerttoKM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKM)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents txtKM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConcerttoKM As Button
    Friend WithEvents btnConcerttoMiles As Button
    Friend WithEvents bntReset As Button
End Class
