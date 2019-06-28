namespace TranZadIA
{
    partial class FormSelection
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
            this.Open_tranZad = new System.Windows.Forms.Button();
            this.open_training = new System.Windows.Forms.Button();
            this.open_tranZadTwo = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Open_tranZad
            // 
            this.Open_tranZad.Location = new System.Drawing.Point(12, 12);
            this.Open_tranZad.Name = "Open_tranZad";
            this.Open_tranZad.Size = new System.Drawing.Size(227, 45);
            this.Open_tranZad.TabIndex = 0;
            this.Open_tranZad.Text = "Одноэтапная транспортная задача";
            this.Open_tranZad.UseVisualStyleBackColor = true;
            this.Open_tranZad.Click += new System.EventHandler(this.Open_tranZad_Click);
            // 
            // open_training
            // 
            this.open_training.Location = new System.Drawing.Point(12, 63);
            this.open_training.Name = "open_training";
            this.open_training.Size = new System.Drawing.Size(227, 45);
            this.open_training.TabIndex = 1;
            this.open_training.Text = "Тренажёр одноэтапной транспортой задачи";
            this.open_training.UseVisualStyleBackColor = true;
            this.open_training.Click += new System.EventHandler(this.open_training_Click);
            // 
            // open_tranZadTwo
            // 
            this.open_tranZadTwo.Location = new System.Drawing.Point(12, 114);
            this.open_tranZadTwo.Name = "open_tranZadTwo";
            this.open_tranZadTwo.Size = new System.Drawing.Size(227, 45);
            this.open_tranZadTwo.TabIndex = 2;
            this.open_tranZadTwo.Text = "Двухэтапная транспортая задача";
            this.open_tranZadTwo.UseVisualStyleBackColor = true;
            this.open_tranZadTwo.Click += new System.EventHandler(this.open_tranZadTwo_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 165);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(227, 45);
            this.exit.TabIndex = 3;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // FormSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 228);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.open_tranZadTwo);
            this.Controls.Add(this.open_training);
            this.Controls.Add(this.Open_tranZad);
            this.Name = "FormSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Транспорнтая задача";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Open_tranZad;
        private System.Windows.Forms.Button open_training;
        private System.Windows.Forms.Button open_tranZadTwo;
        private System.Windows.Forms.Button exit;
    }
}