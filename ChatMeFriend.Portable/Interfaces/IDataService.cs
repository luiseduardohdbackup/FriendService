using System.Collections.Generic;
using ChatMeFriend.Portable.ViewModels;

namespace ChatMeFriend.Portable.Interfaces
{
    public interface IDataService
    {
        List<TextMessageViewModel> GetTextMessages();
        void Insert(TextMessageViewModel textMessage);
        int Count { get; }
    }

}
