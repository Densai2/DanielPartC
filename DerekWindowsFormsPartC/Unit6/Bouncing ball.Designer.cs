namespace DerekWindowsFormsPartC
{
    partial class Bouncing_ball
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
            this.startButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AreaPictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Stop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(327, 513);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(814, 513);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.exitButton);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AreaPictureBox);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 424);
            this.panel1.TabIndex = 3;
            // 
            // AreaPictureBox
            // 
            this.AreaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AreaPictureBox.Location = new System.Drawing.Point(3, 3);
            this.AreaPictureBox.Name = "AreaPictureBox";
            this.AreaPictureBox.Size = new System.Drawing.Size(933, 425);
            this.AreaPictureBox.TabIndex = 0;
            this.AreaPictureBox.TabStop = false;
            this.AreaPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.redBall);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timerMove);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(546, 513);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.stopButton);
            // 
            // Bouncing_ball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 563);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.startButton);
            this.Name = "Bouncing_ball";
            this.Text = "Bouncing_ball";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AreaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox AreaPictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Stop;
    }
}