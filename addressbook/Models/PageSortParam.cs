
namespace addressbook.Models
{
    public class PageSortParam
    {
        public int Size { get; set; } = 10;  //default page size
        public int PageNo { get; set; } = 1;
        public string SortBy { get; set; } = null;
        public SortDirection SortOrder { get; set; }
    }

    public enum SortDirection
    {
        ASC = 0,   //default as ascending
        DESC
    }
}
