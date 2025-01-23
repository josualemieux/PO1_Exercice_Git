namespace PO1_Exercice_Git
{
    public partial class Form1 : Form
    {
        int[] tableau = [1, 2, 3, 5, 8, 13];

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Somme_Click(object sender, EventArgs e)
        {
            int somme = 0;
            for (int i = 0; i < tableau.Length; i++)
            {
                somme += tableau[i];
            }
            MessageBox.Show("La somme des �l�ments du tableau est : " + somme);
        }

        private void button_TestPremier_Click(object sender, EventArgs e)
        {

            if(int.TryParse(textBox_Nombre.Text, out int nombre))
            {
                if (nombre < 2)
                {
                    MessageBox.Show("Le nombre doit �tre sup�rieur ou �gal � 2");
                }
                else
                {
                    bool estPremier = true;
                    for (int i = 2; i < nombre; i++)
                    {
                        if (nombre % i == 0)
                        {
                            estPremier = false;
                            break;
                        }
                    }
                    if (estPremier)
                    {
                        MessageBox.Show("Le nombre est premier");
                    }
                    else
                    {
                        MessageBox.Show("Le nombre n'est pas premier");
                    }
                }
            }
            else
            {
                MessageBox.Show("Le nombre doit �tre un entier");
            }
        }

        private void button_PlusGrand_Click(object sender, EventArgs e)
        {
            int somme = 0;
            for (int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i] > somme)
                {
                    somme = tableau[i];
                }
            }
        }

        private void button_PlusGrand_Click(object sender, EventArgs e)
        {
            int somme = 0;
            for (int i = 0; i <= tableau.Length; i++)
            {
                if (tableau[i] > somme)
                {
                    somme = tableau[i];
                }
            }
        }
    }
}
