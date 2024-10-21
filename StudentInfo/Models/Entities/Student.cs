namespace StudentInfo.Models.Entities
{
    public class Student
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Age { get; set; }
        public string Year { get; set; }
        public string Section { get; set; }
    }
}
