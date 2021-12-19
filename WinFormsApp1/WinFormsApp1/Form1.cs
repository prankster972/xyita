using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       

        public void button1_Click(object sender, System.EventArgs e)
        {
            var PL1 = UInt32.MinValue;
            MinU.Text = PL1.ToString();
            var PL2 = Byte.MinValue;
            MinB.Text = PL2.ToString();
            var PL3 = Int32.MinValue;
            MinI.Text = PL3.ToString();

            var PH1 = UInt32.MaxValue;
            MaxU.Text = PH1.ToString();
            var PH2 = Byte.MaxValue;
            MaxB.Text = PH2.ToString();
            var PH3 = Int32.MaxValue;
            MaxI.Text = PH3.ToString();
            
        }

        protected void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string First = FirstNum.Text;
            string Second = SecondNum.Text;
            string Symb = SymbOper.Text;
            string F_S1 = "";
            int F_S = 0;

            switch (Symb)
                {
                case "+":

                    AnsL.Text = (F_S = int.Parse(First) + int.Parse(Second)).ToString(); break;

                case "-":                  
    
                    AnsL.Text = (F_S = int.Parse(First) - int.Parse(Second)).ToString(); break;

                case "*":

                    AnsL.Text = (F_S = int.Parse(First) * int.Parse(Second)).ToString(); break;

                case "/":

                    AnsL.Text = (F_S = int.Parse(First) / int.Parse(Second)).ToString(); break;

                case "&":   
                    
                    F_S1 = (Math.Max(int.Parse(First), int.Parse(Second))).ToString();
                    AnsL.Text = F_S1.PadLeft(3, '&'); break;

                case "!":       
                    F_S1 = (Math.Min(int.Parse(First), int.Parse(Second))).ToString();
                    AnsL.Text = F_S1.PadLeft(2, '!'); break;
            }
        }
        public void button2_Click(object sender, System.EventArgs e)
        {
            var PD1 = Double.MinValue;
            DMT.Text = PD1.ToString();
            var PD2 = Double.MaxValue;
            D_M.Text = PD2.ToString();           
        }
    }
}