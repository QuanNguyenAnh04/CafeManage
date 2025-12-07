using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.UserControls.Setting
{
    public partial class TableItem : UserControl
    {
        public int TableID { get; set; }

        public string TableName
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public bool Status
        {
            get => lblStatus.Text == "Có khách";
            set => lblStatus.Text = value ? "Có khách" : "Trống";
        }

        // Sự kiện để ucSetting xử lý
        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;

        public TableItem()
        {
            InitializeComponent();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }

        private void TableItem_Load(object sender, EventArgs e)
        {

        }
    }
}
