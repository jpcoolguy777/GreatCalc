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
        Me.add = New System.Windows.Forms.Button()
        Me.Subtract = New System.Windows.Forms.Button()
        Me.Multiply = New System.Windows.Forms.Button()
        Me.Divide = New System.Windows.Forms.Button()
        Me.square = New System.Windows.Forms.Button()
        Me.ce = New System.Windows.Forms.Button()
        Me.equals = New System.Windows.Forms.Button()
        Me.input1 = New System.Windows.Forms.TextBox()
        Me.input2 = New System.Windows.Forms.TextBox()
        Me.result = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'add
        '
        Me.add.Font = New System.Drawing.Font("JetBrains Mono SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.Location = New System.Drawing.Point(12, 351)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(55, 48)
        Me.add.TabIndex = 0
        Me.add.Text = "+"
        Me.add.UseVisualStyleBackColor = True
        '
        'Subtract
        '
        Me.Subtract.Font = New System.Drawing.Font("JetBrains Mono SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtract.Location = New System.Drawing.Point(73, 351)
        Me.Subtract.Name = "Subtract"
        Me.Subtract.Size = New System.Drawing.Size(55, 48)
        Me.Subtract.TabIndex = 1
        Me.Subtract.Text = "-"
        Me.Subtract.UseVisualStyleBackColor = True
        '
        'Multiply
        '
        Me.Multiply.Font = New System.Drawing.Font("JetBrains Mono SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiply.Location = New System.Drawing.Point(134, 351)
        Me.Multiply.Name = "Multiply"
        Me.Multiply.Size = New System.Drawing.Size(55, 48)
        Me.Multiply.TabIndex = 2
        Me.Multiply.Text = "×"
        Me.Multiply.UseVisualStyleBackColor = True
        '
        'Divide
        '
        Me.Divide.Font = New System.Drawing.Font("JetBrains Mono SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divide.Location = New System.Drawing.Point(195, 351)
        Me.Divide.Name = "Divide"
        Me.Divide.Size = New System.Drawing.Size(55, 48)
        Me.Divide.TabIndex = 3
        Me.Divide.Text = "÷"
        Me.Divide.UseVisualStyleBackColor = True
        '
        'square
        '
        Me.square.Font = New System.Drawing.Font("JetBrains Mono SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.square.Location = New System.Drawing.Point(12, 297)
        Me.square.Name = "square"
        Me.square.Size = New System.Drawing.Size(55, 48)
        Me.square.TabIndex = 4
        Me.square.Text = "²"
        Me.square.UseVisualStyleBackColor = True
        '
        'ce
        '
        Me.ce.Font = New System.Drawing.Font("JetBrains Mono SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ce.Location = New System.Drawing.Point(195, 297)
        Me.ce.Name = "ce"
        Me.ce.Size = New System.Drawing.Size(55, 48)
        Me.ce.TabIndex = 5
        Me.ce.Text = "CE"
        Me.ce.UseVisualStyleBackColor = True
        '
        'equals
        '
        Me.equals.Font = New System.Drawing.Font("JetBrains Mono SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equals.Location = New System.Drawing.Point(73, 297)
        Me.equals.Name = "equals"
        Me.equals.Size = New System.Drawing.Size(116, 48)
        Me.equals.TabIndex = 6
        Me.equals.Text = "="
        Me.equals.UseVisualStyleBackColor = True
        '
        'input1
        '
        Me.input1.Font = New System.Drawing.Font("JetBrains Mono SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input1.Location = New System.Drawing.Point(12, 121)
        Me.input1.Name = "input1"
        Me.input1.Size = New System.Drawing.Size(116, 29)
        Me.input1.TabIndex = 7
        '
        'input2
        '
        Me.input2.Font = New System.Drawing.Font("JetBrains Mono SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input2.Location = New System.Drawing.Point(12, 165)
        Me.input2.Name = "input2"
        Me.input2.Size = New System.Drawing.Size(116, 29)
        Me.input2.TabIndex = 8
        '
        'result
        '
        Me.result.Font = New System.Drawing.Font("JetBrains Mono SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result.Location = New System.Drawing.Point(134, 262)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(116, 29)
        Me.result.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("JetBrains Mono Thin", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Answer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("JetBrains Mono Thin", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 14)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Number 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("JetBrains Mono Thin", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Number 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("JetBrains Mono NL ExtraBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(288, 63)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "GreatCalc"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("JetBrains Mono SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Help"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("JetBrains Mono SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(93, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "About"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 411)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.input2)
        Me.Controls.Add(Me.input1)
        Me.Controls.Add(Me.equals)
        Me.Controls.Add(Me.ce)
        Me.Controls.Add(Me.square)
        Me.Controls.Add(Me.Divide)
        Me.Controls.Add(Me.Multiply)
        Me.Controls.Add(Me.Subtract)
        Me.Controls.Add(Me.add)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "GreatCalc 1.2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents Subtract As System.Windows.Forms.Button
    Friend WithEvents Multiply As System.Windows.Forms.Button
    Friend WithEvents Divide As System.Windows.Forms.Button
    Friend WithEvents square As System.Windows.Forms.Button
    Friend WithEvents ce As System.Windows.Forms.Button
    Friend WithEvents equals As System.Windows.Forms.Button
    Friend WithEvents input1 As System.Windows.Forms.TextBox
    Friend WithEvents input2 As System.Windows.Forms.TextBox
    Friend WithEvents result As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
