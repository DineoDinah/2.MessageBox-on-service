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
		Button1 = New Button()
		Label1 = New Label()
		Label2 = New Label()
		SuspendLayout()
		' 
		' Button1
		' 
		Button1.Location = New Point(324, 239)
		Button1.Name = "Button1"
		Button1.Size = New Size(234, 91)
		Button1.TabIndex = 0
		Button1.Text = "Say Hello!!!"
		Button1.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point)
		Label1.Location = New Point(21, 61)
		Label1.Name = "Label1"
		Label1.Size = New Size(666, 44)
		Label1.TabIndex = 1
		Label1.Text = "THE BUTTON ON THAT GREETS YOU!!!"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(21, 285)
		Label2.Name = "Label2"
		Label2.Size = New Size(203, 25)
		Label2.TabIndex = 1
		Label2.Text = "Click the button and see"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.ActiveCaption
		ClientSize = New Size(800, 450)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(Button1)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
End Class
