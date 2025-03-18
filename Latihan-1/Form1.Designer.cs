namespace Latihan_1
{
    partial class Form1
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
            ButtonStopwatch = new Button();
            labelMinute = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonStop = new Button();
            buttonReset = new Button();
            labelHour = new Label();
            labelSecond = new Label();
            SuspendLayout();
            // 
            // ButtonStopwatch
            // 
            ButtonStopwatch.BackColor = Color.FromArgb(128, 255, 128);
            ButtonStopwatch.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonStopwatch.Location = new Point(59, 195);
            ButtonStopwatch.Name = "ButtonStopwatch";
            ButtonStopwatch.Size = new Size(136, 54);
            ButtonStopwatch.TabIndex = 0;
            ButtonStopwatch.Text = "Start\r\n";
            ButtonStopwatch.UseVisualStyleBackColor = false;
            ButtonStopwatch.Click += ButtonStopwatch_Click;
            // 
            // labelMinute
            // 
            labelMinute.AutoSize = true;
            labelMinute.Font = new Font("Times New Roman", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMinute.Location = new Point(261, 83);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(71, 53);
            labelMinute.TabIndex = 1;
            labelMinute.Text = "00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = Color.FromArgb(255, 128, 128);
            buttonStop.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStop.Location = new Point(239, 195);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(124, 54);
            buttonStop.TabIndex = 2;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.FromArgb(128, 255, 255);
            buttonReset.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(405, 195);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(133, 54);
            buttonReset.TabIndex = 3;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // labelHour
            // 
            labelHour.AutoSize = true;
            labelHour.Font = new Font("Times New Roman", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHour.Location = new Point(165, 83);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(71, 53);
            labelHour.TabIndex = 4;
            labelHour.Text = "00";
            // 
            // labelSecond
            // 
            labelSecond.AutoSize = true;
            labelSecond.Font = new Font("Times New Roman", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSecond.Location = new Point(359, 83);
            labelSecond.Name = "labelSecond";
            labelSecond.Size = new Size(71, 53);
            labelSecond.TabIndex = 5;
            labelSecond.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 320);
            Controls.Add(labelSecond);
            Controls.Add(labelHour);
            Controls.Add(buttonReset);
            Controls.Add(buttonStop);
            Controls.Add(labelMinute);
            Controls.Add(ButtonStopwatch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonStopwatch;
        private Label labelMinute;
        private System.Windows.Forms.Timer timer1;
        private Button buttonStop;
        private Button buttonReset;
        private Label labelHour;
        private Label labelSecond;
    }
}
