using Microsoft.EntityFrameworkCore;

using EFMigrationApp;

using (ApplicationContext context = new())
{
    //Employee bob = new() { Name = "Bob", Age = 34 };
    //context.Employees.Add(bob);
    //await context.SaveChangesAsync();
    await context.Database.MigrateAsync();

    //var employees = context.Employees.ToList();
    //foreach(var employee in employees)
    //    Console.WriteLine(employee.Name + " " + employee.Age);
}