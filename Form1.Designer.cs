namespace shipgame1
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
            this.txtGracz = new System.Windows.Forms.Label();
            this.txtPrzeciwnik = new System.Windows.Forms.Label();
            this.txtRundy = new System.Windows.Forms.Label();
            this.ruchWroga = new System.Windows.Forms.Label();
            this.PolePrzeciwnikaListaBox = new System.Windows.Forms.ComboBox();
            this.btnAtak = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.ax4 = new System.Windows.Forms.Button();
            this.ax3 = new System.Windows.Forms.Button();
            this.ax2 = new System.Windows.Forms.Button();
            this.ax1 = new System.Windows.Forms.Button();
            this.bx4 = new System.Windows.Forms.Button();
            this.bx3 = new System.Windows.Forms.Button();
            this.bx2 = new System.Windows.Forms.Button();
            this.bx1 = new System.Windows.Forms.Button();
            this.cx4 = new System.Windows.Forms.Button();
            this.cx3 = new System.Windows.Forms.Button();
            this.cx2 = new System.Windows.Forms.Button();
            this.cx1 = new System.Windows.Forms.Button();
            this.dx4 = new System.Windows.Forms.Button();
            this.dx3 = new System.Windows.Forms.Button();
            this.dx2 = new System.Windows.Forms.Button();
            this.dx1 = new System.Windows.Forms.Button();
            this.CzasGryWroga = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtGracz
            // 
            this.txtGracz.AutoSize = true;
            this.txtGracz.BackColor = System.Drawing.Color.Transparent;
            this.txtGracz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtGracz.ForeColor = System.Drawing.Color.White;
            this.txtGracz.Location = new System.Drawing.Point(268, 545);
            this.txtGracz.Name = "txtGracz";
            this.txtGracz.Size = new System.Drawing.Size(41, 29);
            this.txtGracz.TabIndex = 0;
            this.txtGracz.Text = "00";
            // 
            // txtPrzeciwnik
            // 
            this.txtPrzeciwnik.AutoSize = true;
            this.txtPrzeciwnik.BackColor = System.Drawing.Color.Transparent;
            this.txtPrzeciwnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrzeciwnik.ForeColor = System.Drawing.Color.White;
            this.txtPrzeciwnik.Location = new System.Drawing.Point(895, 545);
            this.txtPrzeciwnik.Name = "txtPrzeciwnik";
            this.txtPrzeciwnik.Size = new System.Drawing.Size(41, 29);
            this.txtPrzeciwnik.TabIndex = 0;
            this.txtPrzeciwnik.Text = "00";
            // 
            // txtRundy
            // 
            this.txtRundy.AutoSize = true;
            this.txtRundy.BackColor = System.Drawing.Color.Transparent;
            this.txtRundy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRundy.ForeColor = System.Drawing.Color.White;
            this.txtRundy.Location = new System.Drawing.Point(457, 152);
            this.txtRundy.Name = "txtRundy";
            this.txtRundy.Size = new System.Drawing.Size(130, 29);
            this.txtRundy.TabIndex = 0;
            this.txtRundy.Text = "Runda: 10";
            // 
            // ruchWroga
            // 
            this.ruchWroga.AutoSize = true;
            this.ruchWroga.BackColor = System.Drawing.Color.Transparent;
            this.ruchWroga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ruchWroga.ForeColor = System.Drawing.Color.White;
            this.ruchWroga.Location = new System.Drawing.Point(909, 19);
            this.ruchWroga.Name = "ruchWroga";
            this.ruchWroga.Size = new System.Drawing.Size(43, 29);
            this.ruchWroga.TabIndex = 0;
            this.ruchWroga.Text = "A1";
            // 
            // PolePrzeciwnikaListaBox
            // 
            this.PolePrzeciwnikaListaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PolePrzeciwnikaListaBox.DropDownWidth = 95;
            this.PolePrzeciwnikaListaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PolePrzeciwnikaListaBox.FormattingEnabled = true;
            this.PolePrzeciwnikaListaBox.Location = new System.Drawing.Point(199, 12);
            this.PolePrzeciwnikaListaBox.Name = "PolePrzeciwnikaListaBox";
            this.PolePrzeciwnikaListaBox.Size = new System.Drawing.Size(121, 28);
            this.PolePrzeciwnikaListaBox.TabIndex = 1;
            // 
            // btnAtak
            // 
            this.btnAtak.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAtak.Location = new System.Drawing.Point(332, 5);
            this.btnAtak.Name = "btnAtak";
            this.btnAtak.Size = new System.Drawing.Size(81, 42);
            this.btnAtak.TabIndex = 2;
            this.btnAtak.Text = "Atakuj";
            this.btnAtak.UseVisualStyleBackColor = true;
            this.btnAtak.Click += new System.EventHandler(this.AtakButtonEvent);
            // 
            // a1
            // 
            this.a1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a1.Location = new System.Drawing.Point(56, 194);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(81, 79);
            this.a1.TabIndex = 2;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // a2
            // 
            this.a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a2.Location = new System.Drawing.Point(147, 194);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(81, 79);
            this.a2.TabIndex = 2;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // a3
            // 
            this.a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a3.Location = new System.Drawing.Point(237, 194);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(99, 79);
            this.a3.TabIndex = 2;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // a4
            // 
            this.a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a4.Location = new System.Drawing.Point(346, 194);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(67, 79);
            this.a4.TabIndex = 2;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = true;
            this.a4.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // b4
            // 
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b4.Location = new System.Drawing.Point(346, 283);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(67, 82);
            this.b4.TabIndex = 4;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // b3
            // 
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b3.Location = new System.Drawing.Point(237, 283);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(99, 82);
            this.b3.TabIndex = 5;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // b2
            // 
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b2.Location = new System.Drawing.Point(147, 283);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(81, 82);
            this.b2.TabIndex = 6;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // b1
            // 
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b1.Location = new System.Drawing.Point(56, 283);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(81, 82);
            this.b1.TabIndex = 7;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // c4
            // 
            this.c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c4.Location = new System.Drawing.Point(346, 376);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(67, 82);
            this.c4.TabIndex = 8;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = true;
            this.c4.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // c3
            // 
            this.c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c3.Location = new System.Drawing.Point(237, 376);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(99, 82);
            this.c3.TabIndex = 9;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // c2
            // 
            this.c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c2.Location = new System.Drawing.Point(147, 376);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(81, 82);
            this.c2.TabIndex = 10;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // c1
            // 
            this.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c1.Location = new System.Drawing.Point(56, 376);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(81, 82);
            this.c1.TabIndex = 11;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // d4
            // 
            this.d4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.d4.Location = new System.Drawing.Point(346, 467);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(67, 59);
            this.d4.TabIndex = 12;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = true;
            this.d4.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // d3
            // 
            this.d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.d3.Location = new System.Drawing.Point(237, 467);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(99, 59);
            this.d3.TabIndex = 13;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = true;
            this.d3.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // d2
            // 
            this.d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.d2.Location = new System.Drawing.Point(147, 467);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(81, 59);
            this.d2.TabIndex = 14;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = true;
            this.d2.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // d1
            // 
            this.d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.d1.Location = new System.Drawing.Point(56, 467);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(81, 59);
            this.d1.TabIndex = 15;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = true;
            this.d1.Click += new System.EventHandler(this.PozycjaGraczaButtonEvents);
            // 
            // ax4
            // 
            this.ax4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ax4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ax4.Location = new System.Drawing.Point(910, 194);
            this.ax4.Name = "ax4";
            this.ax4.Size = new System.Drawing.Size(88, 79);
            this.ax4.TabIndex = 16;
            this.ax4.Text = "AX4";
            this.ax4.UseVisualStyleBackColor = true;
            // 
            // ax3
            // 
            this.ax3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ax3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ax3.Location = new System.Drawing.Point(816, 194);
            this.ax3.Name = "ax3";
            this.ax3.Size = new System.Drawing.Size(84, 79);
            this.ax3.TabIndex = 17;
            this.ax3.Text = "AX3";
            this.ax3.UseVisualStyleBackColor = true;
            // 
            // ax2
            // 
            this.ax2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ax2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ax2.Location = new System.Drawing.Point(732, 194);
            this.ax2.Name = "ax2";
            this.ax2.Size = new System.Drawing.Size(74, 79);
            this.ax2.TabIndex = 18;
            this.ax2.Text = "AX2";
            this.ax2.UseVisualStyleBackColor = true;
            // 
            // ax1
            // 
            this.ax1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ax1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ax1.Location = new System.Drawing.Point(641, 194);
            this.ax1.Name = "ax1";
            this.ax1.Size = new System.Drawing.Size(81, 79);
            this.ax1.TabIndex = 19;
            this.ax1.Text = "AX1";
            this.ax1.UseVisualStyleBackColor = true;
            // 
            // bx4
            // 
            this.bx4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bx4.Location = new System.Drawing.Point(910, 286);
            this.bx4.Name = "bx4";
            this.bx4.Size = new System.Drawing.Size(88, 79);
            this.bx4.TabIndex = 20;
            this.bx4.Text = "BX4";
            this.bx4.UseVisualStyleBackColor = true;
            // 
            // bx3
            // 
            this.bx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bx3.Location = new System.Drawing.Point(816, 286);
            this.bx3.Name = "bx3";
            this.bx3.Size = new System.Drawing.Size(84, 79);
            this.bx3.TabIndex = 21;
            this.bx3.Text = "BX3";
            this.bx3.UseVisualStyleBackColor = true;
            // 
            // bx2
            // 
            this.bx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bx2.Location = new System.Drawing.Point(732, 286);
            this.bx2.Name = "bx2";
            this.bx2.Size = new System.Drawing.Size(74, 79);
            this.bx2.TabIndex = 22;
            this.bx2.Text = "BX2";
            this.bx2.UseVisualStyleBackColor = true;
            // 
            // bx1
            // 
            this.bx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bx1.Location = new System.Drawing.Point(641, 286);
            this.bx1.Name = "bx1";
            this.bx1.Size = new System.Drawing.Size(81, 79);
            this.bx1.TabIndex = 23;
            this.bx1.Text = "BX1";
            this.bx1.UseVisualStyleBackColor = true;
            // 
            // cx4
            // 
            this.cx4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cx4.Location = new System.Drawing.Point(910, 378);
            this.cx4.Name = "cx4";
            this.cx4.Size = new System.Drawing.Size(88, 79);
            this.cx4.TabIndex = 24;
            this.cx4.Text = "CX4";
            this.cx4.UseVisualStyleBackColor = true;
            // 
            // cx3
            // 
            this.cx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cx3.Location = new System.Drawing.Point(816, 378);
            this.cx3.Name = "cx3";
            this.cx3.Size = new System.Drawing.Size(84, 79);
            this.cx3.TabIndex = 25;
            this.cx3.Text = "CX3";
            this.cx3.UseVisualStyleBackColor = true;
            // 
            // cx2
            // 
            this.cx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cx2.Location = new System.Drawing.Point(732, 378);
            this.cx2.Name = "cx2";
            this.cx2.Size = new System.Drawing.Size(74, 79);
            this.cx2.TabIndex = 26;
            this.cx2.Text = "CX2";
            this.cx2.UseVisualStyleBackColor = true;
            // 
            // cx1
            // 
            this.cx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cx1.Location = new System.Drawing.Point(641, 378);
            this.cx1.Name = "cx1";
            this.cx1.Size = new System.Drawing.Size(81, 79);
            this.cx1.TabIndex = 27;
            this.cx1.Text = "CX1";
            this.cx1.UseVisualStyleBackColor = true;
            // 
            // dx4
            // 
            this.dx4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dx4.Location = new System.Drawing.Point(910, 467);
            this.dx4.Name = "dx4";
            this.dx4.Size = new System.Drawing.Size(88, 59);
            this.dx4.TabIndex = 28;
            this.dx4.Text = "DX4";
            this.dx4.UseVisualStyleBackColor = true;
            // 
            // dx3
            // 
            this.dx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dx3.Location = new System.Drawing.Point(816, 467);
            this.dx3.Name = "dx3";
            this.dx3.Size = new System.Drawing.Size(84, 59);
            this.dx3.TabIndex = 29;
            this.dx3.Text = "DX3";
            this.dx3.UseVisualStyleBackColor = true;
            // 
            // dx2
            // 
            this.dx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dx2.Location = new System.Drawing.Point(732, 467);
            this.dx2.Name = "dx2";
            this.dx2.Size = new System.Drawing.Size(74, 59);
            this.dx2.TabIndex = 30;
            this.dx2.Text = "DX2";
            this.dx2.UseVisualStyleBackColor = true;
            // 
            // dx1
            // 
            this.dx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dx1.Location = new System.Drawing.Point(641, 467);
            this.dx1.Name = "dx1";
            this.dx1.Size = new System.Drawing.Size(81, 59);
            this.dx1.TabIndex = 31;
            this.dx1.Text = "DX1";
            this.dx1.UseVisualStyleBackColor = true;
            // 
            // CzasGryWroga
            // 
            this.CzasGryWroga.Interval = 1000;
            this.CzasGryWroga.Tick += new System.EventHandler(this.EnemyPlayTimeEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShipGame.Properties.Resources.menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 578);
            this.Controls.Add(this.dx4);
            this.Controls.Add(this.dx3);
            this.Controls.Add(this.dx2);
            this.Controls.Add(this.dx1);
            this.Controls.Add(this.cx4);
            this.Controls.Add(this.cx3);
            this.Controls.Add(this.cx2);
            this.Controls.Add(this.cx1);
            this.Controls.Add(this.bx4);
            this.Controls.Add(this.bx3);
            this.Controls.Add(this.bx2);
            this.Controls.Add(this.bx1);
            this.Controls.Add(this.ax4);
            this.Controls.Add(this.ax3);
            this.Controls.Add(this.ax2);
            this.Controls.Add(this.ax1);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.btnAtak);
            this.Controls.Add(this.PolePrzeciwnikaListaBox);
            this.Controls.Add(this.txtRundy);
            this.Controls.Add(this.ruchWroga);
            this.Controls.Add(this.txtPrzeciwnik);
            this.Controls.Add(this.txtGracz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtGracz;
        private System.Windows.Forms.Label txtPrzeciwnik;
        private System.Windows.Forms.Label txtRundy;
        private System.Windows.Forms.Label ruchWroga;
        private System.Windows.Forms.ComboBox PolePrzeciwnikaListaBox;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button ax4;
        private System.Windows.Forms.Button ax3;
        private System.Windows.Forms.Button ax2;
        private System.Windows.Forms.Button ax1;
        private System.Windows.Forms.Button bx4;
        private System.Windows.Forms.Button bx3;
        private System.Windows.Forms.Button bx2;
        private System.Windows.Forms.Button bx1;
        private System.Windows.Forms.Button cx4;
        private System.Windows.Forms.Button cx3;
        private System.Windows.Forms.Button cx2;
        private System.Windows.Forms.Button cx1;
        private System.Windows.Forms.Button dx4;
        private System.Windows.Forms.Button dx3;
        private System.Windows.Forms.Button dx2;
        private System.Windows.Forms.Button dx1;
        private System.Windows.Forms.Timer CzasGryWroga;
        public System.Windows.Forms.Button btnAtak;
    }
}

