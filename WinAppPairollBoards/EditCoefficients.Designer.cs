namespace WinAppPairollBoards
{
    partial class FormEditCoefficients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditCoefficients));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcoefficientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juniorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seniorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcomplexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coefficientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pairollBoardsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pairollBoardsDataSet = new WinAppPairollBoards.PairollBoardsDataSet();
            this.coefficientTableAdapter = new WinAppPairollBoards.PairollBoardsDataSetTableAdapters.CoefficientTableAdapter();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBoxEsoft2 = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pairollBoardsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pairollBoardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsoft2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcoefficientDataGridViewTextBoxColumn,
            this.juniorDataGridViewTextBoxColumn,
            this.middleDataGridViewTextBoxColumn,
            this.seniorDataGridViewTextBoxColumn,
            this.kapDataGridViewTextBoxColumn,
            this.kuoDataGridViewTextBoxColumn,
            this.ktosDataGridViewTextBoxColumn,
            this.ktimeDataGridViewTextBoxColumn,
            this.kcomplexDataGridViewTextBoxColumn,
            this.kmoneyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coefficientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(780, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idcoefficientDataGridViewTextBoxColumn
            // 
            this.idcoefficientDataGridViewTextBoxColumn.DataPropertyName = "id_coefficient";
            this.idcoefficientDataGridViewTextBoxColumn.HeaderText = "№ коэффициента";
            this.idcoefficientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcoefficientDataGridViewTextBoxColumn.Name = "idcoefficientDataGridViewTextBoxColumn";
            // 
            // juniorDataGridViewTextBoxColumn
            // 
            this.juniorDataGridViewTextBoxColumn.DataPropertyName = "Junior";
            this.juniorDataGridViewTextBoxColumn.HeaderText = "Junior (мин.ЗП)";
            this.juniorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.juniorDataGridViewTextBoxColumn.Name = "juniorDataGridViewTextBoxColumn";
            // 
            // middleDataGridViewTextBoxColumn
            // 
            this.middleDataGridViewTextBoxColumn.DataPropertyName = "Middle";
            this.middleDataGridViewTextBoxColumn.HeaderText = "Middle (мин.ЗП)";
            this.middleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.middleDataGridViewTextBoxColumn.Name = "middleDataGridViewTextBoxColumn";
            // 
            // seniorDataGridViewTextBoxColumn
            // 
            this.seniorDataGridViewTextBoxColumn.DataPropertyName = "Senior";
            this.seniorDataGridViewTextBoxColumn.HeaderText = "Senior (мин.ЗП)";
            this.seniorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seniorDataGridViewTextBoxColumn.Name = "seniorDataGridViewTextBoxColumn";
            // 
            // kapDataGridViewTextBoxColumn
            // 
            this.kapDataGridViewTextBoxColumn.DataPropertyName = "K_a_p";
            this.kapDataGridViewTextBoxColumn.HeaderText = "K_a_p";
            this.kapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kapDataGridViewTextBoxColumn.Name = "kapDataGridViewTextBoxColumn";
            // 
            // kuoDataGridViewTextBoxColumn
            // 
            this.kuoDataGridViewTextBoxColumn.DataPropertyName = "K_u_o";
            this.kuoDataGridViewTextBoxColumn.HeaderText = "K_u_o";
            this.kuoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kuoDataGridViewTextBoxColumn.Name = "kuoDataGridViewTextBoxColumn";
            // 
            // ktosDataGridViewTextBoxColumn
            // 
            this.ktosDataGridViewTextBoxColumn.DataPropertyName = "K_t_o_s";
            this.ktosDataGridViewTextBoxColumn.HeaderText = "K_t_o_s";
            this.ktosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ktosDataGridViewTextBoxColumn.Name = "ktosDataGridViewTextBoxColumn";
            // 
            // ktimeDataGridViewTextBoxColumn
            // 
            this.ktimeDataGridViewTextBoxColumn.DataPropertyName = "K_time";
            this.ktimeDataGridViewTextBoxColumn.HeaderText = "K_time";
            this.ktimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ktimeDataGridViewTextBoxColumn.Name = "ktimeDataGridViewTextBoxColumn";
            // 
            // kcomplexDataGridViewTextBoxColumn
            // 
            this.kcomplexDataGridViewTextBoxColumn.DataPropertyName = "K_complex";
            this.kcomplexDataGridViewTextBoxColumn.HeaderText = "K_complex";
            this.kcomplexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kcomplexDataGridViewTextBoxColumn.Name = "kcomplexDataGridViewTextBoxColumn";
            // 
            // kmoneyDataGridViewTextBoxColumn
            // 
            this.kmoneyDataGridViewTextBoxColumn.DataPropertyName = "K_money";
            this.kmoneyDataGridViewTextBoxColumn.HeaderText = "K_money";
            this.kmoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kmoneyDataGridViewTextBoxColumn.Name = "kmoneyDataGridViewTextBoxColumn";
            // 
            // coefficientBindingSource
            // 
            this.coefficientBindingSource.DataMember = "Coefficient";
            this.coefficientBindingSource.DataSource = this.pairollBoardsDataSetBindingSource;
            // 
            // pairollBoardsDataSetBindingSource
            // 
            this.pairollBoardsDataSetBindingSource.DataSource = this.pairollBoardsDataSet;
            this.pairollBoardsDataSetBindingSource.Position = 0;
            // 
            // pairollBoardsDataSet
            // 
            this.pairollBoardsDataSet.DataSetName = "PairollBoardsDataSet";
            this.pairollBoardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coefficientTableAdapter
            // 
            this.coefficientTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(12, 399);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(160, 40);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBoxEsoft2
            // 
            this.pictureBoxEsoft2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxEsoft2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsoft2.Image")));
            this.pictureBoxEsoft2.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEsoft2.Name = "pictureBoxEsoft2";
            this.pictureBoxEsoft2.Size = new System.Drawing.Size(802, 87);
            this.pictureBoxEsoft2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEsoft2.TabIndex = 2;
            this.pictureBoxEsoft2.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(650, 399);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 40);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(178, 399);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(228, 40);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormEditCoefficients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 443);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxEsoft2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEditCoefficients";
            this.Text = "Редактирование коэффициентов";
            this.Load += new System.EventHandler(this.FormEditCoefficients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pairollBoardsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pairollBoardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsoft2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pairollBoardsDataSetBindingSource;
        private PairollBoardsDataSet pairollBoardsDataSet;
        private System.Windows.Forms.BindingSource coefficientBindingSource;
        private PairollBoardsDataSetTableAdapters.CoefficientTableAdapter coefficientTableAdapter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBoxEsoft2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcoefficientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juniorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seniorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kcomplexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDelete;
    }
}