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

            myRestaurant.AddDishesToCleanStack("Dish 4");
            myRestaurant.AddDishesToCleanStack("Dish 3");
            myRestaurant.AddDishesToCleanStack("Dish 2");
            myRestaurant.AddDishesToCleanStack("Dish 1");

            myRestaurant.moveToDirtyStack();
            Console.WriteLine("Dirty Dishes:");
            myRestaurant.PrintDirtyDishes();
            Console.WriteLine("Clean Dishes:");
            myRestaurant.PrintCleanDishes();

            Console.WriteLine("Washing:");
            myRestaurant.moveToCleanStack();
            Console.WriteLine("Dirty Dishes:");
            myRestaurant.PrintDirtyDishes();
            Console.WriteLine("Clean Dishes:");
            myRestaurant.PrintCleanDishes();

            //myRestaurant.stackDishesAction("stacks the used plates in the dirty dish stack");
            //myRestaurant.PrintWaiterActions();
            //myRestaurant.stackCleanDishesAction("stacks the clean plates in the clean dish stack");
            //myRestaurant.cleanDishesAction("washes the dishes");
            //myRestaurant.removesDishesAction("removes the dirty dishes from the stack of dirty dishes");
            //myRestaurant.PrintPorterActions();

        }
    }


    public class Restaurant
    {
        private Queue<string> waitingQueue = new Queue<string>();
        private Stack<string> customerActions = new Stack<string>();
        private Stack<string> waiterActions = new Stack<string>();
        private Stack<string> porterActions = new Stack<string>();
        private Stack<string> dirtyDishes = new Stack<string>();
        private Stack<string> cleanDishes = new Stack<string>();
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

        public void AddDishesToCleanStack(string AddtoCleanStack)
        {
            cleanDishes.Push(AddtoCleanStack);
        }

        public void moveToDirtyStack()
        {
            string moveDishesToDirty = cleanDishes.Pop();dirtyDishes.Push(moveDishesToDirty);
        }

        public void moveToCleanStack()
        {
            string moveDishesToClean = dirtyDishes.Pop(); cleanDishes.Push(moveDishesToClean);
        }

        public void PrintCleanDishes()
        {
            foreach (var item in cleanDishes)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintDirtyDishes()
        {
            foreach (var item in dirtyDishes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
