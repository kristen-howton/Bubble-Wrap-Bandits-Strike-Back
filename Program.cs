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

            Console.WriteLine($"The Number of operatives in your rolodex is {rolodex.Count}!!!!!");

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine($"Enter the name of a new operative!");
                string newOperative = Console.ReadLine();
                if (newOperative != "")
                {
                    Console.WriteLine("");
                    Console.WriteLine($@"Choose a speciality: 
Enter 1 for Hacker
Enter 2 for Muscle
Enter 3 for Lock Specialist");

                    Console.WriteLine("");
                    string newSpecialty = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine($"Choose a skill level: 1-100");
                    string newSkillLevel = Console.ReadLine();
                    int skillLevelInt = Int32.Parse(newSkillLevel);
                    Console.WriteLine("");
                    Console.WriteLine("What percentage of the cut does this operative get?");
                    string newCut = Console.ReadLine();
                    int cutInt = Int32.Parse(newCut);

                    if (newSpecialty == "1")
                    {
                        Hacker hacker = new Hacker()
                        {
                        Name = newOperative,
                        SkillLevel = skillLevelInt,
                        PercentageCut = cutInt
                        };
                        rolodex.Add(hacker);
                    }
                    else if (newSpecialty == "2")
                    {
                        Muscle muscle = new Muscle()
                        {
                        Name = newOperative,
                        SkillLevel = skillLevelInt,
                        PercentageCut = cutInt
                        };
                        rolodex.Add(muscle);

                    }
                    else if (newSpecialty == "3")
                    {
                        LockSpecialist lockDude = new LockSpecialist()
                        {
                        Name = newOperative,
                        SkillLevel = skillLevelInt,
                        PercentageCut = cutInt
                        };
                        rolodex.Add(lockDude);
                    }
                }
                else
                {
                    break;
                }
                /*AlarmScore (between 0 and 100)
                VaultScore (between 0 and 100)
                SecurityGuardScore (between 0 and 100)
                CashOnHand (between 50,000 and 1 million) */
                Random oneToAHundred = new Random();
                int oneToAHundredInt = oneToAHundred.Next(0,101);
                Random oneToAHundred2 = new Random();
                int oneToAHundredInt2 = oneToAHundred.Next(0,101);
                Random oneToAHundred3 = new Random();
                int oneToAHundredInt3 = oneToAHundred.Next(0,101);
                Random FiddyToMillion = new Random();
                int FiddyToMillionInt = FiddyToMillion.Next(50_000, 1_000_001);

                Bank Andy = new Bank()
                {
                    CashOnHand = FiddyToMillionInt,
                    AlarmScore = oneToAHundredInt,
                    VaultScore = oneToAHundredInt2,
                    SecurityGuardScore = oneToAHundredInt3
                };
                
            }
        }

    }
}