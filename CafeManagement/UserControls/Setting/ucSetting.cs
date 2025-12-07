using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement.DAO;
using CafeManagement.UserControls.Setting;

namespace CafeManagement.UserControls.Setting
{
    public partial class ucSetting : UserControl
    {
        private TableDAO tableDAO = new TableDAO();
        public ucSetting()
        {
            InitializeComponent();
            LoadTables();   
        }

        private void LoadTables()
        {
            flpTables.Controls.Clear();

            var tables = tableDAO.GetAllTables();

            foreach (var t in tables)
            {
                TableItem item = new TableItem();
                item.TableID = t.TableID;
                item.TableName = t.TableName;
                item.Status = t.Status;

                //item.Width = 120;
                //item.Height = 130;

                // Gắn event
                item.EditClicked += Item_EditClicked;
                item.DeleteClicked += Item_DeleteClicked;

                flpTables.Controls.Add(item);
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập tên bàn mới:",
                "Thêm bàn",
                "Bàn mới");

            if (string.IsNullOrEmpty(name)) return;

            tableDAO.InsertTable(name);
            LoadTables();
        }

        private void Item_EditClicked(object sender, EventArgs e)
        {
            TableItem item = (TableItem)sender;

            string newName = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập tên bàn mới:",
                "Sửa bàn",
                item.TableName);

            if (string.IsNullOrEmpty(newName)) return;

            tableDAO.UpdateTable(item.TableID, newName);
            LoadTables();
        }

        private void Item_DeleteClicked(object sender, EventArgs e)
        {
            TableItem item = (TableItem)sender;

            if (MessageBox.Show("Bạn có chắc muốn xóa bàn này?",
                "Xóa bàn", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tableDAO.DeleteTable(item.TableID);
                LoadTables();
            }
        }

        public void ShowTableList()
        {
            LoadTables();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
