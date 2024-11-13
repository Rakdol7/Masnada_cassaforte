namespace Masnada_cassaforte
{
    public partial class Form1 : Form
    {
        private Cassaforte cassaforte;
        public Form1()
        {
            InitializeComponent();
            cassaforte = new Cassaforte("43646465", "Gambirasio", "T110", "44bb55nn66kk", false, "!", false, "!", 0);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cassaforte.Sblocca(textBox3.Text);
            if (cassaforte.Apertura == true) label1.Text = "Aperta";
            else label1.Text = "Chiusa";
            if (cassaforte.Blocco == true) label5.Text = "Bloccata";
            else label5.Text = "Sbloccata";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cassaforte.Apertura == true) label1.Text = "Aperta";
            else label1.Text = "Chiusa";
            if (cassaforte.Blocco == true) label5.Text = "Bloccata";
            else label5.Text = "Sbloccata";
        }

        private void Chiusura_Click(object sender, EventArgs e)
        {
            cassaforte.Chiudi();
            if (cassaforte.Apertura == true) label1.Text = "Aperta";
            else label1.Text = "Chiusa";
            if (cassaforte.Blocco == true) label5.Text = "Bloccata";
            else label5.Text = "Sbloccata";
        }

        private void Apertura_Click(object sender, EventArgs e)
        {
            cassaforte.Apri(CodiceUtente.Text);
            if (cassaforte.Apertura == true) label1.Text = "Aperta";
            else label1.Text = "Chiusa";
            if (cassaforte.Blocco == true) label5.Text = "Bloccata";
            else label5.Text = "Sbloccata";
        }

        private void Programmata_Click(object sender, EventArgs e)
        {
            cassaforte.AperturaProgrammata(textBox1.Text, textBox2.Text);
            if (cassaforte.Apertura == true) label1.Text = "Aperta";
            else label1.Text = "Chiusa";
            if (cassaforte.Blocco == true) label5.Text = "Bloccata";
            else label5.Text = "Sbloccata";
        }

        private void ImpostaUtente_Click(object sender, EventArgs e)
        {
            cassaforte.ImpostaCodiceUtente(ImpostaCodice.Text);
        }

        private void ImpostaGiorno_Click(object sender, EventArgs e)
        {
            cassaforte.ImpostaData(ImpostaData.Text);
        }
    }
}
