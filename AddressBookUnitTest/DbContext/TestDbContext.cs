using AddressBook.DbContexts;
using AddressBook.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;

namespace AddressBookUnitTest.DbContext
{
    public static class TestDbContext
    {
        /// <summary>
        /// This method is used to create the InMemeorydatabase
        /// </summary>
        /// <returns></returns>
        public static AddressBookContext addressBookDbContext()
        {
            var options = new DbContextOptionsBuilder<AddressBookContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;
            var context = new AddressBookContext(options);

            return context;
        }
    }
}

