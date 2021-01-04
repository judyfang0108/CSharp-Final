using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form_HabitChecking : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int left,
                int top,
                int right,
                int bottom,
                int width,
                int height
            );
        Bitmap checked_pic = new Bitmap("../../Resources/checked.png");
        int add_habit_mode = 0;
        HabitCheckingData data = new HabitCheckingData();
        public Form_HabitChecking()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
            // 畫進度條
            this.circleProgressBar.Progress = 0;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            button_habit1.Enabled = false;
            button_habit2.Enabled = false;
            button_habit3.Enabled = false;
            button_habit4.Enabled = false;
            Bitmap waterIcon = new Bitmap("../../Resources/waterIcon.png");
            Bitmap studyIcon = new Bitmap("../../Resources/studyIcon.png");
            Bitmap fitnessIcon = new Bitmap("../../Resources/fitnessIcon.png");
            Bitmap meditationIcon = new Bitmap("../../Resources/meditationIcon.png");
            button1.BackgroundImage = waterIcon;
            button2.BackgroundImage = fitnessIcon;
            button3.BackgroundImage = meditationIcon;
            button4.BackgroundImage = studyIcon;
            label_completeNumber.Text = data.completed_habits_times.ToString();
            label_startedNumber.Text = data.now_doing_habits.ToString();
            label_incompleteNumber.Text = data.now_doing_habits.ToString();
        }
        private void Form_HabitChecking_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void button_back_Click(object sender, EventArgs e) => this.Close();

        private void button_display_habit_Click(object sender, EventArgs e)
        {
            panel_display.SetBounds(400, 0, 400, 700);
            timer_scroll.Enabled = true;
        }

        private void timer_scroll_Tick(object sender, EventArgs e)
        {
            if (panel_display.Location.X > 0)
                panel_display.SetBounds(panel_display.Location.X - 15, 0, 400, 700);
            else
                timer_scroll.Enabled = false;
        }

        private void button_backToP1_Click(object sender, EventArgs e)
        {
            panel_display.SetBounds(0, 0, 400, 700);
            timer_scrollback.Enabled = true;
        }

        private void timer_scrollback_Tick(object sender, EventArgs e)
        {
            if (panel_display.Location.X < 400)
                panel_display.SetBounds(panel_display.Location.X + 15, 0, 400, 700);
            else
                timer_scrollback.Enabled = false;
        }

        private void button_add_new_Click(object sender, EventArgs e)
        {
            panel_add_habit.SetBounds(0, 700, 400, 700);
            panel_display.Enabled = false;
            timer_scrollup.Enabled = true;
        }

        private void timer_scrollup_Tick(object sender, EventArgs e)
        {
            if (panel_add_habit.Location.Y > 150)
                panel_add_habit.SetBounds(0, panel_add_habit.Location.Y - 15, 400, 700);
            else
                timer_scrollup.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (add_habit_mode)
            {
                case 1:
                    if (data.water.is_build == false)
                    {
                        try
                        {
                            data.water.total_times = int.Parse(textBox_input_times.Text);
                            data.water.repeat_freq = int.Parse(textBox_repeat_freq.Text);
                            ++data.now_doing_habits;
                            data.water.is_build = true;
                        }
                        catch
                        {
                            MessageBox.Show("Please input all in numbers");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("This habit has been added");
                        return;
                    }
                    break;
                case 2:
                    if (data.workout.is_build == false)
                    {
                        try
                        {
                            data.workout.total_times = int.Parse(textBox_input_times.Text);
                            data.workout.repeat_freq = int.Parse(textBox_repeat_freq.Text);
                            ++data.now_doing_habits;
                            data.workout.is_build = true;
                        }
                        catch
                        {
                            MessageBox.Show("Please input all in numbers");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("This habit has been added");
                        return;
                    }
                    break;
                case 3:
                    if (data.meditation.is_build == false)
                    {
                        try
                        {
                            data.meditation.total_times = int.Parse(textBox_input_times.Text);
                            data.meditation.repeat_freq = int.Parse(textBox_repeat_freq.Text);
                            ++data.now_doing_habits;
                            data.meditation.is_build = true;
                        }
                        catch
                        {
                            MessageBox.Show("Please input all in numbers");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("This habit has been added");
                        return;
                    }
                    break;
                case 4:
                    if (data.study.is_build == false)
                    {
                        try
                        {
                            data.study.total_times = int.Parse(textBox_input_times.Text);
                            data.study.repeat_freq = int.Parse(textBox_repeat_freq.Text);
                            ++data.now_doing_habits;
                            data.study.is_build = true;
                        }
                        catch
                        {
                            MessageBox.Show("Please input all in numbers");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("This habit has been added");
                        return;
                    }
                    break;
                case 0:
                    MessageBox.Show("Please choose a habit");
                    return;
            }
            label_startedNumber.Text = data.now_doing_habits.ToString();
            label_incompleteNumber.Text = data.now_doing_habits.ToString();
            textBox_repeat_freq.Text = "";
            textBox_input_times.Text = "";
            label_display_habit.Text = "";
            add_habit_mode = 0;
            panel_add_habit.SetBounds(0, panel_add_habit.Location.Y, 400, 700);
            panel_display.Enabled = true;
            timer_scrolldown.Enabled = true;
            if (data.water.is_build)
            {
                pictureBox1.Visible = true;
                button_habit1.Enabled = true;
            }
            else
            {
                pictureBox1.Visible = false;
                button_habit1.Enabled = false;
            }
            if (data.workout.is_build)
            {
                pictureBox2.Visible = true;
                button_habit2.Enabled = true;
            }
            else
            {
                pictureBox2.Visible = false;
                button_habit2.Enabled = false;
            }
            if (data.meditation.is_build)
            {
                pictureBox3.Visible = true;
                button_habit3.Enabled = true;
            }
            else
            {
                pictureBox3.Visible = false;
                button_habit3.Enabled = false;
            }
            if (data.study.is_build)
            {
                pictureBox4.Visible = true;
                button_habit4.Enabled = true;
            }
            else
            {
                pictureBox4.Visible = false;
                button_habit4.Enabled = false;
            }
        }

        private void timer_scrolldown_Tick(object sender, EventArgs e)
        {
            if (panel_add_habit.Location.Y < 700)
                panel_add_habit.SetBounds(0, panel_add_habit.Location.Y + 15, 400, 700);
            else
                timer_scrolldown.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel_add_habit.SetBounds(0, panel_add_habit.Location.Y, 400, 700);
            panel_display.Enabled = true;
            timer_scrolldown.Enabled = true;
            add_habit_mode = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label_display_habit.Text = "Water Dreinking";
            add_habit_mode = 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label_display_habit.Text = "Workout";
            add_habit_mode = 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label_display_habit.Text = "Meditation";
            add_habit_mode = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label_display_habit.Text = "Study";
            add_habit_mode = 4;
        }

        private void button_habit1_Click(object sender, EventArgs e)
        {
            ++data.water.completed_times;
            pictureBox1.BackgroundImage = checked_pic;
            button_habit1.Enabled = false;
        }

        private void button_habit2_Click(object sender, EventArgs e)
        {
            ++data.workout.completed_times;
            pictureBox2.BackgroundImage = checked_pic;
            button_habit2.Enabled = false;
        }

        private void button_habit3_Click(object sender, EventArgs e)
        {
            ++data.meditation.completed_times;
            pictureBox3.BackgroundImage = checked_pic;
            button_habit3.Enabled = false;
        }

        private void button_habit4_Click(object sender, EventArgs e)
        {
            ++data.study.completed_times;
            pictureBox4.BackgroundImage = checked_pic;
            button_habit4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int full;
            if(data.water.completed_times == 0)
            {
                this.circleProgressBar.Progress = 0;
                return;
            }
            else
            {
                full = data.water.completed_times * 100 / data.water.total_times;
            }
            int sleep = 1000 / full;
            // 畫進度條
            Thread thread = new Thread(new ThreadStart(new Action(delegate
            {

                for (int i = 0; i < full; i++)
                {
                    Thread.Sleep(sleep);
                    this.circleProgressBar.Progress = i + 1;
                }
            })));
            thread.IsBackground = true;
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int full;
            if (data.workout.completed_times == 0)
            {
                this.circleProgressBar.Progress = 0;
                return;
            }
            else
            {
                full = data.workout.completed_times * 100 / data.workout.total_times;
            }
            int sleep = 1000 / full;
            // 畫進度條
            Thread thread = new Thread(new ThreadStart(new Action(delegate
            {

                for (int i = 0; i < full; i++)
                {
                    Thread.Sleep(sleep);
                    this.circleProgressBar.Progress = i + 1;
                }
            })));
            thread.IsBackground = true;
            thread.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int full;
            if (data.meditation.completed_times == 0)
            {
                this.circleProgressBar.Progress = 0;
                return;
            }
            else
            {
                full = data.meditation.completed_times * 100 / data.meditation.total_times;
            }
            int sleep = 1000 / full;
            // 畫進度條
            Thread thread = new Thread(new ThreadStart(new Action(delegate
            {

                for (int i = 0; i < full; i++)
                {
                    Thread.Sleep(sleep);
                    this.circleProgressBar.Progress = i + 1;
                }
            })));
            thread.IsBackground = true;
            thread.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int full = 1;
            if (data.study.completed_times == 0)
            {
                this.circleProgressBar.Progress = 0;
                return;
            }
            else
            {
                full = data.study.completed_times * 100 / data.study.total_times;
            }
            int sleep = 1000 / full;
            // 畫進度條
            Thread thread = new Thread(new ThreadStart(new Action(delegate
            {

                for (int i = 0; i < full; i++)
                {
                    Thread.Sleep(sleep);
                    this.circleProgressBar.Progress = i + 1;
                }
            })));
            thread.IsBackground = true;
            thread.Start();
        }
    }
}
