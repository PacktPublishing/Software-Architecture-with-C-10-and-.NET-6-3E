namespace WWTravelClubDBTest
{
    public record PackagesListDTO
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public int DurationInDays { get; init; }
        public DateTime? StartValidityDate { get; init; }
        public DateTime? EndValidityDate { get; init; }
        public string DestinationName { get; init; }
        public int DestinationId { get; init; }
        public override string ToString()
        {
            return string.Format("{0}. {1} days in {2}, price: {3}", 
                Name, DurationInDays, DestinationName, Price);
        }
    }
}
