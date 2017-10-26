using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Win_Calculator
{
    public partial class Form1 : Form
    {
        //Define variables
        Double value = 0;
        String operation = "";
        Boolean operationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        /* 
         * This method button_Click name was created in the Solution Explorer Properties Event Action item Click.
         * This method button_Click will be invoked when any of the following buttons of properties decimal point "."
         * , or any button digits "0-9" are clicked.
         * When any of the buttons are clicked the the value of the button corresponding number or decimal point
         * will return to display in the result text box on the form.
         */ 
        private void button_Click(object sender, EventArgs e)
        {
            if(result.Text == "0" || operationPressed == true)
            {
                result.Clear();
            }

            operationPressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        //This method button16 corresponds to the CE button on the form and will 
        //return a zero on the text box display 
        private void button16_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        /* 
         * This method operator_Click name was created in the Solution Explorer Properties Event Action item Click.
         * This method operator_Click will be invoked when any of the following buttons of properties *, /, -, or +
         * are clicked.
         * When any of the buttons are clicked the value of the button corresponding arithmetic operator
         * will be added with the value from text box and saved into the equation text to be displayed in 
         * the result text box.
         */
        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operationPressed = true;
            equation.Text = value + " " + operation;
        }

        /*
         * This method button19_Click corresponds to the equal sign on the form. Once invoke
         * the operation will be evaluated to determine the proper arithmetic process to 
         * continue and return the results in the result text box of form.
         */
        private void button19_Click(object sender, EventArgs e)
        {
            equation.Text = "";

            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;

            }//end switch
           
        }
        
        //Clear all and reset method for the C button on the form
        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }


        

    }
}
