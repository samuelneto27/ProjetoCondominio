namespace ProjetoCondominio
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Visitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PossuiVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioDeEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImovelVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Morador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiberarVisitante = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Imovel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImovelFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiberarFunc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imovelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Visitante,
            this.PossuiVeiculo,
            this.HorarioDeEntrada,
            this.ImovelVisita,
            this.Morador,
            this.TempoTotal,
            this.LiberarVisitante,
            this.Editar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(805, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Visitante
            // 
            this.Visitante.HeaderText = "Visitante";
            this.Visitante.Name = "Visitante";
            // 
            // PossuiVeiculo
            // 
            this.PossuiVeiculo.HeaderText = "Possui Veiculo?";
            this.PossuiVeiculo.Name = "PossuiVeiculo";
            // 
            // HorarioDeEntrada
            // 
            this.HorarioDeEntrada.HeaderText = "Entrada";
            this.HorarioDeEntrada.Name = "HorarioDeEntrada";
            // 
            // ImovelVisita
            // 
            this.ImovelVisita.HeaderText = "Imovel";
            this.ImovelVisita.Name = "ImovelVisita";
            // 
            // Morador
            // 
            this.Morador.HeaderText = "Morador";
            this.Morador.Name = "Morador";
            // 
            // TempoTotal
            // 
            this.TempoTotal.HeaderText = "Tempo Total";
            this.TempoTotal.Name = "TempoTotal";
            // 
            // LiberarVisitante
            // 
            this.LiberarVisitante.HeaderText = "Liberar Visitante";
            this.LiberarVisitante.Name = "LiberarVisitante";
            this.LiberarVisitante.Text = "Liberar";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imovel,
            this.Visitantes});
            this.dataGridView2.Location = new System.Drawing.Point(12, 223);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(204, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // Imovel
            // 
            this.Imovel.HeaderText = "Imovel";
            this.Imovel.Name = "Imovel";
            // 
            // Visitantes
            // 
            this.Visitantes.HeaderText = "Visitantes";
            this.Visitantes.Name = "Visitantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fluxo de Visitantes:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Visitantes por Imovel:";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Funcionario,
            this.ImovelFunc,
            this.LiberarFunc});
            this.dataGridView4.Location = new System.Drawing.Point(512, 223);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.Size = new System.Drawing.Size(305, 150);
            this.dataGridView4.TabIndex = 8;
            // 
            // Funcionario
            // 
            this.Funcionario.HeaderText = "Funcionario";
            this.Funcionario.Name = "Funcionario";
            // 
            // ImovelFunc
            // 
            this.ImovelFunc.HeaderText = "Imovel";
            this.ImovelFunc.Name = "ImovelFunc";
            // 
            // LiberarFunc
            // 
            this.LiberarFunc.HeaderText = "Liberar Funcionario";
            this.LiberarFunc.Name = "LiberarFunc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Controle de Funcionarios:";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitanteToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.moradorToolStripMenuItem,
            this.imovelToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // visitanteToolStripMenuItem
            // 
            this.visitanteToolStripMenuItem.Name = "visitanteToolStripMenuItem";
            this.visitanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visitanteToolStripMenuItem.Text = "Visitante";
            this.visitanteToolStripMenuItem.Click += new System.EventHandler(this.visitanteToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            // 
            // moradorToolStripMenuItem
            // 
            this.moradorToolStripMenuItem.Name = "moradorToolStripMenuItem";
            this.moradorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moradorToolStripMenuItem.Text = "Morador";
            // 
            // imovelToolStripMenuItem
            // 
            this.imovelToolStripMenuItem.Name = "imovelToolStripMenuItem";
            this.imovelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imovelToolStripMenuItem.Text = "Imovel";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 386);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imovel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visitantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImovelFunc;
        private System.Windows.Forms.DataGridViewButtonColumn LiberarFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn PossuiVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioDeEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImovelVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Morador;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoTotal;
        private System.Windows.Forms.DataGridViewButtonColumn LiberarVisitante;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imovelToolStripMenuItem;
    }
}

