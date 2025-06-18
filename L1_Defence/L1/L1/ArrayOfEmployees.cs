//ArrayOfEmployees.cs

namespace L1
{
    /// <summary>
    /// Class to store multiple employees in an array
    /// </summary>
    internal class ArrayOfEmployees
    {
        private Employee[] employees; // Array of employees
        public int Count { get; private set; } // Number of employees
        private int Capacity; // Capacity of an array

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capacity">Capacity of an array</param>
        public ArrayOfEmployees(int capacity = 10)
        {
            this.Capacity = capacity;
            this.employees = new Employee[capacity];
        }

        /// <summary>
        /// Ensures that array has enough Capacity to store all employees
        /// </summary>
        /// <param name="minimumCapacity">Minimum Capacity</param>
        private void EnsureCapacity(int minimumCapacity)
        {
            if (this.Capacity < minimumCapacity)
            {
                Employee[] temp = new Employee[minimumCapacity];
                for (int i = 0; i < this.Count; i++)
                {
                    temp[i] = this.employees[i];
                }
                this.Capacity = minimumCapacity;
                this.employees = temp;
            }
        }

        /// <summary>
        /// Adds an employee
        /// </summary>
        /// <param name="emp">Employee</param>
        public void AddEmployee(Employee emp)
        {
            if (this.Count == this.Capacity)
            {
                EnsureCapacity(this.Capacity * 2);
            }
            this.employees[this.Count++] = emp;
        }

        /// <summary>
        /// Gets an employee by index
        /// </summary>
        /// <param name="index">Index of employee</param>
        /// <returns>Employee</returns>
        public Employee GetEmployee(int index)
        {
            return this.employees[index];
        }

        /// <summary>
        /// Removes an employee by index
        /// </summary>
        /// <param name="index">Index of employee</param>
        public void RemoveEmployeeAt(int index)
        {
            if (index >= 0 && index <= this.Count)
            {
                for (int i = index; i < this.Count - 1; i++)
                {
                    employees[i] = employees[i + 1];
                }
                employees[this.Count - 1] = null;
                this.Count--;
            }
        }

        /// <summary>
        /// Removes specified employee
        /// </summary>
        /// <param name="emp">Employee</param>
        public void RemoveEmployee(Employee emp)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.employees[i] == emp)
                {
                    this.RemoveEmployeeAt(i);
                }
            }
        }

        /// <summary>
        /// Inserts specified employee in specified place
        /// </summary>
        /// <param name="index">Index</param>
        /// <param name="emp">Employee</param>
        public void InsertEmployee(int index, Employee emp)
        {
            if (index >= 0 && index <= this.Count)
            {
                if (this.Count == this.Capacity)
                {
                    EnsureCapacity(this.Capacity * 2);
                }
                for (int i = this.Count; i > index; i--)
                {
                    employees[i] = employees[i - 1];
                }
                employees[index] = emp;
                this.Count++;
            }
        }

        /// <summary>
        /// Adds employee to sorted container
        /// </summary>
        /// <param name="emp">Employee</param>
        public void AddEmployeeToSortedContainer(Employee emp)
        {
            int indexToInsert = this.Count;

            for (int i = 0; i < this.Count; i++)
            {
                Employee currentEmployee = this.employees[i];

                if (currentEmployee.CompareTo(emp) > 0)
                {
                    indexToInsert = i;
                    break;
                }
            }
            InsertEmployee(indexToInsert, emp);
        }

        /// <summary>
        /// Bubble sort methos
        /// </summary>
        public void Sort()
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < this.Count - 1; i++)
                {
                    Employee a = this.employees[i];
                    Employee b = this.employees[i + 1];
                    if (a.CompareTo(b) > 0)
                    {
                        this.employees[i] = b;
                        this.employees[i + 1] = a;
                        flag = true;
                    }
                }
            }
        }
    }
}
