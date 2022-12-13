using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Data;
using System.Linq;

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
                    PlannerDate = new DateTime(2018, 7, 20),
                    Conducting = "Billy Thorpe",
                    Presiding = "Charlie Jones",
                    OpeningHymn = "I am Like a Star",
                    SacramentHymn = "A Child's Prayer",
                    IntermediateHymn = "Head, Shoulders, Knees, and Toes",
                    ClosingHymn = "Popcorn Popping on the Apricot Tree",
                    OpeningPrayer = "Jenny Collins",
                    ClosingPrayer = "Alfalfa Gerard",
                    Speaker1 = "Julie Brown",
                    Speaker2 = "Gabe Schnell",
                    Speaker3 = "James May",
                    Topic1 = "Atonement",
                    Topic2 = "Word of Wisdom",
                    Topic3 = "Ministering",
                    Speakers = new List<Speaker>()

                },

                new Planner
                {
                    PlannerDate = new DateTime(2022, 3, 12),
                    Conducting = "Harry Potter",
                    Presiding = "Albus Dumbledor",
                    OpeningHymn = "Double, Double, Toil and Trouble",
                    SacramentHymn = "Hogwart's Theme",
                    IntermediateHymn = "",
                    ClosingHymn = "Diagon Alley",
                    OpeningPrayer = "Jenny Weasley",
                    ClosingPrayer = "George Weasley",
                    Speaker1 = "Parvati Patil",
                    Speaker2 = "Neville LongBottom",
                    Speaker3 = "Peter Pettigrew",
                    Topic1 = "Faith",
                    Topic2 = "CTR",
                    Topic3 = "Charity",
                    Speakers = new List<Speaker>()
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
                    ClosingPrayer = "Joseph Smith",
                    Speaker1 = "Thomas Monson",
                    Speaker2 = "Emma Smith",
                    Speaker3 = "John Bytheway",
                    Topic1 = "Family History",
                    Topic2 = "Trials",
                    Topic3 = "Holy Ghost",
                    Speakers = new List<Speaker>()
                }
            );
            context.SaveChanges();

            var speakers = new List<Speaker> {
                new Speaker
                {
                    Planner = context.Planner.FirstOrDefault(d => d.Id == 1),
                    SpeakerName = "Joe",
                    SpeakerSubject = "Souls"
                },

                new Speaker
                {
                    Planner = context.Planner.FirstOrDefault(d => d.Id == 2),
                    SpeakerName = "Kelly",
                    SpeakerSubject = "Heavenly Mother"
                },

                new Speaker
                {
                    Planner = context.Planner.FirstOrDefault(d => d.Id == 3),
                    SpeakerName = "Ken",
                    SpeakerSubject = "Heavenly Father"
                }
            };
            context.Planner.FirstOrDefault(d => d.Id == 1).Speakers.Add(speakers[0]);
            context.SaveChanges();
        }
    }
}
