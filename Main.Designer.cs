namespace heumnEXdemo2
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labelFio = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonZakaz = new System.Windows.Forms.Button();
            this.buttonCheckHistory = new System.Windows.Forms.Button();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonOtchet = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAddKlient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFio.Location = new System.Drawing.Point(582, 0);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(204, 52);
            this.labelFio.TabIndex = 1;
            this.labelFio.Text = "ИмяКои ФамилияНа ОтчетсвоАрбузе";
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmployee.Location = new System.Drawing.Point(927, 0);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(139, 52);
            this.labelEmployee.TabIndex = 2;
            this.labelEmployee.Text = "Менеджер по продажам";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.tickTimer);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(3, 438);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(326, 26);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Времени прошло с начала сеанса:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // buttonZakaz
            // 
            this.buttonZakaz.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.buttonZakaz.Location = new System.Drawing.Point(3, 196);
            this.buttonZakaz.Name = "buttonZakaz";
            this.buttonZakaz.Size = new System.Drawing.Size(176, 68);
            this.buttonZakaz.TabIndex = 10;
            this.buttonZakaz.Text = "Добавить заказ";
            this.buttonZakaz.UseVisualStyleBackColor = true;
            this.buttonZakaz.Visible = false;
            this.buttonZakaz.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCheckHistory
            // 
            this.buttonCheckHistory.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.buttonCheckHistory.Location = new System.Drawing.Point(582, 389);
            this.buttonCheckHistory.Name = "buttonCheckHistory";
            this.buttonCheckHistory.Size = new System.Drawing.Size(176, 46);
            this.buttonCheckHistory.TabIndex = 11;
            this.buttonCheckHistory.Text = "Посмотреть историю входа";
            this.buttonCheckHistory.UseVisualStyleBackColor = true;
            this.buttonCheckHistory.Visible = false;
            this.buttonCheckHistory.Click += new System.EventHandler(this.buttonCheckHistory_Click);
            // 
            // buttonGet
            // 
            this.buttonGet.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.buttonGet.Location = new System.Drawing.Point(927, 196);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(176, 68);
            this.buttonGet.TabIndex = 12;
            this.buttonGet.Text = "Добавить услугу";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Visible = false;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonOtchet
            // 
            this.buttonOtchet.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.buttonOtchet.Location = new System.Drawing.Point(582, 196);
            this.buttonOtchet.Name = "buttonOtchet";
            this.buttonOtchet.Size = new System.Drawing.Size(176, 68);
            this.buttonOtchet.TabIndex = 13;
            this.buttonOtchet.Text = "Отчетность";
            this.buttonOtchet.UseVisualStyleBackColor = true;
            this.buttonOtchet.Visible = false;
            this.buttonOtchet.Click += new System.EventHandler(this.buttonOtchet_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.buttonAdd.Location = new System.Drawing.Point(3, 389);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(176, 46);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить пользователя";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonAddKlient
            // 
            this.buttonAddKlient.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.buttonAddKlient.Location = new System.Drawing.Point(927, 389);
            this.buttonAddKlient.Name = "buttonAddKlient";
            this.buttonAddKlient.Size = new System.Drawing.Size(176, 46);
            this.buttonAddKlient.TabIndex = 15;
            this.buttonAddKlient.Text = "Добавить клиента";
            this.buttonAddKlient.UseVisualStyleBackColor = true;
            this.buttonAddKlient.Visible = false;
            this.buttonAddKlient.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.66234F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.33766F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Controls.Add(this.labelFio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelEmployee, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonCheckHistory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOtchet, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonZakaz, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddKlient, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonGet, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTime, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1113, 528);
            this.tableLayoutPanel1.TabIndex = 16;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button buttonZakaz;
        private System.Windows.Forms.Button buttonCheckHistory;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button buttonOtchet;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAddKlient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}