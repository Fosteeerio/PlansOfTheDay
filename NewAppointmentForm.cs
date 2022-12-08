using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopCalendar
{
    public partial class NewAppointmentForm : Form
    {
        private DateTime _currentDate;
        private Appointment _appointment;
        public NewAppointmentForm(DateTime currentDate, Appointment appointment)
        {
            InitializeComponent();
            _appointment = appointment;
            _currentDate = currentDate;
            txtResult.Visible = false;
            Singleton.Instance.recurrenceTemplate = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Visible = false;
            txtResult.Enabled = false;
            btnSave.Location = new Point(13, 363);
            btnSettings.Location = new Point(232, 363);
            this.Width = 368;
            this.Height = 428;
            if (checkBox1.Checked)
            {
                this.Width = 368;
                this.Height = 528;
                txtResult.Location = new Point(13, 349);
                txtResult.Visible = true;
                txtResult.Enabled = true;
                btnSave.Location = new Point(13, 453);
                btnSettings.Location = new Point(232, 453);
            }
        }

        private void codeeloButton1_Click(object sender, EventArgs e)
        {
            if (_appointment == null)
                SaveAppointment();
            else
                UpdateAppointment();
            Singleton.Instance.MainForm.RefreshCalendar(_currentDate.Year, _currentDate.Month);
            Close();
        }
        private void SaveAppointment()
        {
            if (Singleton.Instance.recurrenceTemplate == null)
            {
                var appointment = new Appointment()
                {
                    Title = txtTitle.Text,
                    EndDate = codeeloDateTimePicker1.Value,
                    Description = txtDescription.Text,
                    IsCompleted = false
                };
                FosterSQL.AddAppointment(appointment);
            }
            else
            {
                var appointment = new Appointment()
                {
                    Title = txtTitle.Text,
                    Description = txtDescription.Text
                };
                FosterSQL.AddRecurrenceInfo(appointment, Singleton.Instance.recurrenceTemplate);
            }
        }
        private void UpdateAppointment()
        {
            _appointment.Title = txtTitle.Text;
            _appointment.EndDate = codeeloDateTimePicker1.Value;
            _appointment.Description = txtDescription.Text;
            if (_appointment.ID == 0)
            {
                _appointment.ID = FosterSQL.GetNextAppointmentID();
                FosterSQL.AddAppointment(_appointment);
            }
            if (checkBox1.Checked)
            {
                _appointment.IsCompleted = checkBox1.Checked;
                _appointment.Result = txtResult.Text;
            }
            FosterSQL.UpdateAppointment(_appointment);
        }

        private void NewAppointmentForm_Load(object sender, EventArgs e)
        {
            codeeloDateTimePicker1.Value = _currentDate;
            codeeloDateTimePicker1.ForeColor = Color.White;
            if (_appointment != null)
            {
                txtTitle.Text = _appointment.Title;
                txtDescription.Text = _appointment.Description;
                txtResult.Text = _appointment.Result;
                codeeloDateTimePicker1.Value = _appointment.EndDate;
                checkBox1.Checked = _appointment.IsCompleted;
            }
        }

        private void codeeloButton3_Click(object sender, EventArgs e)
        {
            var recurrenceForm = new RecurrenceForm(_currentDate);
            recurrenceForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
