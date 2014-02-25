using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIMvcApplication5.Models
{
    public class Arbitrator
    {

        public string Name { get; set; }

        public string Company { get; set; }

        public string Location { get; set; }

        public string AverageRating { get; set; }

        public int Id { get; set; }

        public string MostRecentArbitration { get; set; }
    }


    public class Person
    {
        public string Icon;
        public int Id;
        public string Title;
        public string Status;
        public string AssignedTo;
        public string LastModified;
        public int BaseId; 
    
    
    }
}