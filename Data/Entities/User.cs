using System.ComponentModel.DataAnnotations.Schema;

namespace micro_lotto.Data.Entities
{
    public class User
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("balance")]
        public float Balance { get; set; }

        [Column("username")]
        public string Username { get; set; }
    }
}
