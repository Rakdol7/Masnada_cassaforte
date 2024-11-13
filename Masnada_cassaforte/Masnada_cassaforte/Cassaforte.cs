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

        public Cassaforte(string numMatricola, string produttore, string modello, string codiceSblocco, bool apertura, string codiceUtente, bool blocco, string data)
        {
            this.numMatricola = numMatricola;
            this.produttore = produttore;
            this.modello = modello;
            this.codiceSblocco = codiceSblocco;
            this.apertura = apertura;
            this.codiceUtente = codiceUtente;
            this.blocco = blocco;
            this.data = data;
        }
        
        public string NumMatricola { get { return numMatricola; } }
        public string Produttore { get { return produttore; } }
        public string Modello { get { return modello; } }
        public bool Apertura { get { return apertura; } }
        public bool Blocco { get { return blocco; } } 

        public void ImpostaCodiceUtente(string codice)
        {
            if (codice.Length != 5) return;
            codiceUtente = codice;
        }
        
        public void Apri(string codice)
        {
            if (blocco == false)
            {
                int i = 0;
                if (codiceUtente == codice) apertura = true;
                else
                {
                    i++;
                    if (i == 5) blocco = true;
                }
            }
        }

        public void Chiudi()
        {
            apertura = false;
        }

        public void Sblocca(string codice)
        {
            if (codice.Length != 12) return;
            if(codiceSblocco == codice) blocco = false;
        }

        public void ImpostaData(string dataProgrammata)
        {
            data = dataProgrammata;
        }

        public void AperturaProgrammata(string codice, string dataProgrammata)
        {
            if (blocco == false)
            {
                int i = 0;
                if (codiceUtente == codice && data == dataProgrammata) apertura = true;
                else
                {
                    i++;
                    if (i == 5) blocco = true;
                }
            }
        }


    }
}
