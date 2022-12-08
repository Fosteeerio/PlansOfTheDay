﻿namespace DesktopCalendar
{
    partial class AppointmentViewPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.codeeloDateTimePicker1 = new CodeeloUI.Controls.CodeeloDateTimePicker();
            this.codeeloGradientPanel1 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.SuspendLayout();
            // 
            // codeeloDateTimePicker1
            // 
            this.codeeloDateTimePicker1.BorderColor = System.Drawing.Color.Black;
            this.codeeloDateTimePicker1.BorderSize = 1;
            this.codeeloDateTimePicker1.CalendarFont = null;
            this.codeeloDateTimePicker1.CalendarForeColor = System.Drawing.Color.Empty;
            this.codeeloDateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Empty;
            this.codeeloDateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Empty;
            this.codeeloDateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Empty;
            this.codeeloDateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Empty;
            this.codeeloDateTimePicker1.Checked = false;
            this.codeeloDateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeeloDateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.codeeloDateTimePicker1.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.codeeloDateTimePicker1.Location = new System.Drawing.Point(2, 2);
            this.codeeloDateTimePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.codeeloDateTimePicker1.Name = "codeeloDateTimePicker1";
            this.codeeloDateTimePicker1.Size = new System.Drawing.Size(244, 35);
            this.codeeloDateTimePicker1.TabIndex = 2;
            // 
            // codeeloGradientPanel1
            // 
            this.codeeloGradientPanel1.AccessibleRole = null;
            this.codeeloGradientPanel1.AutoScroll = true;
            this.codeeloGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.codeeloGradientPanel1.CausesValidation = false;
            this.codeeloGradientPanel1.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.codeeloGradientPanel1.ColorFillSecond = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.codeeloGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeeloGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel1.Location = new System.Drawing.Point(2, 37);
            this.codeeloGradientPanel1.Name = "codeeloGradientPanel1";
            this.codeeloGradientPanel1.Size = new System.Drawing.Size(244, 409);
            this.codeeloGradientPanel1.TabIndex = 3;
            // 
            // AppointmentViewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.codeeloGradientPanel1);
            this.Controls.Add(this.codeeloDateTimePicker1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "AppointmentViewPanel";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(248, 448);
            this.Load += new System.EventHandler(this.AppointmentViewPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CodeeloUI.Controls.CodeeloDateTimePicker codeeloDateTimePicker1;
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel1;
    }
}
