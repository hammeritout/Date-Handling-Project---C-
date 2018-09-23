using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateDueDays_Click(object sender, System.EventArgs e)
        {

            DateTime dueDate;
            DateTime.TryParse(txtFutureDate.Text, out dueDate);

            
            // TODO: Add code to calculate the days until due date
            DateTime currentDate = DateTime.Today;
            // dueDate = DateTime.Parse(txtFutureDate);
            TimeSpan timeTillDue = dueDate.Subtract(currentDate);

            int days = timeTillDue.Days;

            MessageBox.Show("Current date: " + currentDate.ToShortDateString() + "\n\n" +
                             "Future date: " + dueDate.ToShortDateString() + "\n\n"  +
                              "Days until due: " + days.ToString()) ;

           // MessageBox.Show(days.ToString());

        }

        private void btnCalculateAge_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to calculate the age
            DateTime birthDate;
            DateTime.TryParse(txtBirthDate.Text, out birthDate);
            DateTime currentDate = DateTime.Today;
            int age;
            age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age = age - 1;
            }
                  

            MessageBox.Show("Current Date: " + currentDate.ToLongDateString() + "\n\n"
                         + "Birth Date: " + birthDate.ToLongDateString() + "\n\n"
                          + "Age: " + age.ToString() );
           
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}