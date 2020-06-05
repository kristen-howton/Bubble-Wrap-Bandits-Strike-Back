using System;

namespace Bubble_Wrap_Bandits_Strike_Back
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= this.SkillLevel;

            Console.WriteLine($"{this.Name} has disabled the lazzzersss! Decreased lazer alarms by {this.SkillLevel}.");

            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"All the lazers are trashed garbage! {this.Name} is back! She/He is AWESOME!!!!");
            }
        }
    }
}