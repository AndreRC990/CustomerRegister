
namespace CustomerRegister
{
    partial class frmCadastro
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabReg = new System.Windows.Forms.TabPage();
            this.gbPersonalInfo = new System.Windows.Forms.GroupBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.dwnEstado = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabView = new System.Windows.Forms.TabPage();
            this.dgvCadastrados = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabReg.SuspendLayout();
            this.gbPersonalInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastrados)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(97, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(312, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabReg);
            this.tabControl.Controls.Add(this.tabView);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(700, 426);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabReg
            // 
            this.tabReg.BackColor = System.Drawing.Color.Transparent;
            this.tabReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabReg.Controls.Add(this.gbPersonalInfo);
            this.tabReg.Controls.Add(this.panel2);
            this.tabReg.Location = new System.Drawing.Point(4, 22);
            this.tabReg.Name = "tabReg";
            this.tabReg.Padding = new System.Windows.Forms.Padding(3);
            this.tabReg.Size = new System.Drawing.Size(692, 400);
            this.tabReg.TabIndex = 0;
            this.tabReg.Text = "CADASTRO";
            // 
            // gbPersonalInfo
            // 
            this.gbPersonalInfo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.gbPersonalInfo.Controls.Add(this.txtCpf);
            this.gbPersonalInfo.Controls.Add(this.dwnEstado);
            this.gbPersonalInfo.Controls.Add(this.txtCidade);
            this.gbPersonalInfo.Controls.Add(this.label5);
            this.gbPersonalInfo.Controls.Add(this.label1);
            this.gbPersonalInfo.Controls.Add(this.txtEndereco);
            this.gbPersonalInfo.Controls.Add(this.label2);
            this.gbPersonalInfo.Controls.Add(this.txtFirstName);
            this.gbPersonalInfo.Controls.Add(this.label4);
            this.gbPersonalInfo.Controls.Add(this.label3);
            this.gbPersonalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbPersonalInfo.Location = new System.Drawing.Point(3, 3);
            this.gbPersonalInfo.Name = "gbPersonalInfo";
            this.gbPersonalInfo.Size = new System.Drawing.Size(684, 195);
            this.gbPersonalInfo.TabIndex = 6;
            this.gbPersonalInfo.TabStop = false;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(97, 166);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(312, 20);
            this.txtCpf.TabIndex = 5;
            // 
            // dwnEstado
            // 
            this.dwnEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dwnEstado.FormattingEnabled = true;
            this.dwnEstado.Items.AddRange(new object[] {
            "(AC) - Acre",
            "(AL) - Alagoas",
            "(AP) - Amapá",
            "(AM) - Amazonas",
            "(BA) - Bahia",
            "(CE) - Ceará",
            "(DF) - Distrito Federal",
            "(ES) - Espírito Santo",
            "(GO) - Goiás",
            "(MA) - Maranhão",
            "(MT) - Mato Grosso",
            "(MS) - Mato Grosso do Sul",
            "(MG) - Minas Gerais",
            "(PA) - Pará",
            "(PB) - Paraíba",
            "(PR) - Paraná",
            "(PE) - Pernambuco",
            "(PI) - Piauí",
            "(RJ) - Rio de Janeiro",
            "(RN) - Rio Grande do Norte",
            "(RS) - Rio Grande do Sul",
            "(RO) - Rondônia",
            "(RR) - Roraima",
            "(SC) - Santa Catarina",
            "(SP) - São Paulo",
            "(SE) - Sergipe",
            "(TO) - Tocantins"});
            this.dwnEstado.Location = new System.Drawing.Point(97, 134);
            this.dwnEstado.Name = "dwnEstado";
            this.dwnEstado.Size = new System.Drawing.Size(161, 21);
            this.dwnEstado.TabIndex = 3;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(97, 96);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(312, 20);
            this.txtCidade.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(97, 56);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(312, 20);
            this.txtEndereco.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cidade:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 95);
            this.panel2.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.BackgroundImage = global::CustomerRegister.Properties.Resources.Search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(321, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 63);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.BackgroundImage = global::CustomerRegister.Properties.Resources.Trash;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Location = new System.Drawing.Point(221, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 63);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.BackgroundImage = global::CustomerRegister.Properties.Resources.Update;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Location = new System.Drawing.Point(121, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 63);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.BackgroundImage = global::CustomerRegister.Properties.Resources.Save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Location = new System.Drawing.Point(21, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 63);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.dgvCadastrados);
            this.tabView.Location = new System.Drawing.Point(4, 22);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(712, 400);
            this.tabView.TabIndex = 1;
            this.tabView.Text = "CADASTRADOS";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // dgvCadastrados
            // 
            this.dgvCadastrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cNome,
            this.cEndereco,
            this.cCidade,
            this.cEstado,
            this.cCPF});
            this.dgvCadastrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCadastrados.Location = new System.Drawing.Point(3, 3);
            this.dgvCadastrados.Name = "dgvCadastrados";
            this.dgvCadastrados.Size = new System.Drawing.Size(706, 394);
            this.dgvCadastrados.TabIndex = 0;
            // 
            // cID
            // 
            this.cID.HeaderText = "ID";
            this.cID.MinimumWidth = 2;
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Width = 50;
            // 
            // cNome
            // 
            this.cNome.HeaderText = "Nome";
            this.cNome.Name = "cNome";
            // 
            // cEndereco
            // 
            this.cEndereco.HeaderText = "Endereço";
            this.cEndereco.Name = "cEndereco";
            // 
            // cCidade
            // 
            this.cCidade.HeaderText = "Cidade";
            this.cCidade.Name = "cCidade";
            // 
            // cEstado
            // 
            this.cEstado.HeaderText = "Estado";
            this.cEstado.Name = "cEstado";
            // 
            // cCPF
            // 
            this.cCPF.HeaderText = "CPF";
            this.cCPF.Name = "cCPF";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(700, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTime
            // 
            this.lblTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblTime.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(51, 19);
            this.lblTime.Text = "TEMPO";
            // 
            // myTimer
            // 
            this.myTimer.Enabled = true;
            this.myTimer.Interval = 10;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(700, 426);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTER";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.tabControl.ResumeLayout(false);
            this.tabReg.ResumeLayout(false);
            this.gbPersonalInfo.ResumeLayout(false);
            this.gbPersonalInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastrados)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabReg;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPersonalInfo;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dwnEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCadastrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCPF;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

