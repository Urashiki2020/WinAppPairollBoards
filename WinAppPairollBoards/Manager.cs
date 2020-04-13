﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppPairollBoards
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
            
        }

        private void FormManager_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit1_Click(object sender, EventArgs e)
        {
            Form formAuthorization = new FormAuthorization();
            formAuthorization.ShowDialog();
            this.Hide();
        }

        private void buttonCoefficients_Click(object sender, EventArgs e)
        {
            Form formEditCoefficients = new FormEditCoefficients();
            formEditCoefficients.ShowDialog();
            this.Hide();
        }

        private void buttonExecutors_Click(object sender, EventArgs e)
        {
            Form formEditExecutors = new FormEditExecutors();
            formEditExecutors.ShowDialog();
            this.Hide();
        }
    }
}
