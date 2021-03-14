namespace Pizza
{
    partial class Form1
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
            this.groupBoxBilgiler = new System.Windows.Forms.GroupBox();
            this.numericUpDownIcecek = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPizza = new System.Windows.Forms.NumericUpDown();
            this.comboBoxIcecek = new System.Windows.Forms.ComboBox();
            this.comboBoxPizzaBoy = new System.Windows.Forms.ComboBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.labelIcecekAdet = new System.Windows.Forms.Label();
            this.labelPizzaBoyAdet = new System.Windows.Forms.Label();
            this.labelIcecek = new System.Windows.Forms.Label();
            this.labelPizzaBoy = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.groupBoxSiparisler = new System.Windows.Forms.GroupBox();
            this.listBoxUcret = new System.Windows.Forms.ListBox();
            this.listBoxIcecek = new System.Windows.Forms.ListBox();
            this.listBoxEkstra = new System.Windows.Forms.ListBox();
            this.listBoxPizza = new System.Windows.Forms.ListBox();
            this.listBoxAdres = new System.Windows.Forms.ListBox();
            this.listBoxTelefon = new System.Windows.Forms.ListBox();
            this.listBoxAdSoyad = new System.Windows.Forms.ListBox();
            this.labelSiparisIcecek = new System.Windows.Forms.Label();
            this.labelSiparisEkstra = new System.Windows.Forms.Label();
            this.labelSiparisUcret = new System.Windows.Forms.Label();
            this.labelSiparisAdres = new System.Windows.Forms.Label();
            this.labelSiparisAdSoyad = new System.Windows.Forms.Label();
            this.labelSiparisPizza = new System.Windows.Forms.Label();
            this.labelSiparisTelefon = new System.Windows.Forms.Label();
            this.groupBoxEkstra = new System.Windows.Forms.GroupBox();
            this.checkBoxSebze = new System.Windows.Forms.CheckBox();
            this.checkBoxPeynir = new System.Windows.Forms.CheckBox();
            this.checkBoxKasar = new System.Windows.Forms.CheckBox();
            this.checkBoxMantar = new System.Windows.Forms.CheckBox();
            this.checkBoxSosis = new System.Windows.Forms.CheckBox();
            this.checkBoxSucuk = new System.Windows.Forms.CheckBox();
            this.buttonSiparisAl = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonSiparisTemizle = new System.Windows.Forms.Button();
            this.groupBoxBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIcecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPizza)).BeginInit();
            this.groupBoxSiparisler.SuspendLayout();
            this.groupBoxEkstra.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBilgiler
            // 
            this.groupBoxBilgiler.Controls.Add(this.numericUpDownIcecek);
            this.groupBoxBilgiler.Controls.Add(this.numericUpDownPizza);
            this.groupBoxBilgiler.Controls.Add(this.comboBoxIcecek);
            this.groupBoxBilgiler.Controls.Add(this.comboBoxPizzaBoy);
            this.groupBoxBilgiler.Controls.Add(this.textBoxAdres);
            this.groupBoxBilgiler.Controls.Add(this.textBoxTelefon);
            this.groupBoxBilgiler.Controls.Add(this.textBoxAdSoyad);
            this.groupBoxBilgiler.Controls.Add(this.labelIcecekAdet);
            this.groupBoxBilgiler.Controls.Add(this.labelPizzaBoyAdet);
            this.groupBoxBilgiler.Controls.Add(this.labelIcecek);
            this.groupBoxBilgiler.Controls.Add(this.labelPizzaBoy);
            this.groupBoxBilgiler.Controls.Add(this.labelAdres);
            this.groupBoxBilgiler.Controls.Add(this.labelTelefon);
            this.groupBoxBilgiler.Controls.Add(this.labelAdSoyad);
            this.groupBoxBilgiler.Location = new System.Drawing.Point(20, 17);
            this.groupBoxBilgiler.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxBilgiler.Name = "groupBoxBilgiler";
            this.groupBoxBilgiler.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxBilgiler.Size = new System.Drawing.Size(683, 230);
            this.groupBoxBilgiler.TabIndex = 0;
            this.groupBoxBilgiler.TabStop = false;
            this.groupBoxBilgiler.Text = "Bilgiler";
            // 
            // numericUpDownIcecek
            // 
            this.numericUpDownIcecek.Location = new System.Drawing.Point(410, 174);
            this.numericUpDownIcecek.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownIcecek.Name = "numericUpDownIcecek";
            this.numericUpDownIcecek.Size = new System.Drawing.Size(56, 29);
            this.numericUpDownIcecek.TabIndex = 13;
            // 
            // numericUpDownPizza
            // 
            this.numericUpDownPizza.Location = new System.Drawing.Point(410, 132);
            this.numericUpDownPizza.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPizza.Name = "numericUpDownPizza";
            this.numericUpDownPizza.Size = new System.Drawing.Size(56, 29);
            this.numericUpDownPizza.TabIndex = 12;
            // 
            // comboBoxIcecek
            // 
            this.comboBoxIcecek.FormattingEnabled = true;
            this.comboBoxIcecek.Items.AddRange(new object[] {
            "2,5lt Coca Cola",
            "1lt Fanta",
            "1lt Sprite"});
            this.comboBoxIcecek.Location = new System.Drawing.Point(122, 174);
            this.comboBoxIcecek.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIcecek.Name = "comboBoxIcecek";
            this.comboBoxIcecek.Size = new System.Drawing.Size(200, 32);
            this.comboBoxIcecek.TabIndex = 11;
            // 
            // comboBoxPizzaBoy
            // 
            this.comboBoxPizzaBoy.FormattingEnabled = true;
            this.comboBoxPizzaBoy.Items.AddRange(new object[] {
            "Küçük",
            "Orta",
            "Büyük"});
            this.comboBoxPizzaBoy.Location = new System.Drawing.Point(122, 132);
            this.comboBoxPizzaBoy.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPizzaBoy.Name = "comboBoxPizzaBoy";
            this.comboBoxPizzaBoy.Size = new System.Drawing.Size(200, 32);
            this.comboBoxPizzaBoy.TabIndex = 10;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(407, 22);
            this.textBoxAdres.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(255, 95);
            this.textBoxAdres.TabIndex = 9;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(122, 68);
            this.textBoxTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(200, 29);
            this.textBoxTelefon.TabIndex = 8;
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(122, 26);
            this.textBoxAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(200, 29);
            this.textBoxAdSoyad.TabIndex = 7;
            // 
            // labelIcecekAdet
            // 
            this.labelIcecekAdet.AutoSize = true;
            this.labelIcecekAdet.Location = new System.Drawing.Point(343, 174);
            this.labelIcecekAdet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIcecekAdet.Name = "labelIcecekAdet";
            this.labelIcecekAdet.Size = new System.Drawing.Size(53, 24);
            this.labelIcecekAdet.TabIndex = 6;
            this.labelIcecekAdet.Text = "Adet";
            // 
            // labelPizzaBoyAdet
            // 
            this.labelPizzaBoyAdet.AutoSize = true;
            this.labelPizzaBoyAdet.Location = new System.Drawing.Point(343, 132);
            this.labelPizzaBoyAdet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPizzaBoyAdet.Name = "labelPizzaBoyAdet";
            this.labelPizzaBoyAdet.Size = new System.Drawing.Size(53, 24);
            this.labelPizzaBoyAdet.TabIndex = 5;
            this.labelPizzaBoyAdet.Text = "Adet";
            // 
            // labelIcecek
            // 
            this.labelIcecek.AutoSize = true;
            this.labelIcecek.Location = new System.Drawing.Point(11, 174);
            this.labelIcecek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIcecek.Name = "labelIcecek";
            this.labelIcecek.Size = new System.Drawing.Size(71, 24);
            this.labelIcecek.TabIndex = 4;
            this.labelIcecek.Text = "İçecek";
            // 
            // labelPizzaBoy
            // 
            this.labelPizzaBoy.AutoSize = true;
            this.labelPizzaBoy.Location = new System.Drawing.Point(11, 132);
            this.labelPizzaBoy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPizzaBoy.Name = "labelPizzaBoy";
            this.labelPizzaBoy.Size = new System.Drawing.Size(100, 24);
            this.labelPizzaBoy.TabIndex = 3;
            this.labelPizzaBoy.Text = "Pizza Boy";
            this.labelPizzaBoy.Click += new System.EventHandler(this.labelPizzaBoy_Click);
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(343, 26);
            this.labelAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(65, 24);
            this.labelAdres.TabIndex = 2;
            this.labelAdres.Text = "Adres";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(11, 68);
            this.labelTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(81, 24);
            this.labelTelefon.TabIndex = 1;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(11, 28);
            this.labelAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(110, 24);
            this.labelAdSoyad.TabIndex = 0;
            this.labelAdSoyad.Text = "Adı Soyadı";
            // 
            // groupBoxSiparisler
            // 
            this.groupBoxSiparisler.Controls.Add(this.listBoxUcret);
            this.groupBoxSiparisler.Controls.Add(this.listBoxIcecek);
            this.groupBoxSiparisler.Controls.Add(this.listBoxEkstra);
            this.groupBoxSiparisler.Controls.Add(this.listBoxPizza);
            this.groupBoxSiparisler.Controls.Add(this.listBoxAdres);
            this.groupBoxSiparisler.Controls.Add(this.listBoxTelefon);
            this.groupBoxSiparisler.Controls.Add(this.listBoxAdSoyad);
            this.groupBoxSiparisler.Controls.Add(this.labelSiparisIcecek);
            this.groupBoxSiparisler.Controls.Add(this.labelSiparisEkstra);
            this.groupBoxSiparisler.Controls.Add(this.labelSiparisUcret);
            this.groupBoxSiparisler.Controls.Add(this.labelSiparisAdres);
            this.groupBoxSiparisler.Controls.Add(this.labelSiparisAdSoyad);
            this.groupBoxSiparisler.Controls.Add(this.labelSiparisPizza);
            this.groupBoxSiparisler.Controls.Add(this.labelSiparisTelefon);
            this.groupBoxSiparisler.Location = new System.Drawing.Point(20, 269);
            this.groupBoxSiparisler.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSiparisler.Name = "groupBoxSiparisler";
            this.groupBoxSiparisler.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSiparisler.Size = new System.Drawing.Size(1050, 220);
            this.groupBoxSiparisler.TabIndex = 1;
            this.groupBoxSiparisler.TabStop = false;
            this.groupBoxSiparisler.Text = "Siparişler";
            // 
            // listBoxUcret
            // 
            this.listBoxUcret.FormattingEnabled = true;
            this.listBoxUcret.ItemHeight = 24;
            this.listBoxUcret.Location = new System.Drawing.Point(956, 71);
            this.listBoxUcret.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxUcret.Name = "listBoxUcret";
            this.listBoxUcret.Size = new System.Drawing.Size(75, 124);
            this.listBoxUcret.TabIndex = 28;
            // 
            // listBoxIcecek
            // 
            this.listBoxIcecek.FormattingEnabled = true;
            this.listBoxIcecek.HorizontalScrollbar = true;
            this.listBoxIcecek.ItemHeight = 24;
            this.listBoxIcecek.Location = new System.Drawing.Point(800, 71);
            this.listBoxIcecek.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxIcecek.Name = "listBoxIcecek";
            this.listBoxIcecek.Size = new System.Drawing.Size(134, 124);
            this.listBoxIcecek.TabIndex = 27;
            // 
            // listBoxEkstra
            // 
            this.listBoxEkstra.FormattingEnabled = true;
            this.listBoxEkstra.HorizontalScrollbar = true;
            this.listBoxEkstra.ItemHeight = 24;
            this.listBoxEkstra.Location = new System.Drawing.Point(644, 71);
            this.listBoxEkstra.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEkstra.Name = "listBoxEkstra";
            this.listBoxEkstra.Size = new System.Drawing.Size(134, 124);
            this.listBoxEkstra.TabIndex = 26;
            // 
            // listBoxPizza
            // 
            this.listBoxPizza.FormattingEnabled = true;
            this.listBoxPizza.ItemHeight = 24;
            this.listBoxPizza.Location = new System.Drawing.Point(482, 71);
            this.listBoxPizza.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPizza.Name = "listBoxPizza";
            this.listBoxPizza.Size = new System.Drawing.Size(147, 124);
            this.listBoxPizza.TabIndex = 25;
            // 
            // listBoxAdres
            // 
            this.listBoxAdres.FormattingEnabled = true;
            this.listBoxAdres.HorizontalScrollbar = true;
            this.listBoxAdres.ItemHeight = 24;
            this.listBoxAdres.Location = new System.Drawing.Point(298, 71);
            this.listBoxAdres.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAdres.Name = "listBoxAdres";
            this.listBoxAdres.Size = new System.Drawing.Size(171, 124);
            this.listBoxAdres.TabIndex = 24;
            // 
            // listBoxTelefon
            // 
            this.listBoxTelefon.FormattingEnabled = true;
            this.listBoxTelefon.ItemHeight = 24;
            this.listBoxTelefon.Location = new System.Drawing.Point(167, 71);
            this.listBoxTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTelefon.Name = "listBoxTelefon";
            this.listBoxTelefon.Size = new System.Drawing.Size(120, 124);
            this.listBoxTelefon.TabIndex = 23;
            // 
            // listBoxAdSoyad
            // 
            this.listBoxAdSoyad.FormattingEnabled = true;
            this.listBoxAdSoyad.HorizontalScrollbar = true;
            this.listBoxAdSoyad.ItemHeight = 24;
            this.listBoxAdSoyad.Location = new System.Drawing.Point(17, 71);
            this.listBoxAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAdSoyad.Name = "listBoxAdSoyad";
            this.listBoxAdSoyad.Size = new System.Drawing.Size(134, 124);
            this.listBoxAdSoyad.TabIndex = 22;
            // 
            // labelSiparisIcecek
            // 
            this.labelSiparisIcecek.AutoSize = true;
            this.labelSiparisIcecek.Location = new System.Drawing.Point(796, 34);
            this.labelSiparisIcecek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiparisIcecek.Name = "labelSiparisIcecek";
            this.labelSiparisIcecek.Size = new System.Drawing.Size(148, 24);
            this.labelSiparisIcecek.TabIndex = 21;
            this.labelSiparisIcecek.Text = "İçecek ve Adet";
            // 
            // labelSiparisEkstra
            // 
            this.labelSiparisEkstra.AutoSize = true;
            this.labelSiparisEkstra.Location = new System.Drawing.Point(640, 34);
            this.labelSiparisEkstra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiparisEkstra.Name = "labelSiparisEkstra";
            this.labelSiparisEkstra.Size = new System.Drawing.Size(67, 24);
            this.labelSiparisEkstra.TabIndex = 20;
            this.labelSiparisEkstra.Text = "Ekstra";
            // 
            // labelSiparisUcret
            // 
            this.labelSiparisUcret.AutoSize = true;
            this.labelSiparisUcret.Location = new System.Drawing.Point(953, 34);
            this.labelSiparisUcret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiparisUcret.Name = "labelSiparisUcret";
            this.labelSiparisUcret.Size = new System.Drawing.Size(59, 24);
            this.labelSiparisUcret.TabIndex = 18;
            this.labelSiparisUcret.Text = "Ücret";
            // 
            // labelSiparisAdres
            // 
            this.labelSiparisAdres.AutoSize = true;
            this.labelSiparisAdres.Location = new System.Drawing.Point(297, 34);
            this.labelSiparisAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiparisAdres.Name = "labelSiparisAdres";
            this.labelSiparisAdres.Size = new System.Drawing.Size(65, 24);
            this.labelSiparisAdres.TabIndex = 14;
            this.labelSiparisAdres.Text = "Adres";
            // 
            // labelSiparisAdSoyad
            // 
            this.labelSiparisAdSoyad.AutoSize = true;
            this.labelSiparisAdSoyad.Location = new System.Drawing.Point(16, 34);
            this.labelSiparisAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiparisAdSoyad.Name = "labelSiparisAdSoyad";
            this.labelSiparisAdSoyad.Size = new System.Drawing.Size(110, 24);
            this.labelSiparisAdSoyad.TabIndex = 14;
            this.labelSiparisAdSoyad.Text = "Adı Soyadı";
            // 
            // labelSiparisPizza
            // 
            this.labelSiparisPizza.AutoSize = true;
            this.labelSiparisPizza.Location = new System.Drawing.Point(482, 34);
            this.labelSiparisPizza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiparisPizza.Name = "labelSiparisPizza";
            this.labelSiparisPizza.Size = new System.Drawing.Size(177, 24);
            this.labelSiparisPizza.TabIndex = 16;
            this.labelSiparisPizza.Text = "Pizza Boy ve Adet";
            // 
            // labelSiparisTelefon
            // 
            this.labelSiparisTelefon.AutoSize = true;
            this.labelSiparisTelefon.Location = new System.Drawing.Point(162, 34);
            this.labelSiparisTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiparisTelefon.Name = "labelSiparisTelefon";
            this.labelSiparisTelefon.Size = new System.Drawing.Size(81, 24);
            this.labelSiparisTelefon.TabIndex = 15;
            this.labelSiparisTelefon.Text = "Telefon";
            // 
            // groupBoxEkstra
            // 
            this.groupBoxEkstra.Controls.Add(this.checkBoxSebze);
            this.groupBoxEkstra.Controls.Add(this.checkBoxPeynir);
            this.groupBoxEkstra.Controls.Add(this.checkBoxKasar);
            this.groupBoxEkstra.Controls.Add(this.checkBoxMantar);
            this.groupBoxEkstra.Controls.Add(this.checkBoxSosis);
            this.groupBoxEkstra.Controls.Add(this.checkBoxSucuk);
            this.groupBoxEkstra.Location = new System.Drawing.Point(743, 17);
            this.groupBoxEkstra.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEkstra.Name = "groupBoxEkstra";
            this.groupBoxEkstra.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEkstra.Size = new System.Drawing.Size(327, 138);
            this.groupBoxEkstra.TabIndex = 2;
            this.groupBoxEkstra.TabStop = false;
            this.groupBoxEkstra.Text = "Ekstra";
            // 
            // checkBoxSebze
            // 
            this.checkBoxSebze.AutoSize = true;
            this.checkBoxSebze.Location = new System.Drawing.Point(209, 90);
            this.checkBoxSebze.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSebze.Name = "checkBoxSebze";
            this.checkBoxSebze.Size = new System.Drawing.Size(91, 28);
            this.checkBoxSebze.TabIndex = 5;
            this.checkBoxSebze.Text = "Sebze";
            this.checkBoxSebze.UseVisualStyleBackColor = true;
            // 
            // checkBoxPeynir
            // 
            this.checkBoxPeynir.AutoSize = true;
            this.checkBoxPeynir.Location = new System.Drawing.Point(209, 58);
            this.checkBoxPeynir.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxPeynir.Name = "checkBoxPeynir";
            this.checkBoxPeynir.Size = new System.Drawing.Size(91, 28);
            this.checkBoxPeynir.TabIndex = 4;
            this.checkBoxPeynir.Text = "Peynir";
            this.checkBoxPeynir.UseVisualStyleBackColor = true;
            // 
            // checkBoxKasar
            // 
            this.checkBoxKasar.AutoSize = true;
            this.checkBoxKasar.Location = new System.Drawing.Point(209, 26);
            this.checkBoxKasar.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxKasar.Name = "checkBoxKasar";
            this.checkBoxKasar.Size = new System.Drawing.Size(84, 28);
            this.checkBoxKasar.TabIndex = 3;
            this.checkBoxKasar.Text = "Kaşar";
            this.checkBoxKasar.UseVisualStyleBackColor = true;
            // 
            // checkBoxMantar
            // 
            this.checkBoxMantar.AutoSize = true;
            this.checkBoxMantar.Location = new System.Drawing.Point(27, 90);
            this.checkBoxMantar.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMantar.Name = "checkBoxMantar";
            this.checkBoxMantar.Size = new System.Drawing.Size(95, 28);
            this.checkBoxMantar.TabIndex = 2;
            this.checkBoxMantar.Text = "Mantar";
            this.checkBoxMantar.UseVisualStyleBackColor = true;
            // 
            // checkBoxSosis
            // 
            this.checkBoxSosis.AutoSize = true;
            this.checkBoxSosis.Location = new System.Drawing.Point(27, 58);
            this.checkBoxSosis.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSosis.Name = "checkBoxSosis";
            this.checkBoxSosis.Size = new System.Drawing.Size(82, 28);
            this.checkBoxSosis.TabIndex = 1;
            this.checkBoxSosis.Text = "Sosis";
            this.checkBoxSosis.UseVisualStyleBackColor = true;
            // 
            // checkBoxSucuk
            // 
            this.checkBoxSucuk.AutoSize = true;
            this.checkBoxSucuk.Location = new System.Drawing.Point(27, 26);
            this.checkBoxSucuk.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSucuk.Name = "checkBoxSucuk";
            this.checkBoxSucuk.Size = new System.Drawing.Size(90, 28);
            this.checkBoxSucuk.TabIndex = 0;
            this.checkBoxSucuk.Text = "Sucuk";
            this.checkBoxSucuk.UseVisualStyleBackColor = true;
            // 
            // buttonSiparisAl
            // 
            this.buttonSiparisAl.Location = new System.Drawing.Point(744, 164);
            this.buttonSiparisAl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSiparisAl.Name = "buttonSiparisAl";
            this.buttonSiparisAl.Size = new System.Drawing.Size(124, 32);
            this.buttonSiparisAl.TabIndex = 3;
            this.buttonSiparisAl.Text = "Sipariş Al";
            this.buttonSiparisAl.UseVisualStyleBackColor = true;
            this.buttonSiparisAl.Click += new System.EventHandler(this.buttonSiparisAl_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(744, 215);
            this.buttonTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(124, 32);
            this.buttonTemizle.TabIndex = 4;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonSiparisTemizle
            // 
            this.buttonSiparisTemizle.Location = new System.Drawing.Point(880, 164);
            this.buttonSiparisTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSiparisTemizle.Name = "buttonSiparisTemizle";
            this.buttonSiparisTemizle.Size = new System.Drawing.Size(190, 82);
            this.buttonSiparisTemizle.TabIndex = 5;
            this.buttonSiparisTemizle.Text = "Siparişleri Temizle";
            this.buttonSiparisTemizle.UseVisualStyleBackColor = true;
            this.buttonSiparisTemizle.Click += new System.EventHandler(this.buttonSiparisTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 502);
            this.Controls.Add(this.buttonSiparisTemizle);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.buttonSiparisAl);
            this.Controls.Add(this.groupBoxEkstra);
            this.Controls.Add(this.groupBoxSiparisler);
            this.Controls.Add(this.groupBoxBilgiler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Pizza Sipariş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxBilgiler.ResumeLayout(false);
            this.groupBoxBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIcecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPizza)).EndInit();
            this.groupBoxSiparisler.ResumeLayout(false);
            this.groupBoxSiparisler.PerformLayout();
            this.groupBoxEkstra.ResumeLayout(false);
            this.groupBoxEkstra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBilgiler;
        private System.Windows.Forms.NumericUpDown numericUpDownIcecek;
        private System.Windows.Forms.NumericUpDown numericUpDownPizza;
        private System.Windows.Forms.ComboBox comboBoxIcecek;
        private System.Windows.Forms.ComboBox comboBoxPizzaBoy;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.Label labelIcecekAdet;
        private System.Windows.Forms.Label labelPizzaBoyAdet;
        private System.Windows.Forms.Label labelIcecek;
        private System.Windows.Forms.Label labelPizzaBoy;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.GroupBox groupBoxSiparisler;
        private System.Windows.Forms.Label labelSiparisAdres;
        private System.Windows.Forms.Label labelSiparisAdSoyad;
        private System.Windows.Forms.Label labelSiparisPizza;
        private System.Windows.Forms.Label labelSiparisTelefon;
        private System.Windows.Forms.GroupBox groupBoxEkstra;
        private System.Windows.Forms.CheckBox checkBoxSebze;
        private System.Windows.Forms.CheckBox checkBoxPeynir;
        private System.Windows.Forms.CheckBox checkBoxKasar;
        private System.Windows.Forms.CheckBox checkBoxMantar;
        private System.Windows.Forms.CheckBox checkBoxSosis;
        private System.Windows.Forms.CheckBox checkBoxSucuk;
        private System.Windows.Forms.Button buttonSiparisAl;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonSiparisTemizle;
        private System.Windows.Forms.Label labelSiparisUcret;
        private System.Windows.Forms.Label labelSiparisEkstra;
        private System.Windows.Forms.Label labelSiparisIcecek;
        private System.Windows.Forms.ListBox listBoxAdSoyad;
        private System.Windows.Forms.ListBox listBoxTelefon;
        private System.Windows.Forms.ListBox listBoxUcret;
        private System.Windows.Forms.ListBox listBoxIcecek;
        private System.Windows.Forms.ListBox listBoxEkstra;
        private System.Windows.Forms.ListBox listBoxPizza;
        private System.Windows.Forms.ListBox listBoxAdres;
    }
}

