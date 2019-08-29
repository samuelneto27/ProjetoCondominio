namespace ProjetoCondominio
{
    partial class PesquisaMorador
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nomeMorador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoMorador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneMorador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ramalMorador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradorData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeMorador,
            this.enderecoMorador,
            this.telefoneMorador,
            this.ramalMorador,
            this.moradorData});
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 124);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 2;
            // 
            // nomeMorador
            // 
            this.nomeMorador.HeaderText = "Nome do Morador";
            this.nomeMorador.Name = "nomeMorador";
            // 
            // enderecoMorador
            // 
            this.enderecoMorador.HeaderText = "Endereco";
            this.enderecoMorador.Name = "enderecoMorador";
            // 
            // telefoneMorador
            // 
            this.telefoneMorador.HeaderText = "Telefone";
            this.telefoneMorador.Name = "telefoneMorador";
            // 
            // ramalMorador
            // 
            this.ramalMorador.HeaderText = "Ramal";
            this.ramalMorador.Name = "ramalMorador";
            // 
            // moradorData
            // 
            this.moradorData.HeaderText = "Morador desde:";
            this.moradorData.Name = "moradorData";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insira o nome do morador:";
            // 
            // PesquisaMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PesquisaMorador";
            this.Text = "Pesquisa Morador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeMorador;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoMorador;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneMorador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ramalMorador;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradorData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}