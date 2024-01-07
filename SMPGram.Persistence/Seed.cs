using SMPGram.Domain;

namespace SMPGram.Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;

            var activities = new List<Activity>()
            {
                new Activity{Title = "Past Activity 1",Date = DateTime.UtcNow.AddMonths(-2),Description = "Activity 2 Months Ago",Category = "drinks",City = "London",Venue = "Pub",}
            };
            
            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();

        }
    }
}