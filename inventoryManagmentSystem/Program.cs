namespace inventoryManagmentSystem
{
    internal class Program
    {
        static string[,] inventory = new string[50, 3];
        static int id = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my inventory system");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("enter your choise");
            Console.WriteLine("1.add product");
            Console.WriteLine("2.update product");
            Console.WriteLine("3.view all products");
            Console.WriteLine("4.Exit");
            while (true)
            {
                int choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        addProduct();
                        break;
                    case 2:
                        updateProduct();
                        break;
                    case 3:
                        viewProdects();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("you must choose from 1 to 4");
                        break;
                }
            }
        }

        private static void addProduct()
        {
            Console.WriteLine("enter product name");
            string name = Console.ReadLine();
            Console.WriteLine("enter product quantity");
            string quantity = Console.ReadLine();
            Console.WriteLine("enter product price");
            string price = Console.ReadLine();
            inventory[id,0] = name;
            inventory[id, 1] = quantity;
            inventory[id, 2] = price;
            Console.WriteLine("product added successfully");
            id++;
        }


        private static void viewProdects()
        {
            if (id>0)
            {
                for (int i = 0; i <id; i++)
                {
                    Console.WriteLine($"Id : {i} , Name : {inventory[i,0]} , Quantity : {inventory[i, 1]} , Price : {inventory[i, 2]}");
                }
            }
            else
            {
                Console.WriteLine("there is no products");
            }
        }


        private static void updateProduct()
        {
            if (id > 0)
            {
                viewProdects();
                Console.WriteLine("enter the id of the product you want to modify");
                int productId = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine($"Id : {productId} , Name : {inventory[productId, 0]} , Quantity : {inventory[productId, 1]} , Price : {inventory[productId, 2]}");
                    Console.WriteLine("enter your choise");
                    Console.WriteLine("1.change name");
                    Console.WriteLine("2.change quantity");
                    Console.WriteLine("3.change price");
                    Console.WriteLine("4.back to main menu");
                    int modChoise = Convert.ToInt32(Console.ReadLine());
                    switch (modChoise)
                    {
                        case 1:

                            Console.WriteLine("enter the new name");
                            inventory[productId, 0] = Console.ReadLine();
                            Console.WriteLine("Name changed successfully");

                            break;
                        case 2:
                            Console.WriteLine("enter the new quantity");
                            inventory[productId, 1] = Console.ReadLine();
                            Console.WriteLine("Qyantity changed successfully");

                            break;
                        case 3:
                            Console.WriteLine("enter the new price");
                            inventory[productId, 2] = Console.ReadLine();
                            Console.WriteLine("Price changed successfully");

                            break;
                        case 4:
                            Main(null);
                            break;
                        default:
                            Console.WriteLine("you must choose from 1 to 4");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("there is no products to modify");
            }
        }
    }
}
