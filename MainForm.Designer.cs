
namespace DesktopCalendar
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.codeeloGradientPanel2 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.codeeloGradientPanel3 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.AppointmentInfoPanel = new System.Windows.Forms.Panel();
            this.appointmentViewPanel1 = new DesktopCalendar.AppointmentViewPanel();
            this.MonthNavigationPanel = new System.Windows.Forms.Panel();
            this.DecemberButton = new System.Windows.Forms.Button();
            this.NovemberButton = new System.Windows.Forms.Button();
            this.OctoberButton = new System.Windows.Forms.Button();
            this.SeptemberButton = new System.Windows.Forms.Button();
            this.AugustButton = new System.Windows.Forms.Button();
            this.JulyButton = new System.Windows.Forms.Button();
            this.JuneButton = new System.Windows.Forms.Button();
            this.MayButton = new System.Windows.Forms.Button();
            this.AprilButton = new System.Windows.Forms.Button();
            this.MarchButton = new System.Windows.Forms.Button();
            this.FebruaryButton = new System.Windows.Forms.Button();
            this.JanuaryButton = new System.Windows.Forms.Button();
            this.YearNavigationPanel = new System.Windows.Forms.Panel();
            this.YearButton = new System.Windows.Forms.Button();
            this.PreviousYearButton = new System.Windows.Forms.Button();
            this.NextYearButton = new System.Windows.Forms.Button();
            this.codeeloGradientPanel1 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.codeeloGradientPanel3.SuspendLayout();
            this.AppointmentInfoPanel.SuspendLayout();
            this.MonthNavigationPanel.SuspendLayout();
            this.YearNavigationPanel.SuspendLayout();
            this.codeeloGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // codeeloGradientPanel2
            // 
            this.codeeloGradientPanel2.AccessibleRole = null;
            this.codeeloGradientPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.codeeloGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeeloGradientPanel2.CausesValidation = false;
            this.codeeloGradientPanel2.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.codeeloGradientPanel2.ColorFillSecond = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.codeeloGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeeloGradientPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel2.Location = new System.Drawing.Point(0, 19);
            this.codeeloGradientPanel2.Name = "codeeloGradientPanel2";
            this.codeeloGradientPanel2.Size = new System.Drawing.Size(1053, 606);
            this.codeeloGradientPanel2.TabIndex = 3;
            // 
            // codeeloGradientPanel3
            // 
            this.codeeloGradientPanel3.AccessibleRole = null;
            this.codeeloGradientPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel3.CausesValidation = false;
            this.codeeloGradientPanel3.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.codeeloGradientPanel3.ColorFillSecond = System.Drawing.Color.Gray;
            this.codeeloGradientPanel3.Controls.Add(this.AppointmentInfoPanel);
            this.codeeloGradientPanel3.Controls.Add(this.MonthNavigationPanel);
            this.codeeloGradientPanel3.Controls.Add(this.YearNavigationPanel);
            this.codeeloGradientPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.codeeloGradientPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel3.Location = new System.Drawing.Point(1053, 19);
            this.codeeloGradientPanel3.Name = "codeeloGradientPanel3";
            this.codeeloGradientPanel3.Size = new System.Drawing.Size(392, 609);
            this.codeeloGradientPanel3.TabIndex = 2;
            // 
            // AppointmentInfoPanel
            // 
            this.AppointmentInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.AppointmentInfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AppointmentInfoPanel.Controls.Add(this.appointmentViewPanel1);
            this.AppointmentInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppointmentInfoPanel.ForeColor = System.Drawing.Color.White;
            this.AppointmentInfoPanel.Location = new System.Drawing.Point(0, 42);
            this.AppointmentInfoPanel.Name = "AppointmentInfoPanel";
            this.AppointmentInfoPanel.Size = new System.Drawing.Size(255, 567);
            this.AppointmentInfoPanel.TabIndex = 2;
            // 
            // appointmentViewPanel1
            // 
            this.appointmentViewPanel1.BackColor = System.Drawing.Color.Black;
            this.appointmentViewPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appointmentViewPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointmentViewPanel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.appointmentViewPanel1.Location = new System.Drawing.Point(0, 0);
            this.appointmentViewPanel1.Name = "appointmentViewPanel1";
            this.appointmentViewPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.appointmentViewPanel1.Size = new System.Drawing.Size(255, 564);
            this.appointmentViewPanel1.TabIndex = 0;
            // 
            // MonthNavigationPanel
            // 
            this.MonthNavigationPanel.BackColor = System.Drawing.Color.White;
            this.MonthNavigationPanel.Controls.Add(this.DecemberButton);
            this.MonthNavigationPanel.Controls.Add(this.NovemberButton);
            this.MonthNavigationPanel.Controls.Add(this.OctoberButton);
            this.MonthNavigationPanel.Controls.Add(this.SeptemberButton);
            this.MonthNavigationPanel.Controls.Add(this.AugustButton);
            this.MonthNavigationPanel.Controls.Add(this.JulyButton);
            this.MonthNavigationPanel.Controls.Add(this.JuneButton);
            this.MonthNavigationPanel.Controls.Add(this.MayButton);
            this.MonthNavigationPanel.Controls.Add(this.AprilButton);
            this.MonthNavigationPanel.Controls.Add(this.MarchButton);
            this.MonthNavigationPanel.Controls.Add(this.FebruaryButton);
            this.MonthNavigationPanel.Controls.Add(this.JanuaryButton);
            this.MonthNavigationPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MonthNavigationPanel.Location = new System.Drawing.Point(255, 42);
            this.MonthNavigationPanel.Name = "MonthNavigationPanel";
            this.MonthNavigationPanel.Size = new System.Drawing.Size(137, 567);
            this.MonthNavigationPanel.TabIndex = 1;
            // 
            // DecemberButton
            // 
            this.DecemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.DecemberButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecemberButton.FlatAppearance.BorderSize = 0;
            this.DecemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecemberButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecemberButton.ForeColor = System.Drawing.Color.White;
            this.DecemberButton.Image = global::PlansOfTheDay.Properties.Resources.icons8_december_32;
            this.DecemberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DecemberButton.Location = new System.Drawing.Point(0, 500);
            this.DecemberButton.Name = "DecemberButton";
            this.DecemberButton.Size = new System.Drawing.Size(137, 67);
            this.DecemberButton.TabIndex = 12;
            this.DecemberButton.Text = "Декабрь";
            this.DecemberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DecemberButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DecemberButton.UseVisualStyleBackColor = false;
            // 
            // NovemberButton
            // 
            this.NovemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.NovemberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NovemberButton.FlatAppearance.BorderSize = 0;
            this.NovemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NovemberButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NovemberButton.ForeColor = System.Drawing.Color.White;
            this.NovemberButton.Image = global::PlansOfTheDay.Properties.Resources.icons8_november_32;
            this.NovemberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NovemberButton.Location = new System.Drawing.Point(0, 455);
            this.NovemberButton.Name = "NovemberButton";
            this.NovemberButton.Size = new System.Drawing.Size(137, 45);
            this.NovemberButton.TabIndex = 11;
            this.NovemberButton.Text = "Ноябрь";
            this.NovemberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NovemberButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NovemberButton.UseVisualStyleBackColor = false;
            // 
            // OctoberButton
            // 
            this.OctoberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.OctoberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OctoberButton.FlatAppearance.BorderSize = 0;
            this.OctoberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OctoberButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OctoberButton.ForeColor = System.Drawing.Color.White;
            this.OctoberButton.Image = global::PlansOfTheDay.Properties.Resources.icons8_october_32;
            this.OctoberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OctoberButton.Location = new System.Drawing.Point(0, 409);
            this.OctoberButton.Name = "OctoberButton";
            this.OctoberButton.Size = new System.Drawing.Size(137, 46);
            this.OctoberButton.TabIndex = 10;
            this.OctoberButton.Text = "Октябрь";
            this.OctoberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OctoberButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OctoberButton.UseVisualStyleBackColor = false;
            // 
            // SeptemberButton
            // 
            this.SeptemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.SeptemberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeptemberButton.FlatAppearance.BorderSize = 0;
            this.SeptemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeptemberButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeptemberButton.ForeColor = System.Drawing.Color.White;
            this.SeptemberButton.Image = global::PlansOfTheDay.Properties.Resources.icons8_september_32;
            this.SeptemberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeptemberButton.Location = new System.Drawing.Point(0, 364);
            this.SeptemberButton.Name = "SeptemberButton";
            this.SeptemberButton.Size = new System.Drawing.Size(137, 45);
            this.SeptemberButton.TabIndex = 9;
            this.SeptemberButton.Text = "Сентябрь";
            this.SeptemberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeptemberButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SeptemberButton.UseVisualStyleBackColor = false;
            // 
            // AugustButton
            // 
            this.AugustButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.AugustButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AugustButton.FlatAppearance.BorderSize = 0;
            this.AugustButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AugustButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AugustButton.ForeColor = System.Drawing.Color.White;
            this.AugustButton.Image = global::PlansOfTheDay.Properties.Resources.icons8_august_32;
            this.AugustButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AugustButton.Location = new System.Drawing.Point(0, 318);
            this.AugustButton.Name = "AugustButton";
            this.AugustButton.Size = new System.Drawing.Size(137, 46);
            this.AugustButton.TabIndex = 8;
            this.AugustButton.Text = "Август";
            this.AugustButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AugustButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AugustButton.UseVisualStyleBackColor = false;
            // 
            // JulyButton
            // 
            this.JulyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.JulyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.JulyButton.FlatAppearance.BorderSize = 0;
            this.JulyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JulyButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JulyButton.ForeColor = System.Drawing.Color.White;
            this.JulyButton.Image = global::PlansOfTheDay.Properties.Resources.icons8_july_32;
            this.JulyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JulyButton.Location = new System.Drawing.Point(0, 273);
            this.JulyButton.Name = "JulyButton";
            this.JulyButton.Size = new System.Drawing.Size(137, 45);
            this.JulyButton.TabIndex = 7;
            this.JulyButton.Text = "Июль";
            this.JulyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JulyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.JulyButton.UseVisualStyleBackColor = false;
            // 
            // JuneButton
            // 
            this.JuneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.JuneButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.JuneButton.FlatAppearance.BorderSize = 0;
            this.JuneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JuneButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JuneButton.ForeColor = System.Drawing.Color.White;
            this.JuneButton.Image = global::PlansOfTheDay.Properties.Resources.icons8_june_32;
            this.JuneButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JuneButton.Location = new System.Drawing.Point(0, 227);
            this.JuneButton.Name = "JuneButton";
            this.JuneButton.Size = new System.Drawing.Size(137, 46);
            this.JuneButton.TabIndex = 6;
            this.JuneButton.Text = "Июнь";
            this.JuneButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JuneButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.JuneButton.UseVisualStyleBackColor = false;
            // 
            // MayButton
            // 
            this.MayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.MayButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MayButton.FlatAppearance.BorderSize = 0;
            this.MayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MayButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MayButton.ForeColor = System.Drawing.Color.White;
            this.MayButton.Image = global::PlansOfTheDay.Properties.Resources.icons8_may_32;
            this.MayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MayButton.Location = new System.Drawing.Point(0, 182);
            this.MayButton.Name = "MayButton";
            this.MayButton.Size = new System.Drawing.Size(137, 45);
            this.MayButton.TabIndex = 5;
            this.MayButton.Text = "Май";
            this.MayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MayButton.UseVisualStyleBackColor = false;
            // 
            // AprilButton
            // 
            this.AprilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.AprilButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AprilButton.FlatAppearance.BorderSize = 0;
            this.AprilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AprilButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AprilButton.ForeColor = System.Drawing.Color.White;
            this.AprilButton.Image = global::PlansOfTheDay.Properties.Resources.icons8_april_32;
            this.AprilButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AprilButton.Location = new System.Drawing.Point(0, 136);
            this.AprilButton.Name = "AprilButton";
            this.AprilButton.Size = new System.Drawing.Size(137, 46);
            this.AprilButton.TabIndex = 4;
            this.AprilButton.Text = "Апрель";
            this.AprilButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AprilButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AprilButton.UseVisualStyleBackColor = false;
            // 
            // MarchButton
            // 
            this.MarchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.MarchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MarchButton.FlatAppearance.BorderSize = 0;
            this.MarchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarchButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarchButton.ForeColor = System.Drawing.Color.White;
            this.MarchButton.Image = global::PlansOfTheDay.Properties.Resources.icons8_march_32;
            this.MarchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MarchButton.Location = new System.Drawing.Point(0, 91);
            this.MarchButton.Name = "MarchButton";
            this.MarchButton.Size = new System.Drawing.Size(137, 45);
            this.MarchButton.TabIndex = 3;
            this.MarchButton.Text = "Март";
            this.MarchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MarchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MarchButton.UseVisualStyleBackColor = false;
            // 
            // FebruaryButton
            // 
            this.FebruaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.FebruaryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FebruaryButton.FlatAppearance.BorderSize = 0;
            this.FebruaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FebruaryButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FebruaryButton.ForeColor = System.Drawing.Color.White;
            this.FebruaryButton.Image = global::PlansOfTheDay.Properties.Resources.icons8_february_32;
            this.FebruaryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FebruaryButton.Location = new System.Drawing.Point(0, 45);
            this.FebruaryButton.Name = "FebruaryButton";
            this.FebruaryButton.Size = new System.Drawing.Size(137, 46);
            this.FebruaryButton.TabIndex = 2;
            this.FebruaryButton.Text = "Февраль";
            this.FebruaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FebruaryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FebruaryButton.UseVisualStyleBackColor = false;
            // 
            // JanuaryButton
            // 
            this.JanuaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.JanuaryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.JanuaryButton.FlatAppearance.BorderSize = 0;
            this.JanuaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JanuaryButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JanuaryButton.ForeColor = System.Drawing.Color.White;
            this.JanuaryButton.Image = global::PlansOfTheDay.Properties.Resources.icons8_january_32;
            this.JanuaryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JanuaryButton.Location = new System.Drawing.Point(0, 0);
            this.JanuaryButton.Name = "JanuaryButton";
            this.JanuaryButton.Size = new System.Drawing.Size(137, 45);
            this.JanuaryButton.TabIndex = 1;
            this.JanuaryButton.Text = "Январь";
            this.JanuaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JanuaryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.JanuaryButton.UseVisualStyleBackColor = false;
            // 
            // YearNavigationPanel
            // 
            this.YearNavigationPanel.BackColor = System.Drawing.Color.White;
            this.YearNavigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearNavigationPanel.Controls.Add(this.YearButton);
            this.YearNavigationPanel.Controls.Add(this.PreviousYearButton);
            this.YearNavigationPanel.Controls.Add(this.NextYearButton);
            this.YearNavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.YearNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.YearNavigationPanel.Name = "YearNavigationPanel";
            this.YearNavigationPanel.Size = new System.Drawing.Size(392, 42);
            this.YearNavigationPanel.TabIndex = 0;
            // 
            // YearButton
            // 
            this.YearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.YearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearButton.FlatAppearance.BorderSize = 0;
            this.YearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearButton.ForeColor = System.Drawing.Color.White;
            this.YearButton.Location = new System.Drawing.Point(75, 0);
            this.YearButton.Name = "YearButton";
            this.YearButton.Size = new System.Drawing.Size(240, 40);
            this.YearButton.TabIndex = 2;
            this.YearButton.Text = "ГОД";
            this.YearButton.UseVisualStyleBackColor = false;
            // 
            // PreviousYearButton
            // 
            this.PreviousYearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.PreviousYearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreviousYearButton.FlatAppearance.BorderSize = 0;
            this.PreviousYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousYearButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousYearButton.ForeColor = System.Drawing.Color.White;
            this.PreviousYearButton.Location = new System.Drawing.Point(0, 0);
            this.PreviousYearButton.Name = "PreviousYearButton";
            this.PreviousYearButton.Size = new System.Drawing.Size(75, 40);
            this.PreviousYearButton.TabIndex = 1;
            this.PreviousYearButton.Text = "<<";
            this.PreviousYearButton.UseVisualStyleBackColor = false;
            this.PreviousYearButton.Click += new System.EventHandler(this.PreviousYearButton_Click);
            // 
            // NextYearButton
            // 
            this.NextYearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.NextYearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextYearButton.FlatAppearance.BorderSize = 0;
            this.NextYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextYearButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextYearButton.ForeColor = System.Drawing.Color.White;
            this.NextYearButton.Location = new System.Drawing.Point(315, 0);
            this.NextYearButton.Name = "NextYearButton";
            this.NextYearButton.Size = new System.Drawing.Size(75, 40);
            this.NextYearButton.TabIndex = 0;
            this.NextYearButton.Text = ">>";
            this.NextYearButton.UseVisualStyleBackColor = false;
            this.NextYearButton.Click += new System.EventHandler(this.NextYearButton_Click);
            // 
            // codeeloGradientPanel1
            // 
            this.codeeloGradientPanel1.AccessibleRole = null;
            this.codeeloGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel1.CausesValidation = false;
            this.codeeloGradientPanel1.ColorFillFirst = System.Drawing.Color.LightGray;
            this.codeeloGradientPanel1.ColorFillSecond = System.Drawing.Color.LightGray;
            this.codeeloGradientPanel1.Controls.Add(this.btnExit);
            this.codeeloGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeeloGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.codeeloGradientPanel1.Name = "codeeloGradientPanel1";
            this.codeeloGradientPanel1.Size = new System.Drawing.Size(1445, 19);
            this.codeeloGradientPanel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::PlansOfTheDay.Properties.Resources.btnExit;
            this.btnExit.Location = new System.Drawing.Point(1425, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 15);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 13;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1445, 628);
            this.Controls.Add(this.codeeloGradientPanel2);
            this.Controls.Add(this.codeeloGradientPanel3);
            this.Controls.Add(this.codeeloGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskOfTheDay";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.codeeloGradientPanel3.ResumeLayout(false);
            this.AppointmentInfoPanel.ResumeLayout(false);
            this.MonthNavigationPanel.ResumeLayout(false);
            this.YearNavigationPanel.ResumeLayout(false);
            this.codeeloGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel1;
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel3;
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel2;
        private System.Windows.Forms.Panel AppointmentInfoPanel;
        private System.Windows.Forms.Panel MonthNavigationPanel;
        private System.Windows.Forms.Button DecemberButton;
        private System.Windows.Forms.Button NovemberButton;
        private System.Windows.Forms.Button OctoberButton;
        private System.Windows.Forms.Button SeptemberButton;
        private System.Windows.Forms.Button AugustButton;
        private System.Windows.Forms.Button JulyButton;
        private System.Windows.Forms.Button JuneButton;
        private System.Windows.Forms.Button MayButton;
        private System.Windows.Forms.Button AprilButton;
        private System.Windows.Forms.Button MarchButton;
        private System.Windows.Forms.Button FebruaryButton;
        private System.Windows.Forms.Button JanuaryButton;
        private System.Windows.Forms.Panel YearNavigationPanel;
        private System.Windows.Forms.Button YearButton;
        private System.Windows.Forms.Button PreviousYearButton;
        private System.Windows.Forms.Button NextYearButton;
        private System.Windows.Forms.PictureBox btnExit;
        public AppointmentViewPanel appointmentViewPanel1;
    }
}

