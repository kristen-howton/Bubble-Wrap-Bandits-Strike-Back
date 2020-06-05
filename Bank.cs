namespace Bubble_Wrap_Bandits_Strike_Back
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }

        private int _sum

        {
            get
            {
                return
                AlarmScore + VaultScore + SecurityGuardScore;

            }
        }
        public bool IsSecure
        {
            get

            {
                if (_sum <= 0)
                {
                    return false;

                }
                else
                {
                    return true;
                }

            }
        }
    }
}