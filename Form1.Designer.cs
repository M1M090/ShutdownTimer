namespace ShutdownTimer
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            btnStart = new Button();
            btnStop = new Button();
            gbTimer = new GroupBox();
            lblTimer = new Label();
            gbSetTimer = new GroupBox();
            tbSeconds = new TextBox();
            tbMinutes = new TextBox();
            tbHours = new TextBox();
            lblSeconds = new Label();
            lblMinutes = new Label();
            lblHours = new Label();
            gbAction = new GroupBox();
            rbSleep = new RadioButton();
            rbRestart = new RadioButton();
            rbShutdown = new RadioButton();
            Timer = new System.Windows.Forms.Timer(components);
            gbTimer.SuspendLayout();
            gbSetTimer.SuspendLayout();
            gbAction.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 188);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(136, 63);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(154, 189);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(136, 63);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // gbTimer
            // 
            gbTimer.Controls.Add(lblTimer);
            gbTimer.Location = new Point(12, 12);
            gbTimer.Name = "gbTimer";
            gbTimer.Size = new Size(278, 170);
            gbTimer.TabIndex = 2;
            gbTimer.TabStop = false;
            gbTimer.Text = "Timer";
            gbTimer.Enter += gbTimer_Enter;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(31, 58);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(89, 30);
            lblTimer.TabIndex = 3;
            lblTimer.Text = "00:00:00";
            lblTimer.Click += lblTimer_Click;
            // 
            // gbSetTimer
            // 
            gbSetTimer.Controls.Add(tbSeconds);
            gbSetTimer.Controls.Add(tbMinutes);
            gbSetTimer.Controls.Add(tbHours);
            gbSetTimer.Controls.Add(lblSeconds);
            gbSetTimer.Controls.Add(lblMinutes);
            gbSetTimer.Controls.Add(lblHours);
            gbSetTimer.Location = new Point(296, 12);
            gbSetTimer.Name = "gbSetTimer";
            gbSetTimer.Size = new Size(278, 240);
            gbSetTimer.TabIndex = 3;
            gbSetTimer.TabStop = false;
            gbSetTimer.Text = "Set Timer";
            // 
            // tbSeconds
            // 
            tbSeconds.Location = new Point(104, 176);
            tbSeconds.Name = "tbSeconds";
            tbSeconds.Size = new Size(149, 29);
            tbSeconds.TabIndex = 5;
            // 
            // tbMinutes
            // 
            tbMinutes.Location = new Point(104, 115);
            tbMinutes.Name = "tbMinutes";
            tbMinutes.Size = new Size(149, 29);
            tbMinutes.TabIndex = 4;
            // 
            // tbHours
            // 
            tbHours.Location = new Point(104, 54);
            tbHours.Name = "tbHours";
            tbHours.Size = new Size(149, 29);
            tbHours.TabIndex = 3;
            // 
            // lblSeconds
            // 
            lblSeconds.AutoSize = true;
            lblSeconds.Location = new Point(22, 179);
            lblSeconds.Name = "lblSeconds";
            lblSeconds.Size = new Size(68, 21);
            lblSeconds.TabIndex = 2;
            lblSeconds.Text = "Seconds";
            // 
            // lblMinutes
            // 
            lblMinutes.AutoSize = true;
            lblMinutes.Location = new Point(22, 118);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(66, 21);
            lblMinutes.TabIndex = 1;
            lblMinutes.Text = "Minutes";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(22, 57);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(52, 21);
            lblHours.TabIndex = 0;
            lblHours.Text = "Hours";
            lblHours.Click += lblHours_Click;
            // 
            // gbAction
            // 
            gbAction.Controls.Add(rbSleep);
            gbAction.Controls.Add(rbRestart);
            gbAction.Controls.Add(rbShutdown);
            gbAction.Location = new Point(580, 12);
            gbAction.Name = "gbAction";
            gbAction.Size = new Size(278, 240);
            gbAction.TabIndex = 4;
            gbAction.TabStop = false;
            gbAction.Text = "Action";
            // 
            // rbSleep
            // 
            rbSleep.AutoSize = true;
            rbSleep.Location = new Point(20, 180);
            rbSleep.Name = "rbSleep";
            rbSleep.Size = new Size(66, 25);
            rbSleep.TabIndex = 2;
            rbSleep.TabStop = true;
            rbSleep.Text = "Sleep";
            rbSleep.UseVisualStyleBackColor = true;
            // 
            // rbRestart
            // 
            rbRestart.AutoSize = true;
            rbRestart.Location = new Point(20, 119);
            rbRestart.Name = "rbRestart";
            rbRestart.Size = new Size(77, 25);
            rbRestart.TabIndex = 1;
            rbRestart.TabStop = true;
            rbRestart.Text = "Restart";
            rbRestart.UseVisualStyleBackColor = true;
            // 
            // rbShutdown
            // 
            rbShutdown.AutoSize = true;
            rbShutdown.Location = new Point(20, 58);
            rbShutdown.Name = "rbShutdown";
            rbShutdown.Size = new Size(99, 25);
            rbShutdown.TabIndex = 0;
            rbShutdown.TabStop = true;
            rbShutdown.Text = "Shutdown";
            rbShutdown.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 262);
            Controls.Add(gbAction);
            Controls.Add(gbSetTimer);
            Controls.Add(gbTimer);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form";
            Text = "Shutdown Timer";
            gbTimer.ResumeLayout(false);
            gbTimer.PerformLayout();
            gbSetTimer.ResumeLayout(false);
            gbSetTimer.PerformLayout();
            gbAction.ResumeLayout(false);
            gbAction.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private GroupBox gbTimer;
        private Label lblTimer;
        private GroupBox gbSetTimer;
        private Label lblSeconds;
        private Label lblMinutes;
        private Label lblHours;
        private TextBox tbMinutes;
        private TextBox tbHours;
        private GroupBox gbAction;
        private TextBox tbSeconds;
        private RadioButton rbShutdown;
        private RadioButton rbSleep;
        private RadioButton rbRestart;
        private System.Windows.Forms.Timer Timer;
    }
}
