namespace micro_lotto.Data.Contracts
{
    public class BetDTO
    {
        public string ISOTime { get; set; }
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int ThirdNumber { get; set; }
        public int FourthNumber { get; set; }
        public int FifthNumber { get; set; }
        public int UserId { get; set; }
    }
}
