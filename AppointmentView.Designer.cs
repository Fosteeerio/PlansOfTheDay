namespace DesktopCalendar
{
    partial class AppointmentView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isCompletedIcon = new System.Windows.Forms.PictureBox();
            this.btnComments = new System.Windows.Forms.PictureBox();
            this.inProgressIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.isCompletedIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProgressIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(11)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // isCompletedIcon
            // 
            this.isCompletedIcon.Image = global::PlansOfTheDay.Properties.Resources.isComplete;
            this.isCompletedIcon.Location = new System.Drawing.Point(4, 2);
            this.isCompletedIcon.Name = "isCompletedIcon";
            this.isCompletedIcon.Size = new System.Drawing.Size(25, 25);
            this.isCompletedIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.isCompletedIcon.TabIndex = 7;
            this.isCompletedIcon.TabStop = false;
            this.isCompletedIcon.Visible = false;
            // 
            // btnComments
            // 
            this.btnComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComments.BackColor = System.Drawing.Color.Transparent;
            this.btnComments.Image = global::PlansOfTheDay.Properties.Resources.comment;
            this.btnComments.Location = new System.Drawing.Point(222, 2);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(25, 25);
            this.btnComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnComments.TabIndex = 6;
            this.btnComments.TabStop = false;
            this.btnComments.Visible = false;
            // 
            // inProgressIcon
            // 
            this.inProgressIcon.BackColor = System.Drawing.Color.Transparent;
            this.inProgressIcon.Image = global::PlansOfTheDay.Properties.Resources.inProgress;
            this.inProgressIcon.Location = new System.Drawing.Point(4, 2);
            this.inProgressIcon.Name = "inProgressIcon";
            this.inProgressIcon.Size = new System.Drawing.Size(25, 25);
            this.inProgressIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inProgressIcon.TabIndex = 5;
            this.inProgressIcon.TabStop = false;
            // 
            // AppointmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.isCompletedIcon);
            this.Controls.Add(this.btnComments);
            this.Controls.Add(this.inProgressIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AppointmentView";
            this.Size = new System.Drawing.Size(250, 90);
            this.Load += new System.EventHandler(this.AppointmentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.isCompletedIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProgressIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox inProgressIcon;
        private System.Windows.Forms.PictureBox btnComments;
        private System.Windows.Forms.PictureBox isCompletedIcon;
    }
}
