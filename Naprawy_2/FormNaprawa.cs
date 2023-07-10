using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naprawy_2
{
    public partial class FormNaprawa : Form
    {
        Naprawa naprawa;

        internal FormNaprawa(Naprawa naprawa)
        {
            this.naprawa = naprawa;
            InitializeComponent();
        }

        private void FormNaprawa_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            
            foreach (Mechanik mechanik in Mechanik.lista_mechaników)
            {
                comboBox1.Items[comboBox1.Items.Add(mechanik)] = mechanik;
            }
            
            textBox1_numer_rejestracyjny.Text = naprawa.numer_rejestracyjny;
            numericUpDown1_numer_telefonu.Value = naprawa.numer_telefonu;
            comboBox1.SelectedItem = naprawa.mechanik;
            numericUpDown2_koszt_użytych_części.Value = naprawa.koszt_użytych_części;
            numericUpDown3_czas_pracy_mechanika.Value = naprawa.czas_pracy;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {

            if (textBox1_numer_rejestracyjny.Text == "" || numericUpDown1_numer_telefonu.Value == 0 || comboBox1.SelectedItem == null || 
                numericUpDown2_koszt_użytych_części.Value == 0 || numericUpDown3_czas_pracy_mechanika.Value == 0)
            {
                MessageBox.Show("Wprowadź dane naprawy. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            naprawa.numer_rejestracyjny = textBox1_numer_rejestracyjny.Text;
            naprawa.data_przyjęcia = dateTimePicker1.Value;
            naprawa.numer_telefonu = (int)numericUpDown1_numer_telefonu.Value;
            naprawa.mechanik = (Mechanik)comboBox1.SelectedItem;
            naprawa.koszt_użytych_części = numericUpDown2_koszt_użytych_części.Value;       
            naprawa.czas_pracy = (int)numericUpDown3_czas_pracy_mechanika.Value;
            naprawa.wynagrodzenie_dla_mechanika_za_naprawę = Math.Round(naprawa.koszt_użytych_części * 0.01m + (naprawa.czas_pracy * naprawa.mechanik.stawka) * 0.4m, 2, MidpointRounding.AwayFromZero);   
            naprawa.cena_naprawa = naprawa.koszt_użytych_części + (naprawa.czas_pracy * naprawa.mechanik.stawka);

            DialogResult = DialogResult.OK;
        }
    }
}
