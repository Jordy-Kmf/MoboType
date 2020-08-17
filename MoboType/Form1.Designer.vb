<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bxNum = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bxAlpha = New System.Windows.Forms.TextBox()
        Me.lblNC = New System.Windows.Forms.Label()
        Me.lblAR = New System.Windows.Forms.Label()
        Me.lblAL = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(177, 302)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Alpha"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(273, 302)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(369, 302)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bxNum)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 276)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Num"
        '
        'bxNum
        '
        Me.bxNum.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bxNum.Location = New System.Drawing.Point(6, 19)
        Me.bxNum.Multiline = True
        Me.bxNum.Name = "bxNum"
        Me.bxNum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.bxNum.Size = New System.Drawing.Size(284, 251)
        Me.bxNum.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bxAlpha)
        Me.GroupBox2.Location = New System.Drawing.Point(314, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 276)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alpha"
        '
        'bxAlpha
        '
        Me.bxAlpha.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bxAlpha.Location = New System.Drawing.Point(6, 19)
        Me.bxAlpha.MaxLength = 1000
        Me.bxAlpha.Multiline = True
        Me.bxAlpha.Name = "bxAlpha"
        Me.bxAlpha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.bxAlpha.Size = New System.Drawing.Size(285, 251)
        Me.bxAlpha.TabIndex = 1
        '
        'lblNC
        '
        Me.lblNC.AutoSize = True
        Me.lblNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNC.Location = New System.Drawing.Point(18, 291)
        Me.lblNC.Name = "lblNC"
        Me.lblNC.Size = New System.Drawing.Size(15, 16)
        Me.lblNC.TabIndex = 3
        Me.lblNC.Text = "0"
        Me.lblNC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAR
        '
        Me.lblAR.AutoSize = True
        Me.lblAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAR.Location = New System.Drawing.Point(570, 291)
        Me.lblAR.Name = "lblAR"
        Me.lblAR.Size = New System.Drawing.Size(36, 16)
        Me.lblAR.TabIndex = 4
        Me.lblAR.Text = "1000"
        Me.lblAR.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblAL
        '
        Me.lblAL.AutoSize = True
        Me.lblAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAL.Location = New System.Drawing.Point(570, 291)
        Me.lblAL.Name = "lblAL"
        Me.lblAL.Size = New System.Drawing.Size(15, 16)
        Me.lblAL.TabIndex = 5
        Me.lblAL.Text = "0"
        Me.lblAL.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 337)
        Me.Controls.Add(Me.lblAL)
        Me.Controls.Add(Me.lblAR)
        Me.Controls.Add(Me.lblNC)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnClear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "MoboType - Ready..."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnGo As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bxNum As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents bxAlpha As TextBox
    Friend WithEvents lblNC As Label
    Friend WithEvents lblAR As Label
    Friend WithEvents lblAL As Label
End Class
