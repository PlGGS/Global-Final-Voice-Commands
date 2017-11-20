<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinal
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
        Me.components = New System.ComponentModel.Container()
        Me.timVolMax = New System.Windows.Forms.Timer(Me.components)
        Me.timEndCounter = New System.Windows.Forms.Timer(Me.components)
        Me.timVolDown = New System.Windows.Forms.Timer(Me.components)
        Me.timVolExecute = New System.Windows.Forms.Timer(Me.components)
        Me.timVolUp = New System.Windows.Forms.Timer(Me.components)
        Me.timSelfDestruct = New System.Windows.Forms.Timer(Me.components)
        Me.btnTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'timVolMax
        '
        '
        'timEndCounter
        '
        Me.timEndCounter.Interval = 1000
        '
        'timVolDown
        '
        '
        'timVolExecute
        '
        Me.timVolExecute.Interval = 15
        '
        'timVolUp
        '
        '
        'timSelfDestruct
        '
        Me.timSelfDestruct.Interval = 1000
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(59, 44)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(183, 82)
        Me.btnTest.TabIndex = 0
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'frmFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 431)
        Me.Controls.Add(Me.btnTest)
        Me.DoubleBuffered = True
        Me.Location = New System.Drawing.Point(900, 5)
        Me.Name = "frmFinal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents timVolMax As Timer
    Friend WithEvents timEndCounter As Timer
    Friend WithEvents timVolDown As Timer
    Friend WithEvents timVolExecute As Timer
    Friend WithEvents timVolUp As Timer
    Friend WithEvents timSelfDestruct As Timer
    Friend WithEvents btnTest As Button
End Class
