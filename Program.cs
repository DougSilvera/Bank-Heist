using System;
using System.Collections.Generic;

namespace BankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            HeistCrew HeistCrew1 = new HeistCrew("Coolest Heist Crew Ever");
            Console.WriteLine("Plan Your Heist!");
            bool run = true;
            while (run)
            {
            Console.Write("What is your team members name?: ");
            string teamMember = Console.ReadLine();
            if (teamMember == "")
            {
                run = false;
            } else {

            Console.Write("Enter team member's skill level (number): ");
            var teamMemberSkill = int.Parse(Console.ReadLine());

            Console.Write("Enter your team member's courage level (0.0-2.0): ");
            var teamMemberCourage = double.Parse(Console.ReadLine());

            TeamMember teamMemberNew = new TeamMember(teamMember,teamMemberSkill,teamMemberCourage);

            HeistCrew1.addTeamMember(teamMemberNew);
            }
            

            }
            

            HeistCrew1.displayHeistCrew();
            Console.WriteLine($"Number of team members {HeistCrew1.HeistTeam.Count}");

        }
    }
}
