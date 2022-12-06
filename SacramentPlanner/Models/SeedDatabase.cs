using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Data;

namespace SacramentPlanner.Models;

public class SeedDatabase
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new SacramentPlannerContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<SacramentPlannerContext>>()))
        {
            if (context == null || context.Planner == null)
            {
                throw new ArgumentNullException("Null SacramentPlannerContext");
            }

            // Look for any Planners.
            if (context.Planner.Any())
            {
                return;   // DB has been seeded
            }

            context.Planner.AddRange(
                new Planner
                {
                    PlannerDate = DateTime.Now,
                    Conducting = "Billy Thorpe",
                    Presiding = "Charlie Jones",
                    OpeningHymn = "I am Like a Star",
                    SacramentHymn = "A Child's Prayer",
                    IntermediateHymn = "Head, Shoulders, Knees, and Toes",
                    ClosingHymn = "Popcorn Popping on the Apricot Tree",
                    OpeningPrayer = "Jenny Collins",
                    ClosingPrayer = "Alfalfa Gerard",
                    //Speakers = { SpeakerName = "Julie Brown", SpeakerSubject = ""}

                },

                new Planner
                {
                    PlannerDate = DateTime.Now,
                    Conducting = "Harry Potter",
                    Presiding = "Albus Dumbledor",
                    OpeningHymn = "Double, Double, Toil and Trouble",
                    SacramentHymn = "Hogwart's Theme",
                    IntermediateHymn = "",
                    ClosingHymn = "Diagon Alley",
                    OpeningPrayer = "Jenny Weasley",
                    ClosingPrayer = "George Weasley"
                },

                new Planner
                {
                    PlannerDate = DateTime.Now,
                    Conducting = "Dansel Nelson",
                    Presiding = "Russel Nelson",
                    OpeningHymn = "Away in a Manger",
                    SacramentHymn = "While of These Emblems We Partake",
                    IntermediateHymn = "Special Musical Number",
                    ClosingHymn = "Hark, The Herald Angels Sing",
                    OpeningPrayer = "Dallin Oaks",
                    ClosingPrayer = "Joseph Smith"
                }
            );
            context.SaveChanges();
        }
    }
}
