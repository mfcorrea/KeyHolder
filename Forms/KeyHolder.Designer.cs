
namespace KeyHolder
{
    partial class KeyHolder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            lvReserva = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox2 = new GroupBox();
            btnLimparEntrega = new Button();
            btnSalvarEntrega = new Button();
            dataEntrega = new DateTimePicker();
            cboVigilanteEntrega = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnLimparRetirada = new Button();
            btnSalvarRetirada = new Button();
            dataRetirada = new DateTimePicker();
            cboChave = new ComboBox();
            cboVigilanteRetirada = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            lvChaves = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox3 = new GroupBox();
            label9 = new Label();
            txtObservacao = new TextBox();
            txtNomeChave = new TextBox();
            btnLimparChave = new Button();
            btnSalvarChave = new Button();
            txtCodigoChave = new TextBox();
            label6 = new Label();
            label8 = new Label();
            tabPage3 = new TabPage();
            lvVigilantes = new ListView();
            codigo = new ColumnHeader();
            nome = new ColumnHeader();
            groupBox4 = new GroupBox();
            txtNomeVigilante = new TextBox();
            btnLimparVigilante = new Button();
            btnSalvarVigilante = new Button();
            label7 = new Label();
            vigilanteError = new ErrorProvider(components);
            chaveError = new ErrorProvider(components);
            reservaError = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vigilanteError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chaveError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservaError).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1452, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(117, 36);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            sairToolStripMenuItem.Size = new Size(359, 44);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(95, 36);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(359, 44);
            sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Location = new Point(24, 58);
            tabControl.Margin = new Padding(6, 6, 6, 6);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1404, 877);
            tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lvReserva);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Margin = new Padding(6, 6, 6, 6);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(6, 6, 6, 6);
            tabPage1.Size = new Size(1388, 823);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Reserva";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvReserva
            // 
            lvReserva.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvReserva.Location = new Point(11, 282);
            lvReserva.Margin = new Padding(6, 6, 6, 6);
            lvReserva.Name = "lvReserva";
            lvReserva.Size = new Size(1360, 518);
            lvReserva.TabIndex = 9;
            lvReserva.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nome";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Observação";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLimparEntrega);
            groupBox2.Controls.Add(btnSalvarEntrega);
            groupBox2.Controls.Add(dataEntrega);
            groupBox2.Controls.Add(cboVigilanteEntrega);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(698, 15);
            groupBox2.Margin = new Padding(6, 6, 6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 6, 6, 6);
            groupBox2.Size = new Size(676, 254);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Entrega";
            // 
            // btnLimparEntrega
            // 
            btnLimparEntrega.Location = new Point(505, 113);
            btnLimparEntrega.Margin = new Padding(6, 6, 6, 6);
            btnLimparEntrega.Name = "btnLimparEntrega";
            btnLimparEntrega.Size = new Size(139, 49);
            btnLimparEntrega.TabIndex = 8;
            btnLimparEntrega.Text = "Limpar";
            btnLimparEntrega.UseVisualStyleBackColor = true;
            // 
            // btnSalvarEntrega
            // 
            btnSalvarEntrega.Location = new Point(362, 113);
            btnSalvarEntrega.Margin = new Padding(6, 6, 6, 6);
            btnSalvarEntrega.Name = "btnSalvarEntrega";
            btnSalvarEntrega.Size = new Size(139, 49);
            btnSalvarEntrega.TabIndex = 7;
            btnSalvarEntrega.Text = "Salvar";
            btnSalvarEntrega.UseVisualStyleBackColor = true;
            // 
            // dataEntrega
            // 
            dataEntrega.CustomFormat = "dd/MM/yyyy HH:mm";
            dataEntrega.Format = DateTimePickerFormat.Custom;
            dataEntrega.Location = new Point(117, 118);
            dataEntrega.Margin = new Padding(6, 6, 6, 6);
            dataEntrega.Name = "dataEntrega";
            dataEntrega.Size = new Size(231, 39);
            dataEntrega.TabIndex = 6;
            // 
            // cboVigilanteEntrega
            // 
            cboVigilanteEntrega.FormattingEnabled = true;
            cboVigilanteEntrega.Location = new Point(117, 51);
            cboVigilanteEntrega.Margin = new Padding(6, 6, 6, 6);
            cboVigilanteEntrega.Name = "cboVigilanteEntrega";
            cboVigilanteEntrega.Size = new Size(524, 40);
            cboVigilanteEntrega.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 122);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 32);
            label4.TabIndex = 2;
            label4.Text = "Data";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 58);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 32);
            label5.TabIndex = 1;
            label5.Text = "Vigilante";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimparRetirada);
            groupBox1.Controls.Add(btnSalvarRetirada);
            groupBox1.Controls.Add(dataRetirada);
            groupBox1.Controls.Add(cboChave);
            groupBox1.Controls.Add(cboVigilanteRetirada);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 15);
            groupBox1.Margin = new Padding(6, 6, 6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 6, 6, 6);
            groupBox1.Size = new Size(676, 254);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Retirada";
            // 
            // btnLimparRetirada
            // 
            btnLimparRetirada.Location = new Point(505, 171);
            btnLimparRetirada.Margin = new Padding(6, 6, 6, 6);
            btnLimparRetirada.Name = "btnLimparRetirada";
            btnLimparRetirada.Size = new Size(139, 49);
            btnLimparRetirada.TabIndex = 5;
            btnLimparRetirada.Text = "Limpar";
            // 
            // btnSalvarRetirada
            // 
            btnSalvarRetirada.Location = new Point(362, 171);
            btnSalvarRetirada.Margin = new Padding(6, 6, 6, 6);
            btnSalvarRetirada.Name = "btnSalvarRetirada";
            btnSalvarRetirada.Size = new Size(139, 49);
            btnSalvarRetirada.TabIndex = 4;
            btnSalvarRetirada.Text = "Salvar";
            btnSalvarRetirada.UseVisualStyleBackColor = true;
            // 
            // dataRetirada
            // 
            dataRetirada.CustomFormat = "dd/MM/yyyy HH:mm";
            dataRetirada.Format = DateTimePickerFormat.Custom;
            dataRetirada.Location = new Point(117, 177);
            dataRetirada.Margin = new Padding(6, 6, 6, 6);
            dataRetirada.Name = "dataRetirada";
            dataRetirada.Size = new Size(231, 39);
            dataRetirada.TabIndex = 3;
            // 
            // cboChave
            // 
            cboChave.FormattingEnabled = true;
            cboChave.Location = new Point(269, 47);
            cboChave.Margin = new Padding(6, 6, 6, 6);
            cboChave.Name = "cboChave";
            cboChave.Size = new Size(372, 40);
            cboChave.TabIndex = 1;
            // 
            // cboVigilanteRetirada
            // 
            cboVigilanteRetirada.FormattingEnabled = true;
            cboVigilanteRetirada.Location = new Point(117, 109);
            cboVigilanteRetirada.Margin = new Padding(6, 6, 6, 6);
            cboVigilanteRetirada.Name = "cboVigilanteRetirada";
            cboVigilanteRetirada.Size = new Size(524, 40);
            cboVigilanteRetirada.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 47);
            textBox1.Margin = new Padding(6, 6, 6, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 39);
            textBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 179);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 32);
            label3.TabIndex = 2;
            label3.Text = "Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 115);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 32);
            label2.TabIndex = 1;
            label2.Text = "Vigilante";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 55);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 0;
            label1.Text = "Chave";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lvChaves);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Margin = new Padding(6, 6, 6, 6);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(6, 6, 6, 6);
            tabPage2.Size = new Size(1388, 823);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Chave";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvChaves
            // 
            lvChaves.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            lvChaves.Location = new Point(13, 247);
            lvChaves.Margin = new Padding(6, 6, 6, 6);
            lvChaves.Name = "lvChaves";
            lvChaves.Size = new Size(1360, 550);
            lvChaves.TabIndex = 4;
            lvChaves.UseCompatibleStateImageBehavior = false;
            lvChaves.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Código";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nome";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Observacao";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtObservacao);
            groupBox3.Controls.Add(txtNomeChave);
            groupBox3.Controls.Add(btnLimparChave);
            groupBox3.Controls.Add(btnSalvarChave);
            groupBox3.Controls.Add(txtCodigoChave);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(13, 13);
            groupBox3.Margin = new Padding(6, 6, 6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(6, 6, 6, 6);
            groupBox3.Size = new Size(1229, 222);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chave";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 105);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(138, 32);
            label9.TabIndex = 11;
            label9.Text = "Observação";
            // 
            // txtObservacao
            // 
            txtObservacao.CausesValidation = false;
            txtObservacao.Location = new Point(149, 98);
            txtObservacao.Margin = new Padding(6, 6, 6, 6);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(743, 96);
            txtObservacao.TabIndex = 10;
            // 
            // txtNomeChave
            // 
            txtNomeChave.Location = new Point(386, 36);
            txtNomeChave.Margin = new Padding(6, 6, 6, 6);
            txtNomeChave.Name = "txtNomeChave";
            txtNomeChave.Size = new Size(505, 39);
            txtNomeChave.TabIndex = 9;
            // 
            // btnLimparChave
            // 
            btnLimparChave.Location = new Point(1072, 32);
            btnLimparChave.Margin = new Padding(6, 6, 6, 6);
            btnLimparChave.Name = "btnLimparChave";
            btnLimparChave.Size = new Size(139, 49);
            btnLimparChave.TabIndex = 8;
            btnLimparChave.Text = "Limpar";
            btnLimparChave.UseVisualStyleBackColor = true;
            // 
            // btnSalvarChave
            // 
            btnSalvarChave.Location = new Point(929, 32);
            btnSalvarChave.Margin = new Padding(6, 6, 6, 6);
            btnSalvarChave.Name = "btnSalvarChave";
            btnSalvarChave.Size = new Size(139, 49);
            btnSalvarChave.TabIndex = 7;
            btnSalvarChave.Text = "Salvar";
            btnSalvarChave.UseVisualStyleBackColor = true;
            // 
            // txtCodigoChave
            // 
            txtCodigoChave.CausesValidation = false;
            txtCodigoChave.Location = new Point(149, 36);
            txtCodigoChave.Margin = new Padding(6, 6, 6, 6);
            txtCodigoChave.Name = "txtCodigoChave";
            txtCodigoChave.Size = new Size(138, 39);
            txtCodigoChave.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 45);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(80, 32);
            label6.TabIndex = 2;
            label6.Text = "Nome";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(59, 45);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(91, 32);
            label8.TabIndex = 0;
            label8.Text = "Código";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lvVigilantes);
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Margin = new Padding(6, 6, 6, 6);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1388, 823);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Vigilante";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvVigilantes
            // 
            lvVigilantes.Columns.AddRange(new ColumnHeader[] { codigo, nome });
            lvVigilantes.Location = new Point(13, 132);
            lvVigilantes.Margin = new Padding(6, 6, 6, 6);
            lvVigilantes.Name = "lvVigilantes";
            lvVigilantes.Size = new Size(1360, 665);
            lvVigilantes.TabIndex = 6;
            lvVigilantes.UseCompatibleStateImageBehavior = false;
            lvVigilantes.View = View.Details;
            // 
            // codigo
            // 
            codigo.Text = "Código";
            // 
            // nome
            // 
            nome.Text = "Nome";
            nome.Width = 600;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtNomeVigilante);
            groupBox4.Controls.Add(btnLimparVigilante);
            groupBox4.Controls.Add(btnSalvarVigilante);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(13, 13);
            groupBox4.Margin = new Padding(6, 6, 6, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(6, 6, 6, 6);
            groupBox4.Size = new Size(1229, 107);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Vigilante";
            // 
            // txtNomeVigilante
            // 
            txtNomeVigilante.Location = new Point(136, 36);
            txtNomeVigilante.Margin = new Padding(6, 6, 6, 6);
            txtNomeVigilante.Name = "txtNomeVigilante";
            txtNomeVigilante.Size = new Size(768, 39);
            txtNomeVigilante.TabIndex = 9;
            // 
            // btnLimparVigilante
            // 
            btnLimparVigilante.Location = new Point(1053, 30);
            btnLimparVigilante.Margin = new Padding(6, 6, 6, 6);
            btnLimparVigilante.Name = "btnLimparVigilante";
            btnLimparVigilante.Size = new Size(139, 49);
            btnLimparVigilante.TabIndex = 8;
            btnLimparVigilante.Text = "Limpar";
            btnLimparVigilante.UseVisualStyleBackColor = true;
            // 
            // btnSalvarVigilante
            // 
            btnSalvarVigilante.Location = new Point(910, 30);
            btnSalvarVigilante.Margin = new Padding(6, 6, 6, 6);
            btnSalvarVigilante.Name = "btnSalvarVigilante";
            btnSalvarVigilante.Size = new Size(139, 49);
            btnSalvarVigilante.TabIndex = 7;
            btnSalvarVigilante.Text = "Salvar";
            btnSalvarVigilante.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 45);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 32);
            label7.TabIndex = 2;
            label7.Text = "Nome";
            // 
            // vigilanteError
            // 
            vigilanteError.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            vigilanteError.ContainerControl = this;
            // 
            // chaveError
            // 
            chaveError.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            chaveError.ContainerControl = this;
            // 
            // reservaError
            // 
            reservaError.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            reservaError.ContainerControl = this;
            // 
            // KeyHolder
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 960);
            Controls.Add(tabControl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 6, 6, 6);
            MaximizeBox = false;
            Name = "KeyHolder";
            Text = "KeyHolder";
            Load += KeyHolder_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vigilanteError).EndInit();
            ((System.ComponentModel.ISupportInitialize)chaveError).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservaError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ListView lvReserva;
        private GroupBox groupBox2;
        private Button btnLimparEntrega;
        private Button btnSalvarEntrega;
        private DateTimePicker dataEntrega;
        private ComboBox cboVigilanteEntrega;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnLimparRetirada;
        private Button btnSalvarRetirada;
        private DateTimePicker dataRetirada;
        private ComboBox cboChave;
        private ComboBox cboVigilanteRetirada;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lvChaves;
        private GroupBox groupBox3;
        private TextBox txtNomeChave;
        private Button btnLimparChave;
        private Button btnSalvarChave;
        private Label label6;
        private ListView lvVigilantes;
        private GroupBox groupBox4;
        private TextBox txtNomeVigilante;
        private Button btnLimparVigilante;
        private Button btnSalvarVigilante;
        private Label label7;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txtCodigoChave;
        private Label label8;
        private ColumnHeader codigo;
        private ColumnHeader nome;
        private Label label9;
        private TextBox txtObservacao;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ErrorProvider vigilanteError;
        private ErrorProvider chaveError;
        private ErrorProvider reservaError;
    }
}
