namespace Bubble_Wrap_Bandits_Strike_Back
{
    public interface IRobber {
        string Name { get; set; }

        int SkillLevel { get; set; }

        int PercentageCut { get; set; }

        void PerformSkill(Bank bank);
    }
}