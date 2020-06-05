using System;

namespace Bubble_Wrap_Bandits_Strike_Back
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= this.SkillLevel;

            Console.WriteLine($"{this.Name} is murdering all the guards! Decreased security by {this.SkillLevel}.");

            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine("All the guards have been successfully massacared! The Path has been cleared. Go!!!");
            }
        }
    }
}