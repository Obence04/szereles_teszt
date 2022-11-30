using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szereles_teszt
{
    public partial class Osztott : Form
    {
        public Osztott()
        {
            InitializeComponent();
            Olvas_felsz("felszerelesek.csv");
            KerdesGeneralas();
            #region felszerelés kódtábla
            Kod.Add('B', "B tömlő");
            Kod.Add('C', "C tömlő");
            Kod.Add('O', "Osztó");
            Kod.Add('S', "Sugárcső");
            #endregion 
        }

        static List<char> felszereles = new();
        static List<Adat_Osztott> lista = new List<Adat_Osztott>();
        static Dictionary<char, string> Kod = new Dictionary<char, string>();
        static int[] kerdes = new int[2];

        private void KerdesGeneralas()
        {
            Random rnd = new();
            bool ki = false;
            int beo = 0;
            int kr = 1;
            do
            {
                beo = rnd.Next(1, 6);
                
                if (beo == 1 && kr == 1) ki = true;
                else if (beo == 2 && kr == 1) ki = true;
                else if (beo == 3 && kr == 1)
                {
                    kr = rnd.Next(1, 3);
                    ki = true;
                }
                else if (beo == 4 && kr == 1)
                {
                    kr = rnd.Next(1, 3);
                    ki = true;
                }
                else if (beo == 5 && kr == 1) ki = true;
            } while (!ki);

            kerdes[0] = beo;
            kerdes[1] = kr;

            string kerdes1 = "Mit vesz magához ";

            string kerdes2 = beo.ToString();
            if (beo == 1) kerdes2 += "-es ";
            else if (beo == 2) kerdes2 += "-es ";
            else if (beo == 3) kerdes2 += "-as ";
            else if (beo == 4) kerdes2 += "-es ";
            else if (beo == 5) kerdes2 += "-ös ";
            else throw new IndexOutOfRangeException();

            string kerdes3 = $"a {kr}. körben?";
            string kerdes4 = kerdes1 + kerdes2 + kerdes3;
            LB_Kerdes.Text = kerdes4;
        }
        private static void Olvas_felsz(string fajlnev)
        {
            using FileStream fs = new(@"..\..\..\files\" + fajlnev, FileMode.Open);
            using StreamReader sr = new(fs, Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');
                int beosztott = Convert.ToInt16(s[0]);
                int kor = Convert.ToInt16(s[1]);
                string felszereles = s[2];
                lista.Add(new Adat_Osztott(beosztott, kor, felszereles));
            }
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            char bejovo = 'L';
            string tag = sender.GetType().GetProperty("Tag").GetValue(sender).ToString();
            if (tag == "B_Tomlo") bejovo = 'B';
            else if (tag == "C_Tomlo") bejovo = 'C';
            else if (tag == "Oszto") bejovo = 'O';
            else if (tag == "Sugarcso") bejovo = 'S';

            Frissites(bejovo);
        }

        private void Frissites(char bevitel)
        {
            felszereles.Add(bevitel);
            felszereles.Sort();
            string ki = "";
            foreach (var i in felszereles)
            {
                ki+=i;
            }
            //MessageBox.Show(ki);
            Valasz(ki);
            //MessageBox.Show(valasz1);

        }

        private void Valasz(string be)
        {
            string valasz = "Válasz: ";
            string valasz1 = "";
            for (int i = 0; i < felszereles.Count; i++)
            {
                if (Kod.ContainsKey(be[i])) Kod.TryGetValue(be[i], out valasz1);
                valasz += valasz1 + ", ";
            }
            LB_Valasz.Text = valasz;
        }

        private void Osztott_FormClosing(object sender, FormClosingEventArgs e)
        {
            felszereles.Clear();
            Kod.Clear();
            lista.Clear();
        }

        private void Torol(object sender, EventArgs e)
        {
            felszereles.Clear();
            Valasz(null);
        }

        private void Ellenorzes(object sender, EventArgs e)
        {
            //kikeresi a helyes megoldást
            //összehasonlítja a felh. megoldásával
            List<char> megoldas = new();
            int i = 0;
            while (kerdes[0] != lista[i].beosztott || kerdes[1] != lista[i].kor || i == lista.Count) i++;
            if (i == lista.Count) throw new NotImplementedException();
            else
            {
                Font font = new Font(LB_Visszajelzes.Font.Name, 12, FontStyle.Underline);
                try
                {
                    int j = 0;
                    while (j < lista[i].felszereles.Length && lista[i].felszereles[j] == felszereles[j]) j++;
                    if (j == lista[i].felszereles.Length && j == felszereles.Count)
                    {
                        LB_Visszajelzes.Font = font;
                        LB_Visszajelzes.ForeColor = Color.Green;
                        LB_Visszajelzes.Text = "Helyes megoldás!";
                    }
                    else
                    {
                        LB_Visszajelzes.Font = font;
                        LB_Visszajelzes.ForeColor = Color.Red;
                        LB_Visszajelzes.Text = "Helytelen megoldás!";
                    }
                }
                catch (ArgumentOutOfRangeException ie)
                {
                    LB_Visszajelzes.Font = font;
                    LB_Visszajelzes.ForeColor = Color.Orange;
                    if (felszereles.Count == 0) LB_Visszajelzes.Text = "Adjon meg legalább 1 elemet!";
                }
                
            }
        }
    }
}
