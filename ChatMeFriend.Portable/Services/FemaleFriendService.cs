using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChatMeFriend.Portable.Interfaces;
using ChatMeFriend.Portable.ViewModels;

namespace ChatMeFriend.Portable.Services
{
    public class FemaleFriendService : IFriendService
    {
        private UserViewModel user;

        public ViewModels.UserViewModel User
        {
            get
            {
                if (user == null)
                    user = new UserViewModel();

                return user;
            }
        }

        private PersonalityViewModel personality;
        public ViewModels.PersonalityViewModel Personality
        {
            get
            {
                if (personality == null)
                    personality = new PersonalityViewModel(){Gender = GenderType.Female};

                return personality;
            }
        }
    }
}
