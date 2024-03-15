using System.ComponentModel.DataAnnotations;

namespace APIFun.Data
{
    public class Bowlers
    {
        [Key]
        public int BowlerID { get; set; }
        public string? BowlerLastName { get; set; }
        public string? BowlerFirstName { get; set; }
        public string? BowlerMiddleInit { get; set; }
        public string? BowlerAddress { get; set; }
        public string? BowlerCity { get; set; }
        public string? BowlerState { get; set; }
        public int BowlerZip { get; set; }
        public string? BowlerPhoneNumber { get; set; }
        public string? TeamName { get; set; }

    }
}
