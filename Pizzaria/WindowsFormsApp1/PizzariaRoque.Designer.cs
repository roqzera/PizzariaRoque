namespace Pizzaria
    {
    partial class PizzariaRoque
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
            this.lblPizzas = new System.Windows.Forms.Label();
            this.tbxSabor1 = new System.Windows.Forms.TextBox();
            this.lblSabor = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgwPizzas = new System.Windows.Forms.DataGridView();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPizzas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPizzas
            // 
            this.lblPizzas.AutoSize = true;
            this.lblPizzas.BackColor = System.Drawing.Color.Transparent;
            this.lblPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzas.ForeColor = System.Drawing.Color.Black;
            this.lblPizzas.Location = new System.Drawing.Point(75, 36);
            this.lblPizzas.Name = "lblPizzas";
            this.lblPizzas.Size = new System.Drawing.Size(132, 20);
            this.lblPizzas.TabIndex = 0;
            this.lblPizzas.Text = "Adicionar Pizza";
            // 
            // tbxSabor1
            // 
            this.tbxSabor1.BackColor = System.Drawing.Color.White;
            this.tbxSabor1.ForeColor = System.Drawing.Color.Black;
            this.tbxSabor1.Location = new System.Drawing.Point(92, 83);
            this.tbxSabor1.Name = "tbxSabor1";
            this.tbxSabor1.Size = new System.Drawing.Size(145, 20);
            this.tbxSabor1.TabIndex = 1;
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor.Location = new System.Drawing.Point(29, 84);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(48, 16);
            this.lblSabor.TabIndex = 2;
            this.lblSabor.Text = "Sabor:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(32, 142);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 16);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor:";
            // 
            // tbxValor
            // 
            this.tbxValor.BackColor = System.Drawing.Color.White;
            this.tbxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxValor.Location = new System.Drawing.Point(92, 141);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(145, 20);
            this.tbxValor.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Silver;
            this.btnAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.Location = new System.Drawing.Point(142, 198);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(52, 198);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // dgwPizzas
            // 
            this.dgwPizzas.BackgroundColor = System.Drawing.Color.White;
            this.dgwPizzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPizzas.GridColor = System.Drawing.Color.DimGray;
            this.dgwPizzas.Location = new System.Drawing.Point(337, 83);
            this.dgwPizzas.Name = "dgwPizzas";
            this.dgwPizzas.Size = new System.Drawing.Size(412, 150);
            this.dgwPizzas.TabIndex = 7;
            this.dgwPizzas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Silver;
            this.btnRemover.ForeColor = System.Drawing.Color.Black;
            this.btnRemover.Location = new System.Drawing.Point(533, 239);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.BackColor = System.Drawing.Color.Transparent;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.ForeColor = System.Drawing.Color.Black;
            this.lblLista.Location = new System.Drawing.Point(492, 36);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(130, 20);
            this.lblLista.TabIndex = 10;
            this.lblLista.Text = "Lista de Pizzas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(337, 239);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Silver;
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(436, 239);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Location = new System.Drawing.Point(35, 300);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(75, 23);
            this.btnFuncionarios.TabIndex = 13;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.BtnFuncionarios_Click);
            // 
            // PizzariaRoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.dgwPizzas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblSabor);
            this.Controls.Add(this.tbxSabor1);
            this.Controls.Add(this.lblPizzas);
            this.Name = "PizzariaRoque";
            this.Text = "Pizzaria_Roque";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPizzas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblPizzas;
    private System.Windows.Forms.TextBox tbxSabor1;
    private System.Windows.Forms.Label lblSabor;
    private System.Windows.Forms.Label lblValor;
    private System.Windows.Forms.TextBox tbxValor;
    private System.Windows.Forms.Button btnAdicionar;
    private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgwPizzas;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnFuncionarios;
    }
}