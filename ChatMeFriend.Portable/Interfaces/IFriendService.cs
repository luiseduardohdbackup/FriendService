using ChatMeFriend.Portable.ViewModels;

namespace ChatMeFriend.Portable.Interfaces
{
    public interface IFriendService
    {
        UserViewModel User { get; }
        CharacterViewModel Character { get; }
    }
}
