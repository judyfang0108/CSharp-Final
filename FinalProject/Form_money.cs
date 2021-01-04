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
    public partial class Form_money : Form
    {
        public Boolean isexpense;
        public Boolean isincome;
        Boolean isstatistics;
        DateTime dt;
        int day_total_expense;
        int day_total_income;
        int month_total_expense;
        int month_total_income;
        int day_eat_expense;
        int day_cloth_expense;
        int day_live_expense;
        int day_move_expense;
        int day_edu_expense;
        int day_play_expense;
        int day_other_expense;
        int day_wage_income;
        int day_invest_income;
        int day_other_income;
        int month_eat_expense;
        int month_cloth_expense;
        int month_live_expense;
        int month_move_expense;
        int month_edu_expense;
        int month_play_expense;
        int month_other_expense;
        int month_wage_income;
        int month_invest_income;
        int month_other_income;
        //List<List<string>[]> year = new List<List<string>[]>();
        List<string>[,] month_expense_item = new List<string>[12,31];
        List<string>[,] month_income_item = new List<string>[12, 31];
        Boolean[,] isrecord_expense = new Boolean[12, 31];
        Boolean[,] isrecord_income = new Boolean[12, 31];
        int[,,] money_record = new int[12, 31, 2];//0:expense,1:income
        //List<List<string>> month = new List<List<string>>();
        public Form_money()
        {
            InitializeComponent();
        }
        private void Form_money_Load(object sender, EventArgs e)
        {
            dt = monthCalendar1.TodayDate;
            dateText.Text = dt.Year.ToString() + "/" + dt.Month.ToString() + "/" + dt.Day.ToString();
            monthCalendar1.Visible = false;
            monthCalendar1.BringToFront();
            isexpense = true;
            isincome = false;
            isstatistics = false;
            chart_page.Visible = false;
            day_total_expense = 0;
            day_total_income = 0;
            label1.Text = "$" + day_total_expense;
            for (int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 31; j++)
                {
                    month_expense_item[i,j] = new List<string>();
                    month_income_item[i, j] = new List<string>();
                }
            }
        }
        private void choose_date_Click(object sender, EventArgs e)
        {
            isexpense = true;
            isincome = false;
            isstatistics = false;
            monthCalendar1.Visible = true;
            money_record[dt.Month - 1, dt.Day - 1, 0] = day_total_expense;
            money_record[dt.Month - 1, dt.Day - 1, 1] = day_total_income;
            day_total_expense = 0;
            day_total_income = 0;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            chart_page.Visible = false;
            expense_item.Visible = true;
            dt = monthCalendar1.SelectionStart;
            dateText.Text = dt.Year.ToString() + "/" + dt.Month.ToString() + "/" + dt.Day.ToString();
            monthCalendar1.Visible = false;
            expense_item.Items.Clear();
            if (isrecord_expense[dt.Month - 1, dt.Day - 1] == true)
            {
                for (int i = 0; i < month_expense_item[dt.Month - 1, dt.Day - 1].Count(); i++)
                {
                    expense_item.Items.Add(month_expense_item[dt.Month - 1, dt.Day - 1][i]);
                }
            }
            else
            {
                expense_item.Items.Clear();
            }
            day_total_expense = money_record[dt.Month - 1, dt.Day - 1, 0];
            day_total_income = money_record[dt.Month - 1, dt.Day - 1, 1];
            label1.Text = "$" + day_total_expense;
        }

        ADD f3;
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (isstatistics == false)
            {
                f3 = new ADD(isexpense);
                f3.ShowDialog();
            }
            if (f3.isadd == true)
                if (f3.isadd == true)
            {
                if (isexpense == true)
                {
                    if (isrecord_expense[dt.Month - 1, dt.Day - 1] == false)
                    {
                        month_expense_item[dt.Month - 1, dt.Day - 1].Add(f3.category + "/" + f3.item + "/" + f3.money);
                        expense_item.Items.Add(month_expense_item[dt.Month - 1, dt.Day - 1][0]);
                        isrecord_expense[dt.Month - 1, dt.Day - 1] = true;
                        //MessageBox.Show(month[dt.Month - 1].Count().ToString());
                    }
                    else
                    {
                        month_expense_item[dt.Month - 1, dt.Day - 1].Add(f3.category + "/" + f3.item + "/" + f3.money);
                        //MessageBox.Show(month[dt.Month - 1].Count().ToString());
                        expense_item.Items.Add(month_expense_item[dt.Month - 1, dt.Day - 1][month_expense_item[dt.Month - 1, dt.Day - 1].Count() - 1]);
                    }
                    day_total_expense = day_total_expense + f3.money;
                    label1.Text = "$" + day_total_expense;
                }
                else if (isincome == true)
                {
                    if (isrecord_income[dt.Month - 1, dt.Day - 1] == false)
                    {
                        month_income_item[dt.Month - 1, dt.Day - 1].Add(f3.category + "/" + f3.item + "/" + f3.money);
                        expense_item.Items.Add(month_income_item[dt.Month - 1, dt.Day - 1][0]);
                        isrecord_income[dt.Month - 1, dt.Day - 1] = true;
                        //MessageBox.Show(month[dt.Month - 1].Count().ToString());
                    }
                    else
                    {
                        month_income_item[dt.Month - 1, dt.Day - 1].Add(f3.category + "/" + f3.item + "/" + f3.money);
                        //MessageBox.Show(month[dt.Month - 1].Count().ToString());
                        expense_item.Items.Add(month_income_item[dt.Month - 1, dt.Day - 1][month_income_item[dt.Month - 1, dt.Day - 1].Count() - 1]);
                    }
                    day_total_income = day_total_income + f3.money;
                    label1.Text = "$" + day_total_income;
                }
            }
            
            
        }

        private void expense_btn_Click(object sender, EventArgs e)
        {
            isexpense = true;
            isincome = false;
            isstatistics = false;
            expense_item.Items.Clear();
            label1.Text = "$" + day_total_expense;
            chart_page.Visible = false;
            expense_item.Visible = true;
            if (isrecord_expense[dt.Month - 1, dt.Day - 1] == true)
            {
                for (int i = 0; i < month_expense_item[dt.Month - 1, dt.Day - 1].Count(); i++)
                {
                    expense_item.Items.Add(month_expense_item[dt.Month - 1, dt.Day - 1][i]);
                }
            }
            
        }

        private void income_Click(object sender, EventArgs e)
        {
            isexpense = false;
            isincome = true;
            isstatistics = false;
            expense_item.Items.Clear();
            label1.Text = "$" + day_total_income;
            chart_page.Visible = false;
            expense_item.Visible = true;
            if (isrecord_income[dt.Month - 1, dt.Day - 1] == true)
            {
                for (int i = 0; i < month_income_item[dt.Month - 1, dt.Day - 1].Count(); i++)
                {
                    expense_item.Items.Add(month_income_item[dt.Month - 1, dt.Day - 1][i]);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            isexpense = false;
            isincome = false;
            isstatistics = true;
            chart_page.Visible = true;
            expense_item.Visible = false;
            month_total_expense = 0;
            month_total_income = 0;
            day_eat_expense = 0;
            day_cloth_expense = 0;
            day_live_expense = 0;
            day_move_expense = 0;
            day_edu_expense = 0;
            day_play_expense = 0;
            day_other_expense = 0;
            day_wage_income = 0;
            day_invest_income = 0;
            day_other_income = 0;
            month_eat_expense = 0;
            month_cloth_expense = 0;
            month_live_expense = 0;
            month_move_expense = 0;
            month_edu_expense = 0;
            month_play_expense = 0;
            month_other_expense = 0;
            month_wage_income = 0;
            month_invest_income = 0;
            month_other_income = 0;
            money_record[dt.Month - 1, dt.Day - 1, 0] = day_total_expense;
            money_record[dt.Month - 1, dt.Day - 1, 1] = day_total_income;
            //calculate month expense and income money
            for (int i = 0; i < 31; i++)
            {
                month_total_expense = month_total_expense + money_record[dt.Month-1, i, 0];
                month_total_income = month_total_income + money_record[dt.Month-1, i, 1];
            }
            //calculate everyday's every item's income money
            for (int i = 0; i < month_income_item[dt.Month - 1, dt.Day - 1].Count(); i++)
            {
                string[] split_item = month_income_item[dt.Month - 1, dt.Day - 1][i].Split('/');
                switch (split_item[0])
                {
                    case "薪水":
                        day_wage_income = day_wage_income + Convert.ToInt32(split_item[2]);
                        break;
                    case "投資":
                        day_invest_income = day_invest_income + Convert.ToInt32(split_item[2]);
                        break;
                    case "其他":
                        day_other_income = day_other_income + Convert.ToInt32(split_item[2]);
                        break;
                    default:
                        break;
                }
            }
            //calculate everyday's every item's expense money
            for (int i = 0; i < month_expense_item[dt.Month - 1, dt.Day - 1].Count(); i++)
            {
                string[] split_item = month_expense_item[dt.Month - 1, dt.Day - 1][i].Split('/');
                switch (split_item[0])
                {
                    case "食":
                        day_eat_expense = day_eat_expense + Convert.ToInt32(split_item[2]);
                        break;
                    case "衣":
                        day_cloth_expense = day_cloth_expense + Convert.ToInt32(split_item[2]);
                        break;
                    case "住":
                        day_live_expense = day_live_expense + Convert.ToInt32(split_item[2]);
                        break;
                    case "行":
                        day_move_expense = day_move_expense + Convert.ToInt32(split_item[2]);
                        break;
                    case "育":
                        day_edu_expense = day_edu_expense + Convert.ToInt32(split_item[2]);
                        break;
                    case "樂":
                        day_play_expense = day_play_expense + Convert.ToInt32(split_item[2]);
                        break;
                    case "其他":
                        day_other_expense = day_other_expense + Convert.ToInt32(split_item[2]);
                        break;
                    default:
                        break;
                }
            }
            //calculate everymonth's every item's income money
            for(int j = 0; j < 31; j++)
            {
                for (int i = 0; i < month_income_item[dt.Month - 1, j].Count(); i++)
                {
                    string[] split_item = month_income_item[dt.Month - 1, j][i].Split('/');
                    switch (split_item[0])
                    {
                        case "薪水":
                            month_wage_income = month_wage_income + Convert.ToInt32(split_item[2]);
                            break;
                        case "投資":
                            month_invest_income = month_invest_income + Convert.ToInt32(split_item[2]);
                            break;
                        case "其他":
                            month_other_income = month_other_income + Convert.ToInt32(split_item[2]);
                            break;
                        default:
                            break;
                    }
                }
            }
            //calculate everymonth's every item's expense money
            for (int j = 0; j < 31; j++)
            {
                for (int i = 0; i < month_expense_item[dt.Month - 1, j].Count(); i++)
                {
                    string[] split_item = month_expense_item[dt.Month - 1, j][i].Split('/');
                    switch (split_item[0])
                    {
                        case "食":
                            month_eat_expense = month_eat_expense + Convert.ToInt32(split_item[2]);
                            break;
                        case "衣":
                            month_cloth_expense = month_cloth_expense + Convert.ToInt32(split_item[2]);
                            break;
                        case "住":
                            month_live_expense = month_live_expense + Convert.ToInt32(split_item[2]);
                            break;
                        case "行":
                            month_move_expense = month_move_expense + Convert.ToInt32(split_item[2]);
                            break;
                        case "育":
                            month_edu_expense = month_edu_expense + Convert.ToInt32(split_item[2]);
                            break;
                        case "樂":
                            month_play_expense = month_play_expense + Convert.ToInt32(split_item[2]);
                            break;
                        case "其他":
                            month_other_expense = month_other_expense + Convert.ToInt32(split_item[2]);
                            break;
                        default:
                            break;
                    }
                }
            }
            chart1.Series["money_analyse"].Points.Clear();
            chart2.Series["money_analyse"].Points.Clear();
            chart3.Series["money_analyse"].Points.Clear();
            chart4.Series["money_analyse"].Points.Clear();
            chart5.Series["money_analyse"].Points.Clear();
            chart6.Series["money_analyse"].Points.Clear();
            //chart1.Titles.Add(dt.Year+"/"+dt.Month+"/"+dt.Day);
            chart1.Series["money_analyse"].Points.AddXY("收入", day_total_income);
            chart1.Series["money_analyse"].Points.AddXY("支出", day_total_expense);
            chart2.Series["money_analyse"].Points.AddXY("收入", month_total_income);
            chart2.Series["money_analyse"].Points.AddXY("支出", month_total_expense);
            chart3.Series["money_analyse"].Points.AddXY("薪水", day_wage_income);
            chart3.Series["money_analyse"].Points.AddXY("投資", day_invest_income);
            chart3.Series["money_analyse"].Points.AddXY("其他", day_other_income);
            chart4.Series["money_analyse"].Points.AddXY("食", day_eat_expense);
            chart4.Series["money_analyse"].Points.AddXY("衣", day_cloth_expense);
            chart4.Series["money_analyse"].Points.AddXY("住", day_live_expense);
            chart4.Series["money_analyse"].Points.AddXY("行", day_move_expense);
            chart4.Series["money_analyse"].Points.AddXY("育", day_edu_expense);
            chart4.Series["money_analyse"].Points.AddXY("樂", day_play_expense);
            chart4.Series["money_analyse"].Points.AddXY("其他", day_other_expense);
            chart5.Series["money_analyse"].Points.AddXY("薪水", month_wage_income);
            chart5.Series["money_analyse"].Points.AddXY("投資", month_invest_income);
            chart5.Series["money_analyse"].Points.AddXY("其他", month_other_income);
            chart6.Series["money_analyse"].Points.AddXY("食", month_eat_expense);
            chart6.Series["money_analyse"].Points.AddXY("衣", month_cloth_expense);
            chart6.Series["money_analyse"].Points.AddXY("住", month_live_expense);
            chart6.Series["money_analyse"].Points.AddXY("行", month_move_expense);
            chart6.Series["money_analyse"].Points.AddXY("育", month_edu_expense);
            chart6.Series["money_analyse"].Points.AddXY("樂", month_play_expense);
            chart6.Series["money_analyse"].Points.AddXY("其他", month_other_expense);
        }
        private void expense_item_DoubleClick(object sender, EventArgs e)
        {
            if (isexpense == true)
            {
                DialogResult myResult = MessageBox.Show("是否刪除"+ month_expense_item[dt.Month - 1, dt.Day - 1][expense_item.SelectedIndex]+"?", "刪除紀錄",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (myResult == DialogResult.Yes)
                {
                    string[] split_item = month_expense_item[dt.Month - 1, dt.Day - 1][expense_item.SelectedIndex].Split('/');
                    day_total_expense = day_total_expense - Convert.ToInt32(split_item[2]);
                    month_expense_item[dt.Month - 1, dt.Day - 1].Remove(month_expense_item[dt.Month - 1, dt.Day - 1][expense_item.SelectedIndex]);
                    label1.Text = "$" + day_total_expense;
                    expense_item.Items.Remove(expense_item.SelectedItem);
                }
            }
            else if (isincome == true)
            {
                DialogResult myResult = MessageBox.Show("是否刪除" + month_income_item[dt.Month - 1, dt.Day - 1][expense_item.SelectedIndex] + "?", "刪除紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (myResult == DialogResult.Yes)
                {
                    string[] split_item = month_income_item[dt.Month - 1, dt.Day - 1][expense_item.SelectedIndex].Split('/');
                    day_total_income = day_total_income - Convert.ToInt32(split_item[2]);
                    month_income_item[dt.Month - 1, dt.Day - 1].Remove(month_income_item[dt.Month - 1, dt.Day - 1][expense_item.SelectedIndex]);
                    label1.Text = "$" + day_total_income;
                    expense_item.Items.Remove(expense_item.SelectedItem);
                }
                //MessageBox.Show(month_income_item[dt.Month - 1, dt.Day - 1][expense_item.SelectedIndex] + "");
            }
        }

        private void video_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tw.yahoo.com");
        }
    }
}
