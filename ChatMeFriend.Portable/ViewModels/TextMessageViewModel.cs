using System;
using Cirrious.MvvmCross.Plugins.Sqlite;
using Cirrious.MvvmCross.ViewModels;

namespace ChatMeFriend.Portable.ViewModels
{
    public class TextMessageViewModel 
		: MvxViewModel
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }


        private string text = String.Empty;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private DateTime time = DateTime.UtcNow;
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        [Ignore]
        public string TimeDisplay
        {
            get { return String.Format("{0:d/M/yyyy HH:mm:ss}", time.ToLocalTime()); }
        }

        private string pictureFileName = string.Empty;

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
