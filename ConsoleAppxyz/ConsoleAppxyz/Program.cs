namespace ConsoleAppxyz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var res = "N";
            do
            {
                try
                {
                    var choice = PrintChoices();
                    Run(choice);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Do you want to continue more?(y/n");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
        }

        private static void Run(int choice)
        {
            DbCon db = new DbCon();
            switch (choice)
            {
                case 1:
                    db.GetAll();
                    break;

                case 2:
                    db.GetById();
                    break;

                case 3:
                    db.Create();
                    break;

                case 4:
                    db.Edit();
                    break;

                case 5:
                    db.Delete();
                    break;

                default:
                    Console.WriteLine("Please Select the available choices:");
                    break;
            }
        }

        private static int PrintChoices()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to get all records");
            Console.WriteLine("Press 2 to get record by id");
            Console.WriteLine("Press 3 to create record");
            Console.WriteLine("Press 4 to edit record");
            Console.WriteLine("Press 5 to delete record");
            Console.WriteLine("Enter your choice:");

            var choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}