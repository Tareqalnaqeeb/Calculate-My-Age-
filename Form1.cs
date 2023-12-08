using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFirstClassLibrary;

namespace Calculate_My_Age
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct StAge
        {
            public int Year;
            public int Months;
            public int Weeks;

            public int Days;
            public int Hours;
            public int Moinutes;
            public int Seconds;
        }


        int NumOfDays( DateTimePicker Date)
        {

            int Days = 1;
            while (
               dateTimePicker1.Value.AddDays(Days).Date.ToString() != DateTime.Now.Date.ToString()) 
            {
                Days++;
            }

            return Days;
        }

        int NumOfHoures(int Days)
        {
            return Days * 24;
        }
        int NumOfYears(int Days)

        {
            return Days  / 356;
        }

        int NumOfMonths(int Year)
        {
            return Year   * 12   ;
        }

        int NumOfWeeks(int Months)
        {
            return Months * 4;
        }

       
        
        int NumOfMinutes(int Hours)
        {
            return Hours *60;

        }

        int NumOfSeconds(int Minutes)
        {
            return Minutes* 60;
        }

        StAge CalcaluteAged(DateTimePicker Date)
        {
            StAge Age;
            Age.Days = NumOfDays(Date);
            Age.Year = NumOfYears(Age.Days);
            Age.Months = NumOfMonths(Age.Year);
            Age.Weeks = NumOfWeeks(Age.Months);
            Age.Hours = NumOfHoures(Age.Days);
            Age.Moinutes = NumOfMinutes(Age.Hours);
            Age.Seconds = NumOfSeconds(Age.Moinutes);

            return Age;

          
        }
       

        void GetBrithDate( )
        {
            StAge age = CalcaluteAged(dateTimePicker1);

            lbAgeInDays.Text = age.Days.ToString();
            lbAgeInHours.Text = age.Hours.ToString();
            lbAgeInMinutes.Text = age.Moinutes.ToString();
            lbAgeInMonths.Text = age.Months.ToString();
            lbAgeInSeconds.Text = age.Seconds.ToString();
            lbAgeInWeeks.Text = age.Weeks.ToString();
            lbAgeInYear.Text = age.Year.ToString();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            GetBrithDate();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsMyMath myMath = new ClsMyMath();

            MessageBox.Show(myMath.Sum(10, 20).ToString());
           
        }
    }
}
