using System;
using System.Windows.Forms;

namespace heumnEXdemo2
{
    public partial class Login : Form
    {
        int fails;
        public bool ban;
        int minute = 0;
        int second = 0;
        int secondBanLogin = 10;
        bool failsWithCaptha;
        private DataBaseConnect dataBase = new DataBaseConnect();
        DataBaseConnect data = new DataBaseConnect();

        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (ban)
            {
                MessageBox.Show("Подождите идет заполнение данных");
            }
            else
            {
                login();
            }
        }

        private void buttonViewPassword_Click(object sender, EventArgs e)
        {
            
                if (textBoxPassword.PasswordChar == '*')
                {
                    textBoxPassword.PasswordChar = '\0';
                }
                else
                {
                    textBoxPassword.PasswordChar = '*';
                }        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ban) 
            {
                timer.Start();
                MessageBox.Show("Подождите 3 минут, идет заполнение данных");
            }
        }

        public void tickTimer(object sender, EventArgs e)
        {
            second++;

            if (second == 60)
            {
                minute++;
                second = 0;
            }
            
            if (minute > 200)
            {
                ban = false;
                MessageBox.Show("Заполнение данных завершено");
            }
        }
        public void tickTimer2(object sender, EventArgs e)
        {
            secondBanLogin--;

            if (secondBanLogin == 0)
            {
                timer1.Stop();
                secondBanLogin = 10;
                labelBan.Visible = false;
            }

            labelBan.Text = "Блокировка, осталось до снятия: " + secondBanLogin + " секунд";
        }

        public void login() 
        {
            if (ban)
            {
                MessageBox.Show("Подождите идет заполнение данных");
            }
            else
            {
                if (!(dataBase.getLogin(textBoxLogin.Text, textBoxPassword.Text) == "null"))
                {
                    dataBase.typeLogin(textBoxLogin.Text, "true");

                    Hide();
                    Main form2 = new Main();
                    string[] objects = data.getinfo(dataBase.getLogin(textBoxLogin.Text, textBoxPassword.Text));

                    dataBase.loginUser(textBoxLogin.Text, DateTime.Now.ToString());

                    form2.name = objects[0];
                    form2.lastname = objects[1];
                    form2.pantronymic = objects[2];
                    form2.post= objects[3];

                    form2.id = dataBase.getLogin(textBoxLogin.Text, textBoxPassword.Text);
                    form2.Show();
                }
                else 
                {
                    dataBase.typeLogin(textBoxLogin.Text, "false");
                    fails++;
                    MessageBox.Show("неверный логин или пароль");
                    if (fails >= 2)
                    {
                        if (failsWithCaptha)
                        {
                            labelBan.Visible = true;
                            timer1.Start();
                        }
                    }
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
