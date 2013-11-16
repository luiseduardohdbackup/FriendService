using System;
using ChatMeFriend.Portable.Interfaces;
using ChatMeFriend.Portable.ViewModels;

namespace ChatMeFriend.Portable.Services
{
    public class TextService : ITextService
    {
        private IFriendService friendService;
        private IDataService dataService;
        public TextService(IFriendService friendService, IDataService dataService)
        {
            this.friendService = friendService;
            this.dataService = dataService;
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

            this.dataService.Insert(textMessage);

            return textMessage;
        }
    }
}
