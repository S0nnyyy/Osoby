using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void jménoPříjmeníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Opravdu si přejete ukončit aplikaci?", "Ukončení aplikace", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Textové pole Jméno je prázdné. Zadejte prosím text.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Textové pole Příjmení je prázdné. Zadejte prosím text.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox2.Items.Add(textBox2.Text);
                textBox2.Clear();
            }
        }


        private void jménoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Textové soubory (*.txt)|*.txt";
            saveFileDialog.Title = "Vyberte umístění pro exportovaný soubor";
            saveFileDialog.FileName = "osoby.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var item in listBox1.Items)
                        {
                            sw.WriteLine(item.ToString());
                        }
                    }
                    MessageBox.Show("Jména byla úspěšně exportována do souboru.", "Export dokončen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Při exportu došlo k chybě: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void příjmeníToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Textové soubory (*.txt)|*.txt";
            saveFileDialog.Title = "Vyberte umístění pro exportovaný soubor";
            saveFileDialog.FileName = "osoby.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var item in listBox2.Items)
                        {
                            sw.WriteLine(item.ToString());
                        }
                    }
                    MessageBox.Show("Příjmení byla úspěšně exportována do souboru.", "Export dokončen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Při exportu došlo k chybě: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void jménoPřijmeníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != listBox2.Items.Count)
            {
                int pocetJmen = listBox1.Items.Count;
                int pocetPrijmeni = listBox2.Items.Count;
                MessageBox.Show($"Počet jmen ({pocetJmen}) se neshoduje s počtem příjmení ({pocetPrijmeni}).", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var persons = Enumerable.Range(0, listBox1.Items.Count)
                                     .Select(i => $"{listBox1.Items[i]} {listBox2.Items[i]}");

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Textové soubory (*.txt)|*.txt";
            saveFileDialog.Title = "Vyberte umístění pro exportovaný soubor";
            saveFileDialog.FileName = "osoby.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var person in persons)
                        {
                            writer.WriteLine(person);
                        }
                    }
                    MessageBox.Show($"Osoby byly úspěšně exportovány do souboru {saveFileDialog.FileName}.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Nastala chyba při exportu osob: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void jménoPříjmeníToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Textové soubory (*.txt)|*.txt|Všechny soubory (*.*)|*.*";
            openFileDialog.Title = "Vyberte soubor s osobami k importu";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);

                    DialogResult result = MessageBox.Show("Chcete smazat stávající data a nahradit je novými?", "Režim importu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Cancel)
                        return;

                    if (result == DialogResult.Yes)
                    {
                        listBox1.Items.Clear();
                        listBox2.Items.Clear();
                    }

                    foreach (var line in lines)
                    {
                        string[] parts = line.Split(' ');
                        if (parts.Length == 2)
                        {
                            listBox1.Items.Add(parts[0]);
                            listBox2.Items.Add(parts[1]);
                        }
                    }

                    string mode = result == DialogResult.Yes ? "nahrazena" : "přidána k";
                    MessageBox.Show($"Osoby byly úspěšně {mode} stávajícím datům.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Nastala chyba při importu osob: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}