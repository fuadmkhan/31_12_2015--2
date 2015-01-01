using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferigaretorAPP
{
    class Refrigarator
    {
        private double maximum = 0;
        private double current = 0;

        public double Maximum
        {
            set
            {
                maximum = value;
            }

            get {return maximum;}
        }

        public double Current
        {
            set
            {
                current = value;
            }

            get { return current; }
        }

        public double remaining()
        {
            return maximum - current;
        }
        
        public void add(double totalWeight)
        {

            if (limit(totalWeight))
                current += totalWeight;
            else MessageBox.Show("Sorry the Upper Limit is excided");
        }

        private bool limit(double presentWeight)
        {
            if (maximum >= (current + presentWeight)) return true;
            else return false;
        }


    }
}
