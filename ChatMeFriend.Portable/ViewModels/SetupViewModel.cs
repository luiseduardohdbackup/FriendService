using Cirrious.MvvmCross.ViewModels;

namespace ChatMeFriend.Portable.ViewModels
{
    public class SetupViewModel
        : MvxViewModel
    {

        private UserViewModel user;
        public UserViewModel User
        {
            get { return user; }
            set { user = value; }
        }

        private PersonalityViewModel personality;


        public PersonalityViewModel Personality
        {
            get { return personality; }
            set { personality = value; }
        }
    }
}
