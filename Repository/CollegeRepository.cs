public static class CollegeRepository
{
    public static List<Student> Students { get; set; } = new List<Student>()
    {
        new Student
        {
            ID = 1,
            Name = "Student1",
            Address = "Kathmandu"
        },
        new Student
        {
            ID = 2,
            Name = "Student2",
            Address = "Lalitpur"
        },
        new Student
        {
            ID = 3,
            Name = "Student3",
            Address = "Bhaktapur"
        },
        new Student
        {
            ID = 4,
            Name = "Student4",
            Address = "Pokhara"
        }
    };
}


