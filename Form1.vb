Imports System.Data.SQLite
Imports System.Runtime.InteropServices
Public Class VBNetSQlite
    Dim DB_Path As String
    Dim TableName As String = "tabledb"
    Dim IDRam, NameRam, CityRam, Mobile_PhoneRam, EmailRam, GenderRam As String

    'code to make "hint text" in the textbox search
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub VBNetSQlite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        TextBoxSearch.CharacterCasing = CharacterCasing.Normal
        SendMessage(Me.TextBoxSearch.Handle, &H1501, 0, "Search...")


        DB_Path = "Data Source=" & Application.StartupPath & "\databasesqlite.db;"
        ComboBoxGender.SelectedItem = "- choose gender -"
        ButtonUpdate.Enabled = False

        Dim SQLiteCon As New SQLiteConnection(DB_Path)
        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableDB As New DataTable

        Try
            LoadDB("select*from " & TableName & " order by Name", TableDB, SQLiteCon)
            DataGridViewTable.DataSource = Nothing
            DataGridViewTable.DataSource = TableDB
            DataGridViewTable.Columns("Mobile_Phone").HeaderText = "Mobile Phone"
            DataGridViewTable.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub VBNetSQlite_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        DataGridViewTable.ClearSelection()
        ButtonMakeId.Focus()
        SendMessage(Me.TextBoxSearch.Handle, &H1501, 0, "Search...")
    End Sub

    Private Sub TextBoxMobilePhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMobilePhone.KeyPress
        'code to only allow numeric input on the mobile phone textbox
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
            MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If TextBoxId.Text = "" And TextBoxName.Text = "" And TextBoxCity.Text = "" And TextBoxMobilePhone.Text = "" And TextBoxEmail.Text = "" And ComboBoxGender.Text = "- choose gender -" Then
            MessageBox.Show("All data has not been filled, please fill in", "Failed")
            Return
        End If

        If TextBoxId.Text = "" Then
            MessageBox.Show("ID has not been filled, please fill in ID", "Failed")
            Return
        End If

        If TextBoxName.Text = "" Then
            MessageBox.Show("Name has not been filled, please fill in Name", "Failed")
            Return
        End If

        If TextBoxCity.Text = "" Then
            MessageBox.Show("City has not been filled, please fill in City", "Failed")
            Return
        End If

        If TextBoxMobilePhone.Text = "" Then
            MessageBox.Show("Mobile Phone has not been filled, please fill in Mobile Phone", "Failed")
            Return
        End If

        If TextBoxEmail.Text = "" Then
            MessageBox.Show("Email has not been filled, please fill in Email", "Failed")
            Return
        End If

        If ComboBoxGender.Text = "- choose gender -" Then
            MessageBox.Show("Gender not selected, please select Gender", "Failed")
            Return
        End If

        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            ExecuteNonQuery("insert into " & TableName & " (ID,Name,Mobile_Phone,Email,City,Gender) values ('" & TextBoxId.Text & "','" & TextBoxName.Text _
                            & "','" & TextBoxMobilePhone.Text & "','" & TextBoxEmail.Text & "','" & TextBoxCity.Text & "','" & ComboBoxGender.Text & "')", SQLiteCon)
            MsgBox("Insert Data successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        ButtonRefresh_Click(sender, e)
        ButtonClear_Click(sender, e)
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableDB As New DataTable

        Try
            LoadDB("select*from " & TableName & " order by Name", TableDB, SQLiteCon)
            DataGridViewTable.DataSource = Nothing
            DataGridViewTable.DataSource = TableDB
            DataGridViewTable.Columns("Mobile_Phone").HeaderText = "Mobile Phone"
            DataGridViewTable.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        If DataGridViewTable.RowCount = 0 Then
            MsgBox("Cannot delete, table data is empty", MsgBoxStyle.Critical, "Failed")
            Return
        End If

        If DataGridViewTable.SelectedRows.Count = 0 Then
            MsgBox("Cannot delete, select the table data to be deleted", MsgBoxStyle.Critical, "Failed")
            Return
        End If

        If MsgBox("Delete record?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        Try
            If AllCellsSelected(DataGridViewTable) = True Then
                ExecuteNonQuery("delete from " & TableName & "", SQLiteCon)
                SQLiteCon.Close()
                SQLiteCon.Dispose()
                SQLiteCon = Nothing

                ButtonRefresh_Click(sender, e)
                Return
            End If

            For Each row As DataGridViewRow In DataGridViewTable.SelectedRows
                If row.Selected = True Then
                    ExecuteNonQuery("delete from " & TableName & " where ID='" & row.DataBoundItem(0).ToString & "'", SQLiteCon)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        ButtonRefresh_Click(sender, e)
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If TextBoxName.Text = "" Then
            MessageBox.Show("Name has not been filled, please fill in Name", "Failed")
            Return
        End If

        If TextBoxCity.Text = "" Then
            MessageBox.Show("City has not been filled, please fill in City", "Failed")
            Return
        End If

        If TextBoxMobilePhone.Text = "" Then
            MessageBox.Show("Mobile Phone has not been filled, please fill in Mobile Phone", "Failed")
            Return
        End If

        If TextBoxEmail.Text = "" Then
            MessageBox.Show("Email has not been filled, please fill in Email", "Failed")
            Return
        End If

        If ComboBoxGender.Text = "- choose gender -" Then
            MessageBox.Show("Gender not selected, please select Gender", "Failed")
            Return
        End If

        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            ExecuteNonQuery("update " & TableName & " set Name='" & TextBoxName.Text & "',Mobile_Phone='" & TextBoxMobilePhone.Text _
                            & "',Email='" & TextBoxEmail.Text & "',City='" & TextBoxCity.Text & "',Gender='" & ComboBoxGender.Text & "' where ID='" & TextBoxId.Text & "'", SQLiteCon)
            MsgBox("Update successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        ButtonRefresh_Click(sender, e)
        ButtonClear_Click(sender, e)
    End Sub

    Private Sub ButtonMakeId_Click(sender As Object, e As EventArgs) Handles ButtonMakeId.Click
        Dim r As Random = New Random
        Dim num As Integer
        num = (r.Next(1, 9999))
        Dim IDMaker As String = Strings.Right("0000" & num.ToString(), 4)
        TextBoxId.Text = IDMaker

        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableDB As New DataTable

        'The command to detect whether the id that is created is already registered, because the id is a "primary key" so it cannot be the same.
        Try
            LoadDB("select id from " & TableName & " where ID='" & TextBoxId.Text & "'", TableDB, SQLiteCon)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If TableDB.Rows.Count > 0 Then
            ButtonMakeId_Click(sender, e)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ButtonDelete_Click(sender, e)
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxId.Clear()
        TextBoxName.Clear()
        TextBoxCity.Clear()
        TextBoxMobilePhone.Clear()
        TextBoxEmail.Clear()
        ComboBoxGender.SelectedItem = "- choose gender -"
        ButtonSave.Enabled = True
        ButtonUpdate.Enabled = False
        ButtonMakeId.Enabled = True
    End Sub

    Private Sub DataGridViewTable_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewTable.CellMouseClick
        'Dim i As Integer
        'With DataGridViewTable
        '    If e.RowIndex >= 0 Then
        '        i = .CurrentRow.Index
        '        IDRam = .Rows(i).Cells("ID").Value.ToString
        '    End If
        'End With
    End Sub

    Private Sub GroupBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles GroupBox1.MouseClick
        DataGridViewTable.ClearSelection()
        ButtonMakeId.Focus()
        SendMessage(Me.TextBoxSearch.Handle, &H1501, 0, "Search...")
    End Sub

    Private Sub DataGridViewTable_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewTable.CellMouseDown
        If AllCellsSelected(DataGridViewTable) = False Then
            If e.Button = MouseButtons.Right Then
                DataGridViewTable.CurrentCell = DataGridViewTable(e.ColumnIndex, e.RowIndex)
                Dim i As Integer
                With DataGridViewTable
                    If e.RowIndex >= 0 Then
                        i = .CurrentRow.Index

                        IDRam = .Rows(i).Cells("ID").Value.ToString
                        NameRam = .Rows(i).Cells("Name").Value.ToString
                        CityRam = .Rows(i).Cells("City").Value.ToString
                        Mobile_PhoneRam = .Rows(i).Cells("Mobile_Phone").Value.ToString
                        EmailRam = .Rows(i).Cells("Email").Value.ToString
                        GenderRam = .Rows(i).Cells("Gender").Value.ToString
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub CheckBoxSearchbyName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSearchbyName.CheckedChanged
        If CheckBoxSearchbyName.Checked = True Then
            CheckBoxSearchbyID.Checked = False
        End If
        If CheckBoxSearchbyName.Checked = False Then
            CheckBoxSearchbyID.Checked = True
        End If
    End Sub

    Private Sub CheckBoxSearchbyID_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSearchbyID.CheckedChanged
        If CheckBoxSearchbyID.Checked = True Then
            CheckBoxSearchbyName.Checked = False
        End If
        If CheckBoxSearchbyID.Checked = False Then
            CheckBoxSearchbyName.Checked = True
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        DataGridViewTable.SelectAll()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If AllCellsSelected(DataGridViewTable) = False Then
            TextBoxId.Text = IDRam
            TextBoxName.Text = NameRam
            TextBoxCity.Text = CityRam
            TextBoxMobilePhone.Text = Mobile_PhoneRam
            TextBoxEmail.Text = EmailRam
            ComboBoxGender.Text = GenderRam
            ButtonSave.Enabled = False
            ButtonUpdate.Enabled = True
            ButtonMakeId.Enabled = False
        Else
            MsgBox("Can not edit because table row is selected all. Please choose one to edit.", MsgBoxStyle.Critical, "Failed")
        End If
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs)
        Dim SearchCMD As String
        If TextBoxSearch.Text = Nothing Then
            TextBoxSearch.CharacterCasing = CharacterCasing.Normal
            SendMessage(Me.TextBoxSearch.Handle, &H1501, 0, "Search...")
        Else
            TextBoxSearch.CharacterCasing = CharacterCasing.Upper
        End If

        If CheckBoxSearchbyName.Checked = True Then
            If TextBoxSearch.Text = Nothing Then
                SearchCMD = "select*from " & TableName & " order by Name"
            Else
                SearchCMD = "select*from " & TableName & " where Name like'" & TextBoxSearch.Text & "%'"
            End If
        End If

        If CheckBoxSearchbyID.Checked = True Then
            If TextBoxSearch.Text = Nothing Then
                SearchCMD = "select*from " & TableName & " order by Name"
            Else
                SearchCMD = "select*from " & TableName & " where ID like'" & TextBoxSearch.Text & "%'"
            End If
        End If

        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableDB As New DataTable

        Try
            LoadDB(SearchCMD, TableDB, SQLiteCon)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If TableDB.Rows.Count > 0 Then
            DataGridViewTable.DataSource = Nothing
            DataGridViewTable.DataSource = TableDB
        End If
        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    'Sub to read the database
    Private Sub LoadDB(ByVal q As String, ByVal tbl As DataTable, ByVal cn As SQLiteConnection)
        Dim SQLiteDA As New SQLiteDataAdapter(q, cn)
        SQLiteDA.Fill(tbl)
        SQLiteDA.Dispose()
        SQLiteDA = Nothing
    End Sub

    'Sub to write to the database
    Private Sub ExecuteNonQuery(ByVal query As String, ByVal cn As SQLiteConnection)
        Dim SQLiteCM As New SQLiteCommand(query, cn)
        SQLiteCM.ExecuteNonQuery()
        SQLiteCM.Dispose()
        SQLiteCM = Nothing
    End Sub

    'Function to detect datagridview is selected all
    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (DataGridViewTable.SelectedCells.Count = (DataGridViewTable.RowCount * DataGridViewTable.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function
End Class
