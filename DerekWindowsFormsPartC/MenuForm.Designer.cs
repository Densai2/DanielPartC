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
            this.unit6RadioButton = new System.Windows.Forms.RadioButton();
            this.unit7RadioButton = new System.Windows.Forms.RadioButton();
            this.bouncingBallRadio = new System.Windows.Forms.RadioButton();
            this.additionalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.animationRadioButton.Location = new System.Drawing.Point(48, 60);
            this.animationRadioButton.Name = "animationRadioButton";
            this.animationRadioButton.Size = new System.Drawing.Size(408, 30);
            this.animationRadioButton.TabIndex = 2;
            this.animationRadioButton.Text = "Task 5.1 Butterfly and Horse Animation";
            this.animationRadioButton.UseVisualStyleBackColor = true;
            // 
            // flyMeRadioButton
            // 
            this.flyMeRadioButton.AutoSize = true;
            this.flyMeRadioButton.Location = new System.Drawing.Point(48, 114);
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
            this.graphicsRadioButton.Location = new System.Drawing.Point(48, 448);
            this.graphicsRadioButton.Name = "graphicsRadioButton";
            this.graphicsRadioButton.Size = new System.Drawing.Size(180, 30);
            this.graphicsRadioButton.TabIndex = 5;
            this.graphicsRadioButton.Text = "Unit 6 Graphics";
            this.graphicsRadioButton.UseVisualStyleBackColor = true;
            // 
            // unit6RadioButton
            // 
            this.unit6RadioButton.AutoSize = true;
            this.unit6RadioButton.Location = new System.Drawing.Point(48, 168);
            this.unit6RadioButton.Name = "unit6RadioButton";
            this.unit6RadioButton.Size = new System.Drawing.Size(166, 30);
            this.unit6RadioButton.TabIndex = 6;
            this.unit6RadioButton.Text = "Unit 6: 6.1-6.5";
            this.unit6RadioButton.UseVisualStyleBackColor = true;
            // 
            // unit7RadioButton
            // 
            this.unit7RadioButton.AutoSize = true;
            this.unit7RadioButton.Checked = true;
            this.unit7RadioButton.Location = new System.Drawing.Point(48, 287);
            this.unit7RadioButton.Name = "unit7RadioButton";
            this.unit7RadioButton.Size = new System.Drawing.Size(166, 30);
            this.unit7RadioButton.TabIndex = 7;
            this.unit7RadioButton.Text = "Unit 7 Sketch ";
            this.unit7RadioButton.UseVisualStyleBackColor = true;
            // 
            // bouncingBallRadio
            // 
            this.bouncingBallRadio.AutoSize = true;
            this.bouncingBallRadio.Location = new System.Drawing.Point(48, 228);
            this.bouncingBallRadio.Name = "bouncingBallRadio";
            this.bouncingBallRadio.Size = new System.Drawing.Size(230, 30);
            this.bouncingBallRadio.TabIndex = 8;
            this.bouncingBallRadio.Text = "Unit 6: Bouncing ball";
            this.bouncingBallRadio.UseVisualStyleBackColor = true;
            // 
            // additionalLabel
            // 
            this.additionalLabel.AutoSize = true;
            this.additionalLabel.Location = new System.Drawing.Point(43, 389);
            this.additionalLabel.Name = "additionalLabel";
            this.additionalLabel.Size = new System.Drawing.Size(195, 26);
            this.additionalLabel.TabIndex = 9;
            this.additionalLabel.Text = "Additional program";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Main programs";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.additionalLabel);
            this.Controls.Add(this.bouncingBallRadio);
            this.Controls.Add(this.unit7RadioButton);
            this.Controls.Add(this.unit6RadioButton);
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
        private System.Windows.Forms.RadioButton unit6RadioButton;
        private System.Windows.Forms.RadioButton unit7RadioButton;
        private System.Windows.Forms.RadioButton bouncingBallRadio;
        private System.Windows.Forms.Label additionalLabel;
        private System.Windows.Forms.Label label1;
    }
}