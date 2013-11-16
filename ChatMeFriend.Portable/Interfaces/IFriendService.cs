using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChatMeFriend.Portable.ViewModels;

namespace ChatMeFriend.Portable.Interfaces
{
    public interface IFriendService
    {
        UserViewModel User { get; }
        PersonalityViewModel Personality { get; }
    }
}
