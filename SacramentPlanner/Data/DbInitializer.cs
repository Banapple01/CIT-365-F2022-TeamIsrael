using SacramentPlanner.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Data
{
    public class DbInitializer
    {
        public static void Initialize(SacramentPlannerContext context)
        {

            // Look for any Planners
            if (context.Planner.Any())
            {
                return; // Db already has data
            }

            var planners = new Planner[]
            {
                new Planner{PlannerDate=DateTime.Parse("2022-12-5"),Conducting="Someone"},
                new Planner{PlannerDate=DateTime.Parse("2022-04-16")},
                new Planner{PlannerDate=DateTime.Parse("2021-05-24"),Conducting="Joe"},
                new Planner{PlannerDate=DateTime.Parse("2020-11-23")},
            };
            foreach (Planner p in planners)
            {
                context.Planner.Add(p);
            }
            context.SaveChanges();

            var speakers = new Speaker[]
            {
                new Speaker{PlannerId=1, SpeakerName="toodyfrooty", SpeakerSubject="Faith"},
                new Speaker{PlannerId=1, SpeakerName="toodyfro", SpeakerSubject="Fait"},
                new Speaker{PlannerId=2, SpeakerName="toodyf", SpeakerSubject="Fai"},
                new Speaker{PlannerId=3, SpeakerName="toody", SpeakerSubject="Fa"},
                new Speaker{PlannerId=3, SpeakerName="toofrooty", SpeakerSubject="F"},
                new Speaker{PlannerId=3, SpeakerName="tfrooty", SpeakerSubject="Fth"},
                new Speaker{PlannerId=4, SpeakerName="frooty", SpeakerSubject="th"},
                new Speaker{PlannerId=4, SpeakerName="too", SpeakerSubject="aith"},
                new Speaker{PlannerId=5, SpeakerName="t", SpeakerSubject="h"}
            };
            foreach (Speaker s in speakers)
            {
                context.Speaker.Add(s);
            }
            context.SaveChanges();
        }
    }
}
