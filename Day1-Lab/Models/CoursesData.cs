using System.Text.Json;

namespace Day1_Lab.Models
{
    public static class CoursesData
    {
        public static List<Course> Courses { get; set; } = 
            new List<Course> {
                new Course {ID = 1, Name = "Java", Duration = 2, Status = true },
                new Course {ID = 2, Name = "C#", Duration = 1, Status = false },
                new Course {ID = 3, Name = "SQL", Duration = 3, Status = true },
            };

        //public  static List<Course> SeedData()
        //{

        //    if (!Courses.Any())
        //    {
        //        var coursesData = File.ReadAllText("Models/Courses.json");
        //        var resut = JsonSerializer.Deserialize<List<Course>>(coursesData);
        //        return resut;
        //    }
        //    return Courses;
        //}
    }

}
