using System;

namespace Bubble_Wrap_Bandits_Strike_Back
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= this.SkillLevel;

            Console.WriteLine($"{this.Name} is destroying all the locks! Decreased security by {this.SkillLevel}.");

            if (bank.VaultScore <= 0)
            {
                Console.WriteLine("All the locks have been obliterated! You are the key to our success! We love");
            }
        }
    }
}