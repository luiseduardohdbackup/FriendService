using System.Collections.Generic;
using System.Linq;
using ChatMeFriend.Portable.Interfaces;
using ChatMeFriend.Portable.ViewModels;
using Cirrious.MvvmCross.Plugins.Sqlite;

namespace ChatMeFriend.Portable.Services
{
    public class DataService : IDataService
    {
        private readonly ISQLiteConnection connection;


        public DataService(ISQLiteConnectionFactory factory)
        {
            connection = factory.Create("chatmefriend.sql");
            connection.CreateTable<TextMessageViewModel>();
        }


        public List<TextMessageViewModel> GetTextMessages()
        {
            return connection.Table<TextMessageViewModel>()
                              .OrderBy(x => x.Time)
                              .ToList();
        }


        public void Insert(TextMessageViewModel textMessage)
        {
            connection.Insert(textMessage);
        }




        public int Count
        {
            get
            {
                return connection.Table<TextMessageViewModel>().Count();
            }
        }
    }

}
