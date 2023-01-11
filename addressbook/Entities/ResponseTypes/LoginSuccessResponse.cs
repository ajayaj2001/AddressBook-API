namespace AddressBook.Entities.ResponseTypes
{
    public class LoginSuccessResponse
    {
        public string token_type { get; set; }

        public string access_token { get; set; }
    }
}
