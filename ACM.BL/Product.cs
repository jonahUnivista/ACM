using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }

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
        /// Retrieve the current Product.
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public Product Retrieve(int ProductId)
        {
            // Code that retrieves the defined Product
            return new Product();
        }

        /// <summary>
        /// Retrieve all Products. 
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve()
        {
            // Code that retrieves all of the Products

            return new List<Product>();
        }

        /// <summary>
        /// Saves he current Product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined Product

            return true;
        }

        /// <summary>
        /// Validates the Product data.
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
