namespace Pokedex
{
    partial class HomeForm
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
            btnWrite = new Button();
            btnRead = new Button();
            SuspendLayout();
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(246, 147);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(200, 51);
            btnWrite.TabIndex = 0;
            btnWrite.Text = "Escrever";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(246, 90);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(200, 51);
            btnRead.TabIndex = 1;
            btnRead.Text = "Ler";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRead);
            Controls.Add(btnWrite);
            Name = "HomeForm";
            Text = "HomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnWrite;
        private Button btnRead;
    }
}