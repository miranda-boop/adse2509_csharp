namespace Sess01_csharp_intro
{
    /// <summary>
    /// Represents an employee with an identification number, name, and gender.
    /// Provides constructors, methods to access and modify employee details,
    /// and a string representation of the employee.
    /// </summary>
    public class SampleEmployeeXMLDocumentation
    {
        // Fields


        /// <summary>
        /// Stores the employee's unique identification number as an unsigned integer.
        /// </summary>
        private uint _empID;

        /// <summary>
        /// Stores the employee's name as a string.
        /// </summary>
        private string _empName;

        /// <summary>
        /// Stores the employee's gender as a character.
        /// 'M' represents male, while 'F' represents female.
        /// </summary>
        private char _gender;

        /// <summary>
        /// Initializes a new employee with default values.
        /// The employee ID is set to 0, the name to an empty string,
        /// and the gender to 'M'.
        /// </summary>
        public SampleEmployeeXMLDocumentation()
        {
            this._empID = 0;
            this._empName = string.Empty;
            this._gender = 'M';
        }

        /// <summary>
        /// Initializes a new employee with the specified ID, name, and gender.
        /// </summary>
        /// <param name="empid">The employee's identification number.</param>
        /// <param name="name">The employee's name.</param>
        /// <param name="gender">The employee's gender, represented by 'M' or 'F'.</param>
        public SampleEmployeeXMLDocumentation(uint empid, string name, char gender)
        {
            this._empID = empid;
            this._empName = name;
            this._gender = gender;
        }

        // Getters and setters

        /// <summary>
        /// Retrieves the employee's identification number.
        /// </summary>
        /// <returns>The employee's ID.</returns>
        public uint GetID()
        {
            return this._empID;
        }

        /// <summary>
        /// Sets the employee's identification number.
        /// </summary>
        /// <param name="empID">The new employee ID.</param>
        public void SetID(uint empID)
        {
            this._empID = empID;
        }

        /// <summary>
        /// Retrieves the employee's name.
        /// </summary>
        /// <returns>The employee's name.</returns>
        public string GetName()
        {
            return this._empName;
        }

        /// <summary>
        /// Sets the employee's name.
        /// </summary>
        /// <param name="name">The new employee name.</param>
        public void SetName(string name)
        {
            this._empName = name;
        }

        /// <summary>
        /// Retrieves the employee's gender.
        /// </summary>
        /// <returns>The employee's gender as a character.</returns>
        public char GetGender()
        {
            return this._gender;
        }

        /// <summary>
        /// Sets the employee's gender.
        /// </summary>
        /// <param name="gender">The new gender, represented by 'M' or 'F'.</param>
        public void SetGender(char gender)
        {
            this._gender = gender;
        }

        /// <summary>
        /// Returns a formatted string containing the employee's details.
        /// </summary>
        /// <returns>
        /// A formatted string containing the employee's ID, name, and gender.
        /// </returns>
        public override string ToString()
        {
            return $"Employee Details" +
                $"\n--------------------------------------------------------------" +
                $"\nID: {this.GetID()}" +
                $"\nName: {this.GetName()}" +
                $"\nGender: {(this.GetGender() == 'M' || this.GetGender() == 'm' ? "Male" : "Female")}" +
                $"\n--------------------------------------------------------------";
        }
    }

}