namespace AbbySELLERMANAGEMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // E-Commerce - SELLER PROFILE MANAGEMENT TAS MGA PRODUCTS ++ CRUDE (create, read, update, delete, execute) DAPAT

            int pick = 0;
            Console.WriteLine("Welcome to E-Commerce Seller Profile Management System");


            Console.WriteLine("0. View Profile");
            Console.WriteLine("1. Edit Profile");
            Console.WriteLine("2. Read product details");
            Console.WriteLine("3. Update product information");
            Console.WriteLine("4. Delete a product");
            Console.WriteLine("===================");
            Console.Write("Choose an option: ");
            pick = Convert.ToInt32(Console.ReadLine());

            switch (pick)
            {
                case 0:

                    Console.WriteLine("Seller Profile's E-Commerce");

                    Console.WriteLine("Seller Profile");
                    Console.WriteLine("Name: Abbygael Almadin");
                    Console.WriteLine("Brandname: Cutie Bakery");
                    Console.Write("Ratings: 9.9/10 ~");
                    Console.Write(" Reviews: 99");

                    Console.WriteLine("Products: ");

                    break;
                case 1:
                    //Create a new product code
                    break;
                case 2:
                    //Read product details code
                    break;
                case 3:
                    //Update product information code
                    break;
                case 4:
                    //Delete a product code
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
            }



        }
    }
}
