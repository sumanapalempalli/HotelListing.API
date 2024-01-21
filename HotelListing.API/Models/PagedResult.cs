namespace HotelListing.API.Models
{
    public class PagedResult<T>
    {
        public int PageNumber { get; set; }

        public int TotalRecords { get; set; }

        public int RecordNumber { get; set; }

        public List<T> Items { get; set; }
    }
}
