namespace Vmp_C__ex1
{
    partial class FrmDocumentos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocumentos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artigosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtMorada = new System.Windows.Forms.TextBox();
            this.TxtNif = new System.Windows.Forms.TextBox();
            this.TxtContato = new System.Windows.Forms.TextBox();
            this.TxtCodigoCl = new System.Windows.Forms.TextBox();
            this.TxtNomeCl = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DocAtivo = new System.Windows.Forms.RadioButton();
            this.TxtDescricaoDoc = new System.Windows.Forms.TextBox();
            this.TxtCodigoDoc = new System.Windows.Forms.ComboBox();
            this.tipoDocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsDocumentos = new Vmp_C__ex1.DsDocumentos();
            this.DataMod = new System.Windows.Forms.DateTimePicker();
            this.NrDoc = new System.Windows.Forms.NumericUpDown();
            this.BtnBaixo = new System.Windows.Forms.Button();
            this.BtnCima = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.DgridArtigos = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabecDocumentoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLinhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProdutoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.linhasDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnNovo = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NrDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgridArtigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhasDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Silver;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.novoToolStripMenuItem,
            this.gravarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1096, 31);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.artigosToolStripMenuItem});
            this.ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem1.Image")));
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(41, 27);
            this.ToolStripMenuItem1.Text = "  ";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // artigosToolStripMenuItem
            // 
            this.artigosToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.artigosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artigosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("artigosToolStripMenuItem.Image")));
            this.artigosToolStripMenuItem.Name = "artigosToolStripMenuItem";
            this.artigosToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.artigosToolStripMenuItem.Text = "Artigos";
            this.artigosToolStripMenuItem.Click += new System.EventHandler(this.artigosToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.novoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem.Image")));
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(69, 27);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // gravarToolStripMenuItem
            // 
            this.gravarToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.gravarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gravarToolStripMenuItem.Image")));
            this.gravarToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.gravarToolStripMenuItem.Name = "gravarToolStripMenuItem";
            this.gravarToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.gravarToolStripMenuItem.Text = "Gravar";
            this.gravarToolStripMenuItem.Click += new System.EventHandler(this.gravarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.eliminarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(58, 27);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.Panel2);
            this.splitContainer1.Panel1.Controls.Add(this.Panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.BtnBaixo);
            this.splitContainer1.Panel2.Controls.Add(this.BtnCima);
            this.splitContainer1.Panel2.Controls.Add(this.BtnEliminar);
            this.splitContainer1.Panel2.Controls.Add(this.DgridArtigos);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNovo);
            this.splitContainer1.Size = new System.Drawing.Size(1021, 653);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 2;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Panel2.Controls.Add(this.label4);
            this.Panel2.Controls.Add(this.label8);
            this.Panel2.Controls.Add(this.label9);
            this.Panel2.Controls.Add(this.label10);
            this.Panel2.Controls.Add(this.TxtMorada);
            this.Panel2.Controls.Add(this.TxtNif);
            this.Panel2.Controls.Add(this.TxtContato);
            this.Panel2.Controls.Add(this.TxtCodigoCl);
            this.Panel2.Controls.Add(this.TxtNomeCl);
            this.Panel2.Location = new System.Drawing.Point(24, 64);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(968, 86);
            this.Panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Morada:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(746, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "NIF:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(746, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Contato:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cliente";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtMorada
            // 
            this.TxtMorada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMorada.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMorada.Location = new System.Drawing.Point(192, 51);
            this.TxtMorada.Name = "TxtMorada";
            this.TxtMorada.Size = new System.Drawing.Size(548, 25);
            this.TxtMorada.TabIndex = 4;
            // 
            // TxtNif
            // 
            this.TxtNif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNif.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNif.Location = new System.Drawing.Point(804, 51);
            this.TxtNif.Name = "TxtNif";
            this.TxtNif.Size = new System.Drawing.Size(157, 25);
            this.TxtNif.TabIndex = 5;
            // 
            // TxtContato
            // 
            this.TxtContato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtContato.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContato.Location = new System.Drawing.Point(804, 17);
            this.TxtContato.Name = "TxtContato";
            this.TxtContato.Size = new System.Drawing.Size(157, 25);
            this.TxtContato.TabIndex = 7;
            // 
            // TxtCodigoCl
            // 
            this.TxtCodigoCl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoCl.Location = new System.Drawing.Point(123, 16);
            this.TxtCodigoCl.Name = "TxtCodigoCl";
            this.TxtCodigoCl.Size = new System.Drawing.Size(63, 25);
            this.TxtCodigoCl.TabIndex = 8;
            this.TxtCodigoCl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoCl_KeyDown);
            // 
            // TxtNomeCl
            // 
            this.TxtNomeCl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNomeCl.Enabled = false;
            this.TxtNomeCl.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeCl.Location = new System.Drawing.Point(192, 16);
            this.TxtNomeCl.Name = "TxtNomeCl";
            this.TxtNomeCl.Size = new System.Drawing.Size(548, 25);
            this.TxtNomeCl.TabIndex = 6;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Panel1.Controls.Add(this.label11);
            this.Panel1.Controls.Add(this.label12);
            this.Panel1.Controls.Add(this.DocAtivo);
            this.Panel1.Controls.Add(this.TxtDescricaoDoc);
            this.Panel1.Controls.Add(this.TxtCodigoDoc);
            this.Panel1.Controls.Add(this.DataMod);
            this.Panel1.Controls.Add(this.NrDoc);
            this.Panel1.Location = new System.Drawing.Point(24, 12);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(968, 46);
            this.Panel1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(728, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Alterado em:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Documento";
            // 
            // DocAtivo
            // 
            this.DocAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DocAtivo.AutoSize = true;
            this.DocAtivo.Checked = true;
            this.DocAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocAtivo.Location = new System.Drawing.Point(650, 12);
            this.DocAtivo.Name = "DocAtivo";
            this.DocAtivo.Size = new System.Drawing.Size(53, 19);
            this.DocAtivo.TabIndex = 4;
            this.DocAtivo.TabStop = true;
            this.DocAtivo.Text = "Ativo";
            this.DocAtivo.UseVisualStyleBackColor = true;
            this.DocAtivo.CheckedChanged += new System.EventHandler(this.DocAtivo_CheckedChanged);
            // 
            // TxtDescricaoDoc
            // 
            this.TxtDescricaoDoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescricaoDoc.Enabled = false;
            this.TxtDescricaoDoc.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricaoDoc.Location = new System.Drawing.Point(192, 10);
            this.TxtDescricaoDoc.Name = "TxtDescricaoDoc";
            this.TxtDescricaoDoc.Size = new System.Drawing.Size(397, 25);
            this.TxtDescricaoDoc.TabIndex = 99;
            this.TxtDescricaoDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCodigoDoc
            // 
            this.TxtCodigoDoc.DataSource = this.tipoDocumentosBindingSource;
            this.TxtCodigoDoc.DisplayMember = "CodigoDoc";
            this.TxtCodigoDoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoDoc.FormattingEnabled = true;
            this.TxtCodigoDoc.Location = new System.Drawing.Point(123, 10);
            this.TxtCodigoDoc.Name = "TxtCodigoDoc";
            this.TxtCodigoDoc.Size = new System.Drawing.Size(63, 25);
            this.TxtCodigoDoc.TabIndex = 1;
            this.TxtCodigoDoc.ValueMember = "CodigoDoc";
            this.TxtCodigoDoc.Leave += new System.EventHandler(this.TxtCodigoDoc_Leave);
            // 
            // tipoDocumentosBindingSource
            // 
            this.tipoDocumentosBindingSource.DataMember = "TipoDocumentos";
            this.tipoDocumentosBindingSource.DataSource = this.DsDocumentos;
            // 
            // DsDocumentos
            // 
            this.DsDocumentos.DataSetName = "DsDocumentos";
            this.DsDocumentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataMod
            // 
            this.DataMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataMod.Location = new System.Drawing.Point(805, 15);
            this.DataMod.Name = "DataMod";
            this.DataMod.Size = new System.Drawing.Size(157, 20);
            this.DataMod.TabIndex = 1;
            // 
            // NrDoc
            // 
            this.NrDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NrDoc.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrDoc.Location = new System.Drawing.Point(595, 10);
            this.NrDoc.Name = "NrDoc";
            this.NrDoc.Size = new System.Drawing.Size(49, 25);
            this.NrDoc.TabIndex = 2;
            this.NrDoc.Leave += new System.EventHandler(this.NrDoc_Leave);
            // 
            // BtnBaixo
            // 
            this.BtnBaixo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBaixo.BackColor = System.Drawing.Color.Silver;
            this.BtnBaixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBaixo.Location = new System.Drawing.Point(267, -5);
            this.BtnBaixo.Name = "BtnBaixo";
            this.BtnBaixo.Size = new System.Drawing.Size(77, 36);
            this.BtnBaixo.TabIndex = 4;
            this.BtnBaixo.Text = "Baixo";
            this.BtnBaixo.UseVisualStyleBackColor = false;
            this.BtnBaixo.Click += new System.EventHandler(this.BtnBaixo_Click);
            // 
            // BtnCima
            // 
            this.BtnCima.BackColor = System.Drawing.Color.Silver;
            this.BtnCima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCima.Location = new System.Drawing.Point(186, -5);
            this.BtnCima.Name = "BtnCima";
            this.BtnCima.Size = new System.Drawing.Size(75, 36);
            this.BtnCima.TabIndex = 3;
            this.BtnCima.Text = "Cima";
            this.BtnCima.UseVisualStyleBackColor = false;
            this.BtnCima.Click += new System.EventHandler(this.BtnCima_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Silver;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(105, -5);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 36);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // DgridArtigos
            // 
            this.DgridArtigos.AllowUserToAddRows = false;
            this.DgridArtigos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgridArtigos.AutoGenerateColumns = false;
            this.DgridArtigos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgridArtigos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgridArtigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridArtigos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cabecDocumentoIDDataGridViewTextBoxColumn,
            this.numLinhaDataGridViewTextBoxColumn,
            this.artigoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoUntDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.dataEntregaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.estadoProdutoDataGridViewCheckBoxColumn});
            this.DgridArtigos.DataSource = this.linhasDocumentoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgridArtigos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgridArtigos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgridArtigos.Location = new System.Drawing.Point(24, 33);
            this.DgridArtigos.Name = "DgridArtigos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgridArtigos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgridArtigos.Size = new System.Drawing.Size(968, 447);
            this.DgridArtigos.TabIndex = 1;
            this.DgridArtigos.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgridArtigos_RowLeave);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cabecDocumentoIDDataGridViewTextBoxColumn
            // 
            this.cabecDocumentoIDDataGridViewTextBoxColumn.DataPropertyName = "CabecDocumentoID";
            this.cabecDocumentoIDDataGridViewTextBoxColumn.HeaderText = "CabecDocumentoID";
            this.cabecDocumentoIDDataGridViewTextBoxColumn.Name = "cabecDocumentoIDDataGridViewTextBoxColumn";
            this.cabecDocumentoIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // numLinhaDataGridViewTextBoxColumn
            // 
            this.numLinhaDataGridViewTextBoxColumn.DataPropertyName = "NumLinha";
            this.numLinhaDataGridViewTextBoxColumn.HeaderText = "NumLinha";
            this.numLinhaDataGridViewTextBoxColumn.Name = "numLinhaDataGridViewTextBoxColumn";
            // 
            // artigoDataGridViewTextBoxColumn
            // 
            this.artigoDataGridViewTextBoxColumn.DataPropertyName = "Artigo";
            this.artigoDataGridViewTextBoxColumn.HeaderText = "Artigo";
            this.artigoDataGridViewTextBoxColumn.Name = "artigoDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // precoUntDataGridViewTextBoxColumn
            // 
            this.precoUntDataGridViewTextBoxColumn.DataPropertyName = "PrecoUnt";
            this.precoUntDataGridViewTextBoxColumn.HeaderText = "PrecoUnt";
            this.precoUntDataGridViewTextBoxColumn.Name = "precoUntDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // dataEntregaDataGridViewTextBoxColumn
            // 
            this.dataEntregaDataGridViewTextBoxColumn.DataPropertyName = "DataEntrega";
            this.dataEntregaDataGridViewTextBoxColumn.HeaderText = "DataEntrega";
            this.dataEntregaDataGridViewTextBoxColumn.Name = "dataEntregaDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // estadoProdutoDataGridViewCheckBoxColumn
            // 
            this.estadoProdutoDataGridViewCheckBoxColumn.DataPropertyName = "EstadoProduto";
            this.estadoProdutoDataGridViewCheckBoxColumn.HeaderText = "EstadoProduto";
            this.estadoProdutoDataGridViewCheckBoxColumn.Name = "estadoProdutoDataGridViewCheckBoxColumn";
            this.estadoProdutoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // linhasDocumentoBindingSource
            // 
            this.linhasDocumentoBindingSource.DataMember = "LinhasDocumento";
            this.linhasDocumentoBindingSource.DataSource = this.DsDocumentos;
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.Silver;
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Location = new System.Drawing.Point(30, -5);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 36);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(1019, 31);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(77, 653);
            this.webView21.TabIndex = 5;
            this.webView21.ZoomFactor = 1D;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(1019, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assistente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1096, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de documentos";
            this.Load += new System.EventHandler(this.FrmDocumentos_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NrDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgridArtigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhasDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnBaixo;
        private System.Windows.Forms.Button BtnCima;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView DgridArtigos;
        private System.Windows.Forms.Button BtnNovo;
        private DsDocumentos DsDocumentos;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artigosToolStripMenuItem;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox TxtMorada;
        internal System.Windows.Forms.TextBox TxtNif;
        internal System.Windows.Forms.TextBox TxtContato;
        internal System.Windows.Forms.TextBox TxtCodigoCl;
        internal System.Windows.Forms.TextBox TxtNomeCl;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.RadioButton DocAtivo;
        internal System.Windows.Forms.TextBox TxtDescricaoDoc;
        internal System.Windows.Forms.ComboBox TxtCodigoDoc;
        internal System.Windows.Forms.DateTimePicker DataMod;
        internal System.Windows.Forms.NumericUpDown NrDoc;
        private System.Windows.Forms.BindingSource tipoDocumentosBindingSource;
        private System.Windows.Forms.BindingSource linhasDocumentoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabecDocumentoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLinhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoProdutoDataGridViewCheckBoxColumn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Label label1;
    }
}

