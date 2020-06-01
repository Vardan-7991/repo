using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'xanutDataSet.TblfromXanut' table. You can move, or remove it, as needed.
            this.tblfromXanutTableAdapter.Fill(this.xanutDataSet.TblfromXanut);

        }
    }
}
