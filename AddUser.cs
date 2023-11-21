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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            data.addUser(comboBoxdolj.SelectedItem.ToString(), textBoxnam.Text, textBoxlast.Text, textBoxpatr.Text, textBoxlog.Text, textBoxpas.Text);
            MessageBox.Show("Пользователь добавлен");
            updateTable();
        }

        DataBaseConnect data = new DataBaseConnect();

        private void AddUser_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.getTable("employee");
        }

        private void updateTable()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = data.getTable("employee");
        }
    }
}
