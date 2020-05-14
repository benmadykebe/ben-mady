namespace GestionCom
{
    partial class FrmCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnelNewClient = new System.Windows.Forms.GroupBox();
            this.bntEnregistrer = new System.Windows.Forms.Button();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActive = new System.Windows.Forms.Button();
            this.txtTotalCommande = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgvCommande = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtArticleLibelle = new System.Windows.Forms.TextBox();
            this.btnAddCommandeInDtgv = new System.Windows.Forms.Button();
            this.txtQteCommander = new System.Windows.Forms.TextBox();
            this.txtArticleStock = new System.Windows.Forms.TextBox();
            this.btnSearchArticleByReference = new System.Windows.Forms.Button();
            this.txtArticleReferenceSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNomSearch = new System.Windows.Forms.TextBox();
            this.txtAdresseSearch = new System.Windows.Forms.TextBox();
            this.txtPrenomSearch = new System.Windows.Forms.TextBox();
            this.btnSearchClientByTelephone = new System.Windows.Forms.Button();
            this.textTelephoneSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnelNewClient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCommande)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnelNewClient
            // 
            this.pnelNewClient.Controls.Add(this.bntEnregistrer);
            this.pnelNewClient.Controls.Add(this.txtTelephone);
            this.pnelNewClient.Controls.Add(this.txtAdresse);
            this.pnelNewClient.Controls.Add(this.txtPrenom);
            this.pnelNewClient.Controls.Add(this.txtNom);
            this.pnelNewClient.Controls.Add(this.txt);
            this.pnelNewClient.Controls.Add(this.label3);
            this.pnelNewClient.Controls.Add(this.label2);
            this.pnelNewClient.Controls.Add(this.label1);
            this.pnelNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnelNewClient.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pnelNewClient.Location = new System.Drawing.Point(12, 2);
            this.pnelNewClient.Name = "pnelNewClient";
            this.pnelNewClient.Size = new System.Drawing.Size(310, 522);
            this.pnelNewClient.TabIndex = 0;
            this.pnelNewClient.TabStop = false;
            this.pnelNewClient.Text = "Enregistrement Client";
            // 
            // bntEnregistrer
            // 
            this.bntEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bntEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEnregistrer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bntEnregistrer.Location = new System.Drawing.Point(170, 284);
            this.bntEnregistrer.Name = "bntEnregistrer";
            this.bntEnregistrer.Size = new System.Drawing.Size(115, 38);
            this.bntEnregistrer.TabIndex = 8;
            this.bntEnregistrer.Text = "Enregistrer";
            this.bntEnregistrer.UseVisualStyleBackColor = false;
            this.bntEnregistrer.Click += new System.EventHandler(this.bntEnregistrer_Click);
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTelephone.Location = new System.Drawing.Point(121, 169);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(164, 31);
            this.txtTelephone.TabIndex = 7;
            // 
            // txtAdresse
            // 
            this.txtAdresse.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtAdresse.Location = new System.Drawing.Point(121, 223);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(164, 31);
            this.txtAdresse.TabIndex = 6;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPrenom.Location = new System.Drawing.Point(121, 120);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(164, 31);
            this.txtPrenom.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNom.Location = new System.Drawing.Point(121, 72);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(164, 31);
            this.txtNom.TabIndex = 4;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt.Location = new System.Drawing.Point(27, 229);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(68, 20);
            this.txt.TabIndex = 3;
            this.txt.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(27, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telephone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(27, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(27, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActive);
            this.groupBox2.Controls.Add(this.txtTotalCommande);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtgvCommande);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(328, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 522);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnActive.Location = new System.Drawing.Point(508, 41);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(79, 30);
            this.btnActive.TabIndex = 16;
            this.btnActive.Text = "ADD";
            this.btnActive.UseVisualStyleBackColor = false;
            // 
            // txtTotalCommande
            // 
            this.txtTotalCommande.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTotalCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCommande.Location = new System.Drawing.Point(433, 491);
            this.txtTotalCommande.Name = "txtTotalCommande";
            this.txtTotalCommande.Size = new System.Drawing.Size(145, 26);
            this.txtTotalCommande.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(365, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total:";
            // 
            // dtgvCommande
            // 
            this.dtgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCommande.Location = new System.Drawing.Point(6, 319);
            this.dtgvCommande.Name = "dtgvCommande";
            this.dtgvCommande.Size = new System.Drawing.Size(581, 166);
            this.dtgvCommande.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtArticleLibelle);
            this.groupBox4.Controls.Add(this.btnAddCommandeInDtgv);
            this.groupBox4.Controls.Add(this.txtQteCommander);
            this.groupBox4.Controls.Add(this.txtArticleStock);
            this.groupBox4.Controls.Add(this.btnSearchArticleByReference);
            this.groupBox4.Controls.Add(this.txtArticleReferenceSearch);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(6, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(587, 129);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // txtArticleLibelle
            // 
            this.txtArticleLibelle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtArticleLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticleLibelle.Location = new System.Drawing.Point(14, 68);
            this.txtArticleLibelle.Name = "txtArticleLibelle";
            this.txtArticleLibelle.Size = new System.Drawing.Size(145, 24);
            this.txtArticleLibelle.TabIndex = 14;
            this.txtArticleLibelle.Text = "Libelle";
            this.txtArticleLibelle.Enter += new System.EventHandler(this.txtArticleLibelle_Enter);
            this.txtArticleLibelle.Leave += new System.EventHandler(this.txtArticleLibelle_Leave);
            // 
            // btnAddCommandeInDtgv
            // 
            this.btnAddCommandeInDtgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddCommandeInDtgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCommandeInDtgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCommandeInDtgv.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAddCommandeInDtgv.Location = new System.Drawing.Point(502, 100);
            this.btnAddCommandeInDtgv.Name = "btnAddCommandeInDtgv";
            this.btnAddCommandeInDtgv.Size = new System.Drawing.Size(79, 26);
            this.btnAddCommandeInDtgv.TabIndex = 15;
            this.btnAddCommandeInDtgv.Text = "ADD";
            this.btnAddCommandeInDtgv.UseVisualStyleBackColor = false;
            // 
            // txtQteCommander
            // 
            this.txtQteCommander.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtQteCommander.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQteCommander.Location = new System.Drawing.Point(368, 68);
            this.txtQteCommander.Name = "txtQteCommander";
            this.txtQteCommander.Size = new System.Drawing.Size(145, 24);
            this.txtQteCommander.TabIndex = 13;
            this.txtQteCommander.Text = "Qte Commande";
            this.txtQteCommander.Enter += new System.EventHandler(this.txtQteCommander_Enter);
            this.txtQteCommander.Leave += new System.EventHandler(this.txtQteCommander_Leave);
            // 
            // txtArticleStock
            // 
            this.txtArticleStock.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtArticleStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticleStock.Location = new System.Drawing.Point(186, 68);
            this.txtArticleStock.Name = "txtArticleStock";
            this.txtArticleStock.Size = new System.Drawing.Size(145, 24);
            this.txtArticleStock.TabIndex = 12;
            this.txtArticleStock.Text = "Qte Stock";
            this.txtArticleStock.Enter += new System.EventHandler(this.txtArticleStock_Enter);
            this.txtArticleStock.Leave += new System.EventHandler(this.txtArticleStock_Leave);
            // 
            // btnSearchArticleByReference
            // 
            this.btnSearchArticleByReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSearchArticleByReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchArticleByReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchArticleByReference.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSearchArticleByReference.Location = new System.Drawing.Point(267, 19);
            this.btnSearchArticleByReference.Name = "btnSearchArticleByReference";
            this.btnSearchArticleByReference.Size = new System.Drawing.Size(79, 26);
            this.btnSearchArticleByReference.TabIndex = 10;
            this.btnSearchArticleByReference.Text = "Search";
            this.btnSearchArticleByReference.UseVisualStyleBackColor = false;
            // 
            // txtArticleReferenceSearch
            // 
            this.txtArticleReferenceSearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtArticleReferenceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticleReferenceSearch.Location = new System.Drawing.Point(99, 19);
            this.txtArticleReferenceSearch.Name = "txtArticleReferenceSearch";
            this.txtArticleReferenceSearch.Size = new System.Drawing.Size(145, 26);
            this.txtArticleReferenceSearch.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Reference";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNomSearch);
            this.groupBox3.Controls.Add(this.txtAdresseSearch);
            this.groupBox3.Controls.Add(this.txtPrenomSearch);
            this.groupBox3.Controls.Add(this.btnSearchClientByTelephone);
            this.groupBox3.Controls.Add(this.textTelephoneSearch);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(7, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(587, 101);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // txtNomSearch
            // 
            this.txtNomSearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNomSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomSearch.Location = new System.Drawing.Point(13, 68);
            this.txtNomSearch.Name = "txtNomSearch";
            this.txtNomSearch.Size = new System.Drawing.Size(145, 24);
            this.txtNomSearch.TabIndex = 14;
            this.txtNomSearch.Text = "Nom";
            this.txtNomSearch.Enter += new System.EventHandler(this.txtNomSearch_Enter);
            this.txtNomSearch.Leave += new System.EventHandler(this.txtNomSearch_Leave);
            // 
            // txtAdresseSearch
            // 
            this.txtAdresseSearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtAdresseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresseSearch.Location = new System.Drawing.Point(367, 68);
            this.txtAdresseSearch.Name = "txtAdresseSearch";
            this.txtAdresseSearch.Size = new System.Drawing.Size(145, 24);
            this.txtAdresseSearch.TabIndex = 13;
            this.txtAdresseSearch.Text = "Adresse";
            this.txtAdresseSearch.Enter += new System.EventHandler(this.txtAdresseSearch_Enter);
            this.txtAdresseSearch.Leave += new System.EventHandler(this.txtAdresseSearch_Leave);
            // 
            // txtPrenomSearch
            // 
            this.txtPrenomSearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPrenomSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomSearch.Location = new System.Drawing.Point(185, 68);
            this.txtPrenomSearch.Name = "txtPrenomSearch";
            this.txtPrenomSearch.Size = new System.Drawing.Size(145, 24);
            this.txtPrenomSearch.TabIndex = 12;
            this.txtPrenomSearch.Text = "Prenom";
            this.txtPrenomSearch.Enter += new System.EventHandler(this.txtPrenomSearch_Enter);
            this.txtPrenomSearch.Leave += new System.EventHandler(this.txtPrenomSearch_Leave);
            // 
            // btnSearchClientByTelephone
            // 
            this.btnSearchClientByTelephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSearchClientByTelephone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClientByTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClientByTelephone.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSearchClientByTelephone.Location = new System.Drawing.Point(267, 19);
            this.btnSearchClientByTelephone.Name = "btnSearchClientByTelephone";
            this.btnSearchClientByTelephone.Size = new System.Drawing.Size(78, 26);
            this.btnSearchClientByTelephone.TabIndex = 10;
            this.btnSearchClientByTelephone.Text = "Search";
            this.btnSearchClientByTelephone.UseVisualStyleBackColor = false;
            // 
            // textTelephoneSearch
            // 
            this.textTelephoneSearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textTelephoneSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelephoneSearch.Location = new System.Drawing.Point(99, 19);
            this.textTelephoneSearch.Name = "textTelephoneSearch";
            this.textTelephoneSearch.Size = new System.Drawing.Size(145, 26);
            this.textTelephoneSearch.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telephone";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(106, 10);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(145, 26);
            this.txtNumero.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Numero";
            // 
            // FrmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnelNewClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCommande";
            this.Load += new System.EventHandler(this.FrmCommande_Load);
            this.pnelNewClient.ResumeLayout(false);
            this.pnelNewClient.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCommande)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnelNewClient;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntEnregistrer;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvCommande;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtArticleLibelle;
        private System.Windows.Forms.Button btnAddCommandeInDtgv;
        private System.Windows.Forms.TextBox txtQteCommander;
        private System.Windows.Forms.TextBox txtArticleStock;
        private System.Windows.Forms.Button btnSearchArticleByReference;
        private System.Windows.Forms.TextBox txtArticleReferenceSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNomSearch;
        private System.Windows.Forms.TextBox txtAdresseSearch;
        private System.Windows.Forms.TextBox txtPrenomSearch;
        private System.Windows.Forms.Button btnSearchClientByTelephone;
        private System.Windows.Forms.TextBox textTelephoneSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.TextBox txtTotalCommande;
        private System.Windows.Forms.Label label8;
    }
}