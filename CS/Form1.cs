using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GridSeparateFilterList
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            nameColumnFilter.ItemCheck += nameColumnFilter_ItemCheck;
            categoryColumnFilter.ItemCheck += categoryColumnFilter_ItemCheck;
            gridControl1.DataSourceChanged += gridControl1_DataSourceChanged;
            gridControl1.DataSource = GetData(10);
        }

        void categoryColumnFilter_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (categoryColumnFilter.CheckedItems.Count == 0)
            {
                gridView1.Columns["Category"].ClearFilter();
                return;
            }
            AddColumnFilter("Category", categoryColumnFilter);
        }

        void nameColumnFilter_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (nameColumnFilter.CheckedItems.Count == 0)
            {
                gridView1.Columns["Name"].ClearFilter();
                return;
            }
            AddColumnFilter("Name", nameColumnFilter);
        }

        void AddColumnFilter(string fieldName, CheckedListBoxControl filterControl)
        {
            string filterString;
            string[] items = new string[filterControl.CheckedItems.Count];
            for (int i = 0; i < filterControl.CheckedItems.Count; i++)
            {
                items[i] = String.Format("[{0}] = '{1}'", fieldName, filterControl.CheckedItems[i]);
            }
            filterString = String.Join(" Or ", items);
            gridView1.Columns[fieldName].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(filterString);
        }

        void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            nameColumnFilter.DataSource = gridView1.DataController.GetUniqueColumnValues("Name", gridView1.RowCount, true, false, null).ToList<object>();
            categoryColumnFilter.DataSource = gridView1.DataController.GetUniqueColumnValues("Category", gridView1.RowCount, true, false, null).ToList<object>();
        }

        DataTable GetData(int count)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            for (int i = 0; i < count; i++)
            {
                dt.Rows.Add(i, "Name" + i, "Category" + i % 3);
            }
            return dt;
        }
    }

    
}
