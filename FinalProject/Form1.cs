using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox doTextBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button calenderBtn;
        private System.Windows.Forms.Button tagBtn;
        private System.Windows.Forms.PictureBox userPictureBox1;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label listLabel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OK;
        private System.Windows.Forms.Button gameBtn;
        private System.Windows.Forms.Button habitBtn;
        private System.Windows.Forms.Button moneyBtn;
        private System.Windows.Forms.OpenFileDialog openPictureDialog1;
        private System.Windows.Forms.TabPage Month;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage Year;
        private System.Windows.Forms.MonthCalendar yearCalendar;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label sentence;
        private System.Windows.Forms.Label sentence1;
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doTextBox1 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.addBtn = new System.Windows.Forms.Button();
            this.addPanel = new System.Windows.Forms.Panel();
            this.tagBtn = new System.Windows.Forms.Button();
            this.calenderBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.userPictureBox1 = new System.Windows.Forms.PictureBox();
            this.listPanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.listLabel1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gameBtn = new System.Windows.Forms.Button();
            this.habitBtn = new System.Windows.Forms.Button();
            this.moneyBtn = new System.Windows.Forms.Button();
            this.openPictureDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox1)).BeginInit();
            this.listPanel.SuspendLayout();
            this.SuspendLayout();
            this.Month = new System.Windows.Forms.TabPage();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.tab = new System.Windows.Forms.TabControl();
            this.yearCalendar = new System.Windows.Forms.MonthCalendar();
            this.Year = new System.Windows.Forms.TabPage();
            this.txtDate = new System.Windows.Forms.Label();
            this.sentence = new System.Windows.Forms.Label();
            this.sentence1 = new System.Windows.Forms.Label();
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.settingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Location = new System.Drawing.Point(270, 300);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(80, 80);
            this.settingsBtn.TabIndex = 0;
            this.settingsBtn.Text = "settings";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settings_Click);
            // 
            // dataGridView1
            // 
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.DefaultCellStyle.BackColor = Color.LightSlateGray;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.OK});
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(359, 450);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column3
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "tag";
            this.Column3.Name = "Column3";
            this.Column3.Width = 10;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // OK
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            this.OK.DefaultCellStyle = dataGridViewCellStyle4;
            this.OK.HeaderText = "OK";
            this.OK.Name = "OK";
            this.OK.ReadOnly = true;
            this.OK.Width = 30;
            // 
            // doTextBox1
            // 
            this.doTextBox1.Location = new System.Drawing.Point(16, 14);
            this.doTextBox1.Name = "doTextBox1";
            this.doTextBox1.Size = new System.Drawing.Size(100, 29);
            this.doTextBox1.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Visible = false;
            this.monthCalendar1.BackColor = System.Drawing.Color.LightSlateGray;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.monthCalendar1.Location = new System.Drawing.Point(16, 77);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // addBtn
            // 
            addPanel.Visible = false;
            addPanel.Location = new Point(0, 250);
            this.addBtn.BackColor = System.Drawing.Color.SlateGray;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(144, 545);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(50, 50);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.add_Click);
            // 
            // addPanel
            // 
            this.addPanel.Location = new Point(0, 650);
            this.addPanel.BackColor = System.Drawing.Color.White;
            this.addPanel.Controls.Add(this.tagBtn);
            this.addPanel.Controls.Add(this.calenderBtn);
            this.addPanel.Controls.Add(this.okBtn);
            this.addPanel.Controls.Add(this.doTextBox1);
            this.addPanel.Controls.Add(this.monthCalendar1);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(370, 320);
            this.addPanel.TabIndex = 5;
            // 
            // tagBtn
            // 
            this.tagBtn.Location = new System.Drawing.Point(211, 3);
            this.tagBtn.Name = "tagBtn";
            this.tagBtn.Size = new System.Drawing.Size(75, 40);
            this.tagBtn.TabIndex = 7;
            this.tagBtn.Text = "tag";
            this.tagBtn.UseVisualStyleBackColor = true;
            this.tagBtn.Click += new System.EventHandler(this.tagBtn_Click);
            // 
            // calenderBtn
            // 
            this.calenderBtn.Location = new System.Drawing.Point(133, 3);
            this.calenderBtn.Name = "calenderBtn";
            this.calenderBtn.Size = new System.Drawing.Size(75, 40);
            this.calenderBtn.TabIndex = 6;
            this.calenderBtn.Text = "日曆";
            this.calenderBtn.UseVisualStyleBackColor = true;
            this.calenderBtn.Click += new System.EventHandler(this.calenderBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(292, 3);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 40);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // userPictureBox1
            // 
            this.userPictureBox1.Location = new System.Drawing.Point(170, 30);
            this.userPictureBox1.Name = "pictureBox1";
            this.userPictureBox1.Size = new System.Drawing.Size(200, 200);
            this.userPictureBox1.TabIndex = 6;
            this.userPictureBox1.TabStop = false;
            // 
            // listPanel
            // 
            this.listPanel.BackColor = System.Drawing.Color.SlateGray;
            this.listPanel.Controls.Add(this.deleteBtn);
            this.listPanel.Controls.Add(this.listLabel1);
            this.listPanel.Controls.Add(this.dataGridView1);
            this.listPanel.Controls.Add(this.addBtn);
            this.listPanel.Location = new System.Drawing.Point(0, 383);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(365, 600);
            this.listPanel.TabIndex = 7;
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(233, 545);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(50, 50);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click_1);
            // 
            // listLabel1
            // 
            this.listLabel1.AutoSize = true;
            this.listLabel1.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel1.Location = new System.Drawing.Point(58, 0);
            this.listLabel1.Name = "listLabel1";
            this.listLabel1.Size = new System.Drawing.Size(235, 42);
            this.listLabel1.TabIndex = 5;
            this.listLabel1.Text = "TO-DO-LIST";
            // 
            // gameBtn
            // 
            this.gameBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.gameBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.gameBtn.FlatAppearance.BorderSize = 0;
            this.gameBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.gameBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.gameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameBtn.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBtn.Location = new System.Drawing.Point(0, 300);
            this.gameBtn.Name = "gameBtn";
            this.gameBtn.Size = new System.Drawing.Size(80, 80);
            this.gameBtn.TabIndex = 8;
            this.gameBtn.Text = "GOBANG";
            this.gameBtn.UseVisualStyleBackColor = true;
            this.gameBtn.Click += new System.EventHandler(this.gameBtn_Click);
            // 
            // habitBtn
            // 
            this.habitBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.habitBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.habitBtn.FlatAppearance.BorderSize = 0;
            this.habitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.habitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.habitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.habitBtn.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitBtn.Location = new System.Drawing.Point(90, 300);
            this.habitBtn.Name = "habitBtn";
            this.habitBtn.Size = new System.Drawing.Size(80, 80);
            this.habitBtn.TabIndex = 8;
            this.habitBtn.Text = "G";
            this.habitBtn.UseVisualStyleBackColor = true;
            this.habitBtn.Click += new System.EventHandler(this.habitBtn_Click);
            // 
            // moneyBtn
            // 
            this.moneyBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.moneyBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.moneyBtn.FlatAppearance.BorderSize = 0;
            this.moneyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.moneyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.moneyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moneyBtn.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyBtn.Location = new System.Drawing.Point(180, 300);
            this.moneyBtn.Name = "habitBtn";
            this.moneyBtn.Size = new System.Drawing.Size(80, 80);
            this.moneyBtn.TabIndex = 8;
            this.moneyBtn.Text = "M";
            this.moneyBtn.UseVisualStyleBackColor = true;
            this.moneyBtn.Click += new System.EventHandler(this.moneyBtn_Click);
            // 
            // openPictureDialog1
            // 
            this.openPictureDialog1.FileName = "openPictureDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1269, 1500);
            this.Controls.Add(this.gameBtn);
            this.Controls.Add(this.habitBtn);
            this.Controls.Add(this.moneyBtn);
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.userPictureBox1);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.settingsBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox1)).EndInit();
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            this.ResumeLayout(false);
            this.Controls.Add(this.txtDate);
            // 
            // yearCalender
            // 
            this.yearCalendar.CalendarDimensions = new System.Drawing.Size(4, 3);
            //this.yearCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yearCalendar.Location = new System.Drawing.Point(250, 150);
            this.yearCalendar.Name = "yearCalendar";
            this.yearCalendar.ShowToday = false;
            this.Controls.Add(yearCalendar);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Snap ITC", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(0,10);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(163, 246);
            this.txtDate.TabIndex = 5;
            txtDate.Text += DateTime.Now.ToString("MM");
            txtDate.Text += "\r\n"+DateTime.Now.ToString("dd");
            this.Controls.Add(this.txtDate);
            // 
            // sentence
            // 
            this.sentence.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentence.Location = new System.Drawing.Point(300, 10);
            this.sentence.Text = "時間管理大師 GO!";
            this.sentence.Size = new System.Drawing.Size(1500, 100);
            this.Controls.Add(this.sentence);
            // 
            // sentence1
            // 
            this.sentence1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentence1.Location = new System.Drawing.Point(250, 620);
            this.sentence1.Text = "Time is money i am your father i have a dream show me the money who's your daddy";
            this.sentence1.Size = new System.Drawing.Size(1000, 30);
            this.Controls.Add(this.sentence1);
            // 
            // UI
            // 
            Bitmap userIcon = new Bitmap("../../../res/user.jpg");
            userPictureBox1.BackgroundImage = userIcon;
            userPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            Bitmap settingsIcon = new Bitmap("../../../res/profile_icon.png");
            settingsBtn.BackgroundImage = settingsIcon;
            settingsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            settingsBtn.Text = "";
            Bitmap addIcon = new Bitmap("../../../res/add_icon.png");
            addBtn.BackgroundImage = addIcon;
            addBtn.BackgroundImageLayout = ImageLayout.Stretch;
            addBtn.Text = "";
            Bitmap deleteIcon = new Bitmap("../../../res/delete_icon.png");
            deleteBtn.BackgroundImage = deleteIcon;
            deleteBtn.BackgroundImageLayout = ImageLayout.Stretch;
            deleteBtn.Text = "";
            Bitmap gameIcon = new Bitmap("../../../res/game_icon.png");
            gameBtn.BackgroundImage = gameIcon;
            gameBtn.BackgroundImageLayout = ImageLayout.Stretch;
            gameBtn.Text = "";
            Bitmap habitIcon = new Bitmap("../../../res/habit_icon.png");
            habitBtn.BackgroundImage = habitIcon;
            habitBtn.BackgroundImageLayout = ImageLayout.Stretch;
            habitBtn.Text = "";
            Bitmap moneyIcon = new Bitmap("../../../res/money_icon.png");
            moneyBtn.BackgroundImage = moneyIcon;
            moneyBtn.BackgroundImageLayout = ImageLayout.Stretch;
            moneyBtn.Text = "";

        }
        private void settings_Click(object sender, EventArgs e)
        {
            if (openPictureDialog1.ShowDialog() == DialogResult.OK)
            {
                openPictureDialog1.Filter = "JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|PNG|*.png";
                userPictureBox1.Image = Image.FromFile(openPictureDialog1.FileName);
                userPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            addPanel.Visible = true;
            listPanel.SendToBack();
        }
        string month, day;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            month = monthCalendar1.SelectionRange.Start.Date.Month.ToString();
            day = "/" + monthCalendar1.SelectionRange.Start.Date.Day.ToString();

        }
        Color tag = new Color();
        private void tagBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                tag = colorDialog1.Color;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].ReadOnly = false;
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Value = "OK";
            }
        }

        int current = 0;
        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (current - 1 >= 0)
            {
                DataGridViewRow r1 = this.dataGridView1.CurrentRow;
                dataGridView1.Rows.Remove(r1);
                current--;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (doTextBox1.Text != "")
            {
                dataGridView1.Rows.Add("", month + day, doTextBox1.Text);
                if (current == 0)
                    dataGridView1.Rows[current].Cells[0].Style.SelectionBackColor = tag;
                dataGridView1.Rows[current].Cells[0].Style.BackColor = tag;
                current++;
            }
            addPanel.Visible = false;
            doTextBox1.Text = "";
        }

        bool calender = false;

        private void gameBtn_Click(object sender, EventArgs e)
        {
            GOBANG go = new GOBANG();
            go.Owner = this;
            go.Show(this);
        }
        
        private void habitBtn_Click(object sender, EventArgs e)
        {
            Form_HabitChecking testForm = new Form_HabitChecking();
            testForm.Owner = this;
            testForm.Show();
        }

        private void moneyBtn_Click(object sender, EventArgs e)
        {
            Form_money testForm = new Form_money();
            testForm.Owner = this;
            testForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calenderBtn_Click(object sender, EventArgs e)
        {
            if (calender == false)
            {
                monthCalendar1.Visible = true;
                calender = true;
            }
            else
            {
                monthCalendar1.Visible = false;
                calender = false;
            }
        }

    }
}


