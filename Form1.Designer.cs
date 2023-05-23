namespace ShipGame
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
            this.components = new System.ComponentModel.Container();
            this.txtEnemy = new System.Windows.Forms.Label();
            this.txtPlayer = new System.Windows.Forms.Label();
            this.Pomoc = new System.Windows.Forms.Label();
            this.PolaPrzeciwnikaLista = new System.Windows.Forms.ComboBox();
            this.btnAtak = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.ax4 = new System.Windows.Forms.Button();
            this.ax3 = new System.Windows.Forms.Button();
            this.ax2 = new System.Windows.Forms.Button();
            this.ax1 = new System.Windows.Forms.Button();
            this.bx1 = new System.Windows.Forms.Button();
            this.bx2 = new System.Windows.Forms.Button();
            this.bx3 = new System.Windows.Forms.Button();
            this.bx4 = new System.Windows.Forms.Button();
            this.cx1 = new System.Windows.Forms.Button();
            this.cx2 = new System.Windows.Forms.Button();
            this.cx3 = new System.Windows.Forms.Button();
            this.cx4 = new System.Windows.Forms.Button();
            this.dx1 = new System.Windows.Forms.Button();
            this.dx2 = new System.Windows.Forms.Button();
            this.dx3 = new System.Windows.Forms.Button();
            this.dx4 = new System.Windows.Forms.Button();
            this.CzasPrzeciwnika = new System.Windows.Forms.Timer(this.components);
            this.txtRounds = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEnemy
            // 
            this.txtEnemy.AutoSize = true;
            this.txtEnemy.BackColor = System.Drawing.Color.Transparent;
            this.txtEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEnemy.ForeColor = System.Drawing.Color.Black;
            this.txtEnemy.Location = new System.Drawing.Point(804, 39);
            this.txtEnemy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEnemy.Name = "txtEnemy";
            this.txtEnemy.Size = new System.Drawing.Size(46, 31);
            this.txtEnemy.TabIndex = 0;
            this.txtEnemy.Text = "00";
            // 
            // txtPlayer
            // 
            this.txtPlayer.AutoSize = true;
            this.txtPlayer.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPlayer.ForeColor = System.Drawing.Color.Black;
            this.txtPlayer.Location = new System.Drawing.Point(92, 39);
            this.txtPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(46, 31);
            this.txtPlayer.TabIndex = 0;
            this.txtPlayer.Text = "00";
            // 
            // Pomoc
            // 
            this.Pomoc.AutoSize = true;
            this.Pomoc.BackColor = System.Drawing.Color.Transparent;
            this.Pomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pomoc.ForeColor = System.Drawing.Color.Black;
            this.Pomoc.Location = new System.Drawing.Point(1, 85);
            this.Pomoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pomoc.Name = "Pomoc";
            this.Pomoc.Size = new System.Drawing.Size(0, 25);
            this.Pomoc.TabIndex = 3;
            // 
            // PolaPrzeciwnikaLista
            // 
            this.PolaPrzeciwnikaLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PolaPrzeciwnikaLista.DropDownWidth = 95;
            this.PolaPrzeciwnikaLista.FormattingEnabled = true;
            this.PolaPrzeciwnikaLista.Location = new System.Drawing.Point(217, 12);
            this.PolaPrzeciwnikaLista.Name = "PolaPrzeciwnikaLista";
            this.PolaPrzeciwnikaLista.Size = new System.Drawing.Size(121, 24);
            this.PolaPrzeciwnikaLista.TabIndex = 4;
            // 
            // btnAtak
            // 
            this.btnAtak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAtak.Location = new System.Drawing.Point(351, 9);
            this.btnAtak.Name = "btnAtak";
            this.btnAtak.Size = new System.Drawing.Size(74, 33);
            this.btnAtak.TabIndex = 5;
            this.btnAtak.Text = "ATAK";
            this.btnAtak.UseVisualStyleBackColor = true;
            this.btnAtak.Click += new System.EventHandler(this.AtakBtn);
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.Color.White;
            this.a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a2.Location = new System.Drawing.Point(163, 196);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 71);
            this.a2.TabIndex = 5;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = false;
            this.a2.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.Color.White;
            this.a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a3.Location = new System.Drawing.Point(263, 196);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(87, 71);
            this.a3.TabIndex = 5;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = false;
            this.a3.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // a4
            // 
            this.a4.BackColor = System.Drawing.Color.White;
            this.a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a4.Location = new System.Drawing.Point(369, 196);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(72, 71);
            this.a4.TabIndex = 5;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = false;
            this.a4.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.White;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b1.Location = new System.Drawing.Point(65, 284);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 71);
            this.b1.TabIndex = 5;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.White;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b2.Location = new System.Drawing.Point(163, 284);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 71);
            this.b2.TabIndex = 5;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.White;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b3.Location = new System.Drawing.Point(263, 284);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(87, 71);
            this.b3.TabIndex = 5;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.White;
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b4.Location = new System.Drawing.Point(369, 284);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(72, 71);
            this.b4.TabIndex = 5;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.Color.White;
            this.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c1.Location = new System.Drawing.Point(65, 375);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 71);
            this.c1.TabIndex = 5;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = false;
            this.c1.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // c2
            // 
            this.c2.BackColor = System.Drawing.Color.White;
            this.c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c2.Location = new System.Drawing.Point(163, 375);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(75, 71);
            this.c2.TabIndex = 5;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = false;
            this.c2.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // c3
            // 
            this.c3.BackColor = System.Drawing.Color.White;
            this.c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c3.Location = new System.Drawing.Point(263, 375);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(87, 71);
            this.c3.TabIndex = 5;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = false;
            this.c3.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // c4
            // 
            this.c4.BackColor = System.Drawing.Color.White;
            this.c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c4.Location = new System.Drawing.Point(369, 375);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(72, 71);
            this.c4.TabIndex = 5;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = false;
            this.c4.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // d1
            // 
            this.d1.BackColor = System.Drawing.Color.White;
            this.d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.d1.Location = new System.Drawing.Point(65, 462);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(75, 55);
            this.d1.TabIndex = 5;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = false;
            this.d1.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // d2
            // 
            this.d2.BackColor = System.Drawing.Color.White;
            this.d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.d2.Location = new System.Drawing.Point(163, 462);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(75, 55);
            this.d2.TabIndex = 5;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = false;
            this.d2.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // d3
            // 
            this.d3.BackColor = System.Drawing.Color.White;
            this.d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.d3.Location = new System.Drawing.Point(263, 462);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(87, 55);
            this.d3.TabIndex = 5;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = false;
            this.d3.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // d4
            // 
            this.d4.BackColor = System.Drawing.Color.White;
            this.d4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.d4.Location = new System.Drawing.Point(369, 462);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(72, 55);
            this.d4.TabIndex = 5;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = false;
            this.d4.Click += new System.EventHandler(this.PozycjaGraczaBtn);
            // 
            // ax4
            // 
            this.ax4.BackColor = System.Drawing.Color.White;
            this.ax4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ax4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ax4.Location = new System.Drawing.Point(972, 196);
            this.ax4.Name = "ax4";
            this.ax4.Size = new System.Drawing.Size(85, 71);
            this.ax4.TabIndex = 18;
            this.ax4.Text = "A4";
            this.ax4.UseVisualStyleBackColor = false;
            // 
            // ax3
            // 
            this.ax3.BackColor = System.Drawing.Color.White;
            this.ax3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ax3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ax3.Location = new System.Drawing.Point(870, 196);
            this.ax3.Name = "ax3";
            this.ax3.Size = new System.Drawing.Size(87, 71);
            this.ax3.TabIndex = 21;
            this.ax3.Text = "A3";
            this.ax3.UseVisualStyleBackColor = false;
            // 
            // ax2
            // 
            this.ax2.BackColor = System.Drawing.Color.White;
            this.ax2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ax2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ax2.Location = new System.Drawing.Point(780, 196);
            this.ax2.Name = "ax2";
            this.ax2.Size = new System.Drawing.Size(75, 71);
            this.ax2.TabIndex = 14;
            this.ax2.Text = "A2";
            this.ax2.UseVisualStyleBackColor = false;
            // 
            // ax1
            // 
            this.ax1.BackColor = System.Drawing.Color.White;
            this.ax1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ax1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ax1.Location = new System.Drawing.Point(687, 196);
            this.ax1.Name = "ax1";
            this.ax1.Size = new System.Drawing.Size(75, 71);
            this.ax1.TabIndex = 13;
            this.ax1.Text = "A1";
            this.ax1.UseVisualStyleBackColor = false;
            // 
            // bx1
            // 
            this.bx1.BackColor = System.Drawing.Color.White;
            this.bx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bx1.Location = new System.Drawing.Point(687, 284);
            this.bx1.Name = "bx1";
            this.bx1.Size = new System.Drawing.Size(75, 71);
            this.bx1.TabIndex = 13;
            this.bx1.Text = "B1";
            this.bx1.UseVisualStyleBackColor = false;
            // 
            // bx2
            // 
            this.bx2.BackColor = System.Drawing.Color.White;
            this.bx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bx2.Location = new System.Drawing.Point(780, 284);
            this.bx2.Name = "bx2";
            this.bx2.Size = new System.Drawing.Size(75, 71);
            this.bx2.TabIndex = 14;
            this.bx2.Text = "B2";
            this.bx2.UseVisualStyleBackColor = false;
            // 
            // bx3
            // 
            this.bx3.BackColor = System.Drawing.Color.White;
            this.bx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bx3.Location = new System.Drawing.Point(870, 284);
            this.bx3.Name = "bx3";
            this.bx3.Size = new System.Drawing.Size(87, 71);
            this.bx3.TabIndex = 21;
            this.bx3.Text = "B3";
            this.bx3.UseVisualStyleBackColor = false;
            // 
            // bx4
            // 
            this.bx4.BackColor = System.Drawing.Color.White;
            this.bx4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bx4.Location = new System.Drawing.Point(972, 284);
            this.bx4.Name = "bx4";
            this.bx4.Size = new System.Drawing.Size(85, 71);
            this.bx4.TabIndex = 18;
            this.bx4.Text = "B4";
            this.bx4.UseVisualStyleBackColor = false;
            // 
            // cx1
            // 
            this.cx1.BackColor = System.Drawing.Color.White;
            this.cx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cx1.Location = new System.Drawing.Point(687, 375);
            this.cx1.Name = "cx1";
            this.cx1.Size = new System.Drawing.Size(75, 71);
            this.cx1.TabIndex = 13;
            this.cx1.Text = "C1";
            this.cx1.UseVisualStyleBackColor = false;
            // 
            // cx2
            // 
            this.cx2.BackColor = System.Drawing.Color.White;
            this.cx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cx2.Location = new System.Drawing.Point(780, 375);
            this.cx2.Name = "cx2";
            this.cx2.Size = new System.Drawing.Size(75, 71);
            this.cx2.TabIndex = 14;
            this.cx2.Text = "C2";
            this.cx2.UseVisualStyleBackColor = false;
            // 
            // cx3
            // 
            this.cx3.BackColor = System.Drawing.Color.White;
            this.cx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cx3.Location = new System.Drawing.Point(870, 375);
            this.cx3.Name = "cx3";
            this.cx3.Size = new System.Drawing.Size(87, 71);
            this.cx3.TabIndex = 21;
            this.cx3.Text = "C3";
            this.cx3.UseVisualStyleBackColor = false;
            // 
            // cx4
            // 
            this.cx4.BackColor = System.Drawing.Color.White;
            this.cx4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cx4.Location = new System.Drawing.Point(972, 375);
            this.cx4.Name = "cx4";
            this.cx4.Size = new System.Drawing.Size(85, 71);
            this.cx4.TabIndex = 18;
            this.cx4.Text = "C4";
            this.cx4.UseVisualStyleBackColor = false;
            // 
            // dx1
            // 
            this.dx1.BackColor = System.Drawing.Color.White;
            this.dx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dx1.Location = new System.Drawing.Point(687, 458);
            this.dx1.Name = "dx1";
            this.dx1.Size = new System.Drawing.Size(75, 59);
            this.dx1.TabIndex = 13;
            this.dx1.Text = "D1";
            this.dx1.UseVisualStyleBackColor = false;
            // 
            // dx2
            // 
            this.dx2.BackColor = System.Drawing.Color.White;
            this.dx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dx2.Location = new System.Drawing.Point(780, 458);
            this.dx2.Name = "dx2";
            this.dx2.Size = new System.Drawing.Size(75, 59);
            this.dx2.TabIndex = 14;
            this.dx2.Text = "D2";
            this.dx2.UseVisualStyleBackColor = false;
            // 
            // dx3
            // 
            this.dx3.BackColor = System.Drawing.Color.White;
            this.dx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dx3.Location = new System.Drawing.Point(870, 458);
            this.dx3.Name = "dx3";
            this.dx3.Size = new System.Drawing.Size(87, 59);
            this.dx3.TabIndex = 21;
            this.dx3.Text = "D3";
            this.dx3.UseVisualStyleBackColor = false;
            // 
            // dx4
            // 
            this.dx4.BackColor = System.Drawing.Color.White;
            this.dx4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dx4.Location = new System.Drawing.Point(972, 458);
            this.dx4.Name = "dx4";
            this.dx4.Size = new System.Drawing.Size(85, 59);
            this.dx4.TabIndex = 18;
            this.dx4.Text = "D4";
            this.dx4.UseVisualStyleBackColor = false;
            // 
            // CzasPrzeciwnika
            // 
            this.CzasPrzeciwnika.Interval = 1000;
            this.CzasPrzeciwnika.Tick += new System.EventHandler(this.CzasGraniaPrzeciwnika);
            // 
            // txtRounds
            // 
            this.txtRounds.AutoSize = true;
            this.txtRounds.BackColor = System.Drawing.Color.Transparent;
            this.txtRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRounds.ForeColor = System.Drawing.Color.Black;
            this.txtRounds.Location = new System.Drawing.Point(480, 196);
            this.txtRounds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRounds.Name = "txtRounds";
            this.txtRounds.Size = new System.Drawing.Size(147, 31);
            this.txtRounds.TabIndex = 22;
            this.txtRounds.Text = "Rundy: 10";
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.Color.White;
            this.a1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a1.Location = new System.Drawing.Point(65, 196);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 71);
            this.a1.TabIndex = 23;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(982, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "A1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShipGame.Properties.Resources.menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1131, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.txtRounds);
            this.Controls.Add(this.dx4);
            this.Controls.Add(this.dx3);
            this.Controls.Add(this.cx4);
            this.Controls.Add(this.cx3);
            this.Controls.Add(this.bx4);
            this.Controls.Add(this.dx2);
            this.Controls.Add(this.bx3);
            this.Controls.Add(this.cx2);
            this.Controls.Add(this.ax4);
            this.Controls.Add(this.dx1);
            this.Controls.Add(this.bx2);
            this.Controls.Add(this.cx1);
            this.Controls.Add(this.ax3);
            this.Controls.Add(this.bx1);
            this.Controls.Add(this.ax2);
            this.Controls.Add(this.ax1);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.btnAtak);
            this.Controls.Add(this.PolaPrzeciwnikaLista);
            this.Controls.Add(this.Pomoc);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.txtEnemy);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEnemy;
        private System.Windows.Forms.Label txtPlayer;
        private System.Windows.Forms.Label Pomoc;
        private System.Windows.Forms.ComboBox PolaPrzeciwnikaLista;
        private System.Windows.Forms.Button btnAtak;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button ax4;
        private System.Windows.Forms.Button ax3;
        private System.Windows.Forms.Button ax2;
        private System.Windows.Forms.Button ax1;
        private System.Windows.Forms.Button bx1;
        private System.Windows.Forms.Button bx2;
        private System.Windows.Forms.Button bx3;
        private System.Windows.Forms.Button bx4;
        private System.Windows.Forms.Button cx1;
        private System.Windows.Forms.Button cx2;
        private System.Windows.Forms.Button cx3;
        private System.Windows.Forms.Button cx4;
        private System.Windows.Forms.Button dx1;
        private System.Windows.Forms.Button dx2;
        private System.Windows.Forms.Button dx3;
        private System.Windows.Forms.Button dx4;

        private System.Windows.Forms.Timer CzasGryPrzeciwnika;
        private System.Windows.Forms.Timer CzasPrzeciwnika;
        private System.Windows.Forms.Label txtRounds;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Label label1;
    }
}

