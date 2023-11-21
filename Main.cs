using heumnEXdemo2.Properties;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace heumnEXdemo2
{
    public partial class Main : Form
    {
        Zakaz zakaz;
        UsersLogin login;
        GetTovar getTovar;
        addKlient addKlient;
        AddUser addUser;
        Otchet otchet1;
        


        public string name;
        public string lastname;
        public string pantronymic;
        public string post;
        public string id;

        public Main()
        {
            InitializeComponent();
        }

        bool firstlogin = true;
        int hour = 0;
        int minute = 0;
        int second = 0;
        bool messege = false;

        public void tickTimer(object sender, EventArgs e) 
        {
            second++;

            if (second == 60)
            {
                minute++;
                second = 0;
            }
            if (minute == 60)
            {
                minute = 0;
                hour++;
            }

            if (hour == 0)
            {
                labelTime.Text = "Времени прошло с начала сеанса: " + minute + " минут " + second + " секунд";
            }
            if (hour == 1)
            {
                labelTime.Text = "Времени прошло с начала сеанса: " + hour + " час " + minute + " минут " + second + " секунд";
            }
            else {
                labelTime.Text = "Времени прошло с начала сеанса: " + hour + " часа " + minute + " минут " + second + " секунд";
            }


            if (minute > 4 && !messege)
            {
                messege = true;
                MessageBox.Show("До конца сеанса осталось 5 минут");
            }

            if (minute == 10)
            { 
                timer.Stop();

                closeWindow();

                Login form = new Login();
                form.ban = true;
                this.Visible = false;
                form.Show();
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login form = new Login();
            timer.Stop();
            form.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadProfile();
            setRoles();
            timer.Start();
        }

        public void loadProfile() 
        {
            ResourceManager rm = Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject(lastname.ToString());

            pictureBox1.Image = myImage;

            labelFio.Text = $"{name} {lastname} {pantronymic}";
            labelEmployee.Text = post.ToString();
        }

        private void closeWindow()
        {
            Form[] forms = { zakaz, login, getTovar, addKlient, otchet1, addUser };
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i] != null)
                {
                    forms[i].Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zakaz = new Zakaz();
            zakaz.Show();
        }

        public void setRoles() 
        {
            
            if (post == "Продавец")
            {
                buttonZakaz.Visible = true;
            }
            if (post == "Старший смены")
            {
                buttonZakaz.Visible = true;
                buttonGet.Visible = true;
            }
            if (post == "Администратор")
            {
                buttonCheckHistory.Visible = true;
                buttonOtchet.Visible = true;
                buttonAdd.Visible = true;
                buttonAddKlient.Visible = true;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonCheckHistory_Click(object sender, EventArgs e)
        {
                login = new UsersLogin();
            login.Show();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            getTovar = new GetTovar();
            getTovar.Show();
        }

        private void buttonOtchet_Click(object sender, EventArgs e)
        {
            otchet1 = new Otchet();
            otchet1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addUser = new AddUser();
            addUser.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            addKlient = new addKlient();
            addKlient.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
