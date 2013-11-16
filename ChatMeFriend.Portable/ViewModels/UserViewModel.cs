using ChatMeFriend.Portable.Helpers;
using Cirrious.MvvmCross.ViewModels;

namespace ChatMeFriend.Portable.ViewModels
{
    public class UserViewModel : MvxViewModel
    {


        public string Name
        {
            get { return Settings.UserName; }
            set { Settings.UserName = value; RaisePropertyChanged(() => Name); }
        }

        public string Location
        {
            get { return Settings.UserLocation; }
            set { Settings.UserLocation = value; RaisePropertyChanged(() => Location); }
        }


        private GenderType gender;
        public GenderType Gender
        {
            get { return gender; }
            set { gender = value; RaisePropertyChanged(()=>Gender);}
        }



        public string PictureFileName
        {
            get { return Settings.UserPicture; }
            set { Settings.UserPicture = value; RaisePropertyChanged(() => PictureFileName); }
        }
    }
}
