using System;
using System.Collections.Generic;

namespace Midterm_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant myRestaurant = new Restaurant();

            myRestaurant.AddCustomersToTheQueue("First Customer");
            myRestaurant.AddCustomersToTheQueue("Second Customer");
            myRestaurant.AddCustomersToTheQueue("Third Customer");
            myRestaurant.AddCustomersToTheQueue("Fourth Customer");
            myRestaurant.AddCustomersToTheQueue("Fifth Customer");

            myRestaurant.HowManyCustomersWaiting();
            myRestaurant.ShowTheActualCustomers();
            myRestaurant.leavesAction("leaves");
            myRestaurant.paysAction("pays");
            myRestaurant.eatsAction("eats");
            myRestaurant.seatAction("sits down");
            myRestaurant.PrintCustomerActions();
            myRestaurant.CustomerAttended();
            myRestaurant.stackDishesAction("stacks the used plates in the dirty dish stack");
            myRestaurant.cleanTableAction("picks up the dishes and cleans the table");
            myRestaurant.PrintWaiterActions();
            myRestaurant.stackCleanDishesAction("stacks the clean plates in the clean dish stack");
            myRestaurant.cleanDishesAction("washes the dishes");
            myRestaurant.removesDishesAction("removes the dirty dishes from the stack of dirty dishes");
            myRestaurant.PrintPorterActions();
            myRestaurant.HowManyCustomersWaiting();
            myRestaurant.ShowTheActualCustomers();

        }
    }


    public class Restaurant
    {
        private Queue<string> waitingQueue = new Queue<string>();
        private Stack<string> customerActions = new Stack<string>();
        private Stack<string> waiterActions = new Stack<string>();
        private Stack<string> porterActions = new Stack<string>();
        public void AddCustomersToTheQueue(string parameter)
        {
            waitingQueue.Enqueue(parameter);
        }
        
        public void HowManyCustomersWaiting()
        {
            Console.WriteLine("There are " + waitingQueue.Count + " waiting to be seated.");
        }

        public void ShowTheActualCustomers()
        {
            foreach ( var item in waitingQueue)
            {
                Console.WriteLine("Customer: " + item);
            }
        }

        public void CustomerAttended()
        {
            waitingQueue.Dequeue();
        }

        public void seatAction(string actualActions)
        {
            customerActions.Push(actualActions);
        }

        public void eatsAction(string actualActions)
        {
            customerActions.Push(actualActions);
        }

        public void paysAction(string actualActions)
        {
            customerActions.Push(actualActions);
        }

        public void leavesAction(string actualActions)
        {
            customerActions.Push(actualActions);
        }

        public void PrintCustomerActions()
        {
            foreach (var item in customerActions)
            {
                Console.WriteLine("The customer: " + item);
            }
        }

        public void cleanTableAction(string actualActions)
        {
            waiterActions.Push(actualActions);
        }

        public void stackDishesAction(string actualActions)
        {
            waiterActions.Push(actualActions);
        }

        public void PrintWaiterActions()
        {
            foreach (var item in waiterActions)
            {
                Console.WriteLine("The waiter: " + item);
            }
        }

        public void removesDishesAction(string actualActions)
        {
            porterActions.Push(actualActions);
        }

        public void cleanDishesAction(string actualActions)
        {
            porterActions.Push(actualActions);
        }

        public void stackCleanDishesAction(string actualActions)
        {
            porterActions.Push(actualActions);
        }

        public void PrintPorterActions()
        {
            foreach (var item in porterActions)
            {
                Console.WriteLine("The kitchen porter: " + item);
            }
        }
    }
}
