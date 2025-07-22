namespace hey.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public int NumberOfSeats { get; set; }

        public DateTime BookingDate { get; set; } = DateTime.Now;
    }
}
