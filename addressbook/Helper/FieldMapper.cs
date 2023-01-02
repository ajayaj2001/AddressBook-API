using addressbook.Entities;
using addressbook.Services;
using System.Linq;

namespace addressbook.Helper
{
    public class FieldMapper
    {

        public static User updateFields(User userData, IUserRepositary userRepositary)
        {
            var updatedUser = userData;

            updatedUser.Emails = userRepositary.GetEmailIds(userData.UserId).ToList();
            updatedUser.Addresses = userRepositary.GetAddressIds(userData.UserId).ToList();
            updatedUser.Phones = userRepositary.GetPhoneIds(userData.UserId).ToList();
            updatedUser.AssetDto = userRepositary.GetAssetIds(userData.UserId).ToList();

            return updatedUser;
        }
    }
}
