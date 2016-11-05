namespace Idź_na_ryby_
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Postep_txtBox = new System.Windows.Forms.TextBox();
            this.Grupy_txtBox = new System.Windows.Forms.TextBox();
            this.Imie_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartGra_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zapytaj_button = new System.Windows.Forms.Button();
            this.Reka_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Postep_txtBox
            // 
            this.Postep_txtBox.Location = new System.Drawing.Point(12, 77);
            this.Postep_txtBox.Multiline = true;
            this.Postep_txtBox.Name = "Postep_txtBox";
            this.Postep_txtBox.ReadOnly = true;
            this.Postep_txtBox.Size = new System.Drawing.Size(232, 235);
            this.Postep_txtBox.TabIndex = 0;
            // 
            // Grupy_txtBox
            // 
            this.Grupy_txtBox.Location = new System.Drawing.Point(12, 337);
            this.Grupy_txtBox.Multiline = true;
            this.Grupy_txtBox.Name = "Grupy_txtBox";
            this.Grupy_txtBox.ReadOnly = true;
            this.Grupy_txtBox.Size = new System.Drawing.Size(232, 115);
            this.Grupy_txtBox.TabIndex = 1;
            // 
            // Imie_txtBox
            // 
            this.Imie_txtBox.Location = new System.Drawing.Point(12, 29);
            this.Imie_txtBox.Name = "Imie_txtBox";
            this.Imie_txtBox.Size = new System.Drawing.Size(100, 20);
            this.Imie_txtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ręka";
            // 
            // StartGra_button
            // 
            this.StartGra_button.Location = new System.Drawing.Point(148, 29);
            this.StartGra_button.Name = "StartGra_button";
            this.StartGra_button.Size = new System.Drawing.Size(96, 23);
            this.StartGra_button.TabIndex = 6;
            this.StartGra_button.Text = "Rozpocznij grę!";
            this.StartGra_button.UseVisualStyleBackColor = true;
            this.StartGra_button.Click += new System.EventHandler(this.StartGra_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Postęp gry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grupy";
            // 
            // zapytaj_button
            // 
            this.zapytaj_button.Enabled = false;
            this.zapytaj_button.Location = new System.Drawing.Point(264, 429);
            this.zapytaj_button.Name = "zapytaj_button";
            this.zapytaj_button.Size = new System.Drawing.Size(147, 23);
            this.zapytaj_button.TabIndex = 9;
            this.zapytaj_button.Text = "Zaządaj karty!";
            this.zapytaj_button.UseVisualStyleBackColor = true;
            this.zapytaj_button.Click += new System.EventHandler(this.zapytaj_button_Click);
            // 
            // Reka_listBox
            // 
            this.Reka_listBox.FormattingEnabled = true;
            this.Reka_listBox.Location = new System.Drawing.Point(264, 29);
            this.Reka_listBox.Name = "Reka_listBox";
            this.Reka_listBox.Size = new System.Drawing.Size(147, 394);
            this.Reka_listBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 462);
            this.Controls.Add(this.Reka_listBox);
            this.Controls.Add(this.zapytaj_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartGra_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Imie_txtBox);
            this.Controls.Add(this.Grupy_txtBox);
            this.Controls.Add(this.Postep_txtBox);
            this.Name = "Form1";
            this.Text = "Idź na ryby!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Postep_txtBox;
        private System.Windows.Forms.TextBox Grupy_txtBox;
        private System.Windows.Forms.TextBox Imie_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartGra_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button zapytaj_button;
        private System.Windows.Forms.ListBox Reka_listBox;
    }
}

