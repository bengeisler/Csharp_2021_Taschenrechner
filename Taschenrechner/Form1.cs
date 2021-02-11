using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
	public partial class Form1 : Form
	{
		private double LetztesErgebnis;
		private double Summe;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnLöschen_Click(object sender, EventArgs e)
		{
			// Textfelder löschen
			txtZahl1.Text = "";
			txtZahl2.Text = "";

			lblMittelwert.Text = "Mittelwert: 0";
			lblSumme.Text = "Summe: 0";
			

			// Liste Verlauf löschen
			lstVerlauf.Items.Clear();

			// Globale Variablen zurücksetzen
			Summe = 0.0;
			LetztesErgebnis = 0.0;
		}

		private void btnAns_Click(object sender, EventArgs e)
		{
			txtZahl1.Text = LetztesErgebnis.ToString();

			// Bonus: Fokus in das zweite Eingabefeld setzen
			txtZahl2.Focus();
		}

		private void btnErgebnis_Click(object sender, EventArgs e)
		{
			try
			{
				// Beide Zahlen einlesen und in passenden Datentypen konvertieren
				double zahl1 = Convert.ToDouble(txtZahl1.Text);
				double zahl2 = Convert.ToDouble(txtZahl2.Text);
				double ergebnis = 0.0;
				string operation = "";

				// Ergebnis berechnen und Operation zwischenspeichern (für die Ausgabe)
				if (rBtnPlus.Checked)
				{
					ergebnis = zahl1 + zahl2;
					operation = " + ";
				}
				else if (rBtnMinus.Checked)
				{
					ergebnis = zahl1 - zahl2;
					operation = " - ";
				}				
				else if (rBtnMal.Checked)
				{
					ergebnis = zahl1 * zahl2;
					operation = " * ";
				}
				else if (rBtnGeteilt.Checked)
				{
					// Bonus: Division durch 0 bei Double abfangen

					// Alternative: Methode mit "return" verlassen
					//if (zahl2 == 0.0)
					//{
					//	lblFehler.Text = "Division durch 0 unzulässig.";
					//	return;
					//}

					if (zahl2 == 0.0) throw new DivideByZeroException();

					ergebnis = zahl1 / zahl2;
					operation = " / ";
				}
				else
				{
					lblFehler.Text = "Bitte wählen Sie eine gültige Rechenoperation aus!";
					return;
				}

				// Ergebnis der Listbox hinzufügen
				lstVerlauf.Items.Add(
					zahl1 + 
					operation + 
					zahl2 +
					" = " +
					ergebnis);

				// Ergebnis in globaler Variable speichern
				LetztesErgebnis = ergebnis;

				// Gesamtsumme aufaddieren und ausgeben
				Summe += ergebnis;
				lblSumme.Text = "Summe: " + Summe;

				// Mittelwert berechnen und ausgeben
				lblMittelwert.Text = "Mittelwert: " + (Summe / lstVerlauf.Items.Count);

				// Eingabefelder leeren
				txtZahl1.Text = "";
				txtZahl2.Text = "";

				// Bonus: Fokus in erstes Feld setzen
				txtZahl1.Focus();
			}
			catch (FormatException)
			{
				lblFehler.Text = "Bitte geben Sie gültige Zahlen ein!";
			}
			catch (DivideByZeroException)
			{
				lblFehler.Text = "Division durch 0 ist unzulässig";
			}
			catch (Exception ex)
			{
				lblFehler.Text = "Fehler: " + ex.Message;
			}
		}

		private void FehlermeldungRücksetzen(object sender, EventArgs e)
		{
			lblFehler.Text = "";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lblMittelwert.Text = "Mittelwert: 0";
			lblSumme.Text = "Summe: 0";
		}

		private void txtZahl2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btnErgebnis_Click(sender, e);
			}
		}
	}
}
