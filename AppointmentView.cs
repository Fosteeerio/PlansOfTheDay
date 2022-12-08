using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopCalendar
{
    public partial class AppointmentView : UserControl
    {
        private Appointment _appointment;

        public AppointmentView(Appointment appointment)
        {
            InitializeComponent();
            _appointment = appointment;
            FillAppointmentCard(appointment.Title, appointment.Description);
            ContextMenuStrip = CreateMenu();
        }


        private ContextMenuStrip CreateMenu()
        {
            var contextMenuStrip = new ContextMenuStrip();
            var editAppointment = new ToolStripMenuItem();
            editAppointment.Text = "Редактировать";
            editAppointment.Click += EditAppointment_Click;
            var deleteAppointment = new ToolStripMenuItem();
            deleteAppointment.Text = "Удалить";
            deleteAppointment.Click += DeleteAppointment_Click;
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { editAppointment, deleteAppointment });
            return contextMenuStrip;
        }

        private void DeleteAppointment_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить данное мероприятие?", "Внимание!", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (_appointment.ID > 0)
                FosterSQL.ExecuteQuery("delete from Appointments where ID =" + _appointment.ID);
            else
                FosterSQL.ExecuteQuery("Delete from RecurrenceInfo where ID=" + _appointment.RecurrenceID);
            Singleton.Instance.MainForm.RefreshCalendar(_appointment.EndDate.Year, _appointment.EndDate.Month);
            this.Controls.Clear();
        }

        private void EditAppointment_Click(object sender, EventArgs e)
        {
            var editAppointment = new NewAppointmentForm(_appointment.EndDate, _appointment);
            editAppointment.ShowDialog();
        }

        private void FillAppointmentCard(string title, string description)
        {
            label1.Text = title;
            label2.Text = description;
            if (_appointment.IsCompleted)
            {
                inProgressIcon.Visible = false;
                isCompletedIcon.Visible = true;
                btnComments.Visible = true;
                label1.ForeColor = Color.MediumSpringGreen;
                label1.Text = label1.Text;
            }
            var titleHeight = TextRenderer.MeasureText(title, new Font("Bahnschrift", 13f), new Size(150, 30), TextFormatFlags.WordBreak).Height;
            var descriptionHeight = TextRenderer.MeasureText(description, new Font("Bahnschrift", 12f), new Size(250, 60), TextFormatFlags.WordBreak).Height;
            titleHeight = titleHeight > 20 ? titleHeight + 25 : titleHeight + 15;
            titleHeight = titleHeight > 100 ? titleHeight + 5 : titleHeight + 5;
            label1.Height = titleHeight;
            Height = label1.Height + descriptionHeight;
        }

        private void AppointmentView_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.BackColor = Color.FromArgb(222, 11, 17);
            t.ForeColor = Color.WhiteSmoke;
            t.OwnerDraw = true;
            t.Draw += T_Draw;
            t.SetToolTip(btnComments, _appointment.Result);
        }

        private void T_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
    }
}
