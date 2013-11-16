using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ChatMeFriend.Portable.Interfaces;
using Cirrious.MvvmCross.ViewModels;

namespace ChatMeFriend.Portable.ViewModels
{
    public class ChatViewModel 
		: MvxViewModel
    {   
        private ITextService textService;
        public ChatViewModel(ITextService textService)
        {
            this.textService = textService;
        }

        private ObservableCollection<TextMessageViewModel> textMessages = new ObservableCollection<TextMessageViewModel>();

        public ObservableCollection<TextMessageViewModel> TextMessages
        {
            get { return textMessages; }
            set { textMessages = value; RaisePropertyChanged(()=>TextMessages); }
        }

        private MvxCommand<string> addTextCommand;

        /// <summary>
        /// When you bind to this command you pass it a string and it will add this text message from the user
        /// to the local database and update the list.
        /// </summary>
        public ICommand AddTextCommand
        {
            get { return addTextCommand ?? (addTextCommand = new MvxCommand<string>(ExecuteAddTextCommand)); }
        }

        private void ExecuteAddTextCommand(string text)
        {
            TextMessages.Add(textService.AddUserText(text));
        }


    }
}
