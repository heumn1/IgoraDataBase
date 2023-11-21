using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heumnEXdemo2
{
    public partial class UsersLogin : Form
    {
        public UsersLogin()
        {
            InitializeComponent();
        }
        DataBaseConnect data = new DataBaseConnect();

        private void UsersLogin_Load(object sender, EventArgs e)
        {
            loadData();
        }


        private void loadData() 
        { 
            DataTable dataTable = data.getLogins();
            dataGridView1.DataSource = dataTable;
        }

        private void loadDataByLogin() 
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data.getLoginsByUser(textBoxSearch.Text);
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            loadDataByLogin();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data.getDataSort(textBox1.Text);
        }
    }
}
