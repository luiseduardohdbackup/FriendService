using ChatMeFriend.Portable.ViewModels;

namespace ChatMeFriend.Portable.Interfaces
{
    public interface ITextService
    {
        string GeneratePeronalityText();
        TextMessageViewModel AddUserText(string text);
    }
}
