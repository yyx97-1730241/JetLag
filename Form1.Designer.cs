namespace jetlag
{
    partial class frame
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
            this.time_conversion = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.GroupBox();
            this.result_box = new System.Windows.Forms.TextBox();
            this.input_zone = new System.Windows.Forms.ComboBox();
            this.output_zone = new System.Windows.Forms.ComboBox();
            this.convert_button = new System.Windows.Forms.Button();
            this.year_box = new System.Windows.Forms.TextBox();
            this.month_box = new System.Windows.Forms.TextBox();
            this.day_box = new System.Windows.Forms.TextBox();
            this.hour_box = new System.Windows.Forms.TextBox();
            this.minute_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.winter_time = new System.Windows.Forms.CheckBox();
            this.transfer = new System.Windows.Forms.Button();
            this.result.SuspendLayout();
            this.SuspendLayout();
            // 
            // time_conversion
            // 
            this.time_conversion.AutoSize = true;
            this.time_conversion.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_conversion.Location = new System.Drawing.Point(58, 34);
            this.time_conversion.Name = "time_conversion";
            this.time_conversion.Size = new System.Drawing.Size(99, 33);
            this.time_conversion.TabIndex = 0;
            this.time_conversion.Text = "时区转换";
            this.time_conversion.Click += new System.EventHandler(this.label1_Click);
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(58, 83);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(57, 33);
            this.year.TabIndex = 1;
            this.year.Text = "年份";
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.Location = new System.Drawing.Point(58, 130);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(57, 33);
            this.month.TabIndex = 2;
            this.month.Text = "月份";
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.Location = new System.Drawing.Point(58, 179);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(57, 33);
            this.day.TabIndex = 3;
            this.day.Text = "日期";
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.Location = new System.Drawing.Point(58, 224);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(57, 33);
            this.hour.TabIndex = 4;
            this.hour.Text = "小时";
            // 
            // minute
            // 
            this.minute.AutoSize = true;
            this.minute.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute.Location = new System.Drawing.Point(58, 270);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(57, 33);
            this.minute.TabIndex = 5;
            this.minute.Text = "分钟";
            // 
            // result
            // 
            this.result.Controls.Add(this.result_box);
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(54, 328);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(430, 101);
            this.result.TabIndex = 6;
            this.result.TabStop = false;
            this.result.Text = "转换结果";
            // 
            // result_box
            // 
            this.result_box.Enabled = false;
            this.result_box.Location = new System.Drawing.Point(32, 28);
            this.result_box.Multiline = true;
            this.result_box.Name = "result_box";
            this.result_box.ReadOnly = true;
            this.result_box.Size = new System.Drawing.Size(364, 59);
            this.result_box.TabIndex = 0;
            // 
            // input_zone
            // 
            this.input_zone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_zone.FormattingEnabled = true;
            this.input_zone.Items.AddRange(new object[] {
            "北京时间",
            "美西时间",
            "美东时间"});
            this.input_zone.Location = new System.Drawing.Point(178, 39);
            this.input_zone.Name = "input_zone";
            this.input_zone.Size = new System.Drawing.Size(103, 28);
            this.input_zone.TabIndex = 7;
            this.input_zone.Text = "输入时区";
            // 
            // output_zone
            // 
            this.output_zone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_zone.FormattingEnabled = true;
            this.output_zone.Items.AddRange(new object[] {
            "北京时间",
            "美西时间",
            "美东时间"});
            this.output_zone.Location = new System.Drawing.Point(367, 39);
            this.output_zone.Name = "output_zone";
            this.output_zone.Size = new System.Drawing.Size(103, 28);
            this.output_zone.TabIndex = 8;
            this.output_zone.Text = "输出时区";
            // 
            // convert_button
            // 
            this.convert_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.convert_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_button.Location = new System.Drawing.Point(494, 23);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(64, 57);
            this.convert_button.TabIndex = 10;
            this.convert_button.Text = "转换";
            this.convert_button.UseVisualStyleBackColor = false;
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // year_box
            // 
            this.year_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_box.Location = new System.Drawing.Point(178, 89);
            this.year_box.Name = "year_box";
            this.year_box.Size = new System.Drawing.Size(100, 26);
            this.year_box.TabIndex = 11;
            this.year_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // month_box
            // 
            this.month_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_box.Location = new System.Drawing.Point(178, 135);
            this.month_box.Name = "month_box";
            this.month_box.Size = new System.Drawing.Size(100, 26);
            this.month_box.TabIndex = 12;
            this.month_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // day_box
            // 
            this.day_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_box.Location = new System.Drawing.Point(178, 184);
            this.day_box.Name = "day_box";
            this.day_box.Size = new System.Drawing.Size(100, 26);
            this.day_box.TabIndex = 13;
            this.day_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hour_box
            // 
            this.hour_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_box.Location = new System.Drawing.Point(178, 231);
            this.hour_box.Name = "hour_box";
            this.hour_box.Size = new System.Drawing.Size(100, 26);
            this.hour_box.TabIndex = 14;
            this.hour_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minute_box
            // 
            this.minute_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute_box.Location = new System.Drawing.Point(178, 275);
            this.minute_box.Name = "minute_box";
            this.minute_box.Size = new System.Drawing.Size(100, 26);
            this.minute_box.TabIndex = 15;
            this.minute_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 33);
            this.label3.TabIndex = 18;
            this.label3.Text = "日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 33);
            this.label4.TabIndex = 19;
            this.label4.Text = "时";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 33);
            this.label5.TabIndex = 20;
            this.label5.Text = "分";
            // 
            // winter_time
            // 
            this.winter_time.AutoSize = true;
            this.winter_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winter_time.Location = new System.Drawing.Point(384, 73);
            this.winter_time.Name = "winter_time";
            this.winter_time.Size = new System.Drawing.Size(89, 28);
            this.winter_time.TabIndex = 21;
            this.winter_time.Text = "冬令时";
            this.winter_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winter_time.UseVisualStyleBackColor = true;
            // 
            // transfer
            // 
            this.transfer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfer.ForeColor = System.Drawing.Color.DarkBlue;
            this.transfer.Location = new System.Drawing.Point(302, 39);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(50, 29);
            this.transfer.TabIndex = 22;
            this.transfer.Text = "交换";
            this.transfer.UseVisualStyleBackColor = false;
            this.transfer.Click += new System.EventHandler(this.transfer_Click_1);
            // 
            // frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 446);
            this.Controls.Add(this.transfer);
            this.Controls.Add(this.winter_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minute_box);
            this.Controls.Add(this.hour_box);
            this.Controls.Add(this.day_box);
            this.Controls.Add(this.month_box);
            this.Controls.Add(this.year_box);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.output_zone);
            this.Controls.Add(this.input_zone);
            this.Controls.Add(this.result);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.day);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.time_conversion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frame";
            this.Text = "JetLag";
            this.result.ResumeLayout(false);
            this.result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time_conversion;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label minute;
        private System.Windows.Forms.GroupBox result;
        private System.Windows.Forms.ComboBox input_zone;
        private System.Windows.Forms.ComboBox output_zone;
        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.TextBox year_box;
        private System.Windows.Forms.TextBox month_box;
        private System.Windows.Forms.TextBox day_box;
        private System.Windows.Forms.TextBox hour_box;
        private System.Windows.Forms.TextBox minute_box;
        private System.Windows.Forms.TextBox result_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox winter_time;
        private System.Windows.Forms.Button transfer;
    }
}

