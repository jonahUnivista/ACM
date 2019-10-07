using Acme.Common;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : EnitityBase, ILoggable 
    {
        public Customer(): this(0)
        {
        }   
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
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

        public static int InstanceCount { get; set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; }

        //public string Log()
        //{
        //    var logString = CustomerId + ": " +
        //                    FullName + " " +
        //                    "Email: " + EmailAddress + " " +
        //                    "Status: " + EntityState.ToString();

        //    return logString;
        //}
        // Expression body operator
        public string Log() => 
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()})";

        public override string ToString() => FullName;

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
