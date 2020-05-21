namespace WindowsFormsPartC
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.runButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.animationRadioButton = new System.Windows.Forms.RadioButton();
            this.flyMeRadioButton = new System.Windows.Forms.RadioButton();
            this.quitButton = new System.Windows.Forms.Button();
            this.graphicsRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(138, 619);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(101, 48);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runProgram);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(612, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // animationRadioButton
            // 
            this.animationRadioButton.AutoSize = true;
            this.animationRadioButton.Location = new System.Drawing.Point(48, 51);
            this.animationRadioButton.Name = "animationRadioButton";
            this.animationRadioButton.Size = new System.Drawing.Size(408, 30);
            this.animationRadioButton.TabIndex = 2;
            this.animationRadioButton.Text = "Task 5.1 Butterfly and Horse Animation";
            this.animationRadioButton.UseVisualStyleBackColor = true;
            // 
            // flyMeRadioButton
            // 
            this.flyMeRadioButton.AutoSize = true;
            this.flyMeRadioButton.Location = new System.Drawing.Point(48, 105);
            this.flyMeRadioButton.Name = "flyMeRadioButton";
            this.flyMeRadioButton.Size = new System.Drawing.Size(337, 30);
            this.flyMeRadioButton.TabIndex = 3;
            this.flyMeRadioButton.Text = "Task 5.3 Fly With Me Animation";
            this.flyMeRadioButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(319, 619);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(101, 48);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitForm);
            // 
            // graphicsRadioButton
            // 
            this.graphicsRadioButton.AutoSize = true;
            this.graphicsRadioButton.Checked = true;
            this.graphicsRadioButton.Location = new System.Drawing.Point(48, 155);
            this.graphicsRadioButton.Name = "graphicsRadioButton";
            this.graphicsRadioButton.Size = new System.Drawing.Size(180, 30);
            this.graphicsRadioButton.TabIndex = 5;
            this.graphicsRadioButton.TabStop = true;
            this.graphicsRadioButton.Text = "Unit 6 Graphics";
            this.graphicsRadioButton.UseVisualStyleBackColor = true;
            this.graphicsRadioButton.CheckedChanged += new System.EventHandler(this.graphicsRadioButton_CheckedChanged);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 679);
            this.Controls.Add(this.graphicsRadioButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.flyMeRadioButton);
            this.Controls.Add(this.animationRadioButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.runButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MenuForm";
            this.Text = "Part C Menu Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton animationRadioButton;
        private System.Windows.Forms.RadioButton flyMeRadioButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.RadioButton graphicsRadioButton;
    }
}