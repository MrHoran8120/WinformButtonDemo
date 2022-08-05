using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5  
{
    public partial class Form1 : Form
    {
        // note that you could also make the list an array if you prefer. 
        List<Button> mybuttons = new List<Button>();
        public Form1()
        {

            InitializeComponent();

            mybuttons.Add(button1);
            mybuttons.Add(button2);
            mybuttons.Add(button3);

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Button button in mybuttons)
            {
                if (button.BackColor == Color.Aqua)
                    button.BackColor = Color.GreenYellow;
                else
                    button.BackColor = Color.Aqua;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach(Button button in mybuttons)
            {
                Point p = button.Location;
                p.Y = p.Y - 10;
                button.Location = p;
            }
        }
    }
}
