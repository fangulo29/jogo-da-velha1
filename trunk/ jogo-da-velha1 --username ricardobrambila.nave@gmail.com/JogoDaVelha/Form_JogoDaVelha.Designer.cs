namespace JogoDaVelha
{
    partial class Form_JogoDaVelha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_JogoDaVelha));
            this.panel_top = new System.Windows.Forms.Panel();
            this.p2_cpu = new System.Windows.Forms.Button();
            this.gb_empates = new System.Windows.Forms.GroupBox();
            this.lb_empate = new System.Windows.Forms.Label();
            this.bt_reiniciar = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_iniciar = new System.Windows.Forms.Button();
            this.gb_placar = new System.Windows.Forms.GroupBox();
            this.lb_PJogador2 = new System.Windows.Forms.Label();
            this.lb_PJogador1 = new System.Windows.Forms.Label();
            this.gb_opcoes = new System.Windows.Forms.GroupBox();
            this.rb_O = new System.Windows.Forms.RadioButton();
            this.rb_X = new System.Windows.Forms.RadioButton();
            this.gb_jogadores = new System.Windows.Forms.GroupBox();
            this.tb_Jogador2 = new System.Windows.Forms.TextBox();
            this.tb_Jogador = new System.Windows.Forms.TextBox();
            this.lb_jogador2 = new System.Windows.Forms.Label();
            this.lb_jogador = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            this.gb_empates.SuspendLayout();
            this.gb_placar.SuspendLayout();
            this.gb_opcoes.SuspendLayout();
            this.gb_jogadores.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.p2_cpu);
            this.panel_top.Controls.Add(this.gb_empates);
            this.panel_top.Controls.Add(this.bt_reiniciar);
            this.panel_top.Controls.Add(this.bt_sair);
            this.panel_top.Controls.Add(this.bt_iniciar);
            this.panel_top.Controls.Add(this.gb_placar);
            this.panel_top.Controls.Add(this.gb_opcoes);
            this.panel_top.Controls.Add(this.gb_jogadores);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(729, 229);
            this.panel_top.TabIndex = 0;
            // 
            // p2_cpu
            // 
            this.p2_cpu.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_cpu.Location = new System.Drawing.Point(261, 172);
            this.p2_cpu.Name = "p2_cpu";
            this.p2_cpu.Size = new System.Drawing.Size(119, 42);
            this.p2_cpu.TabIndex = 16;
            this.p2_cpu.Text = "CPU";
            this.p2_cpu.UseVisualStyleBackColor = true;
            this.p2_cpu.Click += new System.EventHandler(this.p2_cpu_Click);
            // 
            // gb_empates
            // 
            this.gb_empates.BackColor = System.Drawing.Color.Transparent;
            this.gb_empates.Controls.Add(this.lb_empate);
            this.gb_empates.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_empates.Location = new System.Drawing.Point(504, 12);
            this.gb_empates.Name = "gb_empates";
            this.gb_empates.Size = new System.Drawing.Size(212, 124);
            this.gb_empates.TabIndex = 4;
            this.gb_empates.TabStop = false;
            this.gb_empates.Text = "Empates";
            // 
            // lb_empate
            // 
            this.lb_empate.AutoSize = true;
            this.lb_empate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empate.Location = new System.Drawing.Point(16, 63);
            this.lb_empate.Name = "lb_empate";
            this.lb_empate.Size = new System.Drawing.Size(0, 18);
            this.lb_empate.TabIndex = 0;
            // 
            // bt_reiniciar
            // 
            this.bt_reiniciar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reiniciar.Location = new System.Drawing.Point(495, 172);
            this.bt_reiniciar.Name = "bt_reiniciar";
            this.bt_reiniciar.Size = new System.Drawing.Size(113, 42);
            this.bt_reiniciar.TabIndex = 6;
            this.bt_reiniciar.Text = "Reiniciar";
            this.bt_reiniciar.UseVisualStyleBackColor = true;
            this.bt_reiniciar.Click += new System.EventHandler(this.bt_reiniciar_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.Location = new System.Drawing.Point(617, 172);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(98, 42);
            this.bt_sair.TabIndex = 5;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // bt_iniciar
            // 
            this.bt_iniciar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_iniciar.Location = new System.Drawing.Point(386, 172);
            this.bt_iniciar.Name = "bt_iniciar";
            this.bt_iniciar.Size = new System.Drawing.Size(98, 42);
            this.bt_iniciar.TabIndex = 4;
            this.bt_iniciar.Text = "Iniciar";
            this.bt_iniciar.UseVisualStyleBackColor = true;
            this.bt_iniciar.Click += new System.EventHandler(this.bt_iniciar_Click);
            // 
            // gb_placar
            // 
            this.gb_placar.BackColor = System.Drawing.Color.Transparent;
            this.gb_placar.Controls.Add(this.lb_PJogador2);
            this.gb_placar.Controls.Add(this.lb_PJogador1);
            this.gb_placar.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_placar.Location = new System.Drawing.Point(277, 12);
            this.gb_placar.Name = "gb_placar";
            this.gb_placar.Size = new System.Drawing.Size(207, 124);
            this.gb_placar.TabIndex = 3;
            this.gb_placar.TabStop = false;
            this.gb_placar.Text = "Placar";
            // 
            // lb_PJogador2
            // 
            this.lb_PJogador2.AutoSize = true;
            this.lb_PJogador2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PJogador2.Location = new System.Drawing.Point(7, 77);
            this.lb_PJogador2.Name = "lb_PJogador2";
            this.lb_PJogador2.Size = new System.Drawing.Size(0, 18);
            this.lb_PJogador2.TabIndex = 1;
            // 
            // lb_PJogador1
            // 
            this.lb_PJogador1.AutoSize = true;
            this.lb_PJogador1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PJogador1.Location = new System.Drawing.Point(7, 42);
            this.lb_PJogador1.Name = "lb_PJogador1";
            this.lb_PJogador1.Size = new System.Drawing.Size(0, 18);
            this.lb_PJogador1.TabIndex = 0;
            // 
            // gb_opcoes
            // 
            this.gb_opcoes.BackColor = System.Drawing.Color.Transparent;
            this.gb_opcoes.Controls.Add(this.rb_O);
            this.gb_opcoes.Controls.Add(this.rb_X);
            this.gb_opcoes.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_opcoes.Location = new System.Drawing.Point(12, 142);
            this.gb_opcoes.Name = "gb_opcoes";
            this.gb_opcoes.Size = new System.Drawing.Size(243, 79);
            this.gb_opcoes.TabIndex = 3;
            this.gb_opcoes.TabStop = false;
            this.gb_opcoes.Text = "Opções";
            // 
            // rb_O
            // 
            this.rb_O.AutoSize = true;
            this.rb_O.Location = new System.Drawing.Point(135, 34);
            this.rb_O.Name = "rb_O";
            this.rb_O.Size = new System.Drawing.Size(64, 33);
            this.rb_O.TabIndex = 1;
            this.rb_O.TabStop = true;
            this.rb_O.Text = "O";
            this.rb_O.UseVisualStyleBackColor = true;
            // 
            // rb_X
            // 
            this.rb_X.AutoSize = true;
            this.rb_X.Checked = true;
            this.rb_X.Location = new System.Drawing.Point(23, 34);
            this.rb_X.Name = "rb_X";
            this.rb_X.Size = new System.Drawing.Size(67, 33);
            this.rb_X.TabIndex = 0;
            this.rb_X.TabStop = true;
            this.rb_X.Text = "X";
            this.rb_X.UseVisualStyleBackColor = true;
            // 
            // gb_jogadores
            // 
            this.gb_jogadores.BackColor = System.Drawing.Color.Transparent;
            this.gb_jogadores.Controls.Add(this.tb_Jogador2);
            this.gb_jogadores.Controls.Add(this.tb_Jogador);
            this.gb_jogadores.Controls.Add(this.lb_jogador2);
            this.gb_jogadores.Controls.Add(this.lb_jogador);
            this.gb_jogadores.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_jogadores.Location = new System.Drawing.Point(12, 12);
            this.gb_jogadores.Name = "gb_jogadores";
            this.gb_jogadores.Size = new System.Drawing.Size(243, 124);
            this.gb_jogadores.TabIndex = 2;
            this.gb_jogadores.TabStop = false;
            this.gb_jogadores.Text = "Jogadores";
            // 
            // tb_Jogador2
            // 
            this.tb_Jogador2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Jogador2.Location = new System.Drawing.Point(13, 74);
            this.tb_Jogador2.Name = "tb_Jogador2";
            this.tb_Jogador2.Size = new System.Drawing.Size(211, 27);
            this.tb_Jogador2.TabIndex = 5;
            // 
            // tb_Jogador
            // 
            this.tb_Jogador.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Jogador.Location = new System.Drawing.Point(12, 33);
            this.tb_Jogador.Name = "tb_Jogador";
            this.tb_Jogador.Size = new System.Drawing.Size(212, 27);
            this.tb_Jogador.TabIndex = 4;
            // 
            // lb_jogador2
            // 
            this.lb_jogador2.AutoSize = true;
            this.lb_jogador2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jogador2.Location = new System.Drawing.Point(10, 82);
            this.lb_jogador2.Name = "lb_jogador2";
            this.lb_jogador2.Size = new System.Drawing.Size(0, 18);
            this.lb_jogador2.TabIndex = 1;
            // 
            // lb_jogador
            // 
            this.lb_jogador.AutoSize = true;
            this.lb_jogador.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jogador.Location = new System.Drawing.Point(10, 42);
            this.lb_jogador.Name = "lb_jogador";
            this.lb_jogador.Size = new System.Drawing.Size(0, 18);
            this.lb_jogador.TabIndex = 0;
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.bt9);
            this.panel_bottom.Controls.Add(this.bt8);
            this.panel_bottom.Controls.Add(this.bt7);
            this.panel_bottom.Controls.Add(this.bt6);
            this.panel_bottom.Controls.Add(this.bt5);
            this.panel_bottom.Controls.Add(this.bt4);
            this.panel_bottom.Controls.Add(this.bt3);
            this.panel_bottom.Controls.Add(this.bt2);
            this.panel_bottom.Controls.Add(this.bt1);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom.Enabled = false;
            this.panel_bottom.Location = new System.Drawing.Point(0, 229);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(729, 224);
            this.panel_bottom.TabIndex = 1;
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.CadetBlue;
            this.bt9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt9.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt9.Location = new System.Drawing.Point(389, 144);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(76, 65);
            this.bt9.TabIndex = 15;
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.CadetBlue;
            this.bt8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt8.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt8.Location = new System.Drawing.Point(313, 144);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(76, 65);
            this.bt8.TabIndex = 14;
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.CadetBlue;
            this.bt7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt7.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt7.Location = new System.Drawing.Point(237, 144);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(76, 65);
            this.bt7.TabIndex = 13;
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.CadetBlue;
            this.bt6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt6.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt6.Location = new System.Drawing.Point(389, 80);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(76, 65);
            this.bt6.TabIndex = 12;
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.CadetBlue;
            this.bt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt5.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt5.Location = new System.Drawing.Point(313, 80);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(76, 65);
            this.bt5.TabIndex = 11;
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.CadetBlue;
            this.bt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt4.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt4.Location = new System.Drawing.Point(237, 80);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(76, 65);
            this.bt4.TabIndex = 10;
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.CadetBlue;
            this.bt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt3.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt3.Location = new System.Drawing.Point(389, 15);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(76, 65);
            this.bt3.TabIndex = 9;
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.CadetBlue;
            this.bt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt2.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt2.Location = new System.Drawing.Point(313, 16);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(76, 65);
            this.bt2.TabIndex = 8;
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.CadetBlue;
            this.bt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt1.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt1.Location = new System.Drawing.Point(237, 16);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(76, 65);
            this.bt1.TabIndex = 7;
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // Form_JogoDaVelha
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(729, 453);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Wide Latin", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(19, 10, 19, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_JogoDaVelha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel_top.ResumeLayout(false);
            this.gb_empates.ResumeLayout(false);
            this.gb_empates.PerformLayout();
            this.gb_placar.ResumeLayout(false);
            this.gb_placar.PerformLayout();
            this.gb_opcoes.ResumeLayout(false);
            this.gb_opcoes.PerformLayout();
            this.gb_jogadores.ResumeLayout(false);
            this.gb_jogadores.PerformLayout();
            this.panel_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.GroupBox gb_jogadores;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.GroupBox gb_placar;
        private System.Windows.Forms.GroupBox gb_opcoes;
        private System.Windows.Forms.Label lb_jogador2;
        private System.Windows.Forms.Label lb_jogador;
        private System.Windows.Forms.TextBox tb_Jogador2;
        private System.Windows.Forms.TextBox tb_Jogador;
        private System.Windows.Forms.Label lb_PJogador1;
        private System.Windows.Forms.Label lb_PJogador2;
        private System.Windows.Forms.RadioButton rb_O;
        private System.Windows.Forms.RadioButton rb_X;
        private System.Windows.Forms.Button bt_reiniciar;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_iniciar;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.GroupBox gb_empates;
        private System.Windows.Forms.Label lb_empate;
        private System.Windows.Forms.Button p2_cpu;
    }
}

