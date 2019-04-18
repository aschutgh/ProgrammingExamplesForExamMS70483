using System;
using System.Collections.Generic;

// source: 20483B Programming in Visual C#

namespace Interfaces
{
    // defining an interface
    public interface ILoyaltyCardHolder
    {
        int TotalPoints { get; }
        void AddPoints(decimal TransactionValue);
        void ResetPoints();
    }

    public class Customer : ILoyaltyCardHolder
    {
        // the following implements the interface
        private int totalPoints;

        public int TotalPoints
        {
            get { return totalPoints; }
        }

        public void AddPoints(decimal transactionValue)
        {
            int points = Decimal.ToInt32(transactionValue);
            totalPoints += points;
        }

        public void ResetPoints()
        {
            totalPoints = 0;
        }
        // Other members of the customer class
        public string CustomerName { get; set; }
        public int CustomerID { get; }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
