namespace Pokedex
{
    partial class WriteForm
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
            numNumber = new NumericUpDown();
            txtDescription = new TextBox();
            picSprite = new PictureBox();
            button1 = new Button();
            txtName = new TextBox();
            btnChangeImage = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnInsert = new Button();
            cmbType1 = new ComboBox();
            cmbType2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSprite).BeginInit();
            SuspendLayout();
            // 
            // numNumber
            // 
            numNumber.Location = new Point(177, 12);
            numNumber.Name = "numNumber";
            numNumber.Size = new Size(100, 23);
            numNumber.TabIndex = 12;
            numNumber.ValueChanged += numNumber_ValueChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 161);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(265, 133);
            txtDescription.TabIndex = 8;
            // 
            // picSprite
            // 
            picSprite.Location = new Point(12, 12);
            picSprite.Name = "picSprite";
            picSprite.Size = new Size(159, 143);
            picSprite.SizeMode = PictureBoxSizeMode.StretchImage;
            picSprite.TabIndex = 7;
            picSprite.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(540, 285);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(177, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 14;
            // 
            // btnChangeImage
            // 
            btnChangeImage.Location = new Point(177, 45);
            btnChangeImage.Name = "btnChangeImage";
            btnChangeImage.Size = new Size(100, 23);
            btnChangeImage.TabIndex = 15;
            btnChangeImage.Text = "Carregar";
            btnChangeImage.UseVisualStyleBackColor = true;
            btnChangeImage.Click += btnChangeImage_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 300);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(265, 36);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Atualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 342);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(265, 36);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Remover";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 384);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(265, 36);
            btnInsert.TabIndex = 18;
            btnInsert.Text = "Inserir";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // cmbType1
            // 
            cmbType1.FormattingEnabled = true;
            cmbType1.Location = new Point(177, 103);
            cmbType1.Name = "cmbType1";
            cmbType1.Size = new Size(100, 23);
            cmbType1.TabIndex = 19;
            // 
            // cmbType2
            // 
            cmbType2.FormattingEnabled = true;
            cmbType2.Location = new Point(177, 132);
            cmbType2.Name = "cmbType2";
            cmbType2.Size = new Size(100, 23);
            cmbType2.TabIndex = 20;
            // 
            // WriteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 440);
            Controls.Add(cmbType2);
            Controls.Add(cmbType1);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnChangeImage);
            Controls.Add(txtName);
            Controls.Add(button1);
            Controls.Add(numNumber);
            Controls.Add(txtDescription);
            Controls.Add(picSprite);
            Name = "WriteForm";
            Text = "WriteForm";
            ((System.ComponentModel.ISupportInitialize)numNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSprite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numNumber;
        private TextBox txtDescription;
        private PictureBox picSprite;
        private Button button1;
        private TextBox txtName;
        private Button btnChangeImage;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnInsert;
        private ComboBox cmbType1;
        private ComboBox cmbType2;
    }
}