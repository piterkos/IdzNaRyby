using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idź_na_ryby_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Game game;

        private void StartGra_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Imie_txtBox.Text))
            {
                MessageBox.Show("Wpisz swoje imię", "Nie można jeszcze rozpocząć gry");
                return;
            }
            game = new Game(Imie_txtBox.Text, new  List<string> { "Janek", "Bartek" }, Postep_txtBox);
            StartGra_button.Enabled = false;
            Imie_txtBox.Enabled = false;
            zapytaj_button.Enabled = true;
            UpdateForm();
        }

        private void UpdateForm()
        {
            Reka_listBox.Items.Clear();
            foreach (String cardName in game.GetPlayerCardNames())
            {
                Reka_listBox.Items.Add(cardName);
                Grupy_txtBox.Text = game.DescribeBooks();
                Postep_txtBox.Text += game.DescribePlayerHand();
                Postep_txtBox.SelectionStart = Postep_txtBox.Text.Length;
                Postep_txtBox.ScrollToCaret();
            }
        }

        private void zapytaj_button_Click(object sender, EventArgs e)
        {
            Postep_txtBox.Text = "";
            if (Reka_listBox.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz kartę");
                return;
            }
            if (game.PlayOneRound(Reka_listBox.SelectedIndex))
            {
                Postep_txtBox.Text += "Zwycięscą jest... " + game.GetWinnerName();
                Grupy_txtBox.Text = game.DescribeBooks();
                zapytaj_button.Enabled = false;
            }
            else
            {
                UpdateForm();
            }
        }
    }
}
