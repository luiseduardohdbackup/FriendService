using ChatMeFriend.Portable.Interfaces;
using Cirrious.MvvmCross.ViewModels;

namespace ChatMeFriend.Portable.ViewModels
{
    public class SetupViewModel
        : MvxViewModel
    {

        private IFriendService friendService;
        public SetupViewModel(IFriendService friendService)
        {
            this.friendService = friendService;
        }

        public UserViewModel User
        {
            get { return friendService.User; }
        }


        public CharacterViewModel Personality
        {
            get { return friendService.Personality; }
        }
    }
}
