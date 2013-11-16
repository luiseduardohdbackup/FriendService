using ChatMeFriend.Portable.Services;
using ChatMeFriend.Portable.ViewModels;

namespace ChatMeFriend.WindowsPhone.ViewModels
{
    public class ViewModelLocator
    {

        public ChatViewModel MainPage
        {
            get { return new ChatViewModel(new TextService(new MaleFriendService(), new DataService(null))); }
        }


        public SetupViewModel EditFriend
        {
            get { return new SetupViewModel(new MaleFriendService()); }
        }
    }
}
