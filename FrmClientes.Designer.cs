namespace Vmp_C__ex1
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.PainelCliente = new System.Windows.Forms.Panel();
            this.ClienteAtivo = new System.Windows.Forms.RadioButton();
            this.TxtCodigoCl = new System.Windows.Forms.TextBox();
            this.lblNIF = new System.Windows.Forms.Label();
            this.TxtNIF = new System.Windows.Forms.TextBox();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblMorada = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtMorada = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LabelCliente = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.PainelCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelCliente
            // 
            this.PainelCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PainelCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PainelCliente.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PainelCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PainelCliente.Controls.Add(this.ClienteAtivo);
            this.PainelCliente.Controls.Add(this.TxtCodigoCl);
            this.PainelCliente.Controls.Add(this.lblNIF);
            this.PainelCliente.Controls.Add(this.TxtNIF);
            this.PainelCliente.Controls.Add(this.LblTelefone);
            this.PainelCliente.Controls.Add(this.LblMorada);
            this.PainelCliente.Controls.Add(this.TxtTelefone);
            this.PainelCliente.Controls.Add(this.LblEmail);
            this.PainelCliente.Controls.Add(this.TxtEmail);
            this.PainelCliente.Controls.Add(this.LblNome);
            this.PainelCliente.Controls.Add(this.TxtMorada);
            this.PainelCliente.Controls.Add(this.TxtNome);
            this.PainelCliente.Controls.Add(this.LabelCliente);
            this.PainelCliente.Location = new System.Drawing.Point(23, 59);
            this.PainelCliente.Name = "PainelCliente";
            this.PainelCliente.Size = new System.Drawing.Size(888, 186);
            this.PainelCliente.TabIndex = 2;
            // 
            // ClienteAtivo
            // 
            this.ClienteAtivo.AutoSize = true;
            this.ClienteAtivo.Checked = true;
            this.ClienteAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteAtivo.Location = new System.Drawing.Point(815, 29);
            this.ClienteAtivo.Name = "ClienteAtivo";
            this.ClienteAtivo.Size = new System.Drawing.Size(53, 19);
            this.ClienteAtivo.TabIndex = 21;
            this.ClienteAtivo.TabStop = true;
            this.ClienteAtivo.Text = "Ativo";
            this.ClienteAtivo.UseVisualStyleBackColor = true;
            // 
            // TxtCodigoCl
            // 
            this.TxtCodigoCl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCodigoCl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigoCl.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoCl.Location = new System.Drawing.Point(173, 25);
            this.TxtCodigoCl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtCodigoCl.Name = "TxtCodigoCl";
            this.TxtCodigoCl.Size = new System.Drawing.Size(67, 26);
            this.TxtCodigoCl.TabIndex = 1;
            this.TxtCodigoCl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoCl_KeyDown);
            this.TxtCodigoCl.Leave += new System.EventHandler(this.TxtCodigoCl_Leave);
            // 
            // lblNIF
            // 
            this.lblNIF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNIF.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(650, 118);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(45, 23);
            this.lblNIF.TabIndex = 19;
            this.lblNIF.Text = "NIF :";
            this.lblNIF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtNIF
            // 
            this.TxtNIF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNIF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNIF.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNIF.Location = new System.Drawing.Point(701, 114);
            this.TxtNIF.Name = "TxtNIF";
            this.TxtNIF.Size = new System.Drawing.Size(167, 27);
            this.TxtNIF.TabIndex = 6;
            // 
            // LblTelefone
            // 
            this.LblTelefone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblTelefone.Location = new System.Drawing.Point(80, 113);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(88, 23);
            this.LblTelefone.TabIndex = 17;
            this.LblTelefone.Text = "Telefone :";
            this.LblTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblMorada
            // 
            this.LblMorada.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMorada.Location = new System.Drawing.Point(80, 69);
            this.LblMorada.Name = "LblMorada";
            this.LblMorada.Size = new System.Drawing.Size(78, 27);
            this.LblMorada.TabIndex = 16;
            this.LblMorada.Text = "Morada :";
            this.LblMorada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTelefone.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefone.Location = new System.Drawing.Point(174, 112);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(199, 27);
            this.TxtTelefone.TabIndex = 4;
            // 
            // LblEmail
            // 
            this.LblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(409, 118);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(57, 23);
            this.LblEmail.TabIndex = 15;
            this.LblEmail.Text = "Email :";
            this.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(474, 113);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(159, 27);
            this.TxtEmail.TabIndex = 5;
            // 
            // LblNome
            // 
            this.LblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(265, 29);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(60, 23);
            this.LblNome.TabIndex = 11;
            this.LblNome.Text = "Nome :";
            this.LblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtMorada
            // 
            this.TxtMorada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMorada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMorada.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMorada.Location = new System.Drawing.Point(173, 69);
            this.TxtMorada.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtMorada.Name = "TxtMorada";
            this.TxtMorada.Size = new System.Drawing.Size(695, 27);
            this.TxtMorada.TabIndex = 3;
            // 
            // TxtNome
            // 
            this.TxtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNome.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(333, 25);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(458, 27);
            this.TxtNome.TabIndex = 2;
            // 
            // LabelCliente
            // 
            this.LabelCliente.AutoSize = true;
            this.LabelCliente.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCliente.Location = new System.Drawing.Point(13, 13);
            this.LabelCliente.Name = "LabelCliente";
            this.LabelCliente.Size = new System.Drawing.Size(70, 18);
            this.LabelCliente.TabIndex = 1;
            this.LabelCliente.Text = "Cliente";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.BackColor = System.Drawing.Color.Silver;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(178, 12);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(72, 28);
            this.BtnEliminar.TabIndex = 41;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseCompatibleTextRendering = true;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnNovo
            // 
            this.BtnNovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNovo.BackColor = System.Drawing.Color.Silver;
            this.BtnNovo.FlatAppearance.BorderSize = 0;
            this.BtnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNovo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Location = new System.Drawing.Point(22, 12);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(72, 28);
            this.BtnNovo.TabIndex = 40;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseCompatibleTextRendering = true;
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSair.BackColor = System.Drawing.Color.Silver;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(255, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(72, 28);
            this.BtnSair.TabIndex = 39;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseCompatibleTextRendering = true;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGravar.BackColor = System.Drawing.Color.Silver;
            this.BtnGravar.FlatAppearance.BorderSize = 0;
            this.BtnGravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGravar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGravar.Location = new System.Drawing.Point(100, 12);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(72, 28);
            this.BtnGravar.TabIndex = 38;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseCompatibleTextRendering = true;
            this.BtnGravar.UseVisualStyleBackColor = false;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 267);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.PainelCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.PainelCliente.ResumeLayout(false);
            this.PainelCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PainelCliente;
        internal System.Windows.Forms.Label lblNIF;
        internal System.Windows.Forms.TextBox TxtNIF;
        internal System.Windows.Forms.Label LblTelefone;
        internal System.Windows.Forms.Label LblMorada;
        internal System.Windows.Forms.TextBox TxtTelefone;
        internal System.Windows.Forms.Label LblEmail;
        internal System.Windows.Forms.TextBox TxtEmail;
        internal System.Windows.Forms.Label LblNome;
        internal System.Windows.Forms.TextBox TxtMorada;
        internal System.Windows.Forms.TextBox TxtNome;
        internal System.Windows.Forms.Label LabelCliente;
        internal System.Windows.Forms.Button BtnEliminar;
        internal System.Windows.Forms.Button BtnNovo;
        internal System.Windows.Forms.Button BtnSair;
        internal System.Windows.Forms.Button BtnGravar;
        internal System.Windows.Forms.TextBox TxtCodigoCl;
        private System.Windows.Forms.RadioButton ClienteAtivo;
    }
}