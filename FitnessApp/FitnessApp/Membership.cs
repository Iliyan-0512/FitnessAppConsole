using System;

namespace FitnessApp
{
    // Information about whether the customer has an active subscription
    internal class Membership
    {
        public DateTime StartDate { get; set; }
        public int DurationInMonths { get; set; }

        // Checking if the subscription is still valid
        public bool IsActive()
        {
            return DateTime.Now < StartDate.AddMonths(DurationInMonths);
        }
    }
}
