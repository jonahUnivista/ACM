using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public DateTime OrderDate { get; set; }

        public Order Retrieve(int customerId)
        {
            // Code that retrieves the defined customer
            return new Order();
        }

        /// <summary>
        /// Retrieve all customers. 
        /// </summary>
        /// <returns></returns>
        public List<Order> Retrieve()
        {
            // Code that retrieves all of the customers

            return new List<Order>();
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

            return isValid;
        }

    }
}
