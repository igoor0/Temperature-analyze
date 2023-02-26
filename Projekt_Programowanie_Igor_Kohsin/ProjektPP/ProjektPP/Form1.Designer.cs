namespace ProjektPP
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panel7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wariancja = new System.Windows.Forms.TextBox();
            this.srednia = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.TextBox();
            this.ilosc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_left = new System.Windows.Forms.Panel();
            this.button_zaladuj = new System.Windows.Forms.Button();
            this.button_wyswietl = new System.Windows.Forms.Button();
            this.button_wyczysc = new System.Windows.Forms.Button();
            this.button_zapisz = new System.Windows.Forms.Button();
            this.label_wyczysc = new System.Windows.Forms.Label();
            this.label_zapisz = new System.Windows.Forms.Label();
            this.label_wykres = new System.Windows.Forms.Label();
            this.label_zaladuj = new System.Windows.Forms.Label();
            this.label_left_zaladowanyplik = new System.Windows.Forms.Label();
            this.label_right_zaladowanyplik = new System.Windows.Forms.Label();
            this.label_main_zaladowanyplik = new System.Windows.Forms.Label();
            this.textBox_Max = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.WartoscMax = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.wartoscMin = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxIlosc = new System.Windows.Forms.TextBox();
            this.textBox_wartoscMax = new System.Windows.Forms.TextBox();
            this.label_komunikat = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            panel7 = new System.Windows.Forms.Panel();
            panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            panel7.AutoSize = true;
            panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel7.Controls.Add(this.wariancja);
            panel7.Controls.Add(this.srednia);
            panel7.Controls.Add(this.min);
            panel7.Controls.Add(this.max);
            panel7.Controls.Add(this.ilosc);
            panel7.Controls.Add(this.label1);
            panel7.Controls.Add(this.label12);
            panel7.Controls.Add(this.label11);
            panel7.Controls.Add(this.label10);
            panel7.Controls.Add(this.label9);
            panel7.Controls.Add(this.label8);
            panel7.Cursor = System.Windows.Forms.Cursors.Default;
            panel7.Location = new System.Drawing.Point(408, 130);
            panel7.Margin = new System.Windows.Forms.Padding(5);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(353, 349);
            panel7.TabIndex = 12;
            // 
            // wariancja
            // 
            this.wariancja.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wariancja.ForeColor = System.Drawing.Color.Cyan;
            this.wariancja.Location = new System.Drawing.Point(231, 303);
            this.wariancja.Name = "wariancja";
            this.wariancja.ReadOnly = true;
            this.wariancja.Size = new System.Drawing.Size(100, 20);
            this.wariancja.TabIndex = 14;
            this.wariancja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wariancja.TextChanged += new System.EventHandler(this.wariancja_TextChanged);
            // 
            // srednia
            // 
            this.srednia.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.srednia.ForeColor = System.Drawing.Color.Cyan;
            this.srednia.Location = new System.Drawing.Point(231, 252);
            this.srednia.Name = "srednia";
            this.srednia.ReadOnly = true;
            this.srednia.Size = new System.Drawing.Size(100, 20);
            this.srednia.TabIndex = 13;
            this.srednia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.srednia.TextChanged += new System.EventHandler(this.srednia_TextChanged);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.min.ForeColor = System.Drawing.Color.Cyan;
            this.min.Location = new System.Drawing.Point(231, 199);
            this.min.Name = "min";
            this.min.ReadOnly = true;
            this.min.Size = new System.Drawing.Size(100, 20);
            this.min.TabIndex = 12;
            this.min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.min.TextChanged += new System.EventHandler(this.min_TextChanged);
            // 
            // max
            // 
            this.max.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.max.ForeColor = System.Drawing.Color.Cyan;
            this.max.Location = new System.Drawing.Point(231, 145);
            this.max.Name = "max";
            this.max.ReadOnly = true;
            this.max.Size = new System.Drawing.Size(100, 20);
            this.max.TabIndex = 11;
            this.max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.max.TextChanged += new System.EventHandler(this.max_TextChanged);
            // 
            // ilosc
            // 
            this.ilosc.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ilosc.ForeColor = System.Drawing.Color.Cyan;
            this.ilosc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ilosc.Location = new System.Drawing.Point(231, 99);
            this.ilosc.Name = "ilosc";
            this.ilosc.ReadOnly = true;
            this.ilosc.Size = new System.Drawing.Size(100, 20);
            this.ilosc.TabIndex = 10;
            this.ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ilosc.TextChanged += new System.EventHandler(this.ilosc_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(19, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ilość pomiarów";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Location = new System.Drawing.Point(19, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 28);
            this.label12.TabIndex = 4;
            this.label12.Text = "Wartość średnia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Location = new System.Drawing.Point(19, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Wartość minimalna";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Location = new System.Drawing.Point(19, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "Wariancja";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Location = new System.Drawing.Point(19, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Wartość maksymalna";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Cyan;
            this.label8.Location = new System.Drawing.Point(16, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 45);
            this.label8.TabIndex = 0;
            this.label8.Text = "Obliczanie parametrów";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 58);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aquamarine;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Location = new System.Drawing.Point(638, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Created by";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(658, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Igor Kohsin";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(86, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(577, 58);
            this.label4.TabIndex = 0;
            this.label4.Text = "Analiza pomiarów wyników";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.panel_left);
            this.panel2.Controls.Add(this.button_zaladuj);
            this.panel2.Controls.Add(this.button_wyswietl);
            this.panel2.Controls.Add(this.button_wyczysc);
            this.panel2.Controls.Add(this.button_zapisz);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 492);
            this.panel2.TabIndex = 1;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_left.Location = new System.Drawing.Point(0, 48);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(6, 78);
            this.panel_left.TabIndex = 3;
            // 
            // button_zaladuj
            // 
            this.button_zaladuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.button_zaladuj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_zaladuj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_zaladuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zaladuj.ForeColor = System.Drawing.Color.Cyan;
            this.button_zaladuj.Image = ((System.Drawing.Image)(resources.GetObject("button_zaladuj.Image")));
            this.button_zaladuj.Location = new System.Drawing.Point(12, 48);
            this.button_zaladuj.Name = "button_zaladuj";
            this.button_zaladuj.Size = new System.Drawing.Size(117, 78);
            this.button_zaladuj.TabIndex = 8;
            this.button_zaladuj.UseVisualStyleBackColor = false;
            this.button_zaladuj.Click += new System.EventHandler(this.button_zaladuj_Click);
            this.button_zaladuj.MouseEnter += new System.EventHandler(this.button_zaladuj_MouseEnter);
            this.button_zaladuj.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_zaladuj_MouseMove);
            // 
            // button_wyswietl
            // 
            this.button_wyswietl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.button_wyswietl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_wyswietl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_wyswietl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wyswietl.Image = ((System.Drawing.Image)(resources.GetObject("button_wyswietl.Image")));
            this.button_wyswietl.Location = new System.Drawing.Point(12, 159);
            this.button_wyswietl.Name = "button_wyswietl";
            this.button_wyswietl.Size = new System.Drawing.Size(117, 78);
            this.button_wyswietl.TabIndex = 7;
            this.button_wyswietl.UseVisualStyleBackColor = false;
            this.button_wyswietl.Click += new System.EventHandler(this.button_wyswietl_Click);
            this.button_wyswietl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_wyswietl_MouseMove);
            // 
            // button_wyczysc
            // 
            this.button_wyczysc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.button_wyczysc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_wyczysc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_wyczysc.Image = ((System.Drawing.Image)(resources.GetObject("button_wyczysc.Image")));
            this.button_wyczysc.Location = new System.Drawing.Point(12, 268);
            this.button_wyczysc.Name = "button_wyczysc";
            this.button_wyczysc.Size = new System.Drawing.Size(117, 78);
            this.button_wyczysc.TabIndex = 6;
            this.button_wyczysc.UseVisualStyleBackColor = false;
            this.button_wyczysc.Click += new System.EventHandler(this.button_wyczysc_Click);
            this.button_wyczysc.MouseEnter += new System.EventHandler(this.button_wyczysc_MouseEnter);
            this.button_wyczysc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_wyczysc_MouseMove);
            // 
            // button_zapisz
            // 
            this.button_zapisz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.button_zapisz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_zapisz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_zapisz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_zapisz.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_zapisz.Image = ((System.Drawing.Image)(resources.GetObject("button_zapisz.Image")));
            this.button_zapisz.Location = new System.Drawing.Point(12, 372);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(117, 78);
            this.button_zapisz.TabIndex = 4;
            this.button_zapisz.UseVisualStyleBackColor = false;
            this.button_zapisz.Click += new System.EventHandler(this.button_zapisz_Click);
            this.button_zapisz.MouseEnter += new System.EventHandler(this.button_zapisz_MouseEnter);
            this.button_zapisz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_zapisz_MouseMove);
            // 
            // label_wyczysc
            // 
            this.label_wyczysc.AutoSize = true;
            this.label_wyczysc.BackColor = System.Drawing.Color.Transparent;
            this.label_wyczysc.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wyczysc.ForeColor = System.Drawing.Color.Aquamarine;
            this.label_wyczysc.Location = new System.Drawing.Point(148, 347);
            this.label_wyczysc.Name = "label_wyczysc";
            this.label_wyczysc.Size = new System.Drawing.Size(156, 28);
            this.label_wyczysc.TabIndex = 8;
            this.label_wyczysc.Text = "Wyczyść dane";
            this.label_wyczysc.Visible = false;
            // 
            // label_zapisz
            // 
            this.label_zapisz.AutoSize = true;
            this.label_zapisz.BackColor = System.Drawing.Color.Transparent;
            this.label_zapisz.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_zapisz.ForeColor = System.Drawing.Color.Aquamarine;
            this.label_zapisz.Location = new System.Drawing.Point(148, 451);
            this.label_zapisz.Name = "label_zapisz";
            this.label_zapisz.Size = new System.Drawing.Size(156, 28);
            this.label_zapisz.TabIndex = 9;
            this.label_zapisz.Text = "Zapisz wynik";
            this.label_zapisz.Visible = false;
            // 
            // label_wykres
            // 
            this.label_wykres.AutoSize = true;
            this.label_wykres.BackColor = System.Drawing.Color.Transparent;
            this.label_wykres.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wykres.ForeColor = System.Drawing.Color.Aquamarine;
            this.label_wykres.Location = new System.Drawing.Point(148, 241);
            this.label_wykres.Name = "label_wykres";
            this.label_wykres.Size = new System.Drawing.Size(192, 28);
            this.label_wykres.TabIndex = 10;
            this.label_wykres.Text = "Wyświetl wykres";
            this.label_wykres.Visible = false;
            // 
            // label_zaladuj
            // 
            this.label_zaladuj.AutoSize = true;
            this.label_zaladuj.BackColor = System.Drawing.Color.Transparent;
            this.label_zaladuj.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_zaladuj.ForeColor = System.Drawing.Color.Aquamarine;
            this.label_zaladuj.Location = new System.Drawing.Point(148, 130);
            this.label_zaladuj.Name = "label_zaladuj";
            this.label_zaladuj.Size = new System.Drawing.Size(156, 28);
            this.label_zaladuj.TabIndex = 11;
            this.label_zaladuj.Text = "Załaduj plik";
            this.label_zaladuj.Visible = false;
            this.label_zaladuj.Click += new System.EventHandler(this.label_zaladuj_Click);
            this.label_zaladuj.MouseEnter += new System.EventHandler(this.label_zaladuj_Point);
            // 
            // label_left_zaladowanyplik
            // 
            this.label_left_zaladowanyplik.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_left_zaladowanyplik.Image = ((System.Drawing.Image)(resources.GetObject("label_left_zaladowanyplik.Image")));
            this.label_left_zaladowanyplik.Location = new System.Drawing.Point(447, 489);
            this.label_left_zaladowanyplik.Name = "label_left_zaladowanyplik";
            this.label_left_zaladowanyplik.Size = new System.Drawing.Size(58, 38);
            this.label_left_zaladowanyplik.TabIndex = 0;
            this.label_left_zaladowanyplik.Click += new System.EventHandler(this.label_left_zaladowanyplik_Click);
            // 
            // label_right_zaladowanyplik
            // 
            this.label_right_zaladowanyplik.Image = ((System.Drawing.Image)(resources.GetObject("label_right_zaladowanyplik.Image")));
            this.label_right_zaladowanyplik.Location = new System.Drawing.Point(669, 489);
            this.label_right_zaladowanyplik.Name = "label_right_zaladowanyplik";
            this.label_right_zaladowanyplik.Size = new System.Drawing.Size(30, 38);
            this.label_right_zaladowanyplik.TabIndex = 1;
            this.label_right_zaladowanyplik.Click += new System.EventHandler(this.label_right_zaladowanyplik_Click);
            // 
            // label_main_zaladowanyplik
            // 
            this.label_main_zaladowanyplik.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_main_zaladowanyplik.ForeColor = System.Drawing.SystemColors.Control;
            this.label_main_zaladowanyplik.Location = new System.Drawing.Point(408, 489);
            this.label_main_zaladowanyplik.Name = "label_main_zaladowanyplik";
            this.label_main_zaladowanyplik.Size = new System.Drawing.Size(353, 34);
            this.label_main_zaladowanyplik.TabIndex = 13;
            this.label_main_zaladowanyplik.Text = "Brak pliku";
            this.label_main_zaladowanyplik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_main_zaladowanyplik.Click += new System.EventHandler(this.label_main_zaladowanyplik_Click);
            // 
            // textBox_Max
            // 
            this.textBox_Max.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Max.Location = new System.Drawing.Point(231, 143);
            this.textBox_Max.Name = "textBox_Max";
            this.textBox_Max.Size = new System.Drawing.Size(100, 20);
            this.textBox_Max.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox5.Location = new System.Drawing.Point(231, 92);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // WartoscMax
            // 
            this.WartoscMax.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.WartoscMax.Location = new System.Drawing.Point(231, 143);
            this.WartoscMax.Name = "WartoscMax";
            this.WartoscMax.Size = new System.Drawing.Size(100, 20);
            this.WartoscMax.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(231, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // wartoscMin
            // 
            this.wartoscMin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wartoscMin.Location = new System.Drawing.Point(231, 199);
            this.wartoscMin.Name = "wartoscMin";
            this.wartoscMin.Size = new System.Drawing.Size(100, 20);
            this.wartoscMin.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox3.Location = new System.Drawing.Point(231, 252);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox4.Location = new System.Drawing.Point(231, 304);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBoxIlosc
            // 
            this.textBoxIlosc.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxIlosc.Location = new System.Drawing.Point(231, 92);
            this.textBoxIlosc.Name = "textBoxIlosc";
            this.textBoxIlosc.Size = new System.Drawing.Size(100, 20);
            this.textBoxIlosc.TabIndex = 10;
            // 
            // textBox_wartoscMax
            // 
            this.textBox_wartoscMax.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_wartoscMax.Location = new System.Drawing.Point(231, 143);
            this.textBox_wartoscMax.Name = "textBox_wartoscMax";
            this.textBox_wartoscMax.Size = new System.Drawing.Size(100, 20);
            this.textBox_wartoscMax.TabIndex = 5;
            // 
            // label_komunikat
            // 
            this.label_komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_komunikat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_komunikat.Location = new System.Drawing.Point(141, 523);
            this.label_komunikat.Name = "label_komunikat";
            this.label_komunikat.Size = new System.Drawing.Size(666, 26);
            this.label_komunikat.TabIndex = 14;
            this.label_komunikat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(819, 550);
            this.Controls.Add(this.label_komunikat);
            this.Controls.Add(this.label_right_zaladowanyplik);
            this.Controls.Add(this.label_left_zaladowanyplik);
            this.Controls.Add(panel7);
            this.Controls.Add(this.label_zaladuj);
            this.Controls.Add(this.label_wykres);
            this.Controls.Add(this.label_zapisz);
            this.Controls.Add(this.label_wyczysc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_main_zaladowanyplik);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analiza Temperatur";
            this.Load += new System.EventHandler(this.Form1_Load);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_wyswietl;
        private System.Windows.Forms.Button button_wyczysc;
        private System.Windows.Forms.Button button_zapisz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button button_zaladuj;
        private System.Windows.Forms.Label label_wyczysc;
        private System.Windows.Forms.Label label_zapisz;
        private System.Windows.Forms.Label label_wykres;
        private System.Windows.Forms.Label label_zaladuj;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_left_zaladowanyplik;
        private System.Windows.Forms.Label label_right_zaladowanyplik;
        private System.Windows.Forms.Label label_main_zaladowanyplik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Max;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox WartoscMax;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox wartoscMin;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxIlosc;
        private System.Windows.Forms.TextBox wariancja;
        private System.Windows.Forms.TextBox srednia;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.TextBox ilosc;
        private System.Windows.Forms.TextBox textBox_wartoscMax;
        private System.Windows.Forms.Label label_komunikat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

