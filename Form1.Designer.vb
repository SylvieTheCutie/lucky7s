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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.btnroll = New System.Windows.Forms.Button()
        Me.dice1 = New CustomControlDemo.Dice()
        Me.Dice2 = New CustomControlDemo.Dice()
        Me.Tracker1 = New CustomControlDemo.Tracker()
        Me.SuspendLayout()
        '
        'btnroll
        '
        Me.btnroll.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnroll.Location = New System.Drawing.Point(11, 150)
        Me.btnroll.Name = "btnroll"
        Me.btnroll.Size = New System.Drawing.Size(136, 95)
        Me.btnroll.TabIndex = 1
        Me.btnroll.Text = "Roll It!"
        Me.btnroll.UseVisualStyleBackColor = False
        '
        'dice1
        '
        Me.dice1.Location = New System.Drawing.Point(11, 12)
        Me.dice1.Name = "dice1"
        Me.dice1.Size = New System.Drawing.Size(140, 132)
        Me.dice1.TabIndex = 0
        Me.dice1.value = 0
        '
        'Dice2
        '
        Me.Dice2.Location = New System.Drawing.Point(11, 251)
        Me.Dice2.Name = "Dice2"
        Me.Dice2.Size = New System.Drawing.Size(140, 132)
        Me.Dice2.TabIndex = 3
        Me.Dice2.value = 0
        '
        'Tracker1
        '
        Me.Tracker1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Tracker1.Location = New System.Drawing.Point(157, 12)
        Me.Tracker1.Name = "Tracker1"
        Me.Tracker1.Size = New System.Drawing.Size(105, 338)
        Me.Tracker1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(267, 392)
        Me.Controls.Add(Me.Tracker1)
        Me.Controls.Add(Me.Dice2)
        Me.Controls.Add(Me.btnroll)
        Me.Controls.Add(Me.dice1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Lucky 7's by Frankie"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dice1 As Dice
    Friend WithEvents btnroll As Button
    Friend WithEvents Dice2 As Dice
    Friend WithEvents Tracker1 As Tracker
End Class
