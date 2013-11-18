using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AdBase3.Models
{
    public class Employee
    {
        //Look into the virtual keyword and entity framework here to figure out where things are being stored.

        public int EmpId { get; set; }  
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CompanyNo { get; set; }
        public string CountryCode { get; set; }
        public string Telephone { get; set; }
        public string TelExt { get; set; }
        public string LocId { get; set; }
        public string email { get; set; }
        public string FaxNo { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastChanged { get; set; }
        public Boolean Active { get; set; }

        }
    

}