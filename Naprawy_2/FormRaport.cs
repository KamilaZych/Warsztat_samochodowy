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
    public partial class FormRaport : Form
    {
        internal FormRaport()
        {
            InitializeComponent();
        }

        private void FormRaport_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            foreach (Mechanik mechanik in Mechanik.lista_mechaników)
            {
                comboBox1.Items[comboBox1.Items.Add(mechanik)] = mechanik;
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            foreach (Naprawa naprawa in Naprawa.lista_napraw)
            {
                if (comboBox1.SelectedItem != naprawa.mechanik)
                {
                    MessageBox.Show("Ten mechanik nie wykonał żadnej naprawy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            decimal łączna_ilość_godzin = 0m;
            decimal należność_za_przepracowane_godziny = 0m;
            decimal łączna_wartość_zastosowanych_części = 0m;
            decimal wynagrodzenie = 0m;

            
            foreach (Naprawa naprawa in Naprawa.lista_napraw)
            {
                if (naprawa.mechanik == (Mechanik)comboBox1.SelectedItem)
                {
                    wynagrodzenie += naprawa.wynagrodzenie_dla_mechanika_za_naprawę;
                    łączna_ilość_godzin += naprawa.czas_pracy;
                    łączna_wartość_zastosowanych_części += naprawa.koszt_użytych_części; 
                    należność_za_przepracowane_godziny += łączna_ilość_godzin*naprawa.mechanik.stawka;
                }
            }

            decimal suma_materiałów_i_należność_za_przepracowane_godziny = łączna_wartość_zastosowanych_części + należność_za_przepracowane_godziny;

            MessageBox.Show("Łączna ilość przepracowanych godzin jest równa: " + łączna_ilość_godzin.ToString("0.0") + " h \n\n"
                + "Należność za przepracowane godziny jest równa: " + należność_za_przepracowane_godziny.ToString("0.00") + " zł \n\n"
                + "Łączna wartość zastosowanych części jest równa: " + łączna_wartość_zastosowanych_części.ToString("0.00") + " zł \n\n"
                + "Suma wartości zastosowanych części i należności za przepracowane godziny jest równa: " + suma_materiałów_i_należność_za_przepracowane_godziny.ToString("0.00") + " zł \n\n"
                + "Wynagrodzenie mechanika " + comboBox1.SelectedItem.ToString() + " jest równe: " + wynagrodzenie.ToString("0.00") +" zł", "Raport mechanika: "
                + comboBox1.SelectedItem.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void button_wynagrodzenie_dla_wszystkich_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;

            for (int i = 0; i < Mechanik.lista_mechaników.Count; i++)
            {
                foreach (Naprawa naprawa in Naprawa.lista_napraw)
                {
                    if (naprawa.mechanik.ToString() == Mechanik.lista_mechaników[i].imię_nazwisko)
                    {
                        (Mechanik.lista_mechaników[i]).wynagrodzenie += naprawa.wynagrodzenie_dla_mechanika_za_naprawę;
                    }
                }

                msg += "Wynagrodzenie dla mechanika: " + Mechanik.lista_mechaników[i].imię_nazwisko.ToString() + " jest równe "
                    + Mechanik.lista_mechaników[i].wynagrodzenie + "zł\n";
            }

            MessageBox.Show(msg, "Raport wynagrodzeń mechaników", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
