<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstructions))
        Me.btnBackHome = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBackHome
        '
        Me.btnBackHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBackHome.Font = New System.Drawing.Font("MV Boli", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackHome.Location = New System.Drawing.Point(684, 800)
        Me.btnBackHome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBackHome.Name = "btnBackHome"
        Me.btnBackHome.Size = New System.Drawing.Size(354, 90)
        Me.btnBackHome.TabIndex = 0
        Me.btnBackHome.Text = "Back To Home"
        Me.btnBackHome.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInstructions.Font = New System.Drawing.Font("MV Boli", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(13, 137)
        Me.lblInstructions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(1680, 622)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(526, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(700, 60)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Tic Tac Toe"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TicTacToe.My.Resources.Resources.tttbackground
        Me.ClientSize = New System.Drawing.Size(1702, 929)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnBackHome)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInstructions"
        Me.Text = "Instructions"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBackHome As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents Label1 As Label
End Class
