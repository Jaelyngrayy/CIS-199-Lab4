//Grading ID: R5560
//Lab 4
//Due Date: February 21, 2021
//Course Section: CIS 199-01
/*Description: This program tells if a student got into a university based on their High School GPA and their admission test scores when they click the results button.
It also counts how many applications have been accepted and rejected while the program was running. This is done in a GUI */
using System;
using static System.Console;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class admissionCheck : Form
    {
        private int accepted = 0; //defined counter variable for how many accepted applications there have been
        private int rejected = 0; //defined counter variable for how many rejected applications there have been
        public admissionCheck()
        {
            InitializeComponent();
        }
        //This event hander runs a program that whenever the results button is clicked, it tells the user if their applicated has been accepted or rejected based on the GPA and test score they entered.
        //If their gpa and test scores fall between a specific range, they are accpted and it displayed "Accepted". If not, it displayed "Rejected". 
        //Program also has a counter that counts how many applications have been accepted or rejected so far. 
        private void decisionButton_Click(object sender, EventArgs e)
        {
            float gpa; //User inputted GPA value. Float since GPA's are usually only 2-3 digits
            uint testScore; //User inputted test score value. uint because this integer will never be negative

            //If statement Try.Parse that makes sure inputted value are valid for both GPA and testScores. Also makes sure that the gpa and testscore are in the valid range of inputs.
            //If they are, program runs as normal. If not, the program displays an error message that tells user to input valid values.
            if (float.TryParse(GPAtxt.Text, out gpa) && (uint.TryParse(testScoretxt.Text, out testScore) && (gpa >= 0 && gpa <= 4) && (testScore >= 0 && testScore <= 100)))
            {
                if(gpa >= 3.0 && testScore >= 60) //if statement for a specific range of gpa and test score values
                {
                    decisionOutput.Text = "Accepted"; //displays accepted if true
                    ++accepted; //adds 1 to accepted variable
                    acceptedOutputLbl.Text = $"{accepted}"; //output variable into label
                }
                else if (gpa < 3.0 && testScore >= 80) //same as before but for a different range of values
                {
                    decisionOutput.Text = "Accepted"; //^^
                    ++accepted; //^^
                    acceptedOutputLbl.Text = $"{accepted}"; //^^
                }
                else //else statement that says non of the other two statements are true, run this code
                {
                    decisionOutput.Text = "Rejected"; //displays rejected if true
                    ++rejected; // adds 1 to rejected variable
                    rejectedOutputLbl.Text = $"{rejected}"; //outputs variable into label
                }
            }
            else //if the inputted values are not valid values, this runs
            {
                MessageBox.Show("Enter a valid GPA and test score! (GPA = 0.0 - 4.0; Test Scores = 0 - 100!!)"); //Displays error box telling user to input valid values
            }
        }
    }
}
