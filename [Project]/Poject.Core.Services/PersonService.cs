using Biz.Person;

namespace HIH.Core.Services
{
    public class PersonService
    {
        public Person[] GetSamplePeople()
        {
            Person[] people = new Person[]
            {
                new Person{Id= 0, Title="Something a" , Age= 35 },
                new Person{Id= 1, Title="Something b" , Age= 38 },
                new Person{Id= 2, Title="Something c" , Age= 30 },
                new Person{Id= 3, Title="Something d" , Age= 40 },
                new Person{Id= 4, Title="Something e" , Age= 25 }
            };
            return people;
        }

    }
}
