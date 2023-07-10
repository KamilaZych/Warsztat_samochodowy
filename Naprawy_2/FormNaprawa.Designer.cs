
namespace Naprawy_2
{
    partial class FormNaprawa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown3_czas_pracy_mechanika = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2_koszt_użytych_części = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1_numer_telefonu = new System.Windows.Forms.NumericUpDown();
            this.textBox1_numer_rejestracyjny = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3_czas_pracy_mechanika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_koszt_użytych_części)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_numer_telefonu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button_anuluj);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button_ok);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numericUpDown3_czas_pracy_mechanika);
            this.groupBox1.Controls.Add(this.numericUpDown2_koszt_użytych_części);
            this.groupBox1.Controls.Add(this.numericUpDown1_numer_telefonu);
            this.groupBox1.Controls.Add(this.textBox1_numer_rejestracyjny);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 425);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie i edytowanie naprawy";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 21);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // button_anuluj
            // 
            this.button_anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_anuluj.Location = new System.Drawing.Point(142, 374);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(105, 41);
            this.button_anuluj.TabIndex = 9;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Czas pracy w godzinach";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(13, 374);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(105, 41);
            this.button_ok.TabIndex = 8;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Koszt użytych części";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Numer telefonu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Numer rejestracyjny";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Data oddania do naprawy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Imię i nazwisko mechanika";
            // 
            // numericUpDown3_czas_pracy_mechanika
            // 
            this.numericUpDown3_czas_pracy_mechanika.Location = new System.Drawing.Point(14, 338);
            this.numericUpDown3_czas_pracy_mechanika.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3_czas_pracy_mechanika.Name = "numericUpDown3_czas_pracy_mechanika";
            this.numericUpDown3_czas_pracy_mechanika.Size = new System.Drawing.Size(233, 21);
            this.numericUpDown3_czas_pracy_mechanika.TabIndex = 5;
            // 
            // numericUpDown2_koszt_użytych_części
            // 
            this.numericUpDown2_koszt_użytych_części.DecimalPlaces = 2;
            this.numericUpDown2_koszt_użytych_części.Location = new System.Drawing.Point(14, 278);
            this.numericUpDown2_koszt_użytych_części.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2_koszt_użytych_części.Name = "numericUpDown2_koszt_użytych_części";
            this.numericUpDown2_koszt_użytych_części.Size = new System.Drawing.Size(233, 21);
            this.numericUpDown2_koszt_użytych_części.TabIndex = 4;
            // 
            // numericUpDown1_numer_telefonu
            // 
            this.numericUpDown1_numer_telefonu.Location = new System.Drawing.Point(14, 222);
            this.numericUpDown1_numer_telefonu.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1_numer_telefonu.Name = "numericUpDown1_numer_telefonu";
            this.numericUpDown1_numer_telefonu.Size = new System.Drawing.Size(233, 21);
            this.numericUpDown1_numer_telefonu.TabIndex = 3;
            // 
            // textBox1_numer_rejestracyjny
            // 
            this.textBox1_numer_rejestracyjny.Location = new System.Drawing.Point(13, 166);
            this.textBox1_numer_rejestracyjny.Name = "textBox1_numer_rejestracyjny";
            this.textBox1_numer_rejestracyjny.Size = new System.Drawing.Size(234, 21);
            this.textBox1_numer_rejestracyjny.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // FormNaprawa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 446);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "FormNaprawa";
            this.Text = "Naprawa";
            this.Load += new System.EventHandler(this.FormNaprawa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3_czas_pracy_mechanika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_koszt_użytych_części)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_numer_telefonu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown3_czas_pracy_mechanika;
        private System.Windows.Forms.NumericUpDown numericUpDown2_koszt_użytych_części;
        private System.Windows.Forms.NumericUpDown numericUpDown1_numer_telefonu;
        private System.Windows.Forms.TextBox textBox1_numer_rejestracyjny;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}