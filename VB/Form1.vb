Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace GridSeparateFilterList
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
			AddHandler nameColumnFilter.ItemCheck, AddressOf nameColumnFilter_ItemCheck
			AddHandler categoryColumnFilter.ItemCheck, AddressOf categoryColumnFilter_ItemCheck
			AddHandler gridControl1.DataSourceChanged, AddressOf gridControl1_DataSourceChanged
			gridControl1.DataSource = GetData(10)
		End Sub

		Private Sub categoryColumnFilter_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs)
			If categoryColumnFilter.CheckedItems.Count = 0 Then
				gridView1.Columns("Category").ClearFilter()
				Return
			End If
			AddColumnFilter("Category", categoryColumnFilter)
		End Sub

		Private Sub nameColumnFilter_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs)
			If nameColumnFilter.CheckedItems.Count = 0 Then
				gridView1.Columns("Name").ClearFilter()
				Return
			End If
			AddColumnFilter("Name", nameColumnFilter)
		End Sub

		Private Sub AddColumnFilter(ByVal fieldName As String, ByVal filterControl As CheckedListBoxControl)
			Dim filterString As String
			Dim items(filterControl.CheckedItems.Count - 1) As String
			For i As Integer = 0 To filterControl.CheckedItems.Count - 1
				items(i) = String.Format("[{0}] = '{1}'", fieldName, filterControl.CheckedItems(i))
			Next i
			filterString = String.Join(" Or ", items)
			gridView1.Columns(fieldName).FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(filterString)
		End Sub

		Private Sub gridControl1_DataSourceChanged(ByVal sender As Object, ByVal e As EventArgs)
            nameColumnFilter.DataSource = gridView1.DataController.GetUniqueColumnValues("Name", gridView1.RowCount, True, False, Nothing).ToList()
            categoryColumnFilter.DataSource = gridView1.DataController.GetUniqueColumnValues("Category", gridView1.RowCount, True, False, Nothing).ToList()
		End Sub

		Private Function GetData(ByVal count As Integer) As DataTable
			Dim dt As New DataTable()
			dt.Columns.Add("ID", GetType(Integer))
			dt.Columns.Add("Name", GetType(String))
			dt.Columns.Add("Category", GetType(String))
			For i As Integer = 0 To count - 1
				dt.Rows.Add(i, "Name" & i, "Category" & i Mod 3)
			Next i
			Return dt
		End Function
	End Class


End Namespace
