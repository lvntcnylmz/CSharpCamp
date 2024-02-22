using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

Console.WriteLine("*** Welcome to The Course Management System ***");
Console.WriteLine("===============================================");

Console.WriteLine("\n - Courses - ");
var courseManager = new CourseManager(new CourseDal());
var courses = courseManager.GetAll();
courses.ForEach(c => Console.WriteLine(c.Id + " - " + c.Name));

Console.WriteLine("\n - Categories - ");
var categoryManager = new CategoryManager(new CategoryDal());
var categories = categoryManager.GetAll();
categories.ForEach(c => Console.WriteLine(c.Name));

Console.WriteLine("\n - Instructors - ");
var instructorManager = new InstructorManager(new InstructorDal());
var instructors = instructorManager.GetAll();
instructors.ForEach(i => Console.WriteLine(i.FirstName + " " + i.LastName));