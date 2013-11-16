using System;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;

namespace ChatMeFriend.Portable.ViewModels
{
    public class TextMessageViewModel 
		: MvxViewModel
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private DateTime time;
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        private string pictureFileName;

        public string PictureFileName
        {
            get { return pictureFileName; }
            set { pictureFileName = value; RaisePropertyChanged(() => PictureFileName); }
        }


        private string name = "";
        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(() => Name); }
        }
    }
}
