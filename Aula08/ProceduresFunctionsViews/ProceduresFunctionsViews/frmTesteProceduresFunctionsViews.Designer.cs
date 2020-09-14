namespace ProceduresFunctionsViews
{
    partial class frmTesteProceduresFunctionsViews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTesteProceduresFunctionsViews));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnView = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgDadosPedido = new System.Windows.Forms.DataGridView();
            this.btnFuncaoTipoTabela = new System.Windows.Forms.Button();
            this.txtCodigoPedidoTipoTabela = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChamaFuncaoTipoEscadar = new System.Windows.Forms.Button();
            this.txtCodigoPedido = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgProcDadosPedido = new System.Windows.Forms.DataGridView();
            this.btnChamaprocRetornaTabela = new System.Windows.Forms.Button();
            this.txtCodPedidoProcTabela = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnChamaprocRetornaEscalar = new System.Windows.Forms.Button();
            this.txtCodPedidoProcEscalar = new System.Windows.Forms.TextBox();
            this.lblRetornoProcEscalar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAtualizarProduto = new System.Windows.Forms.Button();
            this.txtPrecoAtualizarProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeAtualizarProduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodProdutoAtualizar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtCodProdutoApagar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnApagarProduto = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDadosPedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcDadosPedido)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 463);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnView);
            this.tabPage1.Controls.Add(this.dgView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(425, 207);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(125, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "Consultar View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(21, 19);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(529, 164);
            this.dgView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Function";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgDadosPedido);
            this.groupBox2.Controls.Add(this.btnFuncaoTipoTabela);
            this.groupBox2.Controls.Add(this.txtCodigoPedidoTipoTabela);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(21, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 251);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funções Tipo Tabela";
            // 
            // dgDadosPedido
            // 
            this.dgDadosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDadosPedido.Location = new System.Drawing.Point(17, 86);
            this.dgDadosPedido.Name = "dgDadosPedido";
            this.dgDadosPedido.Size = new System.Drawing.Size(458, 144);
            this.dgDadosPedido.TabIndex = 6;
            // 
            // btnFuncaoTipoTabela
            // 
            this.btnFuncaoTipoTabela.Location = new System.Drawing.Point(346, 32);
            this.btnFuncaoTipoTabela.Name = "btnFuncaoTipoTabela";
            this.btnFuncaoTipoTabela.Size = new System.Drawing.Size(129, 23);
            this.btnFuncaoTipoTabela.TabIndex = 5;
            this.btnFuncaoTipoTabela.Text = "Chamar Funcao";
            this.btnFuncaoTipoTabela.UseVisualStyleBackColor = true;
            this.btnFuncaoTipoTabela.Click += new System.EventHandler(this.btnFuncaoTipoTabela_Click);
            // 
            // txtCodigoPedidoTipoTabela
            // 
            this.txtCodigoPedidoTipoTabela.Location = new System.Drawing.Point(103, 34);
            this.txtCodigoPedidoTipoTabela.Name = "txtCodigoPedidoTipoTabela";
            this.txtCodigoPedidoTipoTabela.Size = new System.Drawing.Size(64, 20);
            this.txtCodigoPedidoTipoTabela.TabIndex = 3;
            this.txtCodigoPedidoTipoTabela.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cod Pedido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChamaFuncaoTipoEscadar);
            this.groupBox1.Controls.Add(this.txtCodigoPedido);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 129);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funções Tipo Escalar";
            // 
            // btnChamaFuncaoTipoEscadar
            // 
            this.btnChamaFuncaoTipoEscadar.Location = new System.Drawing.Point(350, 29);
            this.btnChamaFuncaoTipoEscadar.Name = "btnChamaFuncaoTipoEscadar";
            this.btnChamaFuncaoTipoEscadar.Size = new System.Drawing.Size(129, 23);
            this.btnChamaFuncaoTipoEscadar.TabIndex = 2;
            this.btnChamaFuncaoTipoEscadar.Text = "Chamar Funcao";
            this.btnChamaFuncaoTipoEscadar.UseVisualStyleBackColor = true;
            this.btnChamaFuncaoTipoEscadar.Click += new System.EventHandler(this.btnChamaFuncaoTipoEscadar_Click);
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Location = new System.Drawing.Point(107, 32);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(64, 20);
            this.txtCodigoPedido.TabIndex = 0;
            this.txtCodigoPedido.Text = "1";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(109, 79);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 23);
            this.lblTotal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(785, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Proc Consulta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgProcDadosPedido);
            this.groupBox3.Controls.Add(this.btnChamaprocRetornaTabela);
            this.groupBox3.Controls.Add(this.txtCodPedidoProcTabela);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(28, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(731, 251);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Funções Retorna Uma Tabela";
            // 
            // dgProcDadosPedido
            // 
            this.dgProcDadosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProcDadosPedido.Location = new System.Drawing.Point(17, 86);
            this.dgProcDadosPedido.Name = "dgProcDadosPedido";
            this.dgProcDadosPedido.Size = new System.Drawing.Size(458, 144);
            this.dgProcDadosPedido.TabIndex = 6;
            // 
            // btnChamaprocRetornaTabela
            // 
            this.btnChamaprocRetornaTabela.Location = new System.Drawing.Point(346, 32);
            this.btnChamaprocRetornaTabela.Name = "btnChamaprocRetornaTabela";
            this.btnChamaprocRetornaTabela.Size = new System.Drawing.Size(129, 23);
            this.btnChamaprocRetornaTabela.TabIndex = 5;
            this.btnChamaprocRetornaTabela.Text = "Chamar Procedure";
            this.btnChamaprocRetornaTabela.UseVisualStyleBackColor = true;
            this.btnChamaprocRetornaTabela.Click += new System.EventHandler(this.btnChamaprocRetornaTabela_Click);
            // 
            // txtCodPedidoProcTabela
            // 
            this.txtCodPedidoProcTabela.Location = new System.Drawing.Point(103, 34);
            this.txtCodPedidoProcTabela.Name = "txtCodPedidoProcTabela";
            this.txtCodPedidoProcTabela.Size = new System.Drawing.Size(64, 20);
            this.txtCodPedidoProcTabela.TabIndex = 3;
            this.txtCodPedidoProcTabela.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cod Pedido";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnChamaprocRetornaEscalar);
            this.groupBox4.Controls.Add(this.txtCodPedidoProcEscalar);
            this.groupBox4.Controls.Add(this.lblRetornoProcEscalar);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(24, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(736, 129);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Procedures Retorna Um Escalar";
            // 
            // btnChamaprocRetornaEscalar
            // 
            this.btnChamaprocRetornaEscalar.Location = new System.Drawing.Point(350, 29);
            this.btnChamaprocRetornaEscalar.Name = "btnChamaprocRetornaEscalar";
            this.btnChamaprocRetornaEscalar.Size = new System.Drawing.Size(129, 23);
            this.btnChamaprocRetornaEscalar.TabIndex = 2;
            this.btnChamaprocRetornaEscalar.Text = "Chamar Procedure";
            this.btnChamaprocRetornaEscalar.UseVisualStyleBackColor = true;
            this.btnChamaprocRetornaEscalar.Click += new System.EventHandler(this.btnChamaprocRetornaEscalar_Click);
            // 
            // txtCodPedidoProcEscalar
            // 
            this.txtCodPedidoProcEscalar.Location = new System.Drawing.Point(107, 32);
            this.txtCodPedidoProcEscalar.Name = "txtCodPedidoProcEscalar";
            this.txtCodPedidoProcEscalar.Size = new System.Drawing.Size(64, 20);
            this.txtCodPedidoProcEscalar.TabIndex = 0;
            this.txtCodPedidoProcEscalar.Text = "1";
            // 
            // lblRetornoProcEscalar
            // 
            this.lblRetornoProcEscalar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRetornoProcEscalar.Location = new System.Drawing.Point(109, 79);
            this.lblRetornoProcEscalar.Name = "lblRetornoProcEscalar";
            this.lblRetornoProcEscalar.Size = new System.Drawing.Size(93, 23);
            this.lblRetornoProcEscalar.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cod Pedido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(785, 437);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Inserir Atualizar Apagar Produto";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.richTextBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(785, 437);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "ATIVIDADE";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnInserirProduto);
            this.groupBox5.Controls.Add(this.txtPreco);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtNomeProduto);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(23, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(744, 84);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Inserir Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(79, 28);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(219, 20);
            this.txtNomeProduto.TabIndex = 1;
            this.txtNomeProduto.Text = "Nome de Teste do Produto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(376, 28);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(108, 20);
            this.txtPreco.TabIndex = 3;
            this.txtPreco.Text = "12,34";
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.Location = new System.Drawing.Point(600, 26);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(129, 23);
            this.btnInserirProduto.TabIndex = 4;
            this.btnInserirProduto.Text = "Inserir Produto";
            this.btnInserirProduto.UseVisualStyleBackColor = true;
            this.btnInserirProduto.Click += new System.EventHandler(this.btnInserirProduto_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtCodProdutoAtualizar);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.btnAtualizarProduto);
            this.groupBox6.Controls.Add(this.txtPrecoAtualizarProduto);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txtNomeAtualizarProduto);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(23, 110);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(744, 110);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Atualizar Produto";
            // 
            // btnAtualizarProduto
            // 
            this.btnAtualizarProduto.Location = new System.Drawing.Point(600, 65);
            this.btnAtualizarProduto.Name = "btnAtualizarProduto";
            this.btnAtualizarProduto.Size = new System.Drawing.Size(129, 23);
            this.btnAtualizarProduto.TabIndex = 4;
            this.btnAtualizarProduto.Text = "Atualizar Produto";
            this.btnAtualizarProduto.UseVisualStyleBackColor = true;
            this.btnAtualizarProduto.Click += new System.EventHandler(this.btnAtualizarProduto_Click);
            // 
            // txtPrecoAtualizarProduto
            // 
            this.txtPrecoAtualizarProduto.Location = new System.Drawing.Point(376, 67);
            this.txtPrecoAtualizarProduto.Name = "txtPrecoAtualizarProduto";
            this.txtPrecoAtualizarProduto.Size = new System.Drawing.Size(108, 20);
            this.txtPrecoAtualizarProduto.TabIndex = 3;
            this.txtPrecoAtualizarProduto.Text = "43,21";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Preço";
            // 
            // txtNomeAtualizarProduto
            // 
            this.txtNomeAtualizarProduto.Location = new System.Drawing.Point(79, 67);
            this.txtNomeAtualizarProduto.Name = "txtNomeAtualizarProduto";
            this.txtNomeAtualizarProduto.Size = new System.Drawing.Size(219, 20);
            this.txtNomeAtualizarProduto.TabIndex = 1;
            this.txtNomeAtualizarProduto.Text = "Atualizado Nome de Teste do Produto ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nome";
            // 
            // txtCodProdutoAtualizar
            // 
            this.txtCodProdutoAtualizar.Location = new System.Drawing.Point(102, 28);
            this.txtCodProdutoAtualizar.Name = "txtCodProdutoAtualizar";
            this.txtCodProdutoAtualizar.Size = new System.Drawing.Size(64, 20);
            this.txtCodProdutoAtualizar.TabIndex = 5;
            this.txtCodProdutoAtualizar.Text = "4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Cod Produto";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtCodProdutoApagar);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.btnApagarProduto);
            this.groupBox7.Location = new System.Drawing.Point(23, 226);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(744, 75);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Apagar Produto";
            // 
            // txtCodProdutoApagar
            // 
            this.txtCodProdutoApagar.Location = new System.Drawing.Point(102, 28);
            this.txtCodProdutoApagar.Name = "txtCodProdutoApagar";
            this.txtCodProdutoApagar.Size = new System.Drawing.Size(64, 20);
            this.txtCodProdutoApagar.TabIndex = 5;
            this.txtCodProdutoApagar.Text = "4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Cod Produto";
            // 
            // btnApagarProduto
            // 
            this.btnApagarProduto.Location = new System.Drawing.Point(600, 21);
            this.btnApagarProduto.Name = "btnApagarProduto";
            this.btnApagarProduto.Size = new System.Drawing.Size(129, 23);
            this.btnApagarProduto.TabIndex = 4;
            this.btnApagarProduto.Text = "Apagar Produto";
            this.btnApagarProduto.UseVisualStyleBackColor = true;
            this.btnApagarProduto.Click += new System.EventHandler(this.btnApagarProduto_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(708, 382);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // frmTesteProceduresFunctionsViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 497);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTesteProceduresFunctionsViews";
            this.Text = "Programa Exemplo Procedures Funcions Views";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDadosPedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcDadosPedido)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnChamaFuncaoTipoEscadar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoPedido;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFuncaoTipoTabela;
        private System.Windows.Forms.TextBox txtCodigoPedidoTipoTabela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgDadosPedido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgProcDadosPedido;
        private System.Windows.Forms.Button btnChamaprocRetornaTabela;
        private System.Windows.Forms.TextBox txtCodPedidoProcTabela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnChamaprocRetornaEscalar;
        private System.Windows.Forms.TextBox txtCodPedidoProcEscalar;
        private System.Windows.Forms.Label lblRetornoProcEscalar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnInserirProduto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAtualizarProduto;
        private System.Windows.Forms.TextBox txtPrecoAtualizarProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeAtualizarProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodProdutoAtualizar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtCodProdutoApagar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnApagarProduto;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

