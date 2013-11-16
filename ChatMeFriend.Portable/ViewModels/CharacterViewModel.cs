using ChatMeFriend.Portable.Helpers;
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

    public enum TextInterval
    {
        TenMinutes,
        HalfHour,
        Hourly,
        SixHours,
        TwelveHours,
        TwentyFourHours
    }

    public class CharacterViewModel : MvxViewModel
    {
        public string Name
        {
            get { return Settings.PersonalityName; }
            set { Settings.PersonalityName = value; RaisePropertyChanged(() => Name); }
        }

        private GenderType gender;
        public GenderType Gender
        {
            get { return gender; }
            set { gender = value; RaisePropertyChanged(() => Gender); }
        }

        public PersonalityType Personality
        {
            get { return Settings.PersonalityType; }
            set { Settings.PersonalityType = value; RaisePropertyChanged(() => Personality); }
        }

        public TextInterval HowOften
        {
            get { return Settings.PersonalityHowOften; }
            set { Settings.PersonalityHowOften = value; RaisePropertyChanged(()=>HowOften); }
        }

        public string PictureFileName
        {
            get { return Settings.PersonalityPicture; }
            set { Settings.PersonalityPicture = value; RaisePropertyChanged(()=>PictureFileName); }
        }

    }
}
