// Form1.cs
/* Task 7
Data about unemployed people in two cities is stored in two separate text files.
First line in text file contains the name of stock exchange. Other lines store 
the following data about unemployed people: name and surname, profession, gender,
work experience in years, preferred working time per day in hours, 
preferred salary (wage).
1. Employer selects employees with no less than m years working experience and 
those who agree to work for salary not less than s. Values for m and s are entered
from keyboard. Calculate how many employees are found who satisfy the criteria 
for both stock exchanges.
2. Create a container of unemployed people from both stock exchanges who satisfy 
employer requirements (result container).
3. Sort result container by work experience in descending order 
and profession alphabetically.
4. Remove unemployed people from result container who require a bigger salary than 
employer can pay (P). Value of P is specified from keyboard.
5. Insert data to result container of unemployed people who satisfy employer 
requirements. Data of result container must remain sorted (extra sorting methods 
should not be implemented, existing sorting methods should not be called again). 
Data of unemployed people to be inserted is prepared in a separate text file 
NewEmployees.txt (first line holds the name of stock exchange).
*/

using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace L1
{
    public partial class Form1 : Form
    {
        string datafile; // Data file
        string resultFile; // Result file

        ArrayOfEmployees employees1; // Employees from 1st stock exchange
        string stockName1; // 1st stock name

        ArrayOfEmployees employees2; // Employees from 2nd stock exchange
        string stockName2; // 2nd stock name
        // Employees who satisfy requirements
        ArrayOfEmployees satisfyRequirements = new ArrayOfEmployees();

        public Form1()
        {
            InitializeComponent();
            if (File.Exists(resultFile))
            {
                File.Delete(resultFile);
            }
            ToggleControls();
        }

        /// <summary>
        /// Method for reading data from separate files
        /// </summary>
        /// <param name="filename"> Name of file </param>
        /// <param name="stockName"> Stock name </param>
        /// <returns> Array of employees </returns>
        private ArrayOfEmployees ReadData
            (string filename, ref string stockName)
        {
            string line; // Line in file
            // Array of employees
            ArrayOfEmployees employees = new ArrayOfEmployees();
            using (StreamReader reader = new StreamReader(filename))
            {
                line = reader.ReadLine();
                stockName = line;
                while ((line = reader.ReadLine()) != null)
                {
                    Gender gender = new Gender();
                    // Line in array 
                    string[] parts = line.Split(';');
                    // Name and surname
                    string nameSurname = parts[0];
                    // Profession
                    string profession = parts[1];
                    // Enumerator
                    bool result = Enum.TryParse(parts[2], out gender);
                    // Work experience
                    int workExperience = Convert.ToInt32(parts[3]);
                    // Working time
                    int workingTime = Convert.ToInt32(parts[4]);
                    // Preferred salary
                    int preferredSalary = Convert.ToInt16(parts[5]);
                    // New employee
                    Employee employee = new Employee(nameSurname,
                        profession, gender, workExperience,
                        workingTime, preferredSalary);
                    employees.AddEmployee(employee);
                }
            }
            return employees;
        }

        /// <summary>
        /// Handles the KeyPress event for the experience input textbox
        /// </summary>
        /// <param name="sender"> The source of the event</param>
        /// <param name="e"> Key press event data</param>
        private void TBExperience_KeyPress(object sender,
                    KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Handles the KeyPress event for the experience input textbox
        /// </summary>
        /// <param name="sender"> The source of the event</param>
        /// <param name="e"> Key press event data</param>
        private void TBSalary_KeyPress(object sender,
                    KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Enables or disables specific UI controls
        /// </summary>
        /// <param name="enabled"> Specifies whether the controls 
        /// should be enabled (default is false) </param>
        private void ToggleControls(bool enabled = false)
        {
            tbExperience.Enabled = enabled;
            tbSalary1.Enabled = enabled;
            tbSalary2.Enabled = enabled;
            CalculateToolStripMenuItem.Enabled = enabled;
            dsToolStripMenuItem.Enabled = enabled;
            sortContainerToolStripMenuItem.Enabled = enabled;
            RemoveToolStripMenuItem.Enabled = enabled;
            InsertToolStripMenuItem.Enabled = enabled;
            saveToolStripMenuItem.Enabled = enabled;
        }

        /// <summary>
        /// Method for displaying data to GUI app
        /// </summary>
        /// <param name="header"> Header </param>
        /// <param name="LB"> List box in GUI app </param>
        /// <param name="emp"> Array of employees to display </param>
        private void DisplayDataToGUI(string header, ListBox LB,
                    ArrayOfEmployees emp)
        {
            if (emp.Count > 0)
            {
                LB.Items.Add(header);
                LB.Items.Add("------------------------------" +
                        "------------------------------------------------" +
                        "---------");
                LB.Items.Add(string.Format("{0, 18} {1,6} {2,10} " +
                    "{3,17} {4,18} {5,8}", "Name and surname",
            "Profession", "Gender", "Experience", "Working time", "Salary"));
                LB.Items.Add("------------------------------" +
                        "------------------------------------------------" +
                        "---------\n");

                for (int i = 0; i < emp.Count; i++)
                {
                    // Gets an employee by index
                    Employee employee = emp.GetEmployee(i);
                    LB.Items.Add(employee.ToString());
                }
                LB.Items.Add("------------------------------" +
                        "------------------------------------------------" +
                        "---------\n");
            }
            else
            {
                LB.Items.Add(header + ": No data to display");
            }
        }

        /// <summary>
        /// Handles the click event for the menu item.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event data</param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open initial data file";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter =
                "Text Files|*.txt|Word Documents|*.doc";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                datafile = openFileDialog1.FileName;
                if (employees1 == null)
                {
                    employees1 = new ArrayOfEmployees();
                    employees1 = ReadData(datafile, ref stockName1);
                    DisplayDataToGUI(stockName1, lbData, employees1);
                }
                else
                {
                    employees2 = new ArrayOfEmployees();
                    employees2 = ReadData(datafile, ref stockName2);
                    DisplayDataToGUI(stockName2, lbData, employees2);
                }
                ToggleControls(true);
            }
        }

        /// <summary>
        /// Handles the click event for the menu item
        /// Calculates employees according to selected criteria
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event data</param>
        private void CalculateAccordingSelectedCriteriaToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            if (tbExperience.Text == "" || tbSalary1.Text == "")
            {
                MessageBox.Show("Enter the data to fields");
            }
            else
            {
                // Working experience entered from keyboard
                int mExperience = Convert.ToInt32(tbExperience.Text);
                // Salary entered from keyboard
                double sSalary = Convert.ToDouble(tbSalary1.Text);
                satisfyRequirements = new ArrayOfEmployees();

                // Number of employees who fit criteria from 1st stock exchange
                int numberOfEmployeesFound1 = CountSuitableEmployees
                  (employees1, mExperience, sSalary);
                // Number of employees who fit criteria from 2nd stock exchange
                int numberOfEmployeesFound2 = CountSuitableEmployees
                  (employees2, mExperience, sSalary);

                lbData.Items.Add("Number of employees who fit criteria " +
                    "from 1st stock exchange: " + numberOfEmployeesFound1);
                lbData.Items.Add("Number of employees who fit criteria " +
                    "from 2nd stock exchange: " + numberOfEmployeesFound2);
            }
        }

        /// <summary>
        /// Counts employees who fit criteria
        /// </summary>
        /// <param name="employees"> Array of employees</param>
        /// <param name="mExperience"> Experience entered from keyboard</param>
        /// <param name="sSalary"> Salary entered from keyboard</param>
        /// <returns> Number of employees who fit criteria</returns>
        private int CountSuitableEmployees(ArrayOfEmployees employees,
            int mExperience, double sSalary)
        {
            int counter = 0; // Number of employees who fit criteria
            for (int i = 0; i < employees.Count; i++)
            {
                // Current employee
                Employee emp1 = employees.GetEmployee(i);
                if (emp1.WorkExperience >= mExperience &&
                    emp1.PreferredSalary >= sSalary)
                {
                    counter++;
                }
            }
            return counter;
        }

        /// <summary>
        /// Handles the click event for the menu item.
        /// </summary>
        /// <param name="sender"> The source of the event</param>
        /// <param name="e"> Key press event data</param>
        private void CreateContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Working experience entered from keyboard
            int mExperience = Convert.ToInt32(tbExperience.Text);
            // Salary entered from keyboard
            double sSalary = Convert.ToDouble(tbSalary1.Text);
            satisfyRequirements = new ArrayOfEmployees();

            SelectEmployees(employees1, mExperience, sSalary);
            SelectEmployees(employees2, mExperience, sSalary);

            DisplayDataToGUI("\nEmployees found according selected criteria ",
                lbData, satisfyRequirements);

            lbData.Items.Add("\nNumber of employees:" +
                satisfyRequirements.Count);
        }

        /// <summary>
        /// Select employees who fit criteria
        /// </summary>
        /// <param name="employees"> Employees from stock exchange</param>
        /// <param name="mExperience"> Experience entered from keyboard</param>
        /// <param name="sSalary"> Salary entered from keyboard</param>
        private void SelectEmployees(ArrayOfEmployees employees, int mExperience, double sSalary)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                // Current employee in object collection
                Employee emp1 = employees.GetEmployee(i);
                if (emp1.WorkExperience >= mExperience &&
                    emp1.PreferredSalary >= sSalary)
                {
                    satisfyRequirements.AddEmployee(emp1);
                }

            }
        }

        /// <summary>
        /// Handles the click event for the menu item.
        /// </summary>
        /// <param name="sender"> The source of the event</param>
        /// <param name="e"> Key press event data</param>
        private void SortContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satisfyRequirements.Sort();

            DisplayDataToGUI("\nSorted container ", lbData, satisfyRequirements);
        }

        /// <summary>
        /// Handles the click event for the menu item.
        /// Closes the program
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event data</param>
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the KeyPress event for the experience input textbox
        /// </summary>
        /// <param name="sender"> The source of the event</param>
        /// <param name="e"> Key press event data</param>
        private void TbSalary2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Handles the click event for the menu item.
        /// Removes unemployed people from result container
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event data</param>
        private void RemoveUnemployedPeopleToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            if (tbSalary2.Text == "")
            {
                MessageBox.Show("Enter the data to fields");
            }
            else
            {
                // Salary employer can pay
                int salaryEmployerCanPay = Convert.ToInt32(tbSalary2.Text);
                ArrayOfEmployees employeesToRemove =
                    RemoveEmployees(salaryEmployerCanPay);

                if (employeesToRemove.Count > 0)
                {
                    DisplayDataToGUI("\nEmployees need to be removed", lbData,
                        employeesToRemove);
                    DisplayDataToGUI("\nEmployees after removing unemployed people ",
                    lbData, satisfyRequirements);
                }
                else
                {
                    lbData.Items.Add("No employees need to be removed");
                }
            }
        }

        /// <summary>
        /// Removes employees who require big salary
        /// </summary>
        /// <param name="salaryEmployerWantsPay"> Salary entered from keyboard</param>
        /// <returns> Employees need to be removed</returns>
        private ArrayOfEmployees RemoveEmployees(int salaryEmployerWantsPay)
        {
            // Employees need to be removed
            ArrayOfEmployees employeesToRemove = new ArrayOfEmployees();

            for (int i = 0; i < satisfyRequirements.Count; i++)
            {
                // Current employee gotten by index
                Employee currentEmp = satisfyRequirements.GetEmployee(i);
                if (currentEmp.PreferredSalary > salaryEmployerWantsPay)
                {
                    employeesToRemove.AddEmployee(currentEmp);
                    satisfyRequirements.RemoveEmployee(currentEmp);
                    i--;

                }
            }

            return employeesToRemove;
        }

        /// <summary>
        /// Handles the click event for the menu item.
        /// Inserts selected employees to result container
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event data</param> 
        private void InsertUnemployedPeopleToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            // Container for storing unemployed people
            ArrayOfEmployees unemployedPeople;
            // Container for storing employees who fit requirements
            ArrayOfEmployees employeesToAdd = new ArrayOfEmployees();

            string stockName3 = ""; // Stock name
            string fileNewEmployees = ""; // File that stores new employees

            openFileDialog1.Title = "Open initial data file";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Files|*.txt|Word Documents|*.doc";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNewEmployees = openFileDialog1.FileName;
            }
            unemployedPeople = ReadData(fileNewEmployees, ref stockName3);

            int experience = Convert.ToInt32(tbExperience.Text); // Experience
            // Salary employee agree to work for
            int salaryEmployeeAgreeToWorkFor = Convert.ToInt32(tbSalary1.Text);
            // Salary employer agree to pay
            int salaryEmployerAgreeToPay = Convert.ToInt32(tbSalary2.Text);

            employeesToAdd = InsertEmployees(unemployedPeople,
                experience, salaryEmployeeAgreeToWorkFor, salaryEmployerAgreeToPay);

            DisplayDataToGUI("\nEmployees from separate file",
                lbData, unemployedPeople);

            DisplayDataToGUI("\nEmployees need to be added", lbData,
                employeesToAdd);

            DisplayDataToGUI("\nEmployees from separate file were added",
                lbData, satisfyRequirements);
        }

        /// <summary>
        /// Insert employees according to criteria
        /// </summary>
        /// <param name="unemployedPeople"> Unemployed people</param>
        /// <param name="experience"> Experience entered from keyboard</param>
        /// <param name="employeeDesiredSalary"> Employee desired salary</param>
        /// <param name="salaryEmployerCanPay"> Salary employer can pay</param>
        /// <returns> Employees need to be added</returns>
        private ArrayOfEmployees InsertEmployees(ArrayOfEmployees unemployedPeople,
            int experience, int employeeDesiredSalary, int salaryEmployerCanPay)
        {
            // Container for storing employees who fit requirements
            ArrayOfEmployees employeesToAdd = new ArrayOfEmployees();

            for (int i = 0; i < unemployedPeople.Count; i++)
            {
                Employee temp = unemployedPeople.GetEmployee(i);
                if (temp.WorkExperience >= experience &&
                    temp.PreferredSalary >= employeeDesiredSalary &&
                    temp.PreferredSalary <= salaryEmployerCanPay)
                {
                    satisfyRequirements.AddEmployeeToSortedContainer(temp);
                    employeesToAdd.AddEmployee(temp);
                }
            }
            return employeesToAdd;
        }

        /// <summary>
        /// Handles the click event for the menu item.
        /// </summary>
        /// <param name="sender"> The source of the event</param>
        /// <param name="e"> Key press event data</param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save your results";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Text Files|*.txt|Word Documents|*.doc";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WriteDataToFile();
            }
        }

        /// <summary>
        /// Writes data to file
        /// </summary>
        private void WriteDataToFile()
        {
            resultFile = saveFileDialog1.FileName;
            using (StreamWriter writer = new StreamWriter(resultFile, false, Encoding.UTF8))
            {
                foreach (string item in lbData.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }
    }
}
