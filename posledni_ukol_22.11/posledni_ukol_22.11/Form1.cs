using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posledni_ukol_22._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hledat_Click(object sender, EventArgs e)
        {
            int min = 0, i = 0;
            bool pravda = false;

            while (i <= vstup.Lines.Length && pravda == false)
            {
                try
                {
                    if (Convert.ToInt32(vstup.Lines[i]) % 2 == 0)
                    {
                        min = Convert.ToInt32(vstup.Lines[i]);
                        pravda = true;

                        if (Convert.ToInt32(vstup.Lines[i]) < min && pravda == true)
                        {
                            min = Convert.ToInt32(vstup.Lines[i]);
                        }
                    }
                }
                catch
                {

                }
                i++;
            }

            i = 0;

            try
            {
                while (i < vstup.Lines.Length)
                {
                    if (Convert.ToInt32(vstup.Lines[i]) < min && Convert.ToInt32(vstup.Lines[i]) % 2 == 0)
                    {
                        min = Convert.ToInt32(vstup.Lines[i]);
                    }
                    i++;
                }

                if (pravda == false)
                {
                    MessageBox.Show("V textBoxu nejsou sudá čísla", "Výsledek");
                }
                else
                {
                    MessageBox.Show("Nejmenší sudé číslo v textBoxu je " + min, "Výsledek");
                }
            }
            catch
            {
                MessageBox.Show("Můžeš zadat pouze čísla!", "Error");
            }
        }
    }
}
