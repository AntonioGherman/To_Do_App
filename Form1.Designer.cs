namespace ToDo
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
            this.afisareSarcini = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschidereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareCaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugatiSarcinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editatiSarcinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergetiSarcinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaSarcina = new System.Windows.Forms.Button();
            this.mesajTitlu = new System.Windows.Forms.Label();
            this.mesajPrioritate = new System.Windows.Forms.Label();
            this.mesajDataFinalizare = new System.Windows.Forms.Label();
            this.mesajDescriereaSarcinii = new System.Windows.Forms.Label();
            this.mesajNumeSarcina = new System.Windows.Forms.Label();
            this.prioritate = new System.Windows.Forms.ComboBox();
            this.dataTerminare = new System.Windows.Forms.DateTimePicker();
            this.descriereSarcina = new System.Windows.Forms.TextBox();
            this.numeSarcina = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // afisareSarcini
            // 
            this.afisareSarcini.Font = new System.Drawing.Font("UT Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afisareSarcini.ItemHeight = 31;
            this.afisareSarcini.Location = new System.Drawing.Point(12, 28);
            this.afisareSarcini.Name = "afisareSarcini";
            this.afisareSarcini.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.afisareSarcini.ScrollAlwaysVisible = true;
            this.afisareSarcini.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.afisareSarcini.Size = new System.Drawing.Size(481, 593);
            this.afisareSarcini.TabIndex = 0;
            this.afisareSarcini.UseWaitCursor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.editareToolStripMenuItem,
            this.ajutorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouToolStripMenuItem,
            this.deschidereToolStripMenuItem,
            this.salvareToolStripMenuItem,
            this.salvareCaToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // nouToolStripMenuItem
            // 
            this.nouToolStripMenuItem.Name = "nouToolStripMenuItem";
            this.nouToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nouToolStripMenuItem.Text = "Nou";
            this.nouToolStripMenuItem.Click += new System.EventHandler(this.nouToolStripMenuItem_Click);
            // 
            // deschidereToolStripMenuItem
            // 
            this.deschidereToolStripMenuItem.Name = "deschidereToolStripMenuItem";
            this.deschidereToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deschidereToolStripMenuItem.Text = "Deschidere";
            this.deschidereToolStripMenuItem.Click += new System.EventHandler(this.deschidereToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // salvareCaToolStripMenuItem
            // 
            this.salvareCaToolStripMenuItem.Name = "salvareCaToolStripMenuItem";
            this.salvareCaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salvareCaToolStripMenuItem.Text = "Salvare ca";
            this.salvareCaToolStripMenuItem.Click += new System.EventHandler(this.salvareCaToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugatiSarcinaToolStripMenuItem,
            this.editatiSarcinaToolStripMenuItem,
            this.stergetiSarcinaToolStripMenuItem});
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.editareToolStripMenuItem.Text = "Editare";
            // 
            // adaugatiSarcinaToolStripMenuItem
            // 
            this.adaugatiSarcinaToolStripMenuItem.Name = "adaugatiSarcinaToolStripMenuItem";
            this.adaugatiSarcinaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adaugatiSarcinaToolStripMenuItem.Text = "Adaugati sarcina";
            this.adaugatiSarcinaToolStripMenuItem.Click += new System.EventHandler(this.adaugatiSarcinaToolStripMenuItem_Click);
            // 
            // editatiSarcinaToolStripMenuItem
            // 
            this.editatiSarcinaToolStripMenuItem.Name = "editatiSarcinaToolStripMenuItem";
            this.editatiSarcinaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editatiSarcinaToolStripMenuItem.Text = "Editati sarcina";
            this.editatiSarcinaToolStripMenuItem.Click += new System.EventHandler(this.editatiSarcinaToolStripMenuItem_Click);
            // 
            // stergetiSarcinaToolStripMenuItem
            // 
            this.stergetiSarcinaToolStripMenuItem.Name = "stergetiSarcinaToolStripMenuItem";
            this.stergetiSarcinaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stergetiSarcinaToolStripMenuItem.Text = "Stergeti sarcina";
            this.stergetiSarcinaToolStripMenuItem.Click += new System.EventHandler(this.stergetiSarcinaToolStripMenuItem_Click);
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despreToolStripMenuItem});
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.despreToolStripMenuItem.Text = "Despre";
            // 
            // adaugaSarcina
            // 
            this.adaugaSarcina.Font = new System.Drawing.Font("UT Sans Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaSarcina.Location = new System.Drawing.Point(623, 519);
            this.adaugaSarcina.Name = "adaugaSarcina";
            this.adaugaSarcina.Size = new System.Drawing.Size(176, 63);
            this.adaugaSarcina.TabIndex = 20;
            this.adaugaSarcina.Text = "Adaugare";
            this.adaugaSarcina.UseVisualStyleBackColor = true;
            this.adaugaSarcina.Click += new System.EventHandler(this.adaugaSarcina_Click);
            // 
            // mesajTitlu
            // 
            this.mesajTitlu.AutoSize = true;
            this.mesajTitlu.Font = new System.Drawing.Font("UT Sans Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesajTitlu.Location = new System.Drawing.Point(616, 28);
            this.mesajTitlu.Name = "mesajTitlu";
            this.mesajTitlu.Size = new System.Drawing.Size(183, 38);
            this.mesajTitlu.TabIndex = 19;
            this.mesajTitlu.Text = "Adauga sarcina";
            // 
            // mesajPrioritate
            // 
            this.mesajPrioritate.AutoSize = true;
            this.mesajPrioritate.Font = new System.Drawing.Font("UT Sans Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesajPrioritate.Location = new System.Drawing.Point(518, 389);
            this.mesajPrioritate.Name = "mesajPrioritate";
            this.mesajPrioritate.Size = new System.Drawing.Size(350, 34);
            this.mesajPrioritate.TabIndex = 18;
            this.mesajPrioritate.Text = "Alege nivelul de prioritate al sarcinii";
            // 
            // mesajDataFinalizare
            // 
            this.mesajDataFinalizare.AutoSize = true;
            this.mesajDataFinalizare.Font = new System.Drawing.Font("UT Sans Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesajDataFinalizare.Location = new System.Drawing.Point(518, 314);
            this.mesajDataFinalizare.Name = "mesajDataFinalizare";
            this.mesajDataFinalizare.Size = new System.Drawing.Size(179, 34);
            this.mesajDataFinalizare.TabIndex = 17;
            this.mesajDataFinalizare.Text = "Data de finalizare";
            // 
            // mesajDescriereaSarcinii
            // 
            this.mesajDescriereaSarcinii.AutoSize = true;
            this.mesajDescriereaSarcinii.Font = new System.Drawing.Font("UT Sans Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesajDescriereaSarcinii.Location = new System.Drawing.Point(518, 211);
            this.mesajDescriereaSarcinii.Name = "mesajDescriereaSarcinii";
            this.mesajDescriereaSarcinii.Size = new System.Drawing.Size(258, 34);
            this.mesajDescriereaSarcinii.TabIndex = 16;
            this.mesajDescriereaSarcinii.Text = "Introdu descrierea sarcinii";
            // 
            // mesajNumeSarcina
            // 
            this.mesajNumeSarcina.AutoSize = true;
            this.mesajNumeSarcina.Font = new System.Drawing.Font("UT Sans Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesajNumeSarcina.Location = new System.Drawing.Point(518, 97);
            this.mesajNumeSarcina.Name = "mesajNumeSarcina";
            this.mesajNumeSarcina.Size = new System.Drawing.Size(231, 34);
            this.mesajNumeSarcina.TabIndex = 15;
            this.mesajNumeSarcina.Text = "Introdu numele sarcinii";
            // 
            // prioritate
            // 
            this.prioritate.FormattingEnabled = true;
            this.prioritate.Items.AddRange(new object[] {
            "Important",
            "Necesar",
            "Fara prioritate"});
            this.prioritate.Location = new System.Drawing.Point(523, 426);
            this.prioritate.Name = "prioritate";
            this.prioritate.Size = new System.Drawing.Size(121, 24);
            this.prioritate.TabIndex = 14;
            // 
            // dataTerminare
            // 
            this.dataTerminare.Location = new System.Drawing.Point(523, 351);
            this.dataTerminare.Name = "dataTerminare";
            this.dataTerminare.Size = new System.Drawing.Size(213, 22);
            this.dataTerminare.TabIndex = 13;
            // 
            // descriereSarcina
            // 
            this.descriereSarcina.Location = new System.Drawing.Point(523, 248);
            this.descriereSarcina.Multiline = true;
            this.descriereSarcina.Name = "descriereSarcina";
            this.descriereSarcina.Size = new System.Drawing.Size(245, 45);
            this.descriereSarcina.TabIndex = 12;
            // 
            // numeSarcina
            // 
            this.numeSarcina.Location = new System.Drawing.Point(523, 134);
            this.numeSarcina.Multiline = true;
            this.numeSarcina.Name = "numeSarcina";
            this.numeSarcina.Size = new System.Drawing.Size(245, 45);
            this.numeSarcina.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 636);
            this.Controls.Add(this.adaugaSarcina);
            this.Controls.Add(this.mesajTitlu);
            this.Controls.Add(this.mesajPrioritate);
            this.Controls.Add(this.mesajDataFinalizare);
            this.Controls.Add(this.mesajDescriereaSarcinii);
            this.Controls.Add(this.mesajNumeSarcina);
            this.Controls.Add(this.prioritate);
            this.Controls.Add(this.dataTerminare);
            this.Controls.Add(this.descriereSarcina);
            this.Controls.Add(this.numeSarcina);
            this.Controls.Add(this.afisareSarcini);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox afisareSarcini;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschidereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareCaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugatiSarcinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editatiSarcinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergetiSarcinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.Button adaugaSarcina;
        private System.Windows.Forms.Label mesajTitlu;
        private System.Windows.Forms.Label mesajPrioritate;
        private System.Windows.Forms.Label mesajDataFinalizare;
        private System.Windows.Forms.Label mesajDescriereaSarcinii;
        private System.Windows.Forms.Label mesajNumeSarcina;
        private System.Windows.Forms.ComboBox prioritate;
        private System.Windows.Forms.DateTimePicker dataTerminare;
        private System.Windows.Forms.TextBox descriereSarcina;
        private System.Windows.Forms.TextBox numeSarcina;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

