namespace WinAppPairollBoards
{
    partial class FormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.pictureBoxEsoft1 = new System.Windows.Forms.PictureBox();
            this.buttonExecutors = new System.Windows.Forms.Button();
            this.buttonCoefficients = new System.Windows.Forms.Button();
            this.buttonExit1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsoft1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEsoft1
            // 
            this.pictureBoxEsoft1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxEsoft1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsoft1.Image")));
            this.pictureBoxEsoft1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEsoft1.Name = "pictureBoxEsoft1";
            this.pictureBoxEsoft1.Size = new System.Drawing.Size(583, 87);
            this.pictureBoxEsoft1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEsoft1.TabIndex = 0;
            this.pictureBoxEsoft1.TabStop = false;
            // 
            // buttonExecutors
            // 
            this.buttonExecutors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonExecutors.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExecutors.Location = new System.Drawing.Point(138, 155);
            this.buttonExecutors.Name = "buttonExecutors";
            this.buttonExecutors.Size = new System.Drawing.Size(304, 48);
            this.buttonExecutors.TabIndex = 1;
            this.buttonExecutors.Text = "Исполнители";
            this.buttonExecutors.UseVisualStyleBackColor = true;
            this.buttonExecutors.Click += new System.EventHandler(this.buttonExecutors_Click);
            // 
            // buttonCoefficients
            // 
            this.buttonCoefficients.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCoefficients.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCoefficients.Location = new System.Drawing.Point(138, 209);
            this.buttonCoefficients.Name = "buttonCoefficients";
            this.buttonCoefficients.Size = new System.Drawing.Size(304, 48);
            this.buttonCoefficients.TabIndex = 2;
            this.buttonCoefficients.Text = "Коэффициенты";
            this.buttonCoefficients.UseVisualStyleBackColor = true;
            this.buttonCoefficients.Click += new System.EventHandler(this.buttonCoefficients_Click);
            // 
            // buttonExit1
            // 
            this.buttonExit1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonExit1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit1.Location = new System.Drawing.Point(460, 344);
            this.buttonExit1.Name = "buttonExit1";
            this.buttonExit1.Size = new System.Drawing.Size(111, 44);
            this.buttonExit1.TabIndex = 3;
            this.buttonExit1.Text = "Выход";
            this.buttonExit1.UseVisualStyleBackColor = true;
            this.buttonExit1.Click += new System.EventHandler(this.buttonExit1_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 400);
            this.Controls.Add(this.buttonExit1);
            this.Controls.Add(this.buttonCoefficients);
            this.Controls.Add(this.buttonExecutors);
            this.Controls.Add(this.pictureBoxEsoft1);
            this.Name = "FormManager";
            this.Text = "Рабочее окно менеджера";
            this.Load += new System.EventHandler(this.FormManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsoft1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEsoft1;
        private System.Windows.Forms.Button buttonExecutors;
        private System.Windows.Forms.Button buttonCoefficients;
        private System.Windows.Forms.Button buttonExit1;
    }
}