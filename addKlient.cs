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
    public partial class addKlient : Form
    {
        public addKlient()
        {
            InitializeComponent();
        }

        DataBaseConnect data = new DataBaseConnect();

        private void addKlient_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.getTable("klients");
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            data.addKlient(textBoxLN.Text, textBoxN.Text, textBoxPat.Text, 
                textBoxNP.Text, textBoxSP.Text, monthCalendar1.SelectionRange.Start.ToString(),
                textBoxMI.Text, textBoxS.Text, textBoxSt.Text, textBoxHouse.Text, textBoxKwa.Text, 
                textBoxEma.Text, textBoxPa.Text);
            MessageBox.Show("Клиент добавлен");
            updateTable();
        }

        private void updateTable()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = data.getTable("klientse");
        }
    }
}
