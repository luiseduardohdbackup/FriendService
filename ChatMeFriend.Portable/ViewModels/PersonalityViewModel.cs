using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirrious.MvvmCross.ViewModels;

namespace ChatMeFriend.Portable.ViewModels
{

    public enum PersonalityType
    {
        Flirty,
        Upset,
        Comedy,
        Caring
    }

    public enum GenderType
    {
        Male,
        Female,
        Other
    }

    public class PersonalityViewModel : MvxViewModel
    {
        private string name = "";
        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(() => Name); }
        }

        private GenderType gender;
        public GenderType Gender
        {
            get { return gender; }
            set { gender = value; RaisePropertyChanged(() => Gender); }
        }

        private PersonalityType personality;

        public PersonalityType Personality
        {
            get { return personality; }
            set { personality = value; RaisePropertyChanged(() => Personality); }
        }


        private int howOften = 0;

        public int HowOften
        {
            get { return howOften; }
            set { howOften = value; RaisePropertyChanged(()=>HowOften); }
        }

        private string pictureFileName;

        public string PictureFileName
        {
            get { return pictureFileName; }
            set { pictureFileName = value; RaisePropertyChanged(()=>PictureFileName); }
        }

    }
}
