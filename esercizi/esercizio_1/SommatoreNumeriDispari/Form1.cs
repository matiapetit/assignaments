using System.Runtime.CompilerServices;

namespace SommatoreNumeriDispari {
    public partial class Form1 : Form {

        //default sum value
        string def = "0";

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            SetDefaultValues();
        }

        private void SetDefaultValues() {
            lbSomma.Text = def;
            nmMax.Value = nmMax.Maximum;
            nmMin.Value = nmMin.Minimum;
        }

        private void btCalculate_Click(object sender, EventArgs e) {
            
            decimal sum = 0;
            
            try {
            
                if (IsValidRange(nmMin.Value, nmMax.Value)) {
                
                    MessageBox.Show($"The program will calculate the sum of the odd numbers in the entered range {nmMin.Value} and {nmMax.Value}.");
                    
                    sum = DoCalculateOddSum(nmMin.Value, nmMax.Value);
                    lbSomma.Text = Convert.ToString(sum);
                
                } else {
                    MessageBox.Show("Sorry! But apparently the maximum limit is less than the minimum limit. Correct and try again!");
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        //method to check is the entered range is valid or not
        private bool IsValidRange(decimal min, decimal max) {
            return max > min;
        }

        //method to add the odd numbers
        private decimal DoCalculateOddSum(decimal min, decimal max) {
            
            decimal sum = 0;
            
            for (decimal i = min; i <= max; i++) {
                if (IsOddNumber(i)) {
                    sum += i;
                }
            }
            
            return sum;
        }

        //method to verify is the number is odd or not
        private bool IsOddNumber(decimal num) {
            return num % 2 != 0;
        }
    }
}