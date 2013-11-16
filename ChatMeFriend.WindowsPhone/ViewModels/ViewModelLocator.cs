using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatMeFriend.Portable.Services;
using ChatMeFriend.Portable.ViewModels;

namespace ChatMeFriend.WindowsPhone.ViewModels
{
    public class ViewModelLocator
    {

        public ChatViewModel MainPage
        {
            get { return new ChatViewModel(new TextService(new MaleFriendService())); }
        }


        public SetupViewModel EditFriend
        {
            get { return new SetupViewModel(); }
        }
    }
}
