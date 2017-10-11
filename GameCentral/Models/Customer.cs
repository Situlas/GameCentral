using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Customer
    {
        public int Id { get; set; }
        public int Phone { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Email { get; set; }
        public int CVR { get; set; }
        public bool CustomerType { get; set; }

        public Customer(int id, int phone, string fName, string lName, string city, int zipCode, string email, int cVR, bool customerType)
        {
            Id = id;
            Phone = phone;
            FName = fName;
            LName = lName;
            City = city;
            ZipCode = zipCode;
            Email = email;
            CVR = cVR;
            CustomerType = customerType;
        }
    }
}
