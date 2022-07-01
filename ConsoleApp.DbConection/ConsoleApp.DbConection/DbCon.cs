using System.Data.SqlClient;

namespace ConsoleApp.DbConection
{
    public class DbCon
    {
        private const string connectionString = "Data Source=MANSIJ\\SQLEXPRESS;Initial Catalog=Console.DbCon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private static void RunReader(string query)
        {
            //Connection object
            SqlConnection con = new SqlConnection(connectionString);

            //Command object
            SqlCommand cmd = new SqlCommand(query, con);

            //Connection Open
            con.Open();

            //Execute command
            var reader = cmd.ExecuteReader();

            //Do work
            while (reader.Read())
            {
                Console.WriteLine("============================================================");
                Console.WriteLine($"Id : {reader.GetFieldValue<int>(0)}");
                Console.WriteLine($"Name : {reader.GetFieldValue<string>(1)}");
                Console.WriteLine($"Email : {reader.GetFieldValue<string>(2)}");
                Console.WriteLine($"Phone : {reader.GetFieldValue<string>(3)}");
                Console.WriteLine("============================================================");
            }

            //Close connection
            con.Close();
        }

        private static void RunNonquery(string query)
        {
            //Connection object
            SqlConnection con = new SqlConnection(connectionString);

            //Command object
            SqlCommand cmd = new SqlCommand(query, con);

            //Connection Open
            con.Open();

            //Execute command
            var reader = cmd.ExecuteNonQuery();

            //No need to do work in this case

            //Close connection
            con.Close();
        }

        public void GetAll()
        {
            //Define Query
            var query = "Select * from PersonalInfo";
            //Run
            RunReader(query);
        }

        public void GetById()
        {
            Console.WriteLine("Enter the id:");
            var id = Console.ReadLine();
            var query = "Select * from PersonalInfo where id = " + id + " ";
            RunReader(query);
        }

        public void Create()
        {
            Console.Write("Enter the name:");
            var name = Console.ReadLine();
            Console.Write("Enter the email:");
            var email = Console.ReadLine();
            Console.Write("Enter the phone:");
            var phone = Console.ReadLine();

            var query = $"insert into PersonalInfo values ('{name}' ,'{email}' ,'{phone}'  )";
            RunNonquery(query);
        }

        public void Edit()
        {
            Console.Write("Enter the id:");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name:");
            var name = Console.ReadLine();
            Console.Write("Enter the email:");
            var email = Console.ReadLine();
            Console.Write("Enter the phone:");
            var phone = Console.ReadLine();

            var query = $"update PersonalInfo set  name='{name}', email='{email}',phone='{phone}' where id='{id}'";
            RunNonquery(query);
        }

        public void Delete()
        {
            Console.Write("Enter the id:");
            var id = Console.ReadLine();

            var query = $"Delete from PersonalInfo where id='{id}'";
            RunNonquery(query);
        }
    }
}