using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisturbanceApp
{
    public partial class ResultForm : Form
    {
        public ResultForm(double percent)
        {
            InitializeComponent();
            ResultLbl.Text = percent.ToString() + "%";
        }
    }
}
