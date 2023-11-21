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
    public partial class GetTovar : Form
    {
        public GetTovar()
        {
            InitializeComponent();
        }
        DataBaseConnect data = new DataBaseConnect();


        private void buttonSort_Click(object sender, EventArgs e)
        {
            data.setYsluga(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show("Услуга добавлена");
            updateTable();
        }

        private void GetTovar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.getTable("ysluga");
        }

        private void updateTable()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = data.getTable("ysluga");
        }
    }
}
