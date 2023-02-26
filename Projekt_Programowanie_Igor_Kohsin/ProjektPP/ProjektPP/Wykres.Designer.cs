namespace ProjektPP
{
    partial class Wykres
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wykres));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WykresRoznicaCheck = new System.Windows.Forms.CheckBox();
            this.WykresCheck = new System.Windows.Forms.CheckBox();
            this.Seria2 = new System.Windows.Forms.CheckBox();
            this.kolorTemperatury = new System.Windows.Forms.CheckBox();
            this.kolorSerii = new System.Windows.Forms.CheckBox();
            this.Siatka = new System.Windows.Forms.CheckBox();
            this.Seria = new System.Windows.Forms.CheckBox();
            this.Legenda = new System.Windows.Forms.CheckBox();
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.WykresRoznicaCheck);
            this.panel2.Controls.Add(this.WykresCheck);
            this.panel2.Controls.Add(this.Seria2);
            this.panel2.Controls.Add(this.kolorTemperatury);
            this.panel2.Controls.Add(this.kolorSerii);
            this.panel2.Controls.Add(this.Siatka);
            this.panel2.Controls.Add(this.Seria);
            this.panel2.Controls.Add(this.Legenda);
            this.panel2.Controls.Add(this.panel_left);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 632);
            this.panel2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(36, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 30);
            this.label3.TabIndex = 33;
            this.label3.Text = "Opcje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(7, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "Opcje Ogólne";
            // 
            // WykresRoznicaCheck
            // 
            this.WykresRoznicaCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.WykresRoznicaCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.WykresRoznicaCheck.Checked = true;
            this.WykresRoznicaCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WykresRoznicaCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WykresRoznicaCheck.Font = new System.Drawing.Font("Cascadia Code", 12.75F);
            this.WykresRoznicaCheck.ForeColor = System.Drawing.Color.Cyan;
            this.WykresRoznicaCheck.Location = new System.Drawing.Point(12, 270);
            this.WykresRoznicaCheck.Name = "WykresRoznicaCheck";
            this.WykresRoznicaCheck.Size = new System.Drawing.Size(117, 56);
            this.WykresRoznicaCheck.TabIndex = 31;
            this.WykresRoznicaCheck.Text = "Wykres Różnicy";
            this.WykresRoznicaCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WykresRoznicaCheck.UseVisualStyleBackColor = false;
            this.WykresRoznicaCheck.CheckedChanged += new System.EventHandler(this.WykresRoznicaCheck_CheckedChanged);
            this.WykresRoznicaCheck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WykresRoznicaCheck_MouseMove);
            // 
            // WykresCheck
            // 
            this.WykresCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.WykresCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.WykresCheck.Checked = true;
            this.WykresCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WykresCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WykresCheck.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WykresCheck.ForeColor = System.Drawing.Color.Cyan;
            this.WykresCheck.Location = new System.Drawing.Point(12, 208);
            this.WykresCheck.Name = "WykresCheck";
            this.WykresCheck.Size = new System.Drawing.Size(117, 56);
            this.WykresCheck.TabIndex = 26;
            this.WykresCheck.Text = "Wykres Odczytu";
            this.WykresCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WykresCheck.UseVisualStyleBackColor = false;
            this.WykresCheck.CheckedChanged += new System.EventHandler(this.WykresCheck_CheckedChanged);
            this.WykresCheck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WykresCheck_MouseMove);
            // 
            // Seria2
            // 
            this.Seria2.Appearance = System.Windows.Forms.Appearance.Button;
            this.Seria2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.Seria2.Checked = true;
            this.Seria2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Seria2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Seria2.Font = new System.Drawing.Font("Cascadia Code", 15.75F);
            this.Seria2.ForeColor = System.Drawing.Color.Cyan;
            this.Seria2.Location = new System.Drawing.Point(12, 131);
            this.Seria2.Name = "Seria2";
            this.Seria2.Size = new System.Drawing.Size(117, 56);
            this.Seria2.TabIndex = 29;
            this.Seria2.Text = "Różnica";
            this.Seria2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Seria2.UseVisualStyleBackColor = false;
            this.Seria2.CheckedChanged += new System.EventHandler(this.Seria2_CheckedChanged);
            this.Seria2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Seria2_MouseMove);
            // 
            // kolorTemperatury
            // 
            this.kolorTemperatury.Appearance = System.Windows.Forms.Appearance.Button;
            this.kolorTemperatury.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.kolorTemperatury.Checked = true;
            this.kolorTemperatury.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kolorTemperatury.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kolorTemperatury.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kolorTemperatury.ForeColor = System.Drawing.Color.Cyan;
            this.kolorTemperatury.Location = new System.Drawing.Point(12, 378);
            this.kolorTemperatury.Name = "kolorTemperatury";
            this.kolorTemperatury.Size = new System.Drawing.Size(117, 56);
            this.kolorTemperatury.TabIndex = 28;
            this.kolorTemperatury.Text = "kolor Temperatury";
            this.kolorTemperatury.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kolorTemperatury.UseVisualStyleBackColor = false;
            this.kolorTemperatury.CheckedChanged += new System.EventHandler(this.kolorTemperatury_CheckedChanged);
            this.kolorTemperatury.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kolorTemperatury_MouseMove);
            // 
            // kolorSerii
            // 
            this.kolorSerii.Appearance = System.Windows.Forms.Appearance.Button;
            this.kolorSerii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.kolorSerii.Checked = true;
            this.kolorSerii.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kolorSerii.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kolorSerii.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kolorSerii.ForeColor = System.Drawing.Color.Cyan;
            this.kolorSerii.Location = new System.Drawing.Point(12, 440);
            this.kolorSerii.Name = "kolorSerii";
            this.kolorSerii.Size = new System.Drawing.Size(117, 56);
            this.kolorSerii.TabIndex = 27;
            this.kolorSerii.Text = "Kolor Serii";
            this.kolorSerii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kolorSerii.UseVisualStyleBackColor = false;
            this.kolorSerii.CheckedChanged += new System.EventHandler(this.kolorSerii_CheckedChanged);
            this.kolorSerii.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kolorSerii_MouseMove);
            // 
            // Siatka
            // 
            this.Siatka.Appearance = System.Windows.Forms.Appearance.Button;
            this.Siatka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.Siatka.Checked = true;
            this.Siatka.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Siatka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Siatka.Font = new System.Drawing.Font("Cascadia Code", 15.75F);
            this.Siatka.ForeColor = System.Drawing.Color.Cyan;
            this.Siatka.Location = new System.Drawing.Point(12, 502);
            this.Siatka.Name = "Siatka";
            this.Siatka.Size = new System.Drawing.Size(117, 56);
            this.Siatka.TabIndex = 25;
            this.Siatka.Text = "Siatka";
            this.Siatka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Siatka.UseVisualStyleBackColor = false;
            this.Siatka.CheckedChanged += new System.EventHandler(this.Siatka_CheckedChanged);
            this.Siatka.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Siatka_MouseMove);
            // 
            // Seria
            // 
            this.Seria.Appearance = System.Windows.Forms.Appearance.Button;
            this.Seria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.Seria.Checked = true;
            this.Seria.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Seria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Seria.Font = new System.Drawing.Font("Cascadia Code", 15.75F);
            this.Seria.ForeColor = System.Drawing.Color.Cyan;
            this.Seria.Location = new System.Drawing.Point(12, 69);
            this.Seria.Name = "Seria";
            this.Seria.Size = new System.Drawing.Size(117, 56);
            this.Seria.TabIndex = 24;
            this.Seria.Text = "Odczyt";
            this.Seria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Seria.UseVisualStyleBackColor = false;
            this.Seria.CheckedChanged += new System.EventHandler(this.Seria_CheckedChanged);
            this.Seria.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Seria_MouseMove);
            // 
            // Legenda
            // 
            this.Legenda.Appearance = System.Windows.Forms.Appearance.Button;
            this.Legenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.Legenda.Checked = true;
            this.Legenda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Legenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Legenda.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Legenda.ForeColor = System.Drawing.Color.Cyan;
            this.Legenda.Location = new System.Drawing.Point(12, 564);
            this.Legenda.Name = "Legenda";
            this.Legenda.Size = new System.Drawing.Size(117, 56);
            this.Legenda.TabIndex = 23;
            this.Legenda.Text = "Legenda";
            this.Legenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Legenda.UseVisualStyleBackColor = false;
            this.Legenda.CheckedChanged += new System.EventHandler(this.Legenda_CheckedChanged);
            this.Legenda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Legenda_MouseMove);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_left.Controls.Add(this.panel1);
            this.panel_left.Location = new System.Drawing.Point(0, 69);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(6, 55);
            this.panel_left.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(-59, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 55);
            this.panel1.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(158, 91);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent40;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Odczyt Temperatur";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Różnica Temperatur";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(638, 529);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "Wykres Pomiarów";
            this.chart1.Titles.Add(title1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aquamarine;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Location = new System.Drawing.Point(526, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Created by";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(546, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Igor Kohsin";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(142, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 70);
            this.panel3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(155, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analiza Wykresu";
            // 
            // Wykres
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(808, 632);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Wykres";
            this.Text = "Wykres";
            this.Load += new System.EventHandler(this.Wykres_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            chart1.MouseWheel += chart1_MouseWheel;

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox kolorTemperatury;
        private System.Windows.Forms.CheckBox kolorSerii;
        private System.Windows.Forms.CheckBox WykresCheck;
        private System.Windows.Forms.CheckBox Siatka;
        private System.Windows.Forms.CheckBox Seria;
        private System.Windows.Forms.CheckBox Legenda;
        private System.Windows.Forms.CheckBox Seria2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox WykresRoznicaCheck;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        
    }
}
