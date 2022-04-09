using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2
{
    public class Store
    {
        public void Start()
        {
            Test();
        }

        public void Test()
        {
            //MenuCatalog menuCatalog = new MenuCatalog();

            //Pizza p1 = new Pizza(63, "Margherita", 72);
            //Pizza p2 = new Pizza(34, "Vesuvio", 78);
            //Pizza p3 = new Pizza(78, "Calzone", 83);
            //Pizza p4 = new Pizza(54, "Tonno", 88);

            ////Adding Pizzas To Menu

            //menuCatalog.CreatePizza(p1);
            //menuCatalog.CreatePizza(p2);
            //menuCatalog.CreatePizza(p3);

            ////Reading Pizzas in menu

            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("| Pizza Menu Before Crud Operations |");
            //Console.WriteLine("-------------------------------------\n");

            //Console.WriteLine(menuCatalog.ReadPizza(63));
            //Console.WriteLine(menuCatalog.ReadPizza(34));
            //Console.WriteLine(menuCatalog.ReadPizza(78));

            ////Updating Pizzas in menu

            //menuCatalog.UpdatePizza(63, p4);

            ////Deleting pizzas in menu

            //menuCatalog.DeletePizza(p2);


            //Console.WriteLine("\n------------------------------------");
            //Console.WriteLine("| Pizza Menu After Crud Operations |");
            //Console.WriteLine("------------------------------------\n");

            //menuCatalog.PrintMenu();

            //Console.WriteLine(menuCatalog.SearchPizza("Tonno"));

            PizzaCatalog.Run();
        }
    }
}
