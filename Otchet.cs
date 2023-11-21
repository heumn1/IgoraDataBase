using Aspose.Pdf;
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
    public partial class Otchet : Form
    {
        public Otchet()
        {
            InitializeComponent();
        }
        DataBaseConnect data;

        private void Otchet_Load(object sender, EventArgs e)
        {
            data = new DataBaseConnect();

            dataGridView1.DataSource = data.getTable("zakazi");
            dataGridView2.DataSource = data.getTable("klients");
            dataGridView3.DataSource = data.getTable("ysluga");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Document document = new Document();

            Page page = document.Pages.Add();

            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Таблица Заказы:"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(data.getInfoFromTable("zakazi", "Заказ")));

            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Таблица Клиенты:"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(data.getInfoFromTable("klients", "Клиент")));

            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Таблица услуг:"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(data.getInfoFromTable("ysluga", "Услуга")));


            document.Save("document.pdf");
        }
    }
}
