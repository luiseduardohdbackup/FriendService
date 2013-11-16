using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirrious.MvvmCross.ViewModels;

namespace ChatMeFriend.Portable.ViewModels
{
    public class UserViewModel : MvxViewModel
    {


        private string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(() => Name); }
        }

        private string location = string.Empty;
        public string Location
        {
            get { return location; }
            set { location = value; RaisePropertyChanged(() => Location); }
        }


        private GenderType gender;
        public GenderType Gender
        {
            get { return gender; }
            set { gender = value; RaisePropertyChanged(()=>Gender);}
        }


        private string pictureFileName;

        public string PictureFileName
        {
            get { return pictureFileName; }
            set { pictureFileName = value; RaisePropertyChanged(() => PictureFileName); }
        }
    }
}
