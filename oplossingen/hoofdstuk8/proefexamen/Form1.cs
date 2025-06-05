using proefexamenDA;
using proefexamenBL;

namespace proefexamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MaakGridView()
        {
            if (!dataGridView1.Columns.Contains("Naam"))
            {
                dataGridView1.Columns.Add("Naam", "Naam");
            }
            if (!dataGridView1.Columns.Contains("Nationaliteit"))
            {
                dataGridView1.Columns.Add("Nationaliteit", "Nationaliteit");
            }
            if (!dataGridView1.Columns.Contains("Punten"))
            {
                dataGridView1.Columns.Add("Punten", "Punten");
            }
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaakGridView();

            RennerData rennerData = new RennerData();
            List<Renner> lstRennerLijst = rennerData.GeefLijst();
            foreach (Renner renner in lstRennerLijst)
            {
                dataGridView1.Rows.Add(renner.Naam, renner.Nationality, renner.TotalPoints);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaakGridView();

            RennerData rennerData = new RennerData();
            List<Renner> lstRennerLijst = rennerData.GeefLijst();
            foreach (Renner renner in lstRennerLijst)
            {
                if (renner.Nationality == "BEL")
                { 
                    dataGridView1.Rows.Add(renner.Naam, renner.Nationality, renner.TotalPoints);
                }
            }
        }
    }
}
