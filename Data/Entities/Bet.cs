using System.ComponentModel.DataAnnotations.Schema;

namespace micro_lotto.Data.Entities
{
    public class Bet
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("iso_time")]
        public string ISOTime { get; set; }

        [Column("first_number")]
        public int FirstNumber { get; set; }
        
        [Column("second_number")]
        public int SecondNumber { get; set; }
        
        [Column("third_number")]
        public int ThirdNumber { get; set; }
        
        [Column("fourth_number")]
        public int FourthNumber { get; set; }
        
        [Column("fifth_number")]
        public int FifthNumber { get; set; }
        
        public User User { get; set; }
    }
}
