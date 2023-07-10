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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mechanik.lista_mechaników.Clear();

            Mechanik.dodaj_mechanika();  
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            Naprawa nowa_naprawa = new Naprawa();
            FormNaprawa formNaprawa = new FormNaprawa(nowa_naprawa);
            if (formNaprawa.ShowDialog() == DialogResult.OK)
                Naprawa.lista_napraw.Add(nowa_naprawa);
            odśwież();
        }
        void odśwież()
        {
            dataGridView1.Rows.Clear();
            foreach (Naprawa naprawa in Naprawa.lista_napraw)
            {
                int index = dataGridView1.Rows.Add(naprawa.Values);
                dataGridView1.Rows[index].Tag = naprawa;
            }
        }

        private void button_edytuj_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak napraw.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            Naprawa naprawa = (Naprawa)dataGridView1.SelectedRows[0].Tag;
            FormNaprawa form = new FormNaprawa(naprawa);
            form.ShowDialog();
            odśwież();
        }

        private void button_usuń_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak napraw.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult msg = MessageBox.Show("Po wykonaniu tego polecenia nie będzie możliwe przywrócenie usuniętej naprawy. " +
                        "Czy na pewno chcesz usunąć tą naprawę?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                Naprawa naprawa = (Naprawa)dataGridView1.SelectedRows[0].Tag;
                Naprawa.lista_napraw.Remove(naprawa);
                odśwież();
            }
        }

        private void button_raport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Brak napraw.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormRaport raport = new FormRaport();
            raport.ShowDialog();     
        }
    }
}
