using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // private variabelen aanmaken
        private Random will = new Random();
        private Speler speler1;
        private Speler speler2;


        private void Form1_Load(object sender, EventArgs e)
        {
            // Instanties aanmaken
            speler1 = new Speler();
            speler2 = new Speler();

            // Gegevens speler1 ingeven
            speler1.Naam = "Pikachu";
            speler1.Gezondheid = 100;
            speler1.PositieX = will.Next(1, 501);
            speler1.PositieY = will.Next(1, 501);
            speler1.IsLevend = true;

            // Gegevens speler2 ingeven
            speler2.Naam = "Gengar";
            speler2.Gezondheid = 100;
            speler2.PositieX = will.Next(1, 501);
            speler2.PositieY = will.Next(1, 501);
            speler2.IsLevend = true;

            // Text van labellen en buttons aanpassen
            labelGezondheid1.Text = "Gezondheid: " + speler1.Gezondheid;
            labelGezondheid2.Text = "Gezondheid: " + speler2.Gezondheid;
            labelSpeler1.Text = speler1.Naam;
            buttonValAan1.Text = "Val gengar aan...";
            labelSpeler2.Text = speler2.Naam;
            buttonValAan2.Text = "Val pikachu aan...";
        }


        // De val aan knoppen
        private void buttonValAan1_Click(object sender, EventArgs e)
        {
            // Speler beschadigen door OntvangSchade methode op te roepen 
            speler2.Gezondheid = speler2.OntvangSchade(will.Next(1, 11));
            // Checken of speler 2/gengar dood is of niet
            if (speler2.Gezondheid <= 0)
            {
                // MessageBox tonen als dood en gezondheid instellen als 0
                MessageBox.Show("Gengar is dood");
                speler2.IsLevend = false;
                speler2.Gezondheid = 0;
                labelGezondheid2.Text = "Gezondheid: " + speler2.Gezondheid;
            }
            else
            {
                // Gezondheid-label updaten
                labelGezondheid2.Text = "Gezondheid: " + speler2.Gezondheid;
            }
        }

        // Hetzelfde als bij het vorige maar dan bij speler 1/pikachu
        private void buttonValAan2_Click(object sender, EventArgs e)
        {
            speler1.Gezondheid = speler1.OntvangSchade(will.Next(1, 11));
            if (speler1.Gezondheid <= 0)
            {
                MessageBox.Show("Pikachu is dood");
                speler1.IsLevend = false;
                speler1.Gezondheid = 0;
                labelGezondheid1.Text = "Gezondheid: " + speler1.Gezondheid;
            }
            else
            {
                labelGezondheid1.Text = "Gezondheid: " + speler1.Gezondheid;
            }
            
        }

        // Genees knoppen
        private void buttonGenees1_Click(object sender, EventArgs e)
        {
            // Checken of gezondheid maximum is
            if (speler1.Gezondheid == 100)
            {
                // Niks doen als de gezondheid 100 is omdat dat het maximum is.
            }
            else
            {
                // Speler genezen door genees methode op te roepen en gezondheid-label updaten
                speler1.Gezondheid = speler1.Genees(will.Next(1, 6));
                labelGezondheid1.Text = "Gezondheid: " + speler1.Gezondheid;
            }
        }

        private void buttonGenees2_Click(object sender, EventArgs e)
        {
            // Checken of gezondheid maximum is.
            if (speler2.Gezondheid == 100)
            {
                // Niks doen als de gezondheid 100 is omdat dat het maximum is.
            }
            else
            {
                // Speler genezen door genees methode op te roepen en gezondheid-label updaten
                speler2.Gezondheid = speler2.Genees(will.Next(1, 6));
                labelGezondheid2.Text = "Gezondheid: " + speler2.Gezondheid;
            }
        }

        private void buttonToonPos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pikachu: (" + speler1.PositieX + ", " + speler1.PositieY + ")" + 
                Environment.NewLine + 
                "Gengar: (" + speler2.PositieX + ", " + speler2.PositieY + ")");
        }
    }
}
