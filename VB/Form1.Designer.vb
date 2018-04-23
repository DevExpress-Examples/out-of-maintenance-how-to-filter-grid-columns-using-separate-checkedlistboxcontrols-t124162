Imports Microsoft.VisualBasic
Imports System
Namespace GridSeparateFilterList
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.nameColumnFilter = New DevExpress.XtraEditors.CheckedListBoxControl()
			Me.categoryColumnFilter = New DevExpress.XtraEditors.CheckedListBoxControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.nameColumnFilter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoryColumnFilter, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(488, 278)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.nameColumnFilter)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.groupControl1.Location = New System.Drawing.Point(488, 0)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(144, 167)
			Me.groupControl1.TabIndex = 1
			Me.groupControl1.Text = "Name"
			' 
			' groupControl2
			' 
			Me.groupControl2.Controls.Add(Me.categoryColumnFilter)
			Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl2.Location = New System.Drawing.Point(488, 167)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(144, 111)
			Me.groupControl2.TabIndex = 2
			Me.groupControl2.Text = "Category"
			' 
			' nameColumnFilter
			' 
			Me.nameColumnFilter.CheckOnClick = True
			Me.nameColumnFilter.Dock = System.Windows.Forms.DockStyle.Fill
			Me.nameColumnFilter.Location = New System.Drawing.Point(2, 21)
			Me.nameColumnFilter.Name = "nameColumnFilter"
			Me.nameColumnFilter.Size = New System.Drawing.Size(140, 144)
			Me.nameColumnFilter.TabIndex = 0
			' 
			' categoryColumnFilter
			' 
			Me.categoryColumnFilter.CheckOnClick = True
			Me.categoryColumnFilter.Dock = System.Windows.Forms.DockStyle.Fill
			Me.categoryColumnFilter.Location = New System.Drawing.Point(2, 21)
			Me.categoryColumnFilter.Name = "categoryColumnFilter"
			Me.categoryColumnFilter.Size = New System.Drawing.Size(140, 88)
			Me.categoryColumnFilter.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(632, 278)
			Me.Controls.Add(Me.groupControl2)
			Me.Controls.Add(Me.groupControl1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.nameColumnFilter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoryColumnFilter, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private nameColumnFilter As DevExpress.XtraEditors.CheckedListBoxControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private categoryColumnFilter As DevExpress.XtraEditors.CheckedListBoxControl

	End Class
End Namespace

