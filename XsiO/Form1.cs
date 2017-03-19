using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XsiO
{
    public partial class Form1 : Form
    {
        bool turn = true; //true x=turn; false=y turn
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ne jucam X si 0 !!! :)", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (turn)
                but.Text = "X";
            else
                but.Text = "O";
            turn = !turn;
            but.Enabled = false;
            turn_count++;
            DacaEsteCastigator();
        }

        private void DacaEsteCastigator()
        {
            bool este_un_castigator = false;
            //Verificare pe orizontala

            if ((A1.Text == A2.Text)&& (A2.Text == A3.Text)&&(!A1.Enabled)){
                este_un_castigator = true;
            }
           else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                este_un_castigator = true;
            }
          else  if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                este_un_castigator = true;
            }

            //Verificare pe Verticala

          else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                este_un_castigator = true; 
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                este_un_castigator = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                este_un_castigator = true;
            }
            //Verificare pe diagonala

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                este_un_castigator = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                este_un_castigator = true;
            }
            

            if (este_un_castigator)
            {
                dezactiveazaButoane();
                string castigator = "";
                if (turn)
                    castigator = "O";
                else
                    castigator = "X";
                MessageBox.Show("Castigator este: "+castigator,"CASTIGATOR!!!");
                
            }//end if
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Este Remiza", "Remiza");
                }
            }

        }//end verificare castigator

        private void dezactiveazaButoane()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch
            {

            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {

           
                 foreach(Control c in Controls)
                 {
                    Button b = (Button)c;
                     b.Enabled = true;
                     b.Text = "";
                 }
            }
            catch
            {

            }
        }
    }

}
