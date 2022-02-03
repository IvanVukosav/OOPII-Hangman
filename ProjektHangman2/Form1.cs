using ProjektHangman2.Properties;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Runtime.Remoting.Messaging;
using System.Xml.Serialization;

namespace ProjektHangman2
{

    public partial class Form1 : Form
    {
        string[] rijeci = { "hello", "and", "welcome", "grad", "drzava", "glagol", "imenica", "bomba", "sloboda","snaga","banana","zgrada",
                           "policija","vatrogasci","priroda","matematika","generacija","kruska","biciklo","zatvor","kuca","spontano","pobjeda",
                           "vrijeme","blizanac","povezane","banalno","metafora","hitna","vizija","dinosaur","semafor","pjena","kabel","igra",
                           "biljeznica","rukavica","ljeto","jesen","zima","proljece","stolic","zvonce","treava","prst","jakna","patike","televizija",
                           "miris","prozor","ogledalo","jastuk","plahta","krevet","daska","crveno","brod","kapetan","more","hrvatska","nogomet"
                          };

        private Bitmap[] Slike = { Resources.slika4, Resources.slika5, Resources.slika6,
                                   Resources.slika7, Resources.slika8,Resources.slika9,
                                   Resources.slika10
                                 };

        int index = 0;
        int NRijec = 0;
        int pogresni = 0;
        int Jednom = 0;
        private List<Spremanje> Korisnici = new List<Spremanje>();//xml
        List<string> Nesmije = new List<string>();//dodaj u listu slova koja su vec isprobana
        string slova = "";//"brojac"

        public void UcitajRijeci()
        {
            try
            {
                //kods
                List<string> Rijeci = new List<string>();//dodaj u listu 
                foreach(string s in rijeci)
                {
                    Rijeci.Add(s);
                }
                
                var rand = new Random();
                int NasumicnaRijec = rand.Next(Rijeci.Count);//funkcija za brojanje elemenata
                NRijec = NasumicnaRijec;//global

                for (int i = 0; i < rijeci[NasumicnaRijec].Length; i++)
                {
                    slova += "_";//ovo mijenjat zelimo za slova,imamo duzina rijeci crtica
                }
                Prikaz();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Prikaz()
        {
            Slova.Text = " ";

            for (int i = 0; i < rijeci[NRijec].Length; i++)
            {
                Slova.Text += slova.Substring(i, 1);
                Slova.Text += " ";
            }
        }
        public Form1()
        {
            InitializeComponent();
            UcitajRijeci();
            
        }

        private void Ogranicenje(object sender, EventArgs e)
        {
            UnosSlova.MaxLength = 1;
        }
        //
        private void Unesi_Click(object sender, EventArgs e)
        {
            string[] a = UnosSlova.Lines;//textbox slovo
            string b = String.Join("", a);//pretvori u string


            if (String.IsNullOrEmpty(UnosSlova.Text))
            {
                MessageBox.Show("Niste unijeli vrijednost");
            }
            else
            {
                if (rijeci[NRijec].Contains(a[0]))
                {
                    //razdvoji rijec u slova //update
                    char[] privremenaProm = slova.ToCharArray();//crtice 
                    char[] Slova = rijeci[NRijec].ToCharArray();//slova

                    char Pogadanje = b.ElementAt(0);// u char
                    for (int i = 0; i < Slova.Length; i++)
                    {
                        if (Slova[i] == Pogadanje)
                        {
                            privremenaProm[i] = Pogadanje;
                        }
                    }
                    slova = new string(privremenaProm);
                    Prikaz();//update prikaza
                }
                else
                {
                    if (Nesmije.Contains(b))
                    {
                        MessageBox.Show("Vec ste pokušali to slovo!");
                    }
                    else
                    {
                        index++;
                    }
                }
            }
            Nesmije.Add(b);//spremi slovo u niz i prolazimo nizom i kazemo da se ne smije stisnut ako se nalazi u ovom nizu

            pogresni = index;//global
            if (index <= 6)
            {
                HangSlike.Image = Slike[index];
            }
            if (index == 6)
            {
                MessageBox.Show(String.Format("Game Over!\nRijec je: {0}", rijeci[NRijec]));
            }
            if (!slova.Contains("_")){
                MessageBox.Show("Pobjeda!");
            };
            UnosSlova.Clear();
        }
        private void Stisnut(object sender, KeyEventArgs e)
        {
            UnosSlova.CharacterCasing = CharacterCasing.Lower;//
        }

        //xml - spremanja 
        private void SpremiClick(object sender, EventArgs e)
        {
            Jednom++;
            if (Jednom <=1)
            {
                // novi korisnik
                Spremanje Korisnik = new Spremanje
                {
                    ime = Ime.Text,
                    prezime = Prezime.Text,
                    Pogresni = pogresni,
                };
                Korisnici.Add(Korisnik);
                // updejtat izvor podataka
               
                ListBox.DataSource = null;
                ListBox.DataSource = Korisnici;
                Serialize();
                Deserialize();
                ListBox.DataSource = Korisnici;
            }
        }

        private void Serialize()
        {
            try
            {
                // serijalizacija tipa List<Korisnik> 
                XmlSerializer serializer = new XmlSerializer(Korisnici.GetType());

                using (StreamWriter sw = new StreamWriter("Hangman1.xml"))
                {
                    serializer.Serialize(sw, Korisnici);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deserialize()
        {
            try
            {
                if (File.Exists("Hangman1.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(Korisnici.GetType());
                    using (StreamReader sr = new StreamReader("Hangman1.xml"))
                    {
                        Korisnici = (List<Spremanje>)serializer.Deserialize(sr);
                    }
                }
                else throw new FileNotFoundException("File not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //prozor velicina save
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.VelicinaForme = this.Size;
                //spremanje korisničkih postavki
                Properties.Settings.Default.Save();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.VelicinaForme.Width != 0 &&
                Properties.Settings.Default.VelicinaForme.Height != 0)
            {
                this.Size = Properties.Settings.Default.VelicinaForme;
            }
        }
        private void NewGameClick(object sender, EventArgs e)
        {
            Klasa NovaKlasa = new Klasa();
            Klasa.form = this;
            Nesmije.Clear();
            slova = " "; Jednom = 0; 
            HangSlike.Image = Slike[NovaKlasa.reset];
            NovaKlasa.funkcija();
           
        }

    }
}
