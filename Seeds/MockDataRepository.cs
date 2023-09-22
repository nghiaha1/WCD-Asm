using Application.Data;
using Application.Models;
using Faker;
using Microsoft.EntityFrameworkCore;
using RimuTec.Faker;

namespace Application.Seeds;

public class MockDataRepository
{
    private static List<Student> _students = new List<Student>();
    private static List<Class> _classes = new List<Class>();
    private static List<Course> _courses = new List<Course>();
    private static DatabaseContext databaseContext;

    public MockDataRepository(DatabaseContext _databaseContext)
    {
        databaseContext = _databaseContext;
    }

    public static void Seeding()
    {
        if (databaseContext._students.ToListAsync() != null)
        {
            return;
        }

        SeedStudent();
        databaseContext._classes.AddRange(_classes);
        databaseContext._courses.AddRange(_courses);
        databaseContext._students.AddRange(_students);
    }

    private static void SeedClass()
    {
        for (var i = 0; i < 10; i++)
        {
            _classes.Add(new Class(Faker.Name.FullName(NameFormats.Standard)));
        }
    }

    private static void SeedCourse()
    {
        for (var i = 0; i < 20; i++)
        {
            _courses.Add(new Course
            {
                Name = Faker.Name.FullName(NameFormats.Standard),
                Description = Faker.Lorem.Paragraph(10),
            });
        }
    }

    private static void SeedStudent()
    {
        SeedClass();
        SeedCourse();
        for (var i = 0; i < 20; i++)
        {
            var studentCode = "STD-" + Faker.RandomNumber.Next(100);
            var firstName = Faker.Name.First();
            var lastName = Faker.Name.Last();
            var fullName = firstName + " " + lastName;
            var email = firstName + lastName + studentCode + "@gmail.com";
            var address = Faker.Address.SecondaryAddress();
            var phone = Faker.Phone.Number();

            _students.Add(new Student(
                studentCode,
                fullName,
                email,
                address,
                phone,
                _classes,
                _courses
            ));
        }
    }
}