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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(149, 242)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 32)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(157, 320)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(270, 31)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(157, 407)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 32)
        Label2.TabIndex = 2
        Label2.Text = "Pasword"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(157, 485)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(270, 31)
        TextBox2.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(149, 641)
        Button1.Name = "Button1"
        Button1.Size = New Size(278, 100)
        Button1.TabIndex = 4
        Button1.Text = "Sign In"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1258, 824)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Tiket Bioskop"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button

End Class
