namespace WinAppPairollBoards
{
    partial class FormEditExecutors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditExecutors));
            this.pictureBoxEsoft3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idexecutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmanagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pairollBoardsDataSet = new WinAppPairollBoards.PairollBoardsDataSet();
            this.executorTableAdapter = new WinAppPairollBoards.PairollBoardsDataSetTableAdapters.ExecutorTableAdapter();
            this.buttonSave1 = new System.Windows.Forms.Button();
            this.buttonBack1 = new System.Windows.Forms.Button();
            this.buttonDelete1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsoft3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.executorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pairollBoardsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEsoft3
            // 
            this.pictureBoxEsoft3.BackColor = System.Drawing.Color.White;
            this.pictureBoxEsoft3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxEsoft3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsoft3.Image")));
            this.pictureBoxEsoft3.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEsoft3.Name = "pictureBoxEsoft3";
            this.pictureBoxEsoft3.Size = new System.Drawing.Size(672, 87);
            this.pictureBoxEsoft3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEsoft3.TabIndex = 3;
            this.pictureBoxEsoft3.TabStop = false;
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
            this.idexecutorDataGridViewTextBoxColumn,
            this.iduserDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.idmanagerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.executorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 153);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idexecutorDataGridViewTextBoxColumn
            // 
            this.idexecutorDataGridViewTextBoxColumn.DataPropertyName = "id_executor";
            this.idexecutorDataGridViewTextBoxColumn.HeaderText = "id_executor";
            this.idexecutorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idexecutorDataGridViewTextBoxColumn.Name = "idexecutorDataGridViewTextBoxColumn";
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "id_user";
            this.iduserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "grade";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // idmanagerDataGridViewTextBoxColumn
            // 
            this.idmanagerDataGridViewTextBoxColumn.DataPropertyName = "id_manager";
            this.idmanagerDataGridViewTextBoxColumn.HeaderText = "id_manager";
            this.idmanagerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idmanagerDataGridViewTextBoxColumn.Name = "idmanagerDataGridViewTextBoxColumn";
            // 
            // executorBindingSource
            // 
            this.executorBindingSource.DataMember = "Executor";
            this.executorBindingSource.DataSource = this.pairollBoardsDataSet;
            // 
            // pairollBoardsDataSet
            // 
            this.pairollBoardsDataSet.DataSetName = "PairollBoardsDataSet";
            this.pairollBoardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // executorTableAdapter
            // 
            this.executorTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSave1
            // 
            this.buttonSave1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave1.Location = new System.Drawing.Point(12, 255);
            this.buttonSave1.Name = "buttonSave1";
            this.buttonSave1.Size = new System.Drawing.Size(160, 40);
            this.buttonSave1.TabIndex = 5;
            this.buttonSave1.Text = "Сохранить";
            this.buttonSave1.UseVisualStyleBackColor = true;
            this.buttonSave1.Click += new System.EventHandler(this.buttonSave1_Click);
            // 
            // buttonBack1
            // 
            this.buttonBack1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack1.Location = new System.Drawing.Point(520, 255);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(140, 40);
            this.buttonBack1.TabIndex = 6;
            this.buttonBack1.Text = "Назад";
            this.buttonBack1.UseVisualStyleBackColor = true;
            this.buttonBack1.Click += new System.EventHandler(this.buttonBack1_Click);
            // 
            // buttonDelete1
            // 
            this.buttonDelete1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete1.Location = new System.Drawing.Point(178, 255);
            this.buttonDelete1.Name = "buttonDelete1";
            this.buttonDelete1.Size = new System.Drawing.Size(228, 40);
            this.buttonDelete1.TabIndex = 7;
            this.buttonDelete1.Text = "Удалить запись";
            this.buttonDelete1.UseVisualStyleBackColor = true;
            this.buttonDelete1.Click += new System.EventHandler(this.buttonDelete1_Click);
            // 
            // FormEditExecutors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 307);
            this.Controls.Add(this.buttonDelete1);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.buttonSave1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBoxEsoft3);
            this.Name = "FormEditExecutors";
            this.Text = "Редактирование исполнителей";
            this.Load += new System.EventHandler(this.EditExecutors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsoft3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.executorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pairollBoardsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEsoft3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PairollBoardsDataSet pairollBoardsDataSet;
        private System.Windows.Forms.BindingSource executorBindingSource;
        private PairollBoardsDataSetTableAdapters.ExecutorTableAdapter executorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idexecutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmanagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSave1;
        private System.Windows.Forms.Button buttonBack1;
        private System.Windows.Forms.Button buttonDelete1;
    }
}