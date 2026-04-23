using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    internal class Speler
    {
		// Eigenschappen maken

		private string _naam;
		public string Naam
		{
			get { return _naam; }
			set { _naam = value; }
		}

		private int _gezondheid;

		public int Gezondheid
		{
			get { return _gezondheid; }
			set { _gezondheid = value; }
		}

		private int _positiex;

		public int PositieX
		{
			get { return _positiex; }
			set { _positiex = value; }
		}

		private int _positiey;

		public int PositieY
		{
			get { return _positiey; }
			set { _positiey = value; }
		}

		private bool _islevend;

		public bool IsLevend
		{
			get { return _islevend; }
			set { _islevend = value; }
		}

		// Constructors maken
		// 1e Constructor default waarde initialiseren
		public Speler()
		{
			Naam = "";
			Gezondheid = 100;
			PositieX = 0;
			PositieY = 0;
			IsLevend = true;
		}

		// 2e constructor waar alle properties meegegeven kunnen worden als parameter
		public Speler(string naam, int gezondheid, int posX, int posY, bool isLevend)
		{
			Naam = naam;
			Gezondheid = gezondheid;
			PositieX = posX;
			PositieY = posY;
			IsLevend = isLevend;
		}

		// Methodes

		public int Verplaats(int x, int y)
		{
			return x & y;
		}

		public int OntvangSchade(int hp)
		{
			// De gezondheid min de schade
            Gezondheid -= hp;
            
			return Gezondheid;
		}

		public int Genees(int hp)
		{
			// Het aantal geneesde gezondheid/hp toevoegen aan Gezondheid
			Gezondheid += hp;
			// Checken of gezondheid nu meer is dan 100 aangezien het de max is, zo ja, dan wordt de rest afgetrokken van de gezondheid zodat het mooi 100 is
			if (Gezondheid >= 100)
			{
				Gezondheid -= (Gezondheid - 100);
			}

			return Gezondheid;
		}
	}
}
