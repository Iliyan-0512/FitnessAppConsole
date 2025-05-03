using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace FitnessApp
{
  
//    What it is: information about whether the customer has an active subscription


//Checking if the subscription is still valid

        public class Membership
        {
            public string CustomerName { get; set; }

            public DateTime StartDate { get; set; }

            public DateTime EndDate { get; set; }

            public Membership(string customerName, DateTime startDate, DateTime endDate)
            {
                CustomerName = customerName;
                StartDate = startDate;
                EndDate = endDate;
            }

            // Method for checking if the subscription is valid
            public bool IsActive()
            {
                DateTime today = DateTime.Today;
                return today >= StartDate && today <= EndDate;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Customer: {CustomerName}");
                Console.WriteLine($"Membership: {StartDate.ToShortDateString()} - {EndDate.ToShortDateString()}");
                Console.WriteLine($"Status: {(IsActive() ? "Active" : "Inactive")}");
            }
        }
    }
