using Microsoft.EntityFrameworkCore;

namespace CardSort.services;

public class DbService(DbContext dbContext) : IDbService
{
    public async Task ValidateDb()
    {
        try
        {
            Console.WriteLine("Checking for migrations updates");
            var migrations = await dbContext.Database.GetPendingMigrationsAsync();
            var migrates = migrations as string[] ?? migrations.ToArray();
            Console.WriteLine("Migrations length is: " + migrates.Length);
            if (migrates.Length != 0)
            {
                Console.WriteLine("I Get Here");
                await dbContext.Database.MigrateAsync();
                Console.WriteLine("Migrations Execute Successfully");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}