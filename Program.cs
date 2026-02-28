namespace aa
{
    internal class Program
    {
        static List<string> sellerProfile = new List<string>();
        static List<string> sellerProduct = new List<string>();
        static List<double> sellerPrice = new List<double>();

        static void Main(string[] args)
        {

            // E-Commerce - SELLER PROFILE MANAGEMENT TAS MGA PRODUCTS ++ CRUDE (create, read, update, delete, execute) DAPAT

            int pick = 0;
            string restart = "true";

            sellerProfile.Add("Almadin_Shop");
            sellerProduct.Add("Powerbank");
            sellerPrice.Add(99.99);

            sellerProfile.Add("Abbygael_Bakery");
            sellerProduct.Add("Crinkles");
            sellerPrice.Add(7.00);

            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Welcome to E-Commerce Seller Profile Management System");
                Console.WriteLine(" ");
                Console.WriteLine("===================");
                Console.WriteLine("0. View Profile");
                Console.WriteLine("1. Add Seller Profile");
                Console.WriteLine("2. Update Profile information");
                Console.WriteLine("3. Delete a Profile");
                Console.WriteLine("===================");
                Console.WriteLine(" ");
                Console.Write("Choose an option: ");
                pick = Convert.ToInt32(Console.ReadLine());

                switch (pick)
                {
                    case 0:
                        // view

                        Console.WriteLine("Seller Profiles");
                        Console.WriteLine(" ");

                        for (int i = 0; i < sellerProfile.Count; i++)
                        {
                            Console.WriteLine($"[{i + 1}] Profile: {sellerProfile[i]} Product: {sellerProduct[i]}, Price: {sellerPrice[i]}");
                        }

                        break;
                    case 1:


                        //Add new Product

                        Console.WriteLine("You are ADDING a new Seller Profile: ");
                        Console.WriteLine(" ");

                        Console.Write("Seller Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Product Name: ");
                        string product = Console.ReadLine();

                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine());

                        sellerProfile.Add(name);
                        sellerProduct.Add(product);
                        sellerPrice.Add(price);
                        Console.WriteLine($"Successfully added product {product} !");

                        break;
                    case 2:
                        //Update product information code
                        break;
                    case 3:
                        //Delete a product code
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            } while (restart == "true");

        }
    }
}
