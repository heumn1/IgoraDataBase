namespace heumnEXdemo2
{
    partial class AddUser
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxlog = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxnam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxlast = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxpatr = new System.Windows.Forms.TextBox();
            this.comboBoxdolj = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxpas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(980, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "Логин";
            // 
            // textBoxlog
            // 
            this.textBoxlog.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.textBoxlog.Location = new System.Drawing.Point(12, 231);
            this.textBoxlog.Name = "textBoxlog";
            this.textBoxlog.Size = new System.Drawing.Size(155, 34);
            this.textBoxlog.TabIndex = 33;
            // 
            // buttonSort
            // 
            this.buttonSort.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.buttonSort.Location = new System.Drawing.Point(647, 282);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(319, 40);
            this.buttonSort.TabIndex = 32;
            this.buttonSort.Text = "Добавить";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label1.Location = new System.Drawing.Point(330, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "Имя";
            // 
            // textBoxnam
            // 
            this.textBoxnam.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.textBoxnam.Location = new System.Drawing.Point(335, 231);
            this.textBoxnam.Name = "textBoxnam";
            this.textBoxnam.Size = new System.Drawing.Size(150, 34);
            this.textBoxnam.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label2.Location = new System.Drawing.Point(486, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "Фамилия";
            // 
            // textBoxlast
            // 
            this.textBoxlast.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.textBoxlast.Location = new System.Drawing.Point(491, 231);
            this.textBoxlast.Name = "textBoxlast";
            this.textBoxlast.Size = new System.Drawing.Size(150, 34);
            this.textBoxlast.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label4.Location = new System.Drawing.Point(642, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 40;
            this.label4.Text = "Отчетсво";
            // 
            // textBoxpatr
            // 
            this.textBoxpatr.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.textBoxpatr.Location = new System.Drawing.Point(647, 231);
            this.textBoxpatr.Name = "textBoxpatr";
            this.textBoxpatr.Size = new System.Drawing.Size(150, 34);
            this.textBoxpatr.TabIndex = 39;
            // 
            // comboBoxdolj
            // 
            this.comboBoxdolj.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.comboBoxdolj.FormattingEnabled = true;
            this.comboBoxdolj.Items.AddRange(new object[] {
            "Администратор",
            "Старший смены",
            "Продавец"});
            this.comboBoxdolj.Location = new System.Drawing.Point(803, 231);
            this.comboBoxdolj.Name = "comboBoxdolj";
            this.comboBoxdolj.Size = new System.Drawing.Size(163, 34);
            this.comboBoxdolj.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label5.Location = new System.Drawing.Point(798, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 26);
            this.label5.TabIndex = 42;
            this.label5.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label6.Location = new System.Drawing.Point(173, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 26);
            this.label6.TabIndex = 44;
            this.label6.Text = "Пароль";
            // 
            // textBoxpas
            // 
            this.textBoxpas.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.textBoxpas.Location = new System.Drawing.Point(173, 231);
            this.textBoxpas.Name = "textBoxpas";
            this.textBoxpas.Size = new System.Drawing.Size(155, 34);
            this.textBoxpas.TabIndex = 43;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 334);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxpas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxdolj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxpatr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxlast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxnam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxlog);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxlog;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxlast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxpatr;
        private System.Windows.Forms.ComboBox comboBoxdolj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxpas;
    }
}