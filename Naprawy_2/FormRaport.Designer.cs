
namespace Naprawy_2
{
    partial class FormRaport
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
            this.button_anuluj = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_wynagrodzenie_dla_wszystkich = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_wynagrodzenie_dla_wszystkich);
            this.groupBox1.Controls.Add(this.button_anuluj);
            this.groupBox1.Controls.Add(this.button_ok);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 195);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raport";
            this.groupBox1.UseWaitCursor = true;
            // 
            // button_anuluj
            // 
            this.button_anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_anuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_anuluj.Location = new System.Drawing.Point(10, 156);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(409, 26);
            this.button_anuluj.TabIndex = 9;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ok.Location = new System.Drawing.Point(10, 64);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(409, 26);
            this.button_ok.TabIndex = 8;
            this.button_ok.Text = "Raport dla wybranego mechanika";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.UseWaitCursor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(7, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Wybierz imię i nazwisko mechanika";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.UseWaitCursor = true;
            // 
            // button_wynagrodzenie_dla_wszystkich
            // 
            this.button_wynagrodzenie_dla_wszystkich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wynagrodzenie_dla_wszystkich.Location = new System.Drawing.Point(10, 98);
            this.button_wynagrodzenie_dla_wszystkich.Name = "button_wynagrodzenie_dla_wszystkich";
            this.button_wynagrodzenie_dla_wszystkich.Size = new System.Drawing.Size(409, 26);
            this.button_wynagrodzenie_dla_wszystkich.TabIndex = 11;
            this.button_wynagrodzenie_dla_wszystkich.Text = "Pokaż wynagrodzenie dla wszystkich pracowników";
            this.button_wynagrodzenie_dla_wszystkich.UseVisualStyleBackColor = true;
            this.button_wynagrodzenie_dla_wszystkich.UseWaitCursor = true;
            this.button_wynagrodzenie_dla_wszystkich.Click += new System.EventHandler(this.button_wynagrodzenie_dla_wszystkich_Click);
            // 
            // FormRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 212);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "FormRaport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Raport";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FormRaport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_wynagrodzenie_dla_wszystkich;
    }
}