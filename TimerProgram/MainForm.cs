using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dateTP.Value = DateTime.Now;
            nH.Value = DateTime.Now.Hour;
            nM.Value = DateTime.Now.Minute;
            nS.Value = DateTime.Now.Second;
            IS_MINIMIZE = chbMin.Checked;
            nIcon.Visible = false;

            this.nIcon.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);

            this.Resize += new EventHandler(this.MainForm_Resize);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {   
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                nIcon.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            nIcon.Visible = false;
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        int TOTAL_SECOND_EXIT;
        bool IS_MINIMIZE;
        private void bStartTimer_Click(object sender, EventArgs e)
        {
            TimerExit.Start();

            DateTime dateBegin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            DateTime dateEnd = new DateTime(dateTP.Value.Year, dateTP.Value.Month, dateTP.Value.Day, (int)nH.Value, (int)nM.Value, (int)nS.Value);
           
            TimeSpan s = dateEnd - dateBegin;

            TOTAL_SECOND_EXIT = (int)s.TotalSeconds;
        }

        async void KillProgramm(string programm)
        {
            foreach (Process proc in Process.GetProcessesByName(programm))
            {
                proc.Kill();
            }

            await Task.Delay(10000); Application.Exit();
        }

        private void TimerExit_Tick(object sender, EventArgs e)
        {
            lValueEndP.Text = $"До выключения программы {TOTAL_SECOND_EXIT} секунд";
            nIcon.Text = $"До выключения программы {TOTAL_SECOND_EXIT} секунд";
            if (TOTAL_SECOND_EXIT <= 0)
            {
                KillProgramm(tbProgram.Text);
                lValueEndP.Text = "Следы затёрты! Программа выключится через 10 сек.";
            }
            else TOTAL_SECOND_EXIT--;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IS_MINIMIZE)
            {
                e.Cancel = true;

                this.WindowState = FormWindowState.Minimized;
            }
        }


        private void chbMin_CheckedChanged(object sender, EventArgs e)
        {
            IS_MINIMIZE = chbMin.Checked;
        }
    }
}
