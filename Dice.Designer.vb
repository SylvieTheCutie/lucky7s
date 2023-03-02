<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dice
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PicFace = New System.Windows.Forms.PictureBox()
        CType(Me.PicFace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicFace
        '
        Me.PicFace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicFace.Image = Global.CustomControlDemo.My.Resources.Resources.Alea_0
        Me.PicFace.Location = New System.Drawing.Point(0, 0)
        Me.PicFace.Name = "PicFace"
        Me.PicFace.Size = New System.Drawing.Size(450, 450)
        Me.PicFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFace.TabIndex = 0
        Me.PicFace.TabStop = False
        '
        'Dice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PicFace)
        Me.Name = "Dice"
        Me.Size = New System.Drawing.Size(450, 450)
        CType(Me.PicFace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicFace As PictureBox
End Class
