using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChatMeFriend.Portable.Interfaces;
using ChatMeFriend.Portable.ViewModels;

namespace ChatMeFriend.Portable.Services
{
    public class TextService : ITextService
    {
        private IFriendService friendService;
        public TextService(IFriendService friendService)
        {
            this.friendService = friendService;
        }

        public string GeneratePeronalityText()
        {
            return "Nina is awesome!";
        }

        public TextMessageViewModel AddUserText(string text)
        {
            var textMessage = new TextMessageViewModel();
            textMessage.Text = text;
            textMessage.Name = friendService.User.Name;
            textMessage.PictureFileName = friendService.User.PictureFileName;
            textMessage.Time = DateTime.UtcNow;

            return textMessage;
        }
    }
}
