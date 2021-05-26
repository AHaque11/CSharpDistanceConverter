
namespace _4._5_Distance_Converter
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.firstUnitGroupBox = new System.Windows.Forms.GroupBox();
            this.secondUnitGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputDisplayLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.firstUnitGroupBox.SuspendLayout();
            this.secondUnitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Inches",
            "Feet ",
            "Yards"});
            this.listBox1.Location = new System.Drawing.Point(23, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(112, 52);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.listBox2.Location = new System.Drawing.Point(23, 30);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(117, 52);
            this.listBox2.TabIndex = 1;
            // 
            // firstUnitGroupBox
            // 
            this.firstUnitGroupBox.Controls.Add(this.listBox1);
            this.firstUnitGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstUnitGroupBox.Location = new System.Drawing.Point(22, 82);
            this.firstUnitGroupBox.Name = "firstUnitGroupBox";
            this.firstUnitGroupBox.Size = new System.Drawing.Size(173, 102);
            this.firstUnitGroupBox.TabIndex = 2;
            this.firstUnitGroupBox.TabStop = false;
            this.firstUnitGroupBox.Text = "From";
            // 
            // secondUnitGroupBox
            // 
            this.secondUnitGroupBox.Controls.Add(this.listBox2);
            this.secondUnitGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondUnitGroupBox.Location = new System.Drawing.Point(228, 82);
            this.secondUnitGroupBox.Name = "secondUnitGroupBox";
            this.secondUnitGroupBox.Size = new System.Drawing.Size(173, 102);
            this.secondUnitGroupBox.TabIndex = 3;
            this.secondUnitGroupBox.TabStop = false;
            this.secondUnitGroupBox.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter a distance to convert:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Converted distance:";
            // 
            // outputDisplayLabel
            // 
            this.outputDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDisplayLabel.Location = new System.Drawing.Point(176, 212);
            this.outputDisplayLabel.Name = "outputDisplayLabel";
            this.outputDisplayLabel.Size = new System.Drawing.Size(132, 23);
            this.outputDisplayLabel.TabIndex = 6;
            this.outputDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(228, 37);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(106, 20);
            this.inputTextBox.TabIndex = 7;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.convertButton.Location = new System.Drawing.Point(79, 261);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(78, 31);
            this.convertButton.TabIndex = 8;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(228, 261);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 31);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 315);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.outputDisplayLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondUnitGroupBox);
            this.Controls.Add(this.firstUnitGroupBox);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.firstUnitGroupBox.ResumeLayout(false);
            this.secondUnitGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox firstUnitGroupBox;
        private System.Windows.Forms.GroupBox secondUnitGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outputDisplayLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

