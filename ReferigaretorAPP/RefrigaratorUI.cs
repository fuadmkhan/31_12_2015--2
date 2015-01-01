using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ReferigaretorAPP
{
    public partial class RefrigaratorUI : Form
    {
        public RefrigaratorUI()
        {
            InitializeComponent();
        }

        Refrigarator aRefrigarator =new Refrigarator();
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Double weight = Convert.ToInt32(textBoxMax.Text);

            aRefrigarator.Maximum = weight;
            aRefrigarator.Current = 0;

            textBoxCurrent.Text = aRefrigarator.Current.ToString();
            textBoxRemaining.Text = aRefrigarator.remaining().ToString();
            
        }

        private void buttonInputSave_Click(object sender, EventArgs e)
        {

            Double items = Convert.ToInt32(textBoxItems.Text);
            Double weight = Convert.ToInt32(textBoxWeight.Text);

            aRefrigarator.add(items*weight);

            textBoxCurrent.Text = aRefrigarator.Current.ToString();
            textBoxRemaining.Text = aRefrigarator.remaining().ToString();

        }


    }
}
