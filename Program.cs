using System;

namespace BankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            
            Console.Write("What is your team members name?: ");
            string teamMember = Console.ReadLine();
            
            Console.Write("Enter team member's skill level (number): ");
            var teamMemberSkill = int.Parse(Console.ReadLine());

            Console.Write("Enter your team member's courage level (0.0-2.0): ");
            var teamMemberCourage = double.Parse(Console.ReadLine());

            Console.WriteLine($"Team Member information:\nName: {teamMember} \nSkill level: {teamMemberSkill} \nCourage level: {teamMemberCourage}");


        }
    }
}
