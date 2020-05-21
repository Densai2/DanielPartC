namespace WindowsFormsPartC.Unit5
{
    partial class FlyMeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.stopRadioButton = new System.Windows.Forms.RadioButton();
            this.startRadioButton = new System.Windows.Forms.RadioButton();
            this.copterPictureBox = new System.Windows.Forms.PictureBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.speedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stopRadioButton);
            this.panel1.Controls.Add(this.startRadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 55);
            this.panel1.TabIndex = 0;
            // 
            // stopRadioButton
            // 
            this.stopRadioButton.AutoSize = true;
            this.stopRadioButton.Location = new System.Drawing.Point(105, 12);
            this.stopRadioButton.Name = "stopRadioButton";
            this.stopRadioButton.Size = new System.Drawing.Size(75, 30);
            this.stopRadioButton.TabIndex = 1;
            this.stopRadioButton.Text = "Stop";
            this.stopRadioButton.UseVisualStyleBackColor = true;
            // 
            // startRadioButton
            // 
            this.startRadioButton.AutoSize = true;
            this.startRadioButton.Checked = true;
            this.startRadioButton.Location = new System.Drawing.Point(13, 12);
            this.startRadioButton.Name = "startRadioButton";
            this.startRadioButton.Size = new System.Drawing.Size(76, 30);
            this.startRadioButton.TabIndex = 0;
            this.startRadioButton.TabStop = true;
            this.startRadioButton.Text = "Start";
            this.startRadioButton.UseVisualStyleBackColor = true;
            this.startRadioButton.CheckedChanged += new System.EventHandler(this.startStopAnimation);
            // 
            // copterPictureBox
            // 
            this.copterPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.copterPictureBox.Location = new System.Drawing.Point(192, 59);
            this.copterPictureBox.Name = "copterPictureBox";
            this.copterPictureBox.Size = new System.Drawing.Size(100, 105);
            this.copterPictureBox.TabIndex = 1;
            this.copterPictureBox.TabStop = false;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(715, 491);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(109, 43);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitForm);
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Tick += new System.EventHandler(this.updateCopter);
            // 
            // speedNumericUpDown
            // 
            this.speedNumericUpDown.Location = new System.Drawing.Point(321, 492);
            this.speedNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedNumericUpDown.Name = "speedNumericUpDown";
            this.speedNumericUpDown.Size = new System.Drawing.Size(71, 32);
            this.speedNumericUpDown.TabIndex = 3;
            this.speedNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speedNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedNumericUpDown.ValueChanged += new System.EventHandler(this.changeSpeed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Speed";
            // 
            // FlyMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DerekWindowsFormsPartC.Properties.Resources.City1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedNumericUpDown);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.copterPictureBox);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FlyMeForm";
            this.Text = "Fly With Me Form";
            this.Load += new System.EventHandler(this.loadImages);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton stopRadioButton;
        private System.Windows.Forms.RadioButton startRadioButton;
        private System.Windows.Forms.PictureBox copterPictureBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.NumericUpDown speedNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}