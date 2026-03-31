<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Button2 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Brown
        Button2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(1056, 721)
        Button2.Name = "Button2"
        Button2.Size = New Size(149, 60)
        Button2.TabIndex = 4
        Button2.Text = "NEXT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Brown
        Button1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(31, 721)
        Button1.Name = "Button1"
        Button1.Size = New Size(149, 60)
        Button1.TabIndex = 5
        Button1.Text = "CANCEL"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1258, 824)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Name = "Menu"
        Text = "Menu"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
