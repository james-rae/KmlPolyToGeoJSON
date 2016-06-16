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
        Me.openSesame = New System.Windows.Forms.OpenFileDialog()
        Me.cmdEnhance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'openSesame
        '
        Me.openSesame.FileName = "d:\data\LWB\LWB_Raw.txt"
        '
        'cmdEnhance
        '
        Me.cmdEnhance.Location = New System.Drawing.Point(12, 12)
        Me.cmdEnhance.Name = "cmdEnhance"
        Me.cmdEnhance.Size = New System.Drawing.Size(257, 45)
        Me.cmdEnhance.TabIndex = 0
        Me.cmdEnhance.Text = "Pick A File And GRIND"
        Me.cmdEnhance.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 70)
        Me.Controls.Add(Me.cmdEnhance)
        Me.Name = "Form1"
        Me.Text = "Make Me Some GeoJSON"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents openSesame As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdEnhance As System.Windows.Forms.Button

End Class
