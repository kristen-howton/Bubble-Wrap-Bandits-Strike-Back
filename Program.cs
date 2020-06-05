using System;
using System.Collections.Generic;

namespace Bubble_Wrap_Bandits_Strike_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker Hack = new Hacker()
            {
                Name = "Jon Durr",
                SkillLevel = 80,

            };
            Hacker C_Sharp = new Hacker()
            {
                Name = "Crystal Elsey",
                SkillLevel = 82,

            };
            LockSpecialist YourNameIsTooLong = new LockSpecialist()
            {
                Name = "Brant Pippin",
                SkillLevel = 85,

            };
            LockSpecialist BeardedBandit = new LockSpecialist()
            {
                Name = "Derek Buckley",
                SkillLevel = 79,

            };
            Muscle BonnieK = new Muscle()
            {
                Name = "Kristen Howton",
                SkillLevel = 97,

            };

            List<IRobber> rolodex = new List<IRobber>
            {

                Hack,
                C_Sharp,
                YourNameIsTooLong,
                BeardedBandit,
                BonnieK
            };

            Console.WriteLine($" The Number of operatives in your rolodex is {rolodex.Count}!!!!!");

        }
    }
}