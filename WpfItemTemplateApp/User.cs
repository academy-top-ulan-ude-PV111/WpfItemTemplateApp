using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfItemTemplateApp
{
    internal class User
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public string Company { set; get; }

        public bool IsActive { set; get; }

        public User(string name, int age, string company)
        {
            this.Name = name;
            this.Age = age;
            this.Company = company;
            this.IsActive = true;
        }

        public override string ToString()
        {
            return $"{Name} ({Age}) {Company} {(IsActive ? "Active" : "Not Active")}";
        }
    }

    class DataSource
    {
        public IEnumerable<User> Users { set; get; }
        public DataSource()
        {
            Users = new[]
            {
                new User("Bob", 34, "Yandex"),
                new User("Joe", 21, "Mail Group"),
                new User("Sam", 43, "Yandex"),
                new User("Tim", 39, "Ozon"),
                new User("Leo", 26, "Avito"),
            };
        }
    }
}
