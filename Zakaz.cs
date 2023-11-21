using System;
using System.Data;
using System.Windows.Forms;

namespace heumnEXdemo2
{
    public partial class Zakaz : Form
    {
        DataBaseConnect dataConnect = new DataBaseConnect();
        public Zakaz()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bool a = false;
            string list = "";
            foreach (string item in checkedListBox1.CheckedItems)
            {
                if (a == false)
                {
                    list += item.ToString();
                    a = true;
                }
                else { 
                    list += " " + item.ToString();
                }
            }

            Console.WriteLine(list);

            dataConnect.addZakaz(
                monthCalendar1.SelectionRange.Start.ToShortDateString(),
                maskedTextBox1.Text,
                textBox2.Text,
                list,
                comboBox1.SelectedItem.ToString(),
                monthCalendar2.SelectionRange.Start.ToShortDateString(),
                textBox1.Text
                );

            updateTable();
        }

        private void Zakaz_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            dataGridView1.DataSource = dataConnect.getTovars();
        }

        private void updateTable() {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = dataConnect.getTovars();
        }
    }
}
