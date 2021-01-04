namespace FinalProject
{
    partial class Form_HabitChecking
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
            this.panel_statistic = new System.Windows.Forms.Panel();
            this.button_display_habit = new System.Windows.Forms.Button();
            this.label_incomplete = new System.Windows.Forms.Label();
            this.label_incompleteNumber = new System.Windows.Forms.Label();
            this.label_started = new System.Windows.Forms.Label();
            this.label_startedNumber = new System.Windows.Forms.Label();
            this.label_complete = new System.Windows.Forms.Label();
            this.label_completeNumber = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_status_show = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.panel_display = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_backToP1 = new System.Windows.Forms.Button();
            this.button_habit4 = new System.Windows.Forms.Button();
            this.button_habit3 = new System.Windows.Forms.Button();
            this.button_habit2 = new System.Windows.Forms.Button();
            this.button_habit1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add_new = new System.Windows.Forms.Button();
            this.panel_add_habit = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_display_choosed_habit = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.timer_scroll = new System.Windows.Forms.Timer(this.components);
            this.circleProgressBar = new FinalProject.CircleProgressBar();
            this.timer_scrollback = new System.Windows.Forms.Timer(this.components);
            this.timer_scrollup = new System.Windows.Forms.Timer(this.components);
            this.timer_scrolldown = new System.Windows.Forms.Timer(this.components);
            this.button13 = new System.Windows.Forms.Button();
            this.label_display_habit = new System.Windows.Forms.Label();
            this.textBox_input_times = new System.Windows.Forms.TextBox();
            this.textBox_repeat_freq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_statistic.SuspendLayout();
            this.panel_display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_add_habit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_statistic
            // 
            this.panel_statistic.Controls.Add(this.button_display_habit);
            this.panel_statistic.Controls.Add(this.label_incomplete);
            this.panel_statistic.Controls.Add(this.label_incompleteNumber);
            this.panel_statistic.Controls.Add(this.label_started);
            this.panel_statistic.Controls.Add(this.label_startedNumber);
            this.panel_statistic.Controls.Add(this.label_complete);
            this.panel_statistic.Controls.Add(this.label_completeNumber);
            this.panel_statistic.Controls.Add(this.button4);
            this.panel_statistic.Controls.Add(this.button3);
            this.panel_statistic.Controls.Add(this.button2);
            this.panel_statistic.Controls.Add(this.button1);
            this.panel_statistic.Controls.Add(this.label_status_show);
            this.panel_statistic.Controls.Add(this.circleProgressBar);
            this.panel_statistic.Controls.Add(this.button_back);
            this.panel_statistic.Location = new System.Drawing.Point(0, 0);
            this.panel_statistic.Name = "panel_statistic";
            this.panel_statistic.Size = new System.Drawing.Size(400, 700);
            this.panel_statistic.TabIndex = 0;
            // 
            // button_display_habit
            // 
            this.button_display_habit.BackgroundImage = global::FinalProject.Properties.Resources.list;
            this.button_display_habit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_display_habit.FlatAppearance.BorderSize = 0;
            this.button_display_habit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_display_habit.Location = new System.Drawing.Point(343, 11);
            this.button_display_habit.Name = "button_display_habit";
            this.button_display_habit.Size = new System.Drawing.Size(51, 33);
            this.button_display_habit.TabIndex = 27;
            this.button_display_habit.UseVisualStyleBackColor = true;
            this.button_display_habit.Click += new System.EventHandler(this.button_display_habit_Click);
            // 
            // label_incomplete
            // 
            this.label_incomplete.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_incomplete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_incomplete.Location = new System.Drawing.Point(276, 649);
            this.label_incomplete.Name = "label_incomplete";
            this.label_incomplete.Size = new System.Drawing.Size(100, 30);
            this.label_incomplete.TabIndex = 26;
            this.label_incomplete.Text = "未完成";
            this.label_incomplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_incompleteNumber
            // 
            this.label_incompleteNumber.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_incompleteNumber.ForeColor = System.Drawing.Color.Green;
            this.label_incompleteNumber.Location = new System.Drawing.Point(276, 599);
            this.label_incompleteNumber.Name = "label_incompleteNumber";
            this.label_incompleteNumber.Size = new System.Drawing.Size(100, 60);
            this.label_incompleteNumber.TabIndex = 25;
            this.label_incompleteNumber.Text = "16";
            this.label_incompleteNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_started
            // 
            this.label_started.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_started.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_started.Location = new System.Drawing.Point(151, 649);
            this.label_started.Name = "label_started";
            this.label_started.Size = new System.Drawing.Size(100, 30);
            this.label_started.TabIndex = 24;
            this.label_started.Text = "已開始";
            this.label_started.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_startedNumber
            // 
            this.label_startedNumber.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startedNumber.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_startedNumber.Location = new System.Drawing.Point(151, 599);
            this.label_startedNumber.Name = "label_startedNumber";
            this.label_startedNumber.Size = new System.Drawing.Size(100, 60);
            this.label_startedNumber.TabIndex = 23;
            this.label_startedNumber.Text = "4";
            this.label_startedNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_complete
            // 
            this.label_complete.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_complete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_complete.Location = new System.Drawing.Point(26, 649);
            this.label_complete.Name = "label_complete";
            this.label_complete.Size = new System.Drawing.Size(100, 30);
            this.label_complete.TabIndex = 22;
            this.label_complete.Text = "已完成";
            this.label_complete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_completeNumber
            // 
            this.label_completeNumber.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_completeNumber.ForeColor = System.Drawing.Color.Green;
            this.label_completeNumber.Location = new System.Drawing.Point(26, 599);
            this.label_completeNumber.Name = "label_completeNumber";
            this.label_completeNumber.Size = new System.Drawing.Size(100, 60);
            this.label_completeNumber.TabIndex = 21;
            this.label_completeNumber.Text = "65";
            this.label_completeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(291, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 20;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(211, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(131, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(51, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_status_show
            // 
            this.label_status_show.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_status_show.Location = new System.Drawing.Point(136, 79);
            this.label_status_show.Name = "label_status_show";
            this.label_status_show.Size = new System.Drawing.Size(130, 70);
            this.label_status_show.TabIndex = 14;
            this.label_status_show.Text = "統計";
            this.label_status_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.SkyBlue;
            this.button_back.BackgroundImage = global::FinalProject.Properties.Resources.back_arrow;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Location = new System.Drawing.Point(2, 11);
            this.button_back.Margin = new System.Windows.Forms.Padding(2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(59, 32);
            this.button_back.TabIndex = 16;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // panel_display
            // 
            this.panel_display.Controls.Add(this.label7);
            this.panel_display.Controls.Add(this.pictureBox4);
            this.panel_display.Controls.Add(this.pictureBox3);
            this.panel_display.Controls.Add(this.pictureBox2);
            this.panel_display.Controls.Add(this.pictureBox1);
            this.panel_display.Controls.Add(this.button_backToP1);
            this.panel_display.Controls.Add(this.button_habit4);
            this.panel_display.Controls.Add(this.button_habit3);
            this.panel_display.Controls.Add(this.button_habit2);
            this.panel_display.Controls.Add(this.button_habit1);
            this.panel_display.Controls.Add(this.label1);
            this.panel_display.Controls.Add(this.button_add_new);
            this.panel_display.Location = new System.Drawing.Point(400, 0);
            this.panel_display.Name = "panel_display";
            this.panel_display.Size = new System.Drawing.Size(400, 700);
            this.panel_display.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::FinalProject.Properties.Resources.check;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(334, 570);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 39);
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::FinalProject.Properties.Resources.check;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(150, 570);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 39);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FinalProject.Properties.Resources.check;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(334, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalProject.Properties.Resources.check;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(150, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // button_backToP1
            // 
            this.button_backToP1.BackColor = System.Drawing.Color.SkyBlue;
            this.button_backToP1.BackgroundImage = global::FinalProject.Properties.Resources.back_arrow;
            this.button_backToP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_backToP1.FlatAppearance.BorderSize = 0;
            this.button_backToP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_backToP1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_backToP1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_backToP1.Location = new System.Drawing.Point(5, 10);
            this.button_backToP1.Margin = new System.Windows.Forms.Padding(2);
            this.button_backToP1.Name = "button_backToP1";
            this.button_backToP1.Size = new System.Drawing.Size(59, 32);
            this.button_backToP1.TabIndex = 28;
            this.button_backToP1.UseVisualStyleBackColor = false;
            this.button_backToP1.Click += new System.EventHandler(this.button_backToP1_Click);
            // 
            // button_habit4
            // 
            this.button_habit4.BackColor = System.Drawing.Color.SkyBlue;
            this.button_habit4.BackgroundImage = global::FinalProject.Properties.Resources.studyIcon;
            this.button_habit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_habit4.FlatAppearance.BorderSize = 0;
            this.button_habit4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_habit4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_habit4.Location = new System.Drawing.Point(222, 385);
            this.button_habit4.Name = "button_habit4";
            this.button_habit4.Size = new System.Drawing.Size(155, 233);
            this.button_habit4.TabIndex = 32;
            this.button_habit4.Text = "Study";
            this.button_habit4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_habit4.UseVisualStyleBackColor = false;
            this.button_habit4.Click += new System.EventHandler(this.button_habit4_Click);
            // 
            // button_habit3
            // 
            this.button_habit3.BackColor = System.Drawing.Color.SkyBlue;
            this.button_habit3.BackgroundImage = global::FinalProject.Properties.Resources.meditationIcon;
            this.button_habit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_habit3.FlatAppearance.BorderSize = 0;
            this.button_habit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_habit3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_habit3.Location = new System.Drawing.Point(25, 385);
            this.button_habit3.Name = "button_habit3";
            this.button_habit3.Size = new System.Drawing.Size(155, 233);
            this.button_habit3.TabIndex = 31;
            this.button_habit3.Text = "Meditation";
            this.button_habit3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_habit3.UseVisualStyleBackColor = false;
            this.button_habit3.Click += new System.EventHandler(this.button_habit3_Click);
            // 
            // button_habit2
            // 
            this.button_habit2.BackColor = System.Drawing.Color.SkyBlue;
            this.button_habit2.BackgroundImage = global::FinalProject.Properties.Resources.fitnessIcon;
            this.button_habit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_habit2.FlatAppearance.BorderSize = 0;
            this.button_habit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_habit2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_habit2.Location = new System.Drawing.Point(222, 93);
            this.button_habit2.Name = "button_habit2";
            this.button_habit2.Size = new System.Drawing.Size(155, 233);
            this.button_habit2.TabIndex = 30;
            this.button_habit2.Text = "Workout";
            this.button_habit2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_habit2.UseVisualStyleBackColor = false;
            this.button_habit2.Click += new System.EventHandler(this.button_habit2_Click);
            // 
            // button_habit1
            // 
            this.button_habit1.BackColor = System.Drawing.Color.SkyBlue;
            this.button_habit1.BackgroundImage = global::FinalProject.Properties.Resources.waterIcon;
            this.button_habit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_habit1.FlatAppearance.BorderSize = 0;
            this.button_habit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_habit1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_habit1.Location = new System.Drawing.Point(25, 93);
            this.button_habit1.Name = "button_habit1";
            this.button_habit1.Size = new System.Drawing.Size(155, 233);
            this.button_habit1.TabIndex = 29;
            this.button_habit1.Text = "Drink Water";
            this.button_habit1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_habit1.UseVisualStyleBackColor = false;
            this.button_habit1.Click += new System.EventHandler(this.button_habit1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 70);
            this.label1.TabIndex = 28;
            this.label1.Text = "Habits";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_add_new
            // 
            this.button_add_new.BackgroundImage = global::FinalProject.Properties.Resources.add;
            this.button_add_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_add_new.FlatAppearance.BorderSize = 0;
            this.button_add_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_new.Location = new System.Drawing.Point(346, 12);
            this.button_add_new.Name = "button_add_new";
            this.button_add_new.Size = new System.Drawing.Size(51, 33);
            this.button_add_new.TabIndex = 28;
            this.button_add_new.Text = "6";
            this.button_add_new.UseVisualStyleBackColor = true;
            this.button_add_new.Click += new System.EventHandler(this.button_add_new_Click);
            // 
            // panel_add_habit
            // 
            this.panel_add_habit.BackColor = System.Drawing.Color.Crimson;
            this.panel_add_habit.Controls.Add(this.label6);
            this.panel_add_habit.Controls.Add(this.label5);
            this.panel_add_habit.Controls.Add(this.textBox_repeat_freq);
            this.panel_add_habit.Controls.Add(this.textBox_input_times);
            this.panel_add_habit.Controls.Add(this.label_display_habit);
            this.panel_add_habit.Controls.Add(this.button13);
            this.panel_add_habit.Controls.Add(this.button12);
            this.panel_add_habit.Controls.Add(this.label4);
            this.panel_add_habit.Controls.Add(this.label3);
            this.panel_add_habit.Controls.Add(this.label_display_choosed_habit);
            this.panel_add_habit.Controls.Add(this.button8);
            this.panel_add_habit.Controls.Add(this.button9);
            this.panel_add_habit.Controls.Add(this.label2);
            this.panel_add_habit.Controls.Add(this.button10);
            this.panel_add_habit.Controls.Add(this.button11);
            this.panel_add_habit.Location = new System.Drawing.Point(800, 0);
            this.panel_add_habit.Name = "panel_add_habit";
            this.panel_add_habit.Size = new System.Drawing.Size(400, 700);
            this.panel_add_habit.TabIndex = 2;
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(169, 385);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(87, 46);
            this.button12.TabIndex = 40;
            this.button12.Text = "OK";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 30);
            this.label4.TabIndex = 39;
            this.label4.Text = "Repeat: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 30);
            this.label3.TabIndex = 38;
            this.label3.Text = "Times: ";
            // 
            // label_display_choosed_habit
            // 
            this.label_display_choosed_habit.AutoSize = true;
            this.label_display_choosed_habit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_display_choosed_habit.Location = new System.Drawing.Point(76, 199);
            this.label_display_choosed_habit.Name = "label_display_choosed_habit";
            this.label_display_choosed_habit.Size = new System.Drawing.Size(87, 30);
            this.label_display_choosed_habit.TabIndex = 37;
            this.label_display_choosed_habit.Text = "Habit: ";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Crimson;
            this.button8.BackgroundImage = global::FinalProject.Properties.Resources.studyIcon;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.Location = new System.Drawing.Point(286, 93);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 70);
            this.button8.TabIndex = 36;
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Crimson;
            this.button9.BackgroundImage = global::FinalProject.Properties.Resources.meditationIcon;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button9.Location = new System.Drawing.Point(203, 93);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 70);
            this.button9.TabIndex = 35;
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(137, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 70);
            this.label2.TabIndex = 33;
            this.label2.Text = "Add";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Crimson;
            this.button10.BackgroundImage = global::FinalProject.Properties.Resources.fitnessIcon;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button10.Location = new System.Drawing.Point(120, 93);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 70);
            this.button10.TabIndex = 34;
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Crimson;
            this.button11.BackgroundImage = global::FinalProject.Properties.Resources.waterIcon;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button11.Location = new System.Drawing.Point(37, 93);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 70);
            this.button11.TabIndex = 33;
            this.button11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // timer_scroll
            // 
            this.timer_scroll.Interval = 1;
            this.timer_scroll.Tick += new System.EventHandler(this.timer_scroll_Tick);
            // 
            // circleProgressBar
            // 
            this.circleProgressBar.BackColor = System.Drawing.Color.SkyBlue;
            this.circleProgressBar.BottomColor = System.Drawing.Color.Gainsboro;
            this.circleProgressBar.FinishedColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(179)))), ((int)(((byte)(63)))));
            this.circleProgressBar.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleProgressBar.Location = new System.Drawing.Point(36, 259);
            this.circleProgressBar.MaxValue = 100;
            this.circleProgressBar.Name = "circleProgressBar";
            this.circleProgressBar.Progress = 20;
            this.circleProgressBar.Size = new System.Drawing.Size(330, 330);
            this.circleProgressBar.TabIndex = 15;
            this.circleProgressBar.Text = "circleProgressBar1";
            this.circleProgressBar.TopColor = System.Drawing.Color.Crimson;
            // 
            // timer_scrollback
            // 
            this.timer_scrollback.Interval = 1;
            this.timer_scrollback.Tick += new System.EventHandler(this.timer_scrollback_Tick);
            // 
            // timer_scrollup
            // 
            this.timer_scrollup.Interval = 1;
            this.timer_scrollup.Tick += new System.EventHandler(this.timer_scrollup_Tick);
            // 
            // timer_scrolldown
            // 
            this.timer_scrolldown.Interval = 1;
            this.timer_scrolldown.Tick += new System.EventHandler(this.timer_scrolldown_Tick);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Crimson;
            this.button13.BackgroundImage = global::FinalProject.Properties.Resources.back_arrow;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Location = new System.Drawing.Point(5, 9);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(59, 32);
            this.button13.TabIndex = 37;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label_display_habit
            // 
            this.label_display_habit.AutoSize = true;
            this.label_display_habit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_display_habit.Location = new System.Drawing.Point(164, 199);
            this.label_display_habit.Name = "label_display_habit";
            this.label_display_habit.Size = new System.Drawing.Size(0, 30);
            this.label_display_habit.TabIndex = 41;
            // 
            // textBox_input_times
            // 
            this.textBox_input_times.BackColor = System.Drawing.Color.Crimson;
            this.textBox_input_times.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_input_times.Location = new System.Drawing.Point(172, 265);
            this.textBox_input_times.Name = "textBox_input_times";
            this.textBox_input_times.Size = new System.Drawing.Size(115, 24);
            this.textBox_input_times.TabIndex = 42;
            // 
            // textBox_repeat_freq
            // 
            this.textBox_repeat_freq.BackColor = System.Drawing.Color.Crimson;
            this.textBox_repeat_freq.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_repeat_freq.Location = new System.Drawing.Point(242, 322);
            this.textBox_repeat_freq.Name = "textBox_repeat_freq";
            this.textBox_repeat_freq.Size = new System.Drawing.Size(47, 24);
            this.textBox_repeat_freq.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 30);
            this.label5.TabIndex = 44;
            this.label5.Text = "every";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 30);
            this.label6.TabIndex = 45;
            this.label6.Text = "days";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(21, 629);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(356, 50);
            this.label7.TabIndex = 28;
            this.label7.Text = "若已完成習慣，請點擊按鈕";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_HabitChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(400, 700);
            this.Controls.Add(this.panel_add_habit);
            this.Controls.Add(this.panel_display);
            this.Controls.Add(this.panel_statistic);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_HabitChecking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habit Checking";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_HabitChecking_MouseDown);
            this.panel_statistic.ResumeLayout(false);
            this.panel_display.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_add_habit.ResumeLayout(false);
            this.panel_add_habit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_statistic;
        private System.Windows.Forms.Button button_display_habit;
        private System.Windows.Forms.Label label_incomplete;
        private System.Windows.Forms.Label label_incompleteNumber;
        private System.Windows.Forms.Label label_started;
        private System.Windows.Forms.Label label_startedNumber;
        private System.Windows.Forms.Label label_complete;
        private System.Windows.Forms.Label label_completeNumber;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_status_show;
        private CircleProgressBar circleProgressBar;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Panel panel_display;
        private System.Windows.Forms.Button button_add_new;
        private System.Windows.Forms.Button button_habit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_backToP1;
        private System.Windows.Forms.Button button_habit4;
        private System.Windows.Forms.Button button_habit3;
        private System.Windows.Forms.Button button_habit2;
        private System.Windows.Forms.Panel panel_add_habit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_display_choosed_habit;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Timer timer_scroll;
        private System.Windows.Forms.Timer timer_scrollback;
        private System.Windows.Forms.Timer timer_scrollup;
        private System.Windows.Forms.Timer timer_scrolldown;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_repeat_freq;
        private System.Windows.Forms.TextBox textBox_input_times;
        private System.Windows.Forms.Label label_display_habit;
        private System.Windows.Forms.Label label7;
    }
}