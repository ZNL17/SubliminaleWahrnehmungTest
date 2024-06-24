using System.Drawing;
using System.Windows.Forms;

namespace SubliminaleWahrnehmungTest
{
    partial class ViewSubTest
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
            labelName = new Label();
            labelPWD = new Label();
            buttonStart = new Button();
            pictureBox = new PictureBox();
            textBoxPWD = new TextBox();
            textBoxName = new TextBox();
            labelZiffer = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(39, 42);
            labelName.Name = "labelName";
            labelName.Size = new Size(64, 15);
            labelName.TabIndex = 0;
            labelName.Text = "labelName";
            // 
            // labelPWD
            // 
            labelPWD.AutoSize = true;
            labelPWD.Location = new Point(39, 89);
            labelPWD.Name = "labelPWD";
            labelPWD.Size = new Size(58, 15);
            labelPWD.TabIndex = 1;
            labelPWD.Text = "labelPWD";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(36, 214);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(245, 68);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 82);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // textBoxPWD
            // 
            textBoxPWD.Location = new Point(39, 107);
            textBoxPWD.Name = "textBoxPWD";
            textBoxPWD.Size = new Size(100, 23);
            textBoxPWD.TabIndex = 4;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(39, 60);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 5;
            // 
            // labelZiffer
            // 
            labelZiffer.AutoSize = true;
            labelZiffer.Location = new Point(39, 196);
            labelZiffer.Name = "labelZiffer";
            labelZiffer.Size = new Size(60, 15);
            labelZiffer.TabIndex = 6;
            labelZiffer.Text = "labelZiffer";
            // 
            // ViewSubTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 288);
            Controls.Add(labelZiffer);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPWD);
            Controls.Add(pictureBox);
            Controls.Add(buttonStart);
            Controls.Add(labelPWD);
            Controls.Add(labelName);
            Name = "ViewSubTest";
            Text = "View";
            KeyDown += this.ViewSubTest_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelPWD;
        private Button buttonStart;
        private PictureBox pictureBox;
        private TextBox textBoxPWD;
        private TextBox textBoxName;
        private Label labelZiffer;
    }
}
