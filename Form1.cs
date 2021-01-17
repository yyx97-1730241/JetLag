using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace jetlag
{
    public partial class frame : Form
    {
        public frame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void convert_button_Click(object sender, EventArgs e)
        {
            // 转换结果先打出输入时区, 再打出输出时区
            // todo@ 年份不超过12, 月份不超过31, 小时不超过24, 分钟不超过60
            // todo@ 增加冬令时/夏令时转换 ✔
            // todo@ input output 一键转换 ✔


            int US_WEST_CHINA = winter_time.Checked ? 16 : 15;
            int US_WEST_US_EAST = 3;
            int US_EAST_CHINA = US_WEST_CHINA - US_WEST_US_EAST;

            string input = input_zone.SelectedItem?.ToString();
            string output = output_zone.SelectedItem?.ToString();
            Annual year = (Annual)year_box.Text;
            Annual month = (Annual)month_box.Text;
            Annual day = (Annual)day_box.Text;
            Annual hour = (Annual)hour_box.Text;
            Annual minute = (Annual)minute_box.Text;
            result_box.Text = $"{input}: {year}年 {month}月 {day}日 {hour}时 {minute}分 ";



            // 美西时间转成北京时间
            if ((input == "美西时间") && (output == "北京时间"))
            {

                hour.Value += US_WEST_CHINA;
            }

            // 美西时间转成美东时间
            if ((input == "美西时间") && (output == "美东时间"))
            {
   
                hour.Value += US_WEST_US_EAST;
            }

            // 北京时间转成美西时间
            if ((input == "北京时间") && (output == "美西时间"))
            {

                hour.Value -= US_WEST_CHINA;
            }

            // 北京时间转成美东时间
            if ((input == "北京时间") && (output == "美东时间"))
            {

                hour.Value -= US_EAST_CHINA;
            }

            // 美东时间转成美西时间
            if ((input == "美东时间") && (output == "美西时间"))
            {

                hour.Value -= US_WEST_US_EAST;
            }

            // 美东时间转成北京时间
            if ((input == "美东时间") && (output == "北京时间"))
            {

                hour.Value += US_EAST_CHINA;
            }

            if (hour.Value > 23)
            {
                hour.Value -= 24;
                day.Value += 1;

                // 平年2月28天
                if (day.Value > 28 && month.Value == 2 && year.Value % 4 != 0)
                {

                    day.Value -= 28;
                    month.Value += 1;
                }

                // 闰年2月29天
                if (day.Value > 29 && month.Value == 2 && year.Value % 4 == 0)
                {
                    day.Value -= 29;
                    month.Value += 1;
                }

                // 小月每月30天
                if (day.Value > 30 && (
                                       month.Value == 4 |
                                       month.Value == 6 |
                                       month.Value == 9 |
                                       month.Value == 11))
                {
                    day.Value -= 30;
                    month.Value += 1;
                }

                // 大月每月31天
                if (day.Value > 31 && (month.Value == 1 |
                                       month.Value == 3 |
                                       month.Value == 5 |
                                       month.Value == 7 |
                                       month.Value == 8 |
                                       month.Value == 10 |
                                       month.Value == 12))
                {
                    day.Value -= 31;
                    month.Value += 1;
                }

                // 大于12月31日需要加年份
                if (month.Value > 12)
                {
                    month.Value -= 12;
                    year.Value += 1;
                }
            }

            if (hour.Value < 0)
            {
                hour.Value += 24;
                day.Value -= 1;

                // 平年2月28天
                if (day.Value < 1 && month.Value == 3 && year.Value % 4 != 0)
                {

                    day.Value += 28;
                    month.Value -= 1;
                }

                // 闰年2月29天
                if (day.Value < 1 && month.Value == 3 && year.Value % 4 == 0)
                {
                    day.Value += 29;
                    month.Value -= 1;
                }

                // 小月每月30天
                if (day.Value < 1 && (month.Value == 1 |
                                      month.Value == 4 |
                                      month.Value == 6 |
                                      month.Value == 9 |
                                      month.Value == 11))

                {
                    day.Value += 31;
                    month.Value -= 1;
                }

                // 大月每月31天
                if (day.Value < 1 && (month.Value == 3 |
                                      month.Value == 5 |
                                      month.Value == 7 |
                                      month.Value == 8 |
                                      month.Value == 10 |
                                      month.Value == 12))
                {

                    day.Value += 30;
                    month.Value -= 1;
                }

                // 小于12月31日需要减年份
                if (month.Value < 1)
                {
                    month.Value += 12;
                    year.Value -= 1;
                }
            }
            result_box.Text +=  $"{Environment.NewLine}{output}: {year}年 {month}月 {day}日 {hour}时 {minute}分";
        }


        private void transfer_Click_1(object sender, EventArgs e)
        {
            string temp = input_zone.SelectedItem?.ToString();
            input_zone.SelectedItem = output_zone.SelectedItem;
            output_zone.SelectedItem = temp;
        }
    }
}


