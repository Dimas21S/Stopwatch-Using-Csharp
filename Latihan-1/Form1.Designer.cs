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
            labelStopwatch = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ButtonStopwatch
            // 
            ButtonStopwatch.Location = new Point(268, 212);
            ButtonStopwatch.Name = "ButtonStopwatch";
            ButtonStopwatch.Size = new Size(94, 29);
            ButtonStopwatch.TabIndex = 0;
            ButtonStopwatch.Text = "Start\r\n";
            ButtonStopwatch.UseVisualStyleBackColor = true;
            ButtonStopwatch.Click += ButtonStopwatch_Click;
            // 
            // labelStopwatch
            // 
            labelStopwatch.AutoSize = true;
            labelStopwatch.Location = new Point(308, 103);
            labelStopwatch.Name = "labelStopwatch";
            labelStopwatch.Size = new Size(17, 20);
            labelStopwatch.TabIndex = 1;
            labelStopwatch.Text = "0";
            // 
            // timer1
            // 
            timer1.Tick += TimerStopwatch;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 320);
            Controls.Add(labelStopwatch);
            Controls.Add(ButtonStopwatch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonStopwatch;
        private Label labelStopwatch;
        private System.Windows.Forms.Timer timer1;
    }
}
