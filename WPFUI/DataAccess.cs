using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WPFUI
{
    public class DataAccess
    {
        List<Person> people = new List<Person>();
        private Person p = new Person();
        public DataAccess(string f, string l)
        {
            p.FirstName = f;
            p.LastName = l;
        }

        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connect = new SqlConnection(Helper.ConnectString("Datas")))
            {
               var output = connect.Query<Person>($"dbo.People_GetByLastName @lastName", new {LastName = lastName}).ToList();
                return output;
            }
        }

        public void AddPerson( Person p)
        {
           people.Add(new Person{FirstName = p.FirstName, LastName = p.LastName, EmailAddress =p.EmailAddress, PhoneNumber = p.PhoneNumber});
           people.Add(new Person { FirstName = "Misa", LastName = "Novaku", EmailAddress = "mordok76@gmail.com", PhoneNumber = "702-435-214" });
           people.Add(new Person { FirstName = "Misa", LastName = "Novaku", EmailAddress = "mordok76@gmail.com", PhoneNumber = "702-435-214" });
           people.Add(new Person { FirstName = "Misa", LastName = "Novaku", EmailAddress = "mordok76@gmail.com", PhoneNumber = "702-435-214" });
            foreach (var pe in people)
            {
                Console.WriteLine(pe);
            }   
        }
    }
}
