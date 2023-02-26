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

namespace ProjektPP
{
    public partial class Form1 : Form
    {
        public static string tytul = "title";
        public static double suma;
        public static double temp;
        public static int accuracy = 4;
        List<double> samples = new List<double>();
        public double average, maxValue, minValue, variance;
        public int quantity;
        public Form1()
        {
            InitializeComponent();
            label_zaladuj.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //---Przyciski Klikanie---///
        private void button_zaladuj_Click(object sender, EventArgs e)
        {

            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "/.";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Contains(".txt"))
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            button_zaladuj.AccessibleRole = AccessibleRole.None;
                            button_zaladuj.Enabled = false;
                            button_zapisz.AccessibleRole = AccessibleRole.Default;
                            label_main_zaladowanyplik.ForeColor = Color.Cyan;

                            //label_komunikat.Text = "Wczytano pliki " + openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf(@"\") + 1);

                            label_main_zaladowanyplik.Text = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf(@"\") + 1);

                            string file = File.ReadAllText(openFileDialog1.FileName);
                            string[] readData = file.Split(';').ToArray();
                            label_komunikat.Text = "";
                           
                            
                            double number;

                            if (!double.TryParse(readData[0], out number))
                                tytul = readData[0];

                            for (int i = 0; i < readData.Length - 1; i++)
                            {
                                if (double.TryParse(readData[i], out number))
                                    samples.Add(number);
                            }
                            calculateValues();
                            myStream.Close();
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Błąd: Nie można było wczytać pliku.\nOriginal error: " + ex.Message, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (openFileDialog1.FileName == "")
            {
                MessageBox.Show("Nie wybrano pliku!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Błąd: Wybrano zły typ pliku!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void button_wyswietl_Click(object sender, EventArgs e)
        {
            if (label_main_zaladowanyplik.Text == "Brak pliku")
            {
                MessageBox.Show("Nie wybrano pliku!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Wykres wykres = new Wykres(samples, tytul);
                wykres.Show();
                //button_wyswietl.Enabled = false;
                
            }
        }
        
        public void calculateValues()
        {
            quantity = samples.Count;

            for (int i = 0; i < samples.Count; i++)
            {
                suma += samples[i];
            }
            average = Math.Round(suma / samples.Count, accuracy);
            samples.Sort();
            maxValue = Math.Round(samples[samples.Count - 1], accuracy);
            minValue = Math.Round(samples[0], accuracy);

            for (int j = 0; j < samples.Count; j++)
            {
                temp += Math.Pow(samples[j] - average, 2);
            }
            variance = Math.Round(temp / samples.Count, accuracy);

            ilosc.Text = quantity.ToString();
            srednia.Text = average.ToString();
            wariancja.Text = variance.ToString();
            max.Text = maxValue.ToString();
            min.Text = minValue.ToString();

        }

        private void button_wyczysc_Click(object sender, EventArgs e)
        {
            button_zaladuj.Enabled = true;
            label_main_zaladowanyplik.Text = "Brak pliku";
            ilosc.Text = "";
            max.Text = "";
            min.Text = "";
            srednia.Text = "";
            wariancja.Text = "";
           
        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Plik nie został zapisany", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {

                List<string> zapisz = new List<string> { };

                zapisz.Add("Wartość maksymalna: " + max.Text);
                zapisz.Add("Wartość minimalna: " + min.Text);
                zapisz.Add("Wartość średnia: " + srednia.Text);
                zapisz.Add("Wariancja: " + wariancja.Text);

                try
                {
                    System.IO.File.AppendAllLines(saveFileDialog1.FileName, zapisz);
                    MessageBox.Show("Zapisano pomyślnie", "Zapisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
                }

            }
        }

      
                                       //---Cringe bugged JM---//
        private void label_zaladuj_Click(object sender, EventArgs e)
        {

        }
        private void label_zaladuj_Point(object sender, EventArgs e)
        {

        }
        private void button_zaladuj_MouseEnter(object sender, EventArgs e)
        {
            //panel_left.Height = button_zaladuj.Height;
            //panel_left.Top = button_zaladuj.Top;
            //label_zaladuj.Visible = true;
        }

        private void button_wyczysc_MouseEnter(object sender, EventArgs e)
        {
            //panel_left.Height = button_wyczysc.Height;
            //panel_left.Top = button_wyczysc.Top;
            //label_wyczysc.Visible = true;
        }

        private void button_zapisz_MouseEnter(object sender, EventArgs e)
        {
            //panel_left.Height = button_zapisz.Height;
            //panel_left.Top = button_zapisz.Top;
            //label_zapisz.Visible = true;
        }


                                   //---Przyciski po najechaniu---///
        private void button_zaladuj_MouseMove(object sender, MouseEventArgs e)
        {
            panel_left.Height = button_zaladuj.Height;
            panel_left.Top = button_zaladuj.Top;
            label_zaladuj.Visible = true;
            label_wyczysc.Visible = false;
            label_wykres.Visible = false;
            label_zapisz.Visible = false;
        }

        private void button_wyswietl_MouseMove(object sender, MouseEventArgs e)
        {
            panel_left.Height = button_wyswietl.Height;
            panel_left.Top = button_wyswietl.Top;
            label_zaladuj.Visible = false;
            label_wyczysc.Visible = false;
            label_wykres.Visible = true;
            label_zapisz.Visible = false;
        }

        private void button_wyczysc_MouseMove(object sender, MouseEventArgs e)
        {
            panel_left.Height = button_wyczysc.Height;
            panel_left.Top = button_wyczysc.Top;
            label_zaladuj.Visible = false;
            label_wyczysc.Visible = true;
            label_wykres.Visible = false;
            label_zapisz.Visible = false;
        }

        private void button_zapisz_MouseMove(object sender, MouseEventArgs e)
        {
            panel_left.Height = button_zapisz.Height;
            panel_left.Top = button_zapisz.Top;
            label_zaladuj.Visible = false;
            label_wyczysc.Visible = false;
            label_wykres.Visible = false;
            label_zapisz.Visible = true;
        }

                                    //---Zaladuj Plik---//
                                    
        public void label_main_zaladowanyplik_MouseMove(object sender, MouseEventArgs e)
        {
            //label_main_zaladowanyplik.Text = "załadowany plik";
        }

        public void label_main_zaladowanyplik_MouseLeave(object sender, EventArgs e)
        {
            //label_main_zaladowanyplik.Text = "brak pliku";
        }


                                    //Jakis cringe tez---//
        private void ilosc_TextChanged(object sender, EventArgs e)
        {

        }

        private void max_TextChanged(object sender, EventArgs e)
        {

        }

        private void min_TextChanged(object sender, EventArgs e)
        {

        }

        private void wariancja_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_right_zaladowanyplik_Click(object sender, EventArgs e)
        {

        }

        private void srednia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_left_zaladowanyplik_Click(object sender, EventArgs e)
        {

        }

        private void label_main_zaladowanyplik_Click(object sender, EventArgs e)
        {

        }
    }
}
