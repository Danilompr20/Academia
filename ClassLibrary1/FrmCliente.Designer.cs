namespace ClassLibrary1
{
    partial class FrmCliente
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkExcluir = new System.Windows.Forms.CheckBox();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ldlTotal = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtLaudo = new System.Windows.Forms.TextBox();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(19, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 456);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkExcluir);
            this.tabPage1.Controls.Add(this.dataLista);
            this.tabPage1.Controls.Add(this.ldlTotal);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(596, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkExcluir
            // 
            this.chkExcluir.AutoSize = true;
            this.chkExcluir.Location = new System.Drawing.Point(9, 90);
            this.chkExcluir.Name = "chkExcluir";
            this.chkExcluir.Size = new System.Drawing.Size(66, 20);
            this.chkExcluir.TabIndex = 5;
            this.chkExcluir.Text = "Excluir";
            this.chkExcluir.UseVisualStyleBackColor = true;
            this.chkExcluir.CheckedChanged += new System.EventHandler(this.ChkExcluir_CheckedChanged);
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir});
            this.dataLista.Location = new System.Drawing.Point(9, 121);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(524, 150);
            this.dataLista.TabIndex = 4;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataLista_CellContentClick);
            this.dataLista.DoubleClick += new System.EventHandler(this.DataLista_DoubleClick);
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            // 
            // ldlTotal
            // 
            this.ldlTotal.AutoSize = true;
            this.ldlTotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ldlTotal.Location = new System.Drawing.Point(458, 78);
            this.ldlTotal.Name = "ldlTotal";
            this.ldlTotal.Size = new System.Drawing.Size(53, 16);
            this.ldlTotal.TabIndex = 3;
            this.ldlTotal.Text = "ldlTotal";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(458, 16);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 33);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Impimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(359, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 33);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(260, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 33);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(57, 16);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(186, 22);
            this.TxtBuscar.TabIndex = 0;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(596, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configurações";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.txtLaudo);
            this.groupBox2.Controls.Add(this.txtAula);
            this.groupBox2.Controls.Add(this.txtAltura);
            this.groupBox2.Controls.Add(this.txtPeso);
            this.groupBox2.Controls.Add(this.txtFoto);
            this.groupBox2.Controls.Add(this.txtContato);
            this.groupBox2.Controls.Add(this.txtTelefone);
            this.groupBox2.Controls.Add(this.txtEndereco);
            this.groupBox2.Controls.Add(this.txtRg);
            this.groupBox2.Controls.Add(this.txtCpf);
            this.groupBox2.Controls.Add(this.txtData);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 415);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(298, 373);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(202, 373);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(104, 373);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(9, 373);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtLaudo
            // 
            this.txtLaudo.Location = new System.Drawing.Point(104, 310);
            this.txtLaudo.Name = "txtLaudo";
            this.txtLaudo.Size = new System.Drawing.Size(159, 22);
            this.txtLaudo.TabIndex = 1;
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(104, 285);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(159, 22);
            this.txtAula.TabIndex = 1;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(104, 260);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(159, 22);
            this.txtAltura.TabIndex = 1;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(104, 235);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(159, 22);
            this.txtPeso.TabIndex = 1;
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(104, 210);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(159, 22);
            this.txtFoto.TabIndex = 1;
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(104, 185);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(159, 22);
            this.txtContato.TabIndex = 1;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(104, 160);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(159, 22);
            this.txtTelefone.TabIndex = 1;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(104, 135);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(159, 22);
            this.txtEndereco.TabIndex = 1;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(104, 109);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(159, 22);
            this.txtRg.TabIndex = 1;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(104, 84);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(159, 22);
            this.txtCpf.TabIndex = 1;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(104, 59);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(159, 22);
            this.txtData.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(104, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(104, 10);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(159, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 313);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Laudo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Aula";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Altura";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Peso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Foto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Contato";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "RG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data De Nasc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(17, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // ttMensagem
            // 
            this.ttMensagem.IsBalloon = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 497);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.Label ldlTotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox chkExcluir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLaudo;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.ToolTip ttMensagem;
    }
}