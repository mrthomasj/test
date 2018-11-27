namespace TesteResort
{
    partial class Form3
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
            System.Windows.Forms.Label qua_numLabel;
            System.Windows.Forms.Label tbl_funcionarios_func_cpfLabel;
            System.Windows.Forms.Label tbl_reg_estadias_id_estadiaLabel;
            System.Windows.Forms.Label tbl_cliente_cli_cpfLabel;
            System.Windows.Forms.Label qua_andarLabel;
            System.Windows.Forms.Label qua_hosp_limitLabel;
            System.Windows.Forms.Label qua_valor_diaLabel;
            System.Windows.Forms.Label qua_tipo_acomodLabel;
            System.Windows.Forms.Label qua_statusLabel;
            this.db_piDataSet = new TesteResort.db_piDataSet();
            this.tbl_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_clienteTableAdapter = new TesteResort.db_piDataSetTableAdapters.tbl_clienteTableAdapter();
            this.tableAdapterManager = new TesteResort.db_piDataSetTableAdapters.TableAdapterManager();
            this.tbl_quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_quartosTableAdapter = new TesteResort.db_piDataSetTableAdapters.tbl_quartosTableAdapter();
            this.qua_numTextBox = new System.Windows.Forms.TextBox();
            this.tbl_funcionarios_func_cpfTextBox = new System.Windows.Forms.TextBox();
            this.tbl_reg_estadias_id_estadiaTextBox = new System.Windows.Forms.TextBox();
            this.tbl_cliente_cli_cpfTextBox = new System.Windows.Forms.TextBox();
            this.qua_andarTextBox = new System.Windows.Forms.TextBox();
            this.qua_hosp_limitTextBox = new System.Windows.Forms.TextBox();
            this.qua_valor_diaTextBox = new System.Windows.Forms.TextBox();
            this.qua_tipo_acomodTextBox = new System.Windows.Forms.TextBox();
            this.qua_statusTextBox = new System.Windows.Forms.TextBox();
            qua_numLabel = new System.Windows.Forms.Label();
            tbl_funcionarios_func_cpfLabel = new System.Windows.Forms.Label();
            tbl_reg_estadias_id_estadiaLabel = new System.Windows.Forms.Label();
            tbl_cliente_cli_cpfLabel = new System.Windows.Forms.Label();
            qua_andarLabel = new System.Windows.Forms.Label();
            qua_hosp_limitLabel = new System.Windows.Forms.Label();
            qua_valor_diaLabel = new System.Windows.Forms.Label();
            qua_tipo_acomodLabel = new System.Windows.Forms.Label();
            qua_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_piDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_quartosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // db_piDataSet
            // 
            this.db_piDataSet.DataSetName = "db_piDataSet";
            this.db_piDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_clienteBindingSource
            // 
            this.tbl_clienteBindingSource.DataMember = "tbl_cliente";
            this.tbl_clienteBindingSource.DataSource = this.db_piDataSet;
            // 
            // tbl_clienteTableAdapter
            // 
            this.tbl_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_clienteTableAdapter = this.tbl_clienteTableAdapter;
            this.tableAdapterManager.tbl_eventos_has_tbl_clienteTableAdapter = null;
            this.tableAdapterManager.tbl_eventosTableAdapter = null;
            this.tableAdapterManager.tbl_funcionariosTableAdapter = null;
            this.tableAdapterManager.tbl_produtos_has_tbl_clienteTableAdapter = null;
            this.tableAdapterManager.tbl_produtosTableAdapter = null;
            this.tableAdapterManager.tbl_quartosTableAdapter = null;
            this.tableAdapterManager.tbl_reg_estadiasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TesteResort.db_piDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_quartosBindingSource
            // 
            this.tbl_quartosBindingSource.DataMember = "tbl_quartos";
            this.tbl_quartosBindingSource.DataSource = this.db_piDataSet;
            // 
            // tbl_quartosTableAdapter
            // 
            this.tbl_quartosTableAdapter.ClearBeforeFill = true;
            // 
            // qua_numLabel
            // 
            qua_numLabel.AutoSize = true;
            qua_numLabel.Location = new System.Drawing.Point(165, 110);
            qua_numLabel.Name = "qua_numLabel";
            qua_numLabel.Size = new System.Drawing.Size(51, 13);
            qua_numLabel.TabIndex = 0;
            qua_numLabel.Text = "qua num:";
            // 
            // qua_numTextBox
            // 
            this.qua_numTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_quartosBindingSource, "qua_num", true));
            this.qua_numTextBox.Location = new System.Drawing.Point(300, 107);
            this.qua_numTextBox.Name = "qua_numTextBox";
            this.qua_numTextBox.Size = new System.Drawing.Size(100, 20);
            this.qua_numTextBox.TabIndex = 1;
            // 
            // tbl_funcionarios_func_cpfLabel
            // 
            tbl_funcionarios_func_cpfLabel.AutoSize = true;
            tbl_funcionarios_func_cpfLabel.Location = new System.Drawing.Point(165, 136);
            tbl_funcionarios_func_cpfLabel.Name = "tbl_funcionarios_func_cpfLabel";
            tbl_funcionarios_func_cpfLabel.Size = new System.Drawing.Size(123, 13);
            tbl_funcionarios_func_cpfLabel.TabIndex = 2;
            tbl_funcionarios_func_cpfLabel.Text = "tbl funcionarios func cpf:";
            // 
            // tbl_funcionarios_func_cpfTextBox
            // 
            this.tbl_funcionarios_func_cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_quartosBindingSource, "tbl_funcionarios_func_cpf", true));
            this.tbl_funcionarios_func_cpfTextBox.Location = new System.Drawing.Point(300, 133);
            this.tbl_funcionarios_func_cpfTextBox.Name = "tbl_funcionarios_func_cpfTextBox";
            this.tbl_funcionarios_func_cpfTextBox.Size = new System.Drawing.Size(100, 20);
            this.tbl_funcionarios_func_cpfTextBox.TabIndex = 3;
            // 
            // tbl_reg_estadias_id_estadiaLabel
            // 
            tbl_reg_estadias_id_estadiaLabel.AutoSize = true;
            tbl_reg_estadias_id_estadiaLabel.Location = new System.Drawing.Point(165, 162);
            tbl_reg_estadias_id_estadiaLabel.Name = "tbl_reg_estadias_id_estadiaLabel";
            tbl_reg_estadias_id_estadiaLabel.Size = new System.Drawing.Size(129, 13);
            tbl_reg_estadias_id_estadiaLabel.TabIndex = 4;
            tbl_reg_estadias_id_estadiaLabel.Text = "tbl reg estadias id estadia:";
            // 
            // tbl_reg_estadias_id_estadiaTextBox
            // 
            this.tbl_reg_estadias_id_estadiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_quartosBindingSource, "tbl_reg_estadias_id_estadia", true));
            this.tbl_reg_estadias_id_estadiaTextBox.Location = new System.Drawing.Point(300, 159);
            this.tbl_reg_estadias_id_estadiaTextBox.Name = "tbl_reg_estadias_id_estadiaTextBox";
            this.tbl_reg_estadias_id_estadiaTextBox.Size = new System.Drawing.Size(100, 20);
            this.tbl_reg_estadias_id_estadiaTextBox.TabIndex = 5;
            // 
            // tbl_cliente_cli_cpfLabel
            // 
            tbl_cliente_cli_cpfLabel.AutoSize = true;
            tbl_cliente_cli_cpfLabel.Location = new System.Drawing.Point(165, 188);
            tbl_cliente_cli_cpfLabel.Name = "tbl_cliente_cli_cpfLabel";
            tbl_cliente_cli_cpfLabel.Size = new System.Drawing.Size(86, 13);
            tbl_cliente_cli_cpfLabel.TabIndex = 6;
            tbl_cliente_cli_cpfLabel.Text = "tbl cliente cli cpf:";
            // 
            // tbl_cliente_cli_cpfTextBox
            // 
            this.tbl_cliente_cli_cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_quartosBindingSource, "tbl_cliente_cli_cpf", true));
            this.tbl_cliente_cli_cpfTextBox.Location = new System.Drawing.Point(300, 185);
            this.tbl_cliente_cli_cpfTextBox.Name = "tbl_cliente_cli_cpfTextBox";
            this.tbl_cliente_cli_cpfTextBox.Size = new System.Drawing.Size(100, 20);
            this.tbl_cliente_cli_cpfTextBox.TabIndex = 7;
            // 
            // qua_andarLabel
            // 
            qua_andarLabel.AutoSize = true;
            qua_andarLabel.Location = new System.Drawing.Point(165, 214);
            qua_andarLabel.Name = "qua_andarLabel";
            qua_andarLabel.Size = new System.Drawing.Size(58, 13);
            qua_andarLabel.TabIndex = 8;
            qua_andarLabel.Text = "qua andar:";
            // 
            // qua_andarTextBox
            // 
            this.qua_andarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_quartosBindingSource, "qua_andar", true));
            this.qua_andarTextBox.Location = new System.Drawing.Point(300, 211);
            this.qua_andarTextBox.Name = "qua_andarTextBox";
            this.qua_andarTextBox.Size = new System.Drawing.Size(100, 20);
            this.qua_andarTextBox.TabIndex = 9;
            // 
            // qua_hosp_limitLabel
            // 
            qua_hosp_limitLabel.AutoSize = true;
            qua_hosp_limitLabel.Location = new System.Drawing.Point(165, 240);
            qua_hosp_limitLabel.Name = "qua_hosp_limitLabel";
            qua_hosp_limitLabel.Size = new System.Drawing.Size(74, 13);
            qua_hosp_limitLabel.TabIndex = 10;
            qua_hosp_limitLabel.Text = "qua hosp limit:";
            // 
            // qua_hosp_limitTextBox
            // 
            this.qua_hosp_limitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_quartosBindingSource, "qua_hosp_limit", true));
            this.qua_hosp_limitTextBox.Location = new System.Drawing.Point(300, 237);
            this.qua_hosp_limitTextBox.Name = "qua_hosp_limitTextBox";
            this.qua_hosp_limitTextBox.Size = new System.Drawing.Size(100, 20);
            this.qua_hosp_limitTextBox.TabIndex = 11;
            // 
            // qua_valor_diaLabel
            // 
            qua_valor_diaLabel.AutoSize = true;
            qua_valor_diaLabel.Location = new System.Drawing.Point(165, 266);
            qua_valor_diaLabel.Name = "qua_valor_diaLabel";
            qua_valor_diaLabel.Size = new System.Drawing.Size(71, 13);
            qua_valor_diaLabel.TabIndex = 12;
            qua_valor_diaLabel.Text = "qua valor dia:";
            // 
            // qua_valor_diaTextBox
            // 
            this.qua_valor_diaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_quartosBindingSource, "qua_valor_dia", true));
            this.qua_valor_diaTextBox.Location = new System.Drawing.Point(300, 263);
            this.qua_valor_diaTextBox.Name = "qua_valor_diaTextBox";
            this.qua_valor_diaTextBox.Size = new System.Drawing.Size(100, 20);
            this.qua_valor_diaTextBox.TabIndex = 13;
            // 
            // qua_tipo_acomodLabel
            // 
            qua_tipo_acomodLabel.AutoSize = true;
            qua_tipo_acomodLabel.Location = new System.Drawing.Point(165, 292);
            qua_tipo_acomodLabel.Name = "qua_tipo_acomodLabel";
            qua_tipo_acomodLabel.Size = new System.Drawing.Size(89, 13);
            qua_tipo_acomodLabel.TabIndex = 14;
            qua_tipo_acomodLabel.Text = "qua tipo acomod:";
            // 
            // qua_tipo_acomodTextBox
            // 
            this.qua_tipo_acomodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_quartosBindingSource, "qua_tipo_acomod", true));
            this.qua_tipo_acomodTextBox.Location = new System.Drawing.Point(300, 289);
            this.qua_tipo_acomodTextBox.Name = "qua_tipo_acomodTextBox";
            this.qua_tipo_acomodTextBox.Size = new System.Drawing.Size(100, 20);
            this.qua_tipo_acomodTextBox.TabIndex = 15;
            // 
            // qua_statusLabel
            // 
            qua_statusLabel.AutoSize = true;
            qua_statusLabel.Location = new System.Drawing.Point(165, 318);
            qua_statusLabel.Name = "qua_statusLabel";
            qua_statusLabel.Size = new System.Drawing.Size(59, 13);
            qua_statusLabel.TabIndex = 16;
            qua_statusLabel.Text = "qua status:";
            // 
            // qua_statusTextBox
            // 
            this.qua_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_quartosBindingSource, "qua_status", true));
            this.qua_statusTextBox.Location = new System.Drawing.Point(300, 315);
            this.qua_statusTextBox.Name = "qua_statusTextBox";
            this.qua_statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.qua_statusTextBox.TabIndex = 17;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 462);
            this.Controls.Add(qua_numLabel);
            this.Controls.Add(this.qua_numTextBox);
            this.Controls.Add(tbl_funcionarios_func_cpfLabel);
            this.Controls.Add(this.tbl_funcionarios_func_cpfTextBox);
            this.Controls.Add(tbl_reg_estadias_id_estadiaLabel);
            this.Controls.Add(this.tbl_reg_estadias_id_estadiaTextBox);
            this.Controls.Add(tbl_cliente_cli_cpfLabel);
            this.Controls.Add(this.tbl_cliente_cli_cpfTextBox);
            this.Controls.Add(qua_andarLabel);
            this.Controls.Add(this.qua_andarTextBox);
            this.Controls.Add(qua_hosp_limitLabel);
            this.Controls.Add(this.qua_hosp_limitTextBox);
            this.Controls.Add(qua_valor_diaLabel);
            this.Controls.Add(this.qua_valor_diaTextBox);
            this.Controls.Add(qua_tipo_acomodLabel);
            this.Controls.Add(this.qua_tipo_acomodTextBox);
            this.Controls.Add(qua_statusLabel);
            this.Controls.Add(this.qua_statusTextBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_piDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_quartosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_piDataSet db_piDataSet;
        private System.Windows.Forms.BindingSource tbl_clienteBindingSource;
        private db_piDataSetTableAdapters.tbl_clienteTableAdapter tbl_clienteTableAdapter;
        private db_piDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tbl_quartosBindingSource;
        private db_piDataSetTableAdapters.tbl_quartosTableAdapter tbl_quartosTableAdapter;
        private System.Windows.Forms.TextBox qua_numTextBox;
        private System.Windows.Forms.TextBox tbl_funcionarios_func_cpfTextBox;
        private System.Windows.Forms.TextBox tbl_reg_estadias_id_estadiaTextBox;
        private System.Windows.Forms.TextBox tbl_cliente_cli_cpfTextBox;
        private System.Windows.Forms.TextBox qua_andarTextBox;
        private System.Windows.Forms.TextBox qua_hosp_limitTextBox;
        private System.Windows.Forms.TextBox qua_valor_diaTextBox;
        private System.Windows.Forms.TextBox qua_tipo_acomodTextBox;
        private System.Windows.Forms.TextBox qua_statusTextBox;
    }
}