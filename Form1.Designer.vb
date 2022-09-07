<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnTICTACTOE = New System.Windows.Forms.Button()
        Me.txtPlay1 = New System.Windows.Forms.TextBox()
        Me.txtPlay2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnInstructions
        '
        Me.btnInstructions.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInstructions.Font = New System.Drawing.Font("MV Boli", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInstructions.Location = New System.Drawing.Point(676, 371)
        Me.btnInstructions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(400, 200)
        Me.btnInstructions.TabIndex = 0
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("MV Boli", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(245, 674)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(500, 100)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnTICTACTOE
        '
        Me.btnTICTACTOE.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTICTACTOE.Font = New System.Drawing.Font("MV Boli", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTICTACTOE.Location = New System.Drawing.Point(979, 674)
        Me.btnTICTACTOE.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTICTACTOE.Name = "btnTICTACTOE"
        Me.btnTICTACTOE.Size = New System.Drawing.Size(500, 100)
        Me.btnTICTACTOE.TabIndex = 2
        Me.btnTICTACTOE.Text = "Play Player Vs Player"
        Me.btnTICTACTOE.UseVisualStyleBackColor = False
        '
        'txtPlay1
        '
        Me.txtPlay1.BackColor = System.Drawing.Color.White
        Me.txtPlay1.Font = New System.Drawing.Font("MV Boli", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlay1.Location = New System.Drawing.Point(13, 483)
        Me.txtPlay1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlay1.Name = "txtPlay1"
        Me.txtPlay1.Size = New System.Drawing.Size(500, 77)
        Me.txtPlay1.TabIndex = 3
        Me.txtPlay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPlay2
        '
        Me.txtPlay2.BackColor = System.Drawing.Color.White
        Me.txtPlay2.Font = New System.Drawing.Font("MV Boli", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlay2.Location = New System.Drawing.Point(1221, 483)
        Me.txtPlay2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlay2.Name = "txtPlay2"
        Me.txtPlay2.Size = New System.Drawing.Size(500, 77)
        Me.txtPlay2.TabIndex = 4
        Me.txtPlay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 386)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 100)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter Player 1's Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1221, 386)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(500, 100)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter Player 2's Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(532, 174)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(694, 100)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tic Tac Toe"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1734, 929)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPlay2)
        Me.Controls.Add(Me.txtPlay1)
        Me.Controls.Add(Me.btnTICTACTOE)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnInstructions)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomePage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInstructions As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnTICTACTOE As Button
    Friend WithEvents txtPlay1 As TextBox
    Friend WithEvents txtPlay2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
