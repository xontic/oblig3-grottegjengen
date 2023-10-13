using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace GUISensor.exe
{
    public partial class Form1 : Form
    {
        List<Isensor> sensorer = new List<Isensor>();
        int sensorteller = 1;
        int index = 0;
        object sensortype;

        public Form1()
        {
            InitializeComponent();
            comboxSensor.SelectedIndexChanged += comboxSensor_SelectedIndexChanged;
        }

        private void btnNyTemperatur_Click(object sender, EventArgs e)
        {
            Temperaturmaaler tempmaaler = new Temperaturmaaler(sensorteller);
            sensorer.Add(tempmaaler); //Adder de i listen for lagring til fil
            comboxSensor.Items.Add(tempmaaler); //Adder de i comboboxen for alle sensorene
            comboxSensor.SelectedIndex = index; //Kode for � velge hvilken index man er i sensor combobox
            sensorteller += 1; //Opdateren sensorteller slik at sensorID �ker
            index += 1; //Oppdaterer index til combobox ettersom ny sensor er opprettet
        }

        private void btnNyTrykkmaaler_Click(object sender, EventArgs e)
        {
            Trykkmaaler trykkmaaler = new Trykkmaaler(sensorteller);
            sensorer.Add(trykkmaaler); //Adder de i listen for lagring til fil
            comboxSensor.Items.Add(trykkmaaler); //Adder de i comboboxen for alle sensorene
            comboxSensor.SelectedIndex = index; //Kode for � velge hvilken index man er i sensor combobox
            sensorteller += 1; //Opdateren sensorteller slik at sensorID �ker
            index += 1; //Oppdaterer index til combobox ettersom ny sensor er opprettet

        }

        private void btnNyMaaling_Click(object sender, EventArgs e)
        {

            sensortype = comboxSensor.SelectedItem; //Lager et objekt for den valgte sensoren i combobox
            //Kj�rer if setning for � finne ut hvilken type sensor det er
            if (sensortype is Temperaturmaaler) 
            {
                Temperaturmaaler s = sensortype as Temperaturmaaler; //Oppretter ny variabel for en temperaturmaaler slik at Maal() kan kj�res
                s.Maal();
                RefreshDataITextBox(); //Kj�rer metoden for tekstboksen slik at den refresher
            }
            else if (sensortype is Trykkmaaler)
            {
                Trykkmaaler s = sensortype as Trykkmaaler; //Oppretter ny variabel for en trykkm�ler slik at Maal() kan kj�res
                s.Maal();
                RefreshDataITextBox(); //Kj�rer metoden for tekstboksen slik at den refresher
            }


        }

        private void btnSlettMaaling_Click(object sender, EventArgs e) //Egentlig Slett Sensor, bare navngitt feil
        {
            int index = comboxSensor.SelectedIndex; //Finner indexen til sensor som er valgt i combobox
            if (index == -1) //Kj�rer en if slik at om en sensor ikke er valgt vil ikkje programmet kresje
            {
                MessageBox.Show("Du kan ikke slette noe som ikke er der");
            }
            else
            {
                comboxSensor.Items.RemoveAt(index); //Sletter sensoren og det som er linket med i tekstboks
                txtTekstboks.Clear();
            }


        }

        private void toolStripMenuLagre_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Text Files | *.txt";
            saveFileDialog1.FilterIndex = 1;
            DialogResult utfall = saveFileDialog1.ShowDialog(); //�pner dialog boks for lagring
            if (utfall == DialogResult.OK) //S� lenge bruker har velgt en fil s� kj�rer en kode under
            {
                StreamWriter writer = null;

                try //Kj�rer try catch for � h�ndtere noe feil som er under slik at programmet ikkje kresjer
                {
                    writer = File.CreateText(saveFileDialog1.FileName); //�pner filen som skal lagres til

                    //For � kunne displaye verdier riktig igjen n�r de blir hentet fra fil s� legger eg til enten temperaturm�ler i stringen
                    //Eller trykkm�ler slik at en senere kan opprette nye objekter basert p� hva type den er. WriteLine vil lagre det som string
                    //Og gj�r det da vanskelig � finne ut hva type sensor det er, derfor er string lagt til bak sensordata for � finne tilbake
                    //Til hva sensor det er
                    foreach (Isensor sensorer in sensorer) 
                    {
                        if(sensorer is Temperaturmaaler)
                        {
                            Temperaturmaaler tempmaaler = sensorer as Temperaturmaaler;
                            writer.WriteLine(tempmaaler.ToString() + "M�ling: " + tempmaaler.Temperatur.ToString("F2") + " Temperaturm�ler");
                        }
                        else if (sensorer  is Trykkmaaler)
                        {
                            Trykkmaaler trykkmaaler = sensorer as Trykkmaaler;
                            writer.WriteLine(trykkmaaler.ToString() + "M�ling: " + trykkmaaler.Trykk.ToString("F2") +  " Trykkm�ler");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Feil: " + ex.Message);
                }

                if (writer != null) writer.Close(); //Lukker filen n�r det er ferdig
            }
        }

        private void toolStripMenuAvslutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuLes_Click(object sender, EventArgs e)
        {
            comboxSensor.Items.Clear();
            DialogResult utfall = openFileDialog1.ShowDialog();
            int id = 0;

            if (utfall == DialogResult.OK)
            {
                sensorer.Clear();
                StreamReader reader = null;
                try
                {
                    reader = File.OpenText(openFileDialog1.FileName);
                    do
                    {
                        //Her kommer poenget med hvordan en lagret dataen til filen, nemlig at man kan s�ke etter hva sensor det er i filen
                        string enlinje = reader.ReadLine();
                        string type = enlinje.Substring(enlinje.IndexOf("T"), enlinje.Length - enlinje.IndexOf("T")); //S�ker da etter stringen som
                        //Er lagt til etter sensordata, og begge begynner p� T s� enkelt nok � s�ke for sensoren
                        string m�ling = enlinje.Substring(enlinje.IndexOf(":") + 1, enlinje.IndexOf("T") - enlinje.IndexOf(":") - 1); //S�ker for verdien av m�lingen mellom 
                        //Stringene M�ling: og Temperaturm�ler eller Trykkm�ler
                        double maaling = Convert.ToDouble(m�ling); //Konverter til double slik at de kan lagres inni klassen igjen
                        string idnummer = enlinje.Substring(0, enlinje.IndexOf('-') - 1); //Finner ut hvilken ID nummer sensoren har
                        id = Convert.ToInt32(idnummer); //Konverter til int slik at sensorteller som bestemmer ID nummer kan oppdateres
                        if(type == "Temperaturm�ler") //Viss det er tempm�ler s� opretter man ny tempm�ler med ID som er i filen
                        {
                            Temperaturmaaler tempmaaler = new Temperaturmaaler(id);
                            tempmaaler.Temperatur = maaling;
                            comboxSensor.Items.Add(tempmaaler);
                            sensorer.Add(tempmaaler);
                        }
                        else if (type == "Trykkm�ler")
                        {
                            Trykkmaaler trykkmaaler = new Trykkmaaler(id);
                            trykkmaaler.Trykk = maaling;
                            comboxSensor.Items.Add(trykkmaaler);
                            sensorer.Add(trykkmaaler);
                        } 
                    } while (reader.EndOfStream == false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Feil: " + ex.Message);
                }
                if (reader != null) reader.Close();
                sensorteller = id + 1;
                index = id;
            }
        }

        private void toolStripMenuFjern_Click(object sender, EventArgs e) //Sletter alt som er i combobox og tekstboks. Setter og indexen til combox tilbake slik at den kan finne indexen sin senere
        {
            comboxSensor.Items.Clear();
            txtTekstboks.Clear();
            index = 0;
        }



        private void comboxSensor_SelectedIndexChanged(object sender, EventArgs e)
        {

            RefreshDataITextBox(); //Kj�rer metoden for � refreshe textbox for valgt sensor
        } 
        private void RefreshDataITextBox()
        {
            sensortype = comboxSensor.SelectedItem; //Finner objektet som er i comboboxen

            if (sensortype is Temperaturmaaler) //Finner ut hvilken type sensor det er
            {
                Temperaturmaaler temp = sensortype as Temperaturmaaler; //Oppretter midlertidlig temperaturobjekt
                txtTekstboks.Text = "Type: Temperaturm�ler\r\nIdnummer: " + 
                    temp.Id.ToString() + "\r\nSiste m�ling: " + temp.Temperatur.ToString("F2"); //Skriver da ut info om sensor til textbox med 2 desimaler for m�lingen
            }
            else if (sensortype is Trykkmaaler)
            {
                Trykkmaaler trykk = sensortype as Trykkmaaler; //Oppretter midlertidlig temperaturobjekt
                txtTekstboks.Text = "Type: Trykkm�ler\r\nIdnummer: " +
                    trykk.Id.ToString() + "\r\nSiste m�ling: " + trykk.Trykk.ToString("F2"); //Skriver da ut info om sensor til textbox med 2 desimaler for m�lingen
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}