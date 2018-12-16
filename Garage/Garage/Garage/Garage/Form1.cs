using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Create methods to call later in the programme (i at the end to distinguish between vaiables)
        public void RoutineServices(double oili, double radiatori,double filteri, double valeti, double tyrei, double catconi)
            
        {
            //Call method servcost to do the maths
            ServCost = oili + radiatori + filteri + valeti + catconi + tyrei;

            //display the answer on labeloutputlabour. Convert servcost to string so it will diaplay correctly
            labeloutputservice.Text = "€" + ServCost.ToString();
                
        }

        //method for parts
        public void Partscost(double partsi)
        {
            //calculate to show the tax is 12%
            Tax = (partsi / 100) * 12;
            
            //Call method parts to do the maths
            Parts = partsi + Tax;

            //display the answer on labeloutputparts. Convert servcost to string so it will diaplay correctly
            labeloutputParts.Text = "€" + Parts.ToString();
            labeloutputtax.Text = "€" + Tax.ToString();

        }

        //method for labour
        public void labourcost(double labouri)
        {
            //call the labour to identify hourly rate - which is 90 per hour
            Labour = labouri * 90;
            labeloutputlabour.Text = "€" + Labour.ToString();
        }

        //method for totalcost
        public void Totalcost(double ServCost, double labourcost, double Partscost)
        {
            TotalCost = ServCost + labourcost + Partscost;
            labeloutputCost.Text = "€" + TotalCost.ToString();
                 
        }

        //define variables globally - all doubles as may have decimal places

        double Oil;
        double Filter;
        double Radiator;
        double Parts;
        double Labour;
        double Valet;
        double Tyre;
        double CatCon;
        double TotalCost;
        double Tax;
        double ServCost;

               


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {

            //input values 
            if (checkBoxoil.Checked)
            {
                Oil = 50;
            }
            else
            {
                Oil = 0;
            }
            if (checkBoxFilter.Checked)
            {
                Filter = 40;
            }
            else
            {
                Filter = 0;
            }
            if (checkBoxRads.Checked)
            {
                Radiator = 200;
            }
            else
            {
                Radiator = 0;
            }
            if (checkBoxvalet.Checked)
            {
                Valet = 20;
            }
            else
            {
                Valet = 0;
            }
            if (checkBoxTyre.Checked)
            {
                Tyre = 50;
            }
            else
            {
                Tyre = 0;
            }
            if (checkBoxChange.Checked)
            {
                CatCon = 100;
            }
            else
            {
                CatCon = 0;
            }
            //call the method
            RoutineServices(Oil, Filter, Radiator, Valet, Tyre, CatCon);

            //change string value into a double
            double.TryParse(textBoxparts.Text, out Parts);
            //call the method
            Partscost(Parts);

            //change string value into a double
            double.TryParse(textBoxlabour.Text, out Labour);
            //call the method now
            labourcost(Labour);

            //change string value into a double for the total cost
            Totalcost(ServCost, Labour, Parts);
           
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            //Clear all the labels, textboxes and variables. 
            //We clear the variables, as otherwise once we clear the textboxes, they will still be there in the background
            labeloutputCost.Text = "";
            labeloutputlabour.Text = "";
            labeloutputParts.Text = "";
            labeloutputservice.Text = "";
            labeloutputtax.Text = "";
            checkBoxChange.Checked = false;
            checkBoxFilter.Checked = false;
            checkBoxoil.Checked = false;
            checkBoxRads.Checked = false;
            checkBoxTyre.Checked = false;
            checkBoxvalet.Checked = false;
            textBoxlabour.Text = "";
            textBoxparts.Text = "";
             Oil = 0;
             Filter = 0; 
             Radiator = 0;
            Parts = 0;
            Labour = 0;
            Valet = 0;
            Tyre = 0;
            CatCon = 0;
            TotalCost = 0;
            Tax = 0;
            ServCost = 0;


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
