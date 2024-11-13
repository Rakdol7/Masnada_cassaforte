using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masnada_cassaforte
{
    internal class Cassaforte
    {
        private string numMatricola;
        private string produttore;
        private string modello;
        private string codiceSblocco;
        private bool apertura;
        private string codiceUtente;
        private bool blocco;
        private string data;
        private int tentativi;

        public Cassaforte(string numMatricola, string produttore, string modello, string codiceSblocco, bool apertura, string codiceUtente, bool blocco, string data, int tentativi)
        {
            this.numMatricola = numMatricola;
            this.produttore = produttore;
            this.modello = modello;
            this.codiceSblocco = codiceSblocco;
            this.apertura = apertura;
            this.codiceUtente = codiceUtente;
            this.blocco = blocco;
            this.data = data;
            this.tentativi = tentativi;
        }
        
        public string NumMatricola { get { return numMatricola; } }
        public string Produttore { get { return produttore; } }
        public string Modello { get { return modello; } }
        public bool Apertura { get { return apertura; } }
        public bool Blocco { get { return blocco; } } 

        public void ImpostaCodiceUtente(string codice)
        {
            if (codice.Length != 5)
            {
                MessageBox.Show("Codice non valido");
                return;
            }
            codiceUtente = codice;
        }
        
        public void Apri(string codice)
        {
            if (blocco == false && apertura == false)
            {
                if (codiceUtente == codice)
                {
                    apertura = true;
                    tentativi = 0;
                }
                else
                {
                    tentativi++;
                    MessageBox.Show("codice errato");
                    if (tentativi == 5)
                        {
                            blocco = true;
                            tentativi = 0;
                        }
                }
            }
            else MessageBox.Show("La cassaforte è bloccata o già aperta");
        }

        public void Chiudi()
        {
            apertura = false;
        }

        public void Sblocca(string codice)
        {
            if (codice.Length != 12)
            {
                MessageBox.Show("codice non valido");
                return;
            }
            if (codiceSblocco == codice) blocco = false;
            else MessageBox.Show("codice errato");
        }

        public void ImpostaData(string dataProgrammata)
        {
            if (dataProgrammata.Length != 10)
            {
                MessageBox.Show("data non valida");
                return;
            }
            codiceUtente = dataProgrammata;
        }

        public void AperturaProgrammata(string codice, string dataProgrammata)
        {
            if (blocco == false && apertura == false)
            {
                if (codiceUtente == codice && data == dataProgrammata)
                {
                    apertura = true;
                    tentativi = 0;
                }
                else
                {
                    tentativi++;
                    MessageBox.Show("codice e/o data errati");
                    if (tentativi == 5)
                    {
                        blocco = true;
                        tentativi = 0;
                    }
                }
            }
            else MessageBox.Show("La cassaforte è bloccata o già aperta");
        }


    }
}
