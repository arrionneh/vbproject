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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBrown = New System.Windows.Forms.RadioButton()
        Me.radBlack = New System.Windows.Forms.RadioButton()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radDeliver = New System.Windows.Forms.RadioButton()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnLoop = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.picShoe = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picShoe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(251, 26)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(395, 39)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Personal Shopper App"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox1.Controls.Add(Me.radBrown)
        Me.GroupBox1.Controls.Add(Me.radBlack)
        Me.GroupBox1.Controls.Add(Me.radRed)
        Me.GroupBox1.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(74, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 97)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick a shoe option:"
        '
        'radBrown
        '
        Me.radBrown.AutoSize = True
        Me.radBrown.Location = New System.Drawing.Point(7, 68)
        Me.radBrown.Name = "radBrown"
        Me.radBrown.Size = New System.Drawing.Size(152, 22)
        Me.radBrown.TabIndex = 2
        Me.radBrown.TabStop = True
        Me.radBrown.Text = "Brown Hiking Boots"
        Me.radBrown.UseVisualStyleBackColor = True
        '
        'radBlack
        '
        Me.radBlack.AutoSize = True
        Me.radBlack.Location = New System.Drawing.Point(7, 44)
        Me.radBlack.Name = "radBlack"
        Me.radBlack.Size = New System.Drawing.Size(110, 22)
        Me.radBlack.TabIndex = 1
        Me.radBlack.TabStop = True
        Me.radBlack.Text = "Black Loafers"
        Me.radBlack.UseVisualStyleBackColor = True
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Location = New System.Drawing.Point(7, 20)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(166, 22)
        Me.radRed.TabIndex = 0
        Me.radRed.TabStop = True
        Me.radRed.Text = "Red Running Sneakers"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox2.Controls.Add(Me.radDeliver)
        Me.GroupBox2.Controls.Add(Me.radPickup)
        Me.GroupBox2.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(74, 299)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 73)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pickup or delivery?"
        '
        'radDeliver
        '
        Me.radDeliver.AutoSize = True
        Me.radDeliver.Location = New System.Drawing.Point(7, 44)
        Me.radDeliver.Name = "radDeliver"
        Me.radDeliver.Size = New System.Drawing.Size(120, 22)
        Me.radDeliver.TabIndex = 1
        Me.radDeliver.TabStop = True
        Me.radDeliver.Text = "Home Delivery"
        Me.radDeliver.UseVisualStyleBackColor = True
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Location = New System.Drawing.Point(7, 20)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(121, 22)
        Me.radPickup.TabIndex = 0
        Me.radPickup.TabStop = True
        Me.radPickup.Text = "In-store Pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(433, 470)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(367, 87)
        Me.lblResults.TabIndex = 3
        Me.lblResults.Text = "Label2"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(174, 438)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 23)
        Me.txtName.TabIndex = 5
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(174, 488)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 23)
        Me.txtNumber.TabIndex = 6
        '
        'txtSize
        '
        Me.txtSize.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSize.Location = New System.Drawing.Point(175, 537)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(72, 23)
        Me.txtSize.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(102, 440)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 488)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Phone Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 539)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Shoe Size:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(128, 591)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(105, 38)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnLoop
        '
        Me.btnLoop.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoop.Location = New System.Drawing.Point(619, 591)
        Me.btnLoop.Name = "btnLoop"
        Me.btnLoop.Size = New System.Drawing.Size(181, 38)
        Me.btnLoop.TabIndex = 12
        Me.btnLoop.Text = "Submit Another Order"
        Me.btnLoop.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(399, 591)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 38)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDesc
        '
        Me.lblDesc.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(470, 401)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(355, 23)
        Me.lblDesc.TabIndex = 14
        Me.lblDesc.Text = "Label1"
        '
        'picShoe
        '
        Me.picShoe.BackColor = System.Drawing.Color.DarkOrange
        Me.picShoe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picShoe.Location = New System.Drawing.Point(509, 100)
        Me.picShoe.Name = "picShoe"
        Me.picShoe.Size = New System.Drawing.Size(276, 265)
        Me.picShoe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShoe.TabIndex = 4
        Me.picShoe.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(883, 660)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoop)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.picShoe)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "Form1"
        Me.Text = "Personal Shopper App"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picShoe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radBrown As RadioButton
    Friend WithEvents radBlack As RadioButton
    Friend WithEvents radRed As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radDeliver As RadioButton
    Friend WithEvents radPickup As RadioButton
    Friend WithEvents lblResults As Label
    Friend WithEvents picShoe As PictureBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnLoop As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDesc As Label
End Class
