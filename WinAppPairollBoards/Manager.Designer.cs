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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExecutors = new System.Windows.Forms.Button();
            this.buttonCoefficients = new System.Windows.Forms.Button();
            this.buttonExit1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExecutors
            // 
            this.buttonExecutors.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExecutors.Location = new System.Drawing.Point(138, 155);
            this.buttonExecutors.Name = "buttonExecutors";
            this.buttonExecutors.Size = new System.Drawing.Size(304, 48);
            this.buttonExecutors.TabIndex = 1;
            this.buttonExecutors.Text = "Исполнители";
            this.buttonExecutors.UseVisualStyleBackColor = true;
            // 
            // buttonCoefficients
            // 
            this.buttonCoefficients.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCoefficients.Location = new System.Drawing.Point(138, 209);
            this.buttonCoefficients.Name = "buttonCoefficients";
            this.buttonCoefficients.Size = new System.Drawing.Size(304, 48);
            this.buttonCoefficients.TabIndex = 2;
            this.buttonCoefficients.Text = "Коэффициенты";
            this.buttonCoefficients.UseVisualStyleBackColor = true;
            // 
            // buttonExit1
            // 
            this.buttonExit1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit1.Location = new System.Drawing.Point(441, 340);
            this.buttonExit1.Name = "buttonExit1";
            this.buttonExit1.Size = new System.Drawing.Size(111, 44);
            this.buttonExit1.TabIndex = 3;
            this.buttonExit1.Text = "Выход";
            this.buttonExit1.UseVisualStyleBackColor = true;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 400);
            this.Controls.Add(this.buttonExit1);
            this.Controls.Add(this.buttonCoefficients);
            this.Controls.Add(this.buttonExecutors);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormManager";
            this.Text = "Рабочее окно менеджера";
            this.Load += new System.EventHandler(this.FormManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExecutors;
        private System.Windows.Forms.Button buttonCoefficients;
        private System.Windows.Forms.Button buttonExit1;
    }
}