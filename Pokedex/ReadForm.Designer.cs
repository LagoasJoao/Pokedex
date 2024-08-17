namespace Pokedex
{
    partial class ReadForm
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
            picSprite = new PictureBox();
            txtDescription = new TextBox();
            lblName = new Label();
            txtType1 = new TextBox();
            txtType2 = new TextBox();
            numNumber = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)picSprite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNumber).BeginInit();
            SuspendLayout();
            // 
            // picSprite
            // 
            picSprite.Location = new Point(12, 12);
            picSprite.Name = "picSprite";
            picSprite.Size = new Size(159, 143);
            picSprite.SizeMode = PictureBoxSizeMode.StretchImage;
            picSprite.TabIndex = 0;
            picSprite.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 161);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(265, 133);
            txtDescription.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(205, 68);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 3;
            lblName.Text = "label2";
            // 
            // txtType1
            // 
            txtType1.ForeColor = SystemColors.ControlText;
            txtType1.Location = new Point(177, 103);
            txtType1.Name = "txtType1";
            txtType1.ReadOnly = true;
            txtType1.Size = new Size(100, 23);
            txtType1.TabIndex = 4;
            // 
            // txtType2
            // 
            txtType2.Location = new Point(177, 132);
            txtType2.Name = "txtType2";
            txtType2.ReadOnly = true;
            txtType2.Size = new Size(100, 23);
            txtType2.TabIndex = 5;
            // 
            // numNumber
            // 
            numNumber.Location = new Point(177, 12);
            numNumber.Name = "numNumber";
            numNumber.Size = new Size(100, 23);
            numNumber.TabIndex = 6;
            numNumber.ValueChanged += numNumber_ValueChanged;
            // 
            // ReadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 319);
            Controls.Add(numNumber);
            Controls.Add(txtType2);
            Controls.Add(txtType1);
            Controls.Add(lblName);
            Controls.Add(txtDescription);
            Controls.Add(picSprite);
            Name = "ReadForm";
            Text = "ReadForm";
            ((System.ComponentModel.ISupportInitialize)picSprite).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picSprite;
        private TextBox txtDescription;
        private Label label1;
        private Label lblName;
        private TextBox txtType1;
        private TextBox txtType2;
        private NumericUpDown numNumber;
    }
}