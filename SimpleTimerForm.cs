using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pKami.SimpleTimer
{
    public partial class SimpleTimerForm : Form
    {
        private Miliseconds msecTime = new Miliseconds();
        private Color colorBeforePause = Color.SeaGreen;
        private bool resetting = false;
        private string windowTitle = "SimpleTimer";

        public SimpleTimerForm()
        {
            InitializeComponent();
            windowTitle = this.Text;
            this.msecTime.PropertyChanged += msecTime_PropertyChanged;
            this.timer1.Tick += timer1_Tick;
        }

        void msecTime_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.lbTimer.Text = TimeSpan.FromMilliseconds(msecTime.Value).ToString();

            if (msecTime.Value == 0)
            {
                lbTimer.ForeColor = Color.Black;

                if (!resetting)
                {
                    bool ring = false;

                    if (rbBlink.Checked)
                    {
                        WinApi.Flash(this);
                    }
                    else if (rbPopup.Checked)
                    {
                        string message = "Countdown finished!";

                        if (!string.IsNullOrWhiteSpace(tbName.Text))
                        {
                            message = "Countdown for " + tbName.Text.Trim() + " finished!";
                        }
                        
                        WinApi.SetForegroundWindow(this.Handle);
                        MessageBox.Show(this, message);
                    }

                    if (ring)       // TODO: Does not work with popup. How can I make it work with popup?
                    {
                        Beeper.Instance.Enable();
                        this.Activated += SimpleTimerForm_ActivatedAfterAlarm;
                        this.GotFocus += SimpleTimerForm_ActivatedAfterAlarm;
                        Task.Factory.StartNew(Beeper.Instance.PlayAlarm);
                    }
                }
            }
            else if (msecTime.Value <= 3 * 1000)
            {
                lbTimer.ForeColor = Color.Firebrick;
            }
        }

        private void SimpleTimerForm_ActivatedAfterAlarm(object sender, EventArgs e)
        {
            Beeper.Instance.RequestStop();
            this.Activated -= SimpleTimerForm_ActivatedAfterAlarm;
            this.GotFocus -= SimpleTimerForm_ActivatedAfterAlarm;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (this.msecTime.Value > 0)
            {
                this.msecTime.Value -= timer1.Interval;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SetTime();

            if (msecTime.Value > 0)
            {
                timer1.Start();
                lbTimer.ForeColor = Color.SeaGreen;
            }
        }

        private void SetTime()
        {
            this.msecTime.Value = TimeSpan.FromHours(Convert.ToDouble(nudHours.Value)).TotalMilliseconds
                                + TimeSpan.FromMinutes(Convert.ToDouble(nudMinutes.Value)).TotalMilliseconds
                                + TimeSpan.FromSeconds(Convert.ToDouble(nudSeconds.Value)).TotalMilliseconds;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)     // not paused
            {
                timer1.Stop();
                colorBeforePause = lbTimer.ForeColor;
                lbTimer.ForeColor = Color.DarkGoldenrod;
            }
            else if (msecTime.Value > 0)    // not enabled (implicit) & paused
            {
                timer1.Start();
                lbTimer.ForeColor = colorBeforePause;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetting = true;
            timer1.Stop();
            msecTime.Value = 0;
            resetting = false;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text))
            {
                this.Text = tbName.Text.Trim() + " - " + windowTitle;
            }
            else
            {
                this.Text = windowTitle;
            }
        }

        private void inputControl_SelectAllText(object sender, EventArgs e)
        {
            if (sender is TextBoxBase)
            {
                ((TextBoxBase)sender).SelectAll();
            }
            else if (sender is UpDownBase)
            {
                UpDownBase udb = (UpDownBase)sender;
                udb.Select(0, 2);
            }
        }

        private void inputControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnStart_Click(sender, e);
            }
        }
    }
}
