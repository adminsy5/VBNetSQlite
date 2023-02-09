<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VBNetSQlite
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.CheckBoxSearchbyID = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSearchbyName = New System.Windows.Forms.CheckBox()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonMakeId = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxMobilePhone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditToolStripMenuItem.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.AllowUserToAddRows = False
        Me.DataGridViewTable.AllowUserToDeleteRows = False
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.ContextMenuStrip = Me.EditToolStripMenuItem
        Me.DataGridViewTable.Location = New System.Drawing.Point(83, 662)
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.ReadOnly = True
        Me.DataGridViewTable.RowHeadersWidth = 82
        Me.DataGridViewTable.RowTemplate.Height = 41
        Me.DataGridViewTable.Size = New System.Drawing.Size(2166, 527)
        Me.DataGridViewTable.TabIndex = 0
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.EditToolStripMenuItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.SelectAllToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "ContextMenuStrip1"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(187, 118)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(186, 38)
        Me.DeleteToolStripMenuItem.Text = "Edit"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(186, 38)
        Me.SelectAllToolStripMenuItem.Text = "Delete"
        '
        'SelectAllToolStripMenuItem1
        '
        Me.SelectAllToolStripMenuItem1.Name = "SelectAllToolStripMenuItem1"
        Me.SelectAllToolStripMenuItem1.Size = New System.Drawing.Size(186, 38)
        Me.SelectAllToolStripMenuItem1.Text = "Select All"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxGender)
        Me.GroupBox1.Controls.Add(Me.TextBoxSearch)
        Me.GroupBox1.Controls.Add(Me.CheckBoxSearchbyID)
        Me.GroupBox1.Controls.Add(Me.CheckBoxSearchbyName)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.ButtonDelete)
        Me.GroupBox1.Controls.Add(Me.ButtonRefresh)
        Me.GroupBox1.Controls.Add(Me.ButtonMakeId)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxEmail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxMobilePhone)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxCity)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxId)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Location = New System.Drawing.Point(83, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(2166, 603)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Items.AddRange(New Object() {"- Choose Gender -", "Male", "Female", "Shemale"})
        Me.ComboBoxGender.Location = New System.Drawing.Point(1476, 262)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(243, 40)
        Me.ComboBoxGender.TabIndex = 21
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(484, 507)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(1051, 39)
        Me.TextBoxSearch.TabIndex = 20
        '
        'CheckBoxSearchbyID
        '
        Me.CheckBoxSearchbyID.AutoSize = True
        Me.CheckBoxSearchbyID.Location = New System.Drawing.Point(1372, 446)
        Me.CheckBoxSearchbyID.Name = "CheckBoxSearchbyID"
        Me.CheckBoxSearchbyID.Size = New System.Drawing.Size(163, 36)
        Me.CheckBoxSearchbyID.TabIndex = 19
        Me.CheckBoxSearchbyID.Text = "CheckBox2"
        Me.CheckBoxSearchbyID.UseVisualStyleBackColor = True
        '
        'CheckBoxSearchbyName
        '
        Me.CheckBoxSearchbyName.AutoSize = True
        Me.CheckBoxSearchbyName.Location = New System.Drawing.Point(484, 446)
        Me.CheckBoxSearchbyName.Name = "CheckBoxSearchbyName"
        Me.CheckBoxSearchbyName.Size = New System.Drawing.Size(163, 36)
        Me.CheckBoxSearchbyName.TabIndex = 18
        Me.CheckBoxSearchbyName.Text = "CheckBox1"
        Me.CheckBoxSearchbyName.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(1604, 384)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(150, 46)
        Me.ButtonUpdate.TabIndex = 17
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(1791, 384)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(150, 46)
        Me.ButtonSave.TabIndex = 16
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(102, 384)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(150, 46)
        Me.ButtonDelete.TabIndex = 15
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(289, 384)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(150, 46)
        Me.ButtonRefresh.TabIndex = 14
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonMakeId
        '
        Me.ButtonMakeId.Location = New System.Drawing.Point(484, 94)
        Me.ButtonMakeId.Name = "ButtonMakeId"
        Me.ButtonMakeId.Size = New System.Drawing.Size(234, 46)
        Me.ButtonMakeId.TabIndex = 13
        Me.ButtonMakeId.Text = "Generate ID"
        Me.ButtonMakeId.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1354, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 32)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1348, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 32)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Email Id"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(1476, 180)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(482, 39)
        Me.TextBoxEmail.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1262, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 32)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Mobile Number"
        '
        'TextBoxMobilePhone
        '
        Me.TextBoxMobilePhone.Location = New System.Drawing.Point(1476, 101)
        Me.TextBoxMobilePhone.Name = "TextBoxMobilePhone"
        Me.TextBoxMobilePhone.Size = New System.Drawing.Size(482, 39)
        Me.TextBoxMobilePhone.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "City"
        '
        'TextBoxCity
        '
        Me.TextBoxCity.Location = New System.Drawing.Point(251, 262)
        Me.TextBoxCity.Name = "TextBoxCity"
        Me.TextBoxCity.Size = New System.Drawing.Size(467, 39)
        Me.TextBoxCity.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(251, 177)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(467, 39)
        Me.TextBoxName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id"
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(251, 98)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(200, 39)
        Me.TextBoxId.TabIndex = 1
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(961, 268)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(150, 46)
        Me.ButtonClear.TabIndex = 0
        Me.ButtonClear.Text = "Clear All"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'VBNetSQlite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2360, 1242)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewTable)
        Me.Name = "VBNetSQlite"
        Me.Text = "VBNetSQlite"
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditToolStripMenuItem.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents CheckBoxSearchbyID As CheckBox
    Friend WithEvents CheckBoxSearchbyName As CheckBox
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents ButtonMakeId As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxMobilePhone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents ButtonClear As Button
    Friend WithEvents EditToolStripMenuItem As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem1 As ToolStripMenuItem
End Class
