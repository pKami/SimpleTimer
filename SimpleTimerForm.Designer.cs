namespace pKami.SimpleTimer
{
    partial class SimpleTimerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleTimerForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbOnFinish = new System.Windows.Forms.GroupBox();
            this.rbQuiet = new System.Windows.Forms.RadioButton();
            this.rbBlink = new System.Windows.Forms.RadioButton();
            this.rbPopup = new System.Windows.Forms.RadioButton();
            this.lbHours = new System.Windows.Forms.Label();
            this.lbSeconds = new System.Windows.Forms.Label();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.nudHours = new SimpleTimer.MyNumericUpDown();
            this.nudMinutes = new SimpleTimer.MyNumericUpDown();
            this.nudSeconds = new SimpleTimer.MyNumericUpDown();
            this.gbOnFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(280, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 45);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPause.Location = new System.Drawing.Point(280, 95);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(121, 45);
            this.btnPause.TabIndex = 7;
            this.btnPause.TabStop = false;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(280, 146);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 45);
            this.btnReset.TabIndex = 8;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Stop && Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.BackColor = System.Drawing.Color.Transparent;
            this.lbTimer.Font = new System.Drawing.Font("Stencil", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(1, 39);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(266, 69);
            this.lbTimer.TabIndex = 7;
            this.lbTimer.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(10, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(39, 17);
            this.lbTitle.TabIndex = 9;
            this.lbTitle.Text = "Title:";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(65, 9);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(336, 22);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.Enter += new System.EventHandler(this.inputControl_SelectAllText);
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputControl_KeyPress);
            // 
            // gbOnFinish
            // 
            this.gbOnFinish.Controls.Add(this.rbQuiet);
            this.gbOnFinish.Controls.Add(this.rbBlink);
            this.gbOnFinish.Controls.Add(this.rbPopup);
            this.gbOnFinish.Location = new System.Drawing.Point(12, 143);
            this.gbOnFinish.Name = "gbOnFinish";
            this.gbOnFinish.Size = new System.Drawing.Size(261, 50);
            this.gbOnFinish.TabIndex = 5;
            this.gbOnFinish.TabStop = false;
            this.gbOnFinish.Text = "When finished:";
            // 
            // rbQuiet
            // 
            this.rbQuiet.AutoSize = true;
            this.rbQuiet.Location = new System.Drawing.Point(188, 21);
            this.rbQuiet.Name = "rbQuiet";
            this.rbQuiet.Size = new System.Drawing.Size(63, 21);
            this.rbQuiet.TabIndex = 2;
            this.rbQuiet.Text = "Quiet";
            this.rbQuiet.UseVisualStyleBackColor = true;
            // 
            // rbBlink
            // 
            this.rbBlink.AutoSize = true;
            this.rbBlink.Checked = true;
            this.rbBlink.Location = new System.Drawing.Point(106, 21);
            this.rbBlink.Name = "rbBlink";
            this.rbBlink.Size = new System.Drawing.Size(59, 21);
            this.rbBlink.TabIndex = 1;
            this.rbBlink.TabStop = true;
            this.rbBlink.Text = "Blink";
            this.rbBlink.UseVisualStyleBackColor = true;
            // 
            // rbPopup
            // 
            this.rbPopup.AutoSize = true;
            this.rbPopup.Location = new System.Drawing.Point(10, 21);
            this.rbPopup.Name = "rbPopup";
            this.rbPopup.Size = new System.Drawing.Size(75, 21);
            this.rbPopup.TabIndex = 0;
            this.rbPopup.Text = "Pop-up";
            this.rbPopup.UseVisualStyleBackColor = true;
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Location = new System.Drawing.Point(73, 112);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(16, 17);
            this.lbHours.TabIndex = 22;
            this.lbHours.Text = "h";
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.Location = new System.Drawing.Point(246, 112);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(15, 17);
            this.lbSeconds.TabIndex = 20;
            this.lbSeconds.Text = "s";
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.Location = new System.Drawing.Point(159, 112);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(19, 17);
            this.lbMinutes.TabIndex = 19;
            this.lbMinutes.Text = "m";
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(24, 108);
            this.nudHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(45, 22);
            this.nudHours.TabIndex = 2;
            this.nudHours.Enter += new System.EventHandler(this.inputControl_SelectAllText);
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(110, 108);
            this.nudMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(45, 22);
            this.nudMinutes.TabIndex = 3;
            this.nudMinutes.Enter += new System.EventHandler(this.inputControl_SelectAllText);
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(197, 108);
            this.nudSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(45, 22);
            this.nudSeconds.TabIndex = 4;
            this.nudSeconds.Enter += new System.EventHandler(this.inputControl_SelectAllText);
            // 
            // SimpleTimerForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 204);
            this.Controls.Add(this.lbHours);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.lbSeconds);
            this.Controls.Add(this.lbMinutes);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.nudSeconds);
            this.Controls.Add(this.gbOnFinish);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SimpleTimerForm";
            this.Text = "SimpleTimer";
            this.gbOnFinish.ResumeLayout(false);
            this.gbOnFinish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbOnFinish;
        private System.Windows.Forms.RadioButton rbQuiet;
        private System.Windows.Forms.RadioButton rbBlink;
        private System.Windows.Forms.RadioButton rbPopup;
        private System.Windows.Forms.Label lbHours;
        private SimpleTimer.MyNumericUpDown nudHours;
        private System.Windows.Forms.Label lbSeconds;
        private System.Windows.Forms.Label lbMinutes;
        private SimpleTimer.MyNumericUpDown nudMinutes;
        private SimpleTimer.MyNumericUpDown nudSeconds;
    }
}

