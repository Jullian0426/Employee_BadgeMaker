using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CatWorx.BadgeMaker
{
    class PeopleFetcher
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                // Move the initial prompt inside the loop, so it repeats for each employee
                Console.WriteLine("Enter first name (leave empty to exit): ");

                // change input to firstName
                string firstName = Console.ReadLine() ?? "";
                if (firstName == "")
                {
                    break;
                }

                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine() ?? "";
                Console.Write("Enter ID: ");
                string id = Console.ReadLine() ?? "";
                Console.Write("Enter Photo URL:");
                string photoUrl = Console.ReadLine() ?? "";
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            return employees;
        }

        async public static Task<List<Employee>> GetFromApi()
        {
            using (HttpClient client = new HttpClient())
            {
                List<Employee> employees = new List<Employee>();

                string response = await client.GetStringAsync("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");

                JObject json = JObject.Parse(response);
                // serialize JSON results into .NET objects
                foreach (JToken result in json.SelectToken("results")!)
                {
                    Employee employee = new Employee
                    (
                        result["name"]!["first"]!.ToString(),
                        result["name"]!["last"]!.ToString(),
                        result["id"]!["value"]!.ToString(),
                        result["picture"]!["large"]!.ToString()
                    );
                    employees.Add(employee);
                }
                return employees;
            }
        }
    }
}