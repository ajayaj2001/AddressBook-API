namespace AddressBook.Entities.Dtos
{
    public class PageSortParam
    {
        ///<summary>
        ///count of addressbook to display
        ///</summary>
        public int Size { get; set; }

        ///<summary>
        ///page number of display all address book
        ///</summary>
        public int PageNo { get; set; }

        ///<summary>
        ///sort by which field
        ///</summary>
        public string SortBy { get; set; }

        ///<summary>
        ///sort in which direction asc or desc
        ///</summary>
        public string SortOrder { get; set; }
    }
}
