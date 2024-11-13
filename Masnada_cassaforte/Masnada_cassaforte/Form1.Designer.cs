namespace Masnada_cassaforte
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Cassaforte = new Button();
            Apertura = new Button();
            Chiusura = new Button();
            CodiceUtente = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Programmata = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            ImpostaCodice = new TextBox();
            ImpostaData = new TextBox();
            label7 = new Label();
            label8 = new Label();
            ImpostaUtente = new Button();
            ImpostaGiorno = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 102);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "apertura";
            label1.Click += label1_Click;
            // 
            // Cassaforte
            // 
            Cassaforte.Location = new Point(53, 120);
            Cassaforte.Name = "Cassaforte";
            Cassaforte.Size = new Size(143, 130);
            Cassaforte.TabIndex = 1;
            Cassaforte.Text = "Cassaforte";
            Cassaforte.UseVisualStyleBackColor = true;
            // 
            // Apertura
            // 
            Apertura.Location = new Point(321, 56);
            Apertura.Name = "Apertura";
            Apertura.Size = new Size(117, 46);
            Apertura.TabIndex = 2;
            Apertura.Text = "Apri";
            Apertura.UseVisualStyleBackColor = true;
            Apertura.Click += Apertura_Click;
            // 
            // Chiusura
            // 
            Chiusura.Location = new Point(462, 56);
            Chiusura.Name = "Chiusura";
            Chiusura.Size = new Size(101, 46);
            Chiusura.TabIndex = 3;
            Chiusura.Text = "Chiudi";
            Chiusura.UseVisualStyleBackColor = true;
            Chiusura.Click += Chiusura_Click;
            // 
            // CodiceUtente
            // 
            CodiceUtente.Location = new Point(402, 27);
            CodiceUtente.Name = "CodiceUtente";
            CodiceUtente.Size = new Size(100, 23);
            CodiceUtente.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(462, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // Programmata
            // 
            Programmata.Location = new Point(389, 178);
            Programmata.Name = "Programmata";
            Programmata.Size = new Size(113, 57);
            Programmata.TabIndex = 7;
            Programmata.Text = "Apertura Programmata";
            Programmata.UseVisualStyleBackColor = true;
            Programmata.Click += Programmata_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 9);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 8;
            label2.Text = "Inserisci codice utente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 131);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 9;
            label3.Text = "Inserisci codice Utente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 131);
            label4.Name = "label4";
            label4.Size = new Size(151, 15);
            label4.TabIndex = 10;
            label4.Text = "Inserisci data programmata";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 253);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 11;
            label5.Text = "blocco";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(74, 320);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 302);
            label6.Name = "label6";
            label6.Size = new Size(144, 15);
            label6.TabIndex = 13;
            label6.Text = "inserisci codice di sblocco";
            // 
            // button1
            // 
            button1.Location = new Point(74, 349);
            button1.Name = "button1";
            button1.Size = new Size(99, 32);
            button1.TabIndex = 14;
            button1.Text = "Sblocca";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ImpostaCodice
            // 
            ImpostaCodice.Location = new Point(349, 285);
            ImpostaCodice.Name = "ImpostaCodice";
            ImpostaCodice.Size = new Size(100, 23);
            ImpostaCodice.TabIndex = 15;
            // 
            // ImpostaData
            // 
            ImpostaData.Location = new Point(488, 285);
            ImpostaData.Name = "ImpostaData";
            ImpostaData.Size = new Size(100, 23);
            ImpostaData.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 267);
            label7.Name = "label7";
            label7.Size = new Size(170, 15);
            label7.TabIndex = 17;
            label7.Text = "inserisci il nuovo codice utente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(488, 267);
            label8.Name = "label8";
            label8.Size = new Size(187, 15);
            label8.TabIndex = 18;
            label8.Text = "inserisci nuova data programmata";
            // 
            // ImpostaUtente
            // 
            ImpostaUtente.Location = new Point(349, 320);
            ImpostaUtente.Name = "ImpostaUtente";
            ImpostaUtente.Size = new Size(100, 35);
            ImpostaUtente.TabIndex = 19;
            ImpostaUtente.Text = "Imposta";
            ImpostaUtente.UseVisualStyleBackColor = true;
            ImpostaUtente.Click += ImpostaUtente_Click;
            // 
            // ImpostaGiorno
            // 
            ImpostaGiorno.Location = new Point(488, 320);
            ImpostaGiorno.Name = "ImpostaGiorno";
            ImpostaGiorno.Size = new Size(100, 35);
            ImpostaGiorno.TabIndex = 20;
            ImpostaGiorno.Text = "Imposta";
            ImpostaGiorno.UseVisualStyleBackColor = true;
            ImpostaGiorno.Click += ImpostaGiorno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ImpostaGiorno);
            Controls.Add(ImpostaUtente);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(ImpostaData);
            Controls.Add(ImpostaCodice);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Programmata);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(CodiceUtente);
            Controls.Add(Chiusura);
            Controls.Add(Apertura);
            Controls.Add(Cassaforte);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Cassaforte;
        private Button Apertura;
        private Button Chiusura;
        private TextBox CodiceUtente;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Programmata;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private Button button1;
        private TextBox ImpostaCodice;
        private TextBox ImpostaData;
        private Label label7;
        private Label label8;
        private Button ImpostaUtente;
        private Button ImpostaGiorno;
    }
}
