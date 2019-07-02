namespace Homework6
{
    public class Builder
    {
        private string address;
        private string dressCode;
        private int guestsCount;

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void SetDressCode(string dressCode)
        {
            this.dressCode = dressCode;
        }

        public void SetGuestsCount(int guestsCount)
        {
            this.guestsCount = guestsCount;
        }

        public Celebration GetCelebration()
        {
            return new Celebration()
            {
                Address = address,
                DressCode = dressCode,
                GuestsCount = guestsCount
            };
        }
    }
}
