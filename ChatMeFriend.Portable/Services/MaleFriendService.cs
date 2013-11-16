using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChatMeFriend.Portable.Interfaces;
using ChatMeFriend.Portable.ViewModels;

namespace ChatMeFriend.Portable.Services
{
    public class MaleFriendService : IFriendService
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

        private CharacterViewModel personality;
        public ViewModels.CharacterViewModel Personality
        {
            get
            {
                if (personality == null)
                    personality = new CharacterViewModel(){Gender = GenderType.Male};

                return personality;
            }
        }
    }
}
