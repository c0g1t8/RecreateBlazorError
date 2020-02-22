namespace Biz.Person
{
    public class Person : Entity
    {
        public string Title { get; set; }
        public int Age { get; set; }

        public Tag[] Tags { get; set; }
    }
}
