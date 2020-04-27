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
            this.HeadLengthTextBox = new System.Windows.Forms.TextBox();
            this.Param1 = new System.Windows.Forms.Label();
            this.HandleHeightTextBox = new System.Windows.Forms.TextBox();
            this.ToeLengthTextBox = new System.Windows.Forms.TextBox();
            this.TipWidthTextBox = new System.Windows.Forms.TextBox();
            this.HoleDiameterTextBox = new System.Windows.Forms.TextBox();
            this.HeadWidthTextBox = new System.Windows.Forms.TextBox();
            this.HandleLengthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buildButton = new System.Windows.Forms.Button();
            this.clearEditLinesButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.HandleWidthTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.startSolidWorksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeadLengthTextBox
            // 
            this.HeadLengthTextBox.Location = new System.Drawing.Point(115, 35);
            this.HeadLengthTextBox.Name = "HeadLengthTextBox";
            this.HeadLengthTextBox.Size = new System.Drawing.Size(105, 20);
            this.HeadLengthTextBox.TabIndex = 0;
            this.HeadLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Param1
            // 
            this.Param1.AutoSize = true;
            this.Param1.Location = new System.Drawing.Point(12, 38);
            this.Param1.Name = "Param1";
            this.Param1.Size = new System.Drawing.Size(68, 13);
            this.Param1.TabIndex = 1;
            this.Param1.Text = "Head length:";
            // 
            // HandleHeightTextBox
            // 
            this.HandleHeightTextBox.Location = new System.Drawing.Point(115, 201);
            this.HandleHeightTextBox.Name = "HandleHeightTextBox";
            this.HandleHeightTextBox.Size = new System.Drawing.Size(105, 20);
            this.HandleHeightTextBox.TabIndex = 5;
            this.HandleHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // ToeLengthTextBox
            // 
            this.ToeLengthTextBox.Location = new System.Drawing.Point(115, 132);
            this.ToeLengthTextBox.Name = "ToeLengthTextBox";
            this.ToeLengthTextBox.Size = new System.Drawing.Size(105, 20);
            this.ToeLengthTextBox.TabIndex = 4;
            this.ToeLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // TipWidthTextBox
            // 
            this.TipWidthTextBox.Location = new System.Drawing.Point(115, 106);
            this.TipWidthTextBox.Name = "TipWidthTextBox";
            this.TipWidthTextBox.Size = new System.Drawing.Size(105, 20);
            this.TipWidthTextBox.TabIndex = 3;
            this.TipWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // HoleDiameterTextBox
            // 
            this.HoleDiameterTextBox.Location = new System.Drawing.Point(115, 81);
            this.HoleDiameterTextBox.Name = "HoleDiameterTextBox";
            this.HoleDiameterTextBox.Size = new System.Drawing.Size(105, 20);
            this.HoleDiameterTextBox.TabIndex = 2;
            this.HoleDiameterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // HeadWidthTextBox
            // 
            this.HeadWidthTextBox.Location = new System.Drawing.Point(115, 58);
            this.HeadWidthTextBox.Name = "HeadWidthTextBox";
            this.HeadWidthTextBox.Size = new System.Drawing.Size(105, 20);
            this.HeadWidthTextBox.TabIndex = 1;
            this.HeadWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // HandleLengthTextBox
            // 
            this.HandleLengthTextBox.Location = new System.Drawing.Point(115, 227);
            this.HandleLengthTextBox.Name = "HandleLengthTextBox";
            this.HandleLengthTextBox.Size = new System.Drawing.Size(105, 20);
            this.HandleLengthTextBox.TabIndex = 6;
            this.HandleLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Handle length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Handle height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Toe length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tip width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hole diameter:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Head width:";
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(15, 297);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(75, 23);
            this.buildButton.TabIndex = 8;
            this.buildButton.Text = "Build";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // clearEditLinesButton
            // 
            this.clearEditLinesButton.Location = new System.Drawing.Point(115, 297);
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
            this.label7.Location = new System.Drawing.Point(12, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hendle width:";
            // 
            // HandleWidthTextBox
            // 
            this.HandleWidthTextBox.Location = new System.Drawing.Point(115, 253);
            this.HandleWidthTextBox.Name = "HandleWidthTextBox";
            this.HandleWidthTextBox.Size = new System.Drawing.Size(105, 20);
            this.HandleWidthTextBox.TabIndex = 7;
            this.HandleWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Handle parameters:";
            // 
            // startSolidWorksButton
            // 
            this.startSolidWorksButton.Location = new System.Drawing.Point(39, 326);
            this.startSolidWorksButton.Name = "startSolidWorksButton";
            this.startSolidWorksButton.Size = new System.Drawing.Size(149, 23);
            this.startSolidWorksButton.TabIndex = 9;
            this.startSolidWorksButton.Text = "Start SolidWorks";
            this.startSolidWorksButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 397);
            this.Controls.Add(this.startSolidWorksButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HandleWidthTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clearEditLinesButton);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HandleLengthTextBox);
            this.Controls.Add(this.HeadWidthTextBox);
            this.Controls.Add(this.HoleDiameterTextBox);
            this.Controls.Add(this.TipWidthTextBox);
            this.Controls.Add(this.ToeLengthTextBox);
            this.Controls.Add(this.HandleHeightTextBox);
            this.Controls.Add(this.Param1);
            this.Controls.Add(this.HeadLengthTextBox);
            this.Name = "MainForm";
            this.Text = "Hammer builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HeadLengthTextBox;
        private System.Windows.Forms.Label Param1;
        private System.Windows.Forms.TextBox HandleHeightTextBox;
        private System.Windows.Forms.TextBox ToeLengthTextBox;
        private System.Windows.Forms.TextBox TipWidthTextBox;
        private System.Windows.Forms.TextBox HoleDiameterTextBox;
        private System.Windows.Forms.TextBox HeadWidthTextBox;
        private System.Windows.Forms.TextBox HandleLengthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.Button clearEditLinesButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HandleWidthTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button startSolidWorksButton;
    }
}

