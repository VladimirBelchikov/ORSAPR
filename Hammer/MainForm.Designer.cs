namespace Hammer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeadLengthTextBox = new System.Windows.Forms.TextBox();
            this.Param1 = new System.Windows.Forms.Label();
            this.HeadHeightTextBox = new System.Windows.Forms.TextBox();
            this.ToeLengthTextBox = new System.Windows.Forms.TextBox();
            this.TipWidthTextBox = new System.Windows.Forms.TextBox();
            this.HeadWidthTextBox = new System.Windows.Forms.TextBox();
            this.HandleLengthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buildButton = new System.Windows.Forms.Button();
            this.clearEditLinesButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.HandleDiameterTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.startSolidWorksButton = new System.Windows.Forms.Button();
            this.TESTBUTTON = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadLengthTextBox
            // 
            this.HeadLengthTextBox.Location = new System.Drawing.Point(671, 81);
            this.HeadLengthTextBox.Name = "HeadLengthTextBox";
            this.HeadLengthTextBox.Size = new System.Drawing.Size(105, 20);
            this.HeadLengthTextBox.TabIndex = 0;
            this.HeadLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Param1
            // 
            this.Param1.AutoSize = true;
            this.Param1.Location = new System.Drawing.Point(686, 58);
            this.Param1.Name = "Param1";
            this.Param1.Size = new System.Drawing.Size(68, 13);
            this.Param1.TabIndex = 1;
            this.Param1.Text = "Head length:";
            // 
            // HeadHeightTextBox
            // 
            this.HeadHeightTextBox.Location = new System.Drawing.Point(67, 200);
            this.HeadHeightTextBox.Name = "HeadHeightTextBox";
            this.HeadHeightTextBox.Size = new System.Drawing.Size(85, 20);
            this.HeadHeightTextBox.TabIndex = 5;
            this.HeadHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // ToeLengthTextBox
            // 
            this.ToeLengthTextBox.Location = new System.Drawing.Point(1091, 87);
            this.ToeLengthTextBox.Name = "ToeLengthTextBox";
            this.ToeLengthTextBox.Size = new System.Drawing.Size(105, 20);
            this.ToeLengthTextBox.TabIndex = 4;
            this.ToeLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // TipWidthTextBox
            // 
            this.TipWidthTextBox.Location = new System.Drawing.Point(1289, 184);
            this.TipWidthTextBox.Name = "TipWidthTextBox";
            this.TipWidthTextBox.Size = new System.Drawing.Size(73, 20);
            this.TipWidthTextBox.TabIndex = 3;
            this.TipWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // HeadWidthTextBox
            // 
            this.HeadWidthTextBox.Location = new System.Drawing.Point(211, 99);
            this.HeadWidthTextBox.Name = "HeadWidthTextBox";
            this.HeadWidthTextBox.Size = new System.Drawing.Size(80, 20);
            this.HeadWidthTextBox.TabIndex = 1;
            this.HeadWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // HandleLengthTextBox
            // 
            this.HandleLengthTextBox.Location = new System.Drawing.Point(931, 372);
            this.HandleLengthTextBox.Name = "HandleLengthTextBox";
            this.HandleLengthTextBox.Size = new System.Drawing.Size(105, 20);
            this.HandleLengthTextBox.TabIndex = 6;
            this.HandleLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1042, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Handle length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Head height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1108, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Toe length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1297, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tip width:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Head width:";
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(137, 447);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(75, 23);
            this.buildButton.TabIndex = 8;
            this.buildButton.Text = "Build";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // clearEditLinesButton
            // 
            this.clearEditLinesButton.Location = new System.Drawing.Point(237, 447);
            this.clearEditLinesButton.Name = "clearEditLinesButton";
            this.clearEditLinesButton.Size = new System.Drawing.Size(105, 23);
            this.clearEditLinesButton.TabIndex = 10;
            this.clearEditLinesButton.Text = "Clear edit lines";
            this.clearEditLinesButton.UseVisualStyleBackColor = true;
            this.clearEditLinesButton.Click += new System.EventHandler(this.clearEditLinesButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Handle diameter";
            // 
            // HandleDiameterTextBox
            // 
            this.HandleDiameterTextBox.Location = new System.Drawing.Point(708, 368);
            this.HandleDiameterTextBox.Name = "HandleDiameterTextBox";
            this.HandleDiameterTextBox.Size = new System.Drawing.Size(105, 20);
            this.HandleDiameterTextBox.TabIndex = 7;
            this.HandleDiameterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Head parameters:";
            // 
            // startSolidWorksButton
            // 
            this.startSolidWorksButton.Location = new System.Drawing.Point(155, 499);
            this.startSolidWorksButton.Name = "startSolidWorksButton";
            this.startSolidWorksButton.Size = new System.Drawing.Size(149, 23);
            this.startSolidWorksButton.TabIndex = 9;
            this.startSolidWorksButton.Text = "Start SolidWorks";
            this.startSolidWorksButton.UseVisualStyleBackColor = true;
            this.startSolidWorksButton.Click += new System.EventHandler(this.startSolidWorksButton_Click);
            // 
            // TESTBUTTON
            // 
            this.TESTBUTTON.Location = new System.Drawing.Point(191, 560);
            this.TESTBUTTON.Name = "TESTBUTTON";
            this.TESTBUTTON.Size = new System.Drawing.Size(75, 23);
            this.TESTBUTTON.TabIndex = 20;
            this.TESTBUTTON.Text = "TEST";
            this.TESTBUTTON.UseVisualStyleBackColor = true;
            this.TESTBUTTON.Click += new System.EventHandler(this.TESTBUTTON_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hammer.Properties.Resources._2020_05_04_19_30_11;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(492, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(928, 392);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hammer.Properties.Resources._2020_05_04_19_30_44;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 391);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(227, 693);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1036, 55);
            this.label5.TabIndex = 23;
            this.label5.Text = "СКОРО ДОРАБОТАЮ МАКЕТ (IN DEVELOP)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 799);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TESTBUTTON);
            this.Controls.Add(this.startSolidWorksButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HandleDiameterTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clearEditLinesButton);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HandleLengthTextBox);
            this.Controls.Add(this.HeadWidthTextBox);
            this.Controls.Add(this.TipWidthTextBox);
            this.Controls.Add(this.ToeLengthTextBox);
            this.Controls.Add(this.HeadHeightTextBox);
            this.Controls.Add(this.Param1);
            this.Controls.Add(this.HeadLengthTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MainForm";
            this.Text = "Hammer builder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HeadLengthTextBox;
        private System.Windows.Forms.Label Param1;
        private System.Windows.Forms.TextBox HeadHeightTextBox;
        private System.Windows.Forms.TextBox ToeLengthTextBox;
        private System.Windows.Forms.TextBox TipWidthTextBox;
        private System.Windows.Forms.TextBox HeadWidthTextBox;
        private System.Windows.Forms.TextBox HandleLengthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.Button clearEditLinesButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HandleDiameterTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button startSolidWorksButton;
        private System.Windows.Forms.Button TESTBUTTON;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}

