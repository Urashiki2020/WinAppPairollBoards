namespace WinAppPairollBoards
{
    partial class FormExecutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExecutor));
            this.pictureBoxEsoft2 = new System.Windows.Forms.PictureBox();
            this.buttonTasks = new System.Windows.Forms.Button();
            this.buttonExit2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsoft2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEsoft2
            // 
            this.pictureBoxEsoft2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxEsoft2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsoft2.Image")));
            this.pictureBoxEsoft2.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEsoft2.Name = "pictureBoxEsoft2";
            this.pictureBoxEsoft2.Size = new System.Drawing.Size(583, 87);
            this.pictureBoxEsoft2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEsoft2.TabIndex = 0;
            this.pictureBoxEsoft2.TabStop = false;
            // 
            // buttonTasks
            // 
            this.buttonTasks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonTasks.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTasks.Location = new System.Drawing.Point(128, 190);
            this.buttonTasks.Name = "buttonTasks";
            this.buttonTasks.Size = new System.Drawing.Size(304, 48);
            this.buttonTasks.TabIndex = 1;
            this.buttonTasks.Text = "Задачи";
            this.buttonTasks.UseVisualStyleBackColor = true;
            // 
            // buttonExit2
            // 
            this.buttonExit2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonExit2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit2.Location = new System.Drawing.Point(460, 344);
            this.buttonExit2.Name = "buttonExit2";
            this.buttonExit2.Size = new System.Drawing.Size(111, 44);
            this.buttonExit2.TabIndex = 2;
            this.buttonExit2.Text = "Выход";
            this.buttonExit2.UseVisualStyleBackColor = true;
            this.buttonExit2.Click += new System.EventHandler(this.buttonExit2_Click);
            // 
            // FormExecutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 400);
            this.Controls.Add(this.buttonExit2);
            this.Controls.Add(this.buttonTasks);
            this.Controls.Add(this.pictureBoxEsoft2);
            this.Name = "FormExecutor";
            this.Text = "Рабочее окно исполнителя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsoft2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEsoft2;
        private System.Windows.Forms.Button buttonTasks;
        private System.Windows.Forms.Button buttonExit2;
    }
}