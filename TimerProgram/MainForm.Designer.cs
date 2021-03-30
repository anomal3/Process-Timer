
namespace TimerProgram
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.nH = new System.Windows.Forms.NumericUpDown();
            this.nM = new System.Windows.Forms.NumericUpDown();
            this.nS = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bStartTimer = new System.Windows.Forms.Button();
            this.tbProgram = new System.Windows.Forms.TextBox();
            this.TimerExit = new System.Windows.Forms.Timer(this.components);
            this.lValueEndP = new System.Windows.Forms.Label();
            this.chbMin = new System.Windows.Forms.CheckBox();
            this.nIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nS)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTP
            // 
            this.dateTP.Location = new System.Drawing.Point(12, 33);
            this.dateTP.Name = "dateTP";
            this.dateTP.Size = new System.Drawing.Size(154, 22);
            this.dateTP.TabIndex = 0;
            // 
            // nH
            // 
            this.nH.Location = new System.Drawing.Point(232, 33);
            this.nH.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nH.Name = "nH";
            this.nH.Size = new System.Drawing.Size(56, 22);
            this.nH.TabIndex = 1;
            // 
            // nM
            // 
            this.nM.Location = new System.Drawing.Point(294, 33);
            this.nM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nM.Name = "nM";
            this.nM.Size = new System.Drawing.Size(56, 22);
            this.nM.TabIndex = 1;
            // 
            // nS
            // 
            this.nS.Location = new System.Drawing.Point(356, 33);
            this.nS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nS.Name = "nS";
            this.nS.Size = new System.Drawing.Size(56, 22);
            this.nS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Час          Мин         Сек";
            // 
            // bStartTimer
            // 
            this.bStartTimer.Location = new System.Drawing.Point(12, 67);
            this.bStartTimer.Name = "bStartTimer";
            this.bStartTimer.Size = new System.Drawing.Size(154, 29);
            this.bStartTimer.TabIndex = 3;
            this.bStartTimer.Text = "bStartTimer";
            this.bStartTimer.UseVisualStyleBackColor = true;
            this.bStartTimer.Click += new System.EventHandler(this.bStartTimer_Click);
            // 
            // tbProgram
            // 
            this.tbProgram.Location = new System.Drawing.Point(386, 70);
            this.tbProgram.Name = "tbProgram";
            this.tbProgram.Size = new System.Drawing.Size(26, 22);
            this.tbProgram.TabIndex = 4;
            this.tbProgram.Text = "Kryptex";
            // 
            // TimerExit
            // 
            this.TimerExit.Interval = 1000;
            this.TimerExit.Tick += new System.EventHandler(this.TimerExit_Tick);
            // 
            // lValueEndP
            // 
            this.lValueEndP.AutoSize = true;
            this.lValueEndP.Location = new System.Drawing.Point(12, 99);
            this.lValueEndP.Name = "lValueEndP";
            this.lValueEndP.Size = new System.Drawing.Size(173, 17);
            this.lValueEndP.TabIndex = 5;
            this.lValueEndP.Text = "label_value_end_program";
            // 
            // chbMin
            // 
            this.chbMin.AutoSize = true;
            this.chbMin.Checked = true;
            this.chbMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMin.Location = new System.Drawing.Point(12, 6);
            this.chbMin.Name = "chbMin";
            this.chbMin.Size = new System.Drawing.Size(161, 21);
            this.chbMin.TabIndex = 6;
            this.chbMin.Text = "Сворачивать в трей";
            this.chbMin.UseVisualStyleBackColor = true;
            this.chbMin.CheckedChanged += new System.EventHandler(this.chbMin_CheckedChanged);
            // 
            // nIcon
            // 
            this.nIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nIcon.BalloonTipText = "Двойной клик восстановит вид";
            this.nIcon.BalloonTipTitle = "Timer";
            this.nIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nIcon.Icon")));
            this.nIcon.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 123);
            this.Controls.Add(this.chbMin);
            this.Controls.Add(this.lValueEndP);
            this.Controls.Add(this.tbProgram);
            this.Controls.Add(this.bStartTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nS);
            this.Controls.Add(this.nM);
            this.Controls.Add(this.nH);
            this.Controls.Add(this.dateTP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 170);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 155);
            this.Name = "MainForm";
            this.Text = "Таймер выключения программ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTP;
        private System.Windows.Forms.NumericUpDown nH;
        private System.Windows.Forms.NumericUpDown nM;
        private System.Windows.Forms.NumericUpDown nS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bStartTimer;
        private System.Windows.Forms.TextBox tbProgram;
        private System.Windows.Forms.Timer TimerExit;
        private System.Windows.Forms.Label lValueEndP;
        private System.Windows.Forms.CheckBox chbMin;
        private System.Windows.Forms.NotifyIcon nIcon;
    }
}

