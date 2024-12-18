using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // Create 2 arrays to hold 10 values each
            Random randGen = new Random();

            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] reverseArray = new int[10];


            //1. Generate random values for BOTH pre-created arrays
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = randGen.Next(0, 10);
                array2[i] = randGen.Next(0, 10);
            }


            //2. Display array 1
            array1Output.Text = "";
            for (int i = 0; i < array1.Length; i++)
            {
                array1Output.Text += array1[i] + " ";
            }


            //3. Display array 2
            array2Output.Text = "";
            for (int i = 0; i < array2.Length; i++)
            {
                array2Output.Text += array2[i] + " ";
            }


            //4. Display array 1 in reverse order
            for (int i = 0; i < array1.Length; i++)
            {
                reverseArray[i] = array1[array1.Length - 1 - i];
            }

            reverseOutput.Text = "";
            for (int i = 0; i < reverseArray.Length; i++)
            {
                reverseOutput.Text += reverseArray[i] + " ";
            }


            //5. Determine and display the largest value in array 1          
            int max = 0;
            maxOutput.Text = array1.Max() + " ";


            //6. Determine and display the average of all values in array 1
            double sum = 0;
            double average = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];
            }
            average = sum / array1.Length;
            averageOutput.Text = average + " ";

            //7. Determine and display the sum of all even values in array 1
            int sumEven = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    sumEven += array1[i];
                }
            }
            evenOutput.Text = sumEven + " ";

            //8. Determine and display the number of 3s in array 1
            int numThrees = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == 3)
                {
                    numThrees++;
                }
            }
            threeOutput.Text = numThrees + " ";

            //9. Determine and display how many matching numbers in matching positions between the 2 arrays there are
            int samePosition = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    samePosition++;
                }
            }
            matchOutput.Text = samePosition + " ";

            // ----------------------
            // ##### ENRICHMENT #####
            // ----------------------


            //1. Determine and display at what index is the first 0 in array 1, (show "null" if no 0 exists)
            bool zeroFound = false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == 0)
                {
                    zeroOutput.Text = i + " ";
                    zeroFound = true;
                    break;
                }
            }
            if (!zeroFound)
            {
                zeroOutput.Text = "null";
            }


            //2. swap and display all values between array1 and array2
            int[] array3 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i];
                array1[i] = array2[i];
                array2[i] = array3[i];

                swap1Output.Text += array1[i] + " ";
                swap2Output.Text += array2[i] + " ";
            }
            swap1Output.Text = " ";
            swap2Output.Text = " ";
        }
    }
}
