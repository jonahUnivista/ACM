using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }

        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        // Auto Implemented property, this is the same as above, only use the top way if you need specific logic in the implementation
        public string LastName { get; set; }
        public static int InstanceCount { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";

                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }

        /// <summary>
        /// Retrieve the current customer.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // Code that retrieves the defined customer
            return new Customer();
        }

        /// <summary>
        /// Retrieve all customers. 
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            // Code that retrieves all of the customers

            return new List<Customer>();
        }

        /// <summary>
        /// Saves he current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined customer

            return true;
        }

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
