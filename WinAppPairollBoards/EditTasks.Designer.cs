namespace WinAppPairollBoards
{
    partial class FormEditTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditTasks));
            this.pictureBoxEsoft4 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idtaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idexecutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complexityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pairollBoardsDataSet = new WinAppPairollBoards.PairollBoardsDataSet();
            this.tasksTableAdapter = new WinAppPairollBoards.PairollBoardsDataSetTableAdapters.TasksTableAdapter();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.buttonDelete2 = new System.Windows.Forms.Button();
            this.buttonBack2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsoft4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pairollBoardsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEsoft4
            // 
            this.pictureBoxEsoft4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxEsoft4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsoft4.Image")));
            this.pictureBoxEsoft4.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEsoft4.Name = "pictureBoxEsoft4";
            this.pictureBoxEsoft4.Size = new System.Drawing.Size(1084, 87);
            this.pictureBoxEsoft4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEsoft4.TabIndex = 4;
            this.pictureBoxEsoft4.TabStop = false;
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
            this.idtaskDataGridViewTextBoxColumn,
            this.idexecutorDataGridViewTextBoxColumn,
            this.nametaskDataGridViewTextBoxColumn,
            this.complexityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.characterDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.performanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tasksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 299);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idtaskDataGridViewTextBoxColumn
            // 
            this.idtaskDataGridViewTextBoxColumn.DataPropertyName = "id_task";
            this.idtaskDataGridViewTextBoxColumn.HeaderText = "id_task";
            this.idtaskDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtaskDataGridViewTextBoxColumn.Name = "idtaskDataGridViewTextBoxColumn";
            // 
            // idexecutorDataGridViewTextBoxColumn
            // 
            this.idexecutorDataGridViewTextBoxColumn.DataPropertyName = "id_executor";
            this.idexecutorDataGridViewTextBoxColumn.HeaderText = "id_executor";
            this.idexecutorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idexecutorDataGridViewTextBoxColumn.Name = "idexecutorDataGridViewTextBoxColumn";
            // 
            // nametaskDataGridViewTextBoxColumn
            // 
            this.nametaskDataGridViewTextBoxColumn.DataPropertyName = "Name_task";
            this.nametaskDataGridViewTextBoxColumn.HeaderText = "Name_task";
            this.nametaskDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nametaskDataGridViewTextBoxColumn.Name = "nametaskDataGridViewTextBoxColumn";
            // 
            // complexityDataGridViewTextBoxColumn
            // 
            this.complexityDataGridViewTextBoxColumn.DataPropertyName = "Complexity";
            this.complexityDataGridViewTextBoxColumn.HeaderText = "Complexity";
            this.complexityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.complexityDataGridViewTextBoxColumn.Name = "complexityDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // characterDataGridViewTextBoxColumn
            // 
            this.characterDataGridViewTextBoxColumn.DataPropertyName = "Character";
            this.characterDataGridViewTextBoxColumn.HeaderText = "Character";
            this.characterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.characterDataGridViewTextBoxColumn.Name = "characterDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // performanceDataGridViewTextBoxColumn
            // 
            this.performanceDataGridViewTextBoxColumn.DataPropertyName = "Performance";
            this.performanceDataGridViewTextBoxColumn.HeaderText = "Performance";
            this.performanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.performanceDataGridViewTextBoxColumn.Name = "performanceDataGridViewTextBoxColumn";
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.pairollBoardsDataSet;
            // 
            // pairollBoardsDataSet
            // 
            this.pairollBoardsDataSet.DataSetName = "PairollBoardsDataSet";
            this.pairollBoardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSave2
            // 
            this.buttonSave2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave2.Location = new System.Drawing.Point(12, 398);
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.Size = new System.Drawing.Size(160, 40);
            this.buttonSave2.TabIndex = 6;
            this.buttonSave2.Text = "Сохранить";
            this.buttonSave2.UseVisualStyleBackColor = true;
            this.buttonSave2.Click += new System.EventHandler(this.buttonSave2_Click);
            // 
            // buttonDelete2
            // 
            this.buttonDelete2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete2.Location = new System.Drawing.Point(178, 398);
            this.buttonDelete2.Name = "buttonDelete2";
            this.buttonDelete2.Size = new System.Drawing.Size(228, 40);
            this.buttonDelete2.TabIndex = 9;
            this.buttonDelete2.Text = "Удалить запись";
            this.buttonDelete2.UseVisualStyleBackColor = true;
            this.buttonDelete2.Click += new System.EventHandler(this.buttonDelete2_Click);
            // 
            // buttonBack2
            // 
            this.buttonBack2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack2.Location = new System.Drawing.Point(932, 398);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(140, 40);
            this.buttonBack2.TabIndex = 8;
            this.buttonBack2.Text = "Назад";
            this.buttonBack2.UseVisualStyleBackColor = true;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // FormEditTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.buttonDelete2);
            this.Controls.Add(this.buttonBack2);
            this.Controls.Add(this.buttonSave2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBoxEsoft4);
            this.Name = "FormEditTasks";
            this.Text = "Редактирование задач";
            this.Load += new System.EventHandler(this.FormEditTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsoft4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pairollBoardsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEsoft4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PairollBoardsDataSet pairollBoardsDataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private PairollBoardsDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idexecutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complexityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn performanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSave2;
        private System.Windows.Forms.Button buttonDelete2;
        private System.Windows.Forms.Button buttonBack2;
    }
}