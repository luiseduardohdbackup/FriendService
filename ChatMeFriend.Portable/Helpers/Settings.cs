using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ceton.mvx.plugins.settings;
using ChatMeFriend.Portable.ViewModels;
using Cirrious.CrossCore;

namespace ChatMeFriend.Portable.Helpers
{
    public static class Settings
    {

        /// Simply setup your settings once when it is initialized.
        /// </summary>
        private static ISettings m_Settings;
        private static ISettings AppSettings
        {
            get
            {
                return m_Settings ?? (m_Settings = m_Settings = Mvx.GetSingleton<ISettings>());
            }
        }

        #region Setting Constants

        private const string UserNameKey = "username";
        private const string UserNameDefault = "";
        private const string UserPictureKey = "userpicture";
        private const string UserPictureDefault = "";
        private const string UserLocationKey = "userlocation";
        private const string UserLocationDefault = "Cambridge";
        private const int UserGenderDefault = (int)GenderType.Female;
        private const string UserGenderKey = "usergender";
        private const string PersonalityNameKey = "personalityname";
        private const string PersonalityNameDefault = "";
        private const string PersonalityTypeKey = "personalitytype";
        private const int PersonalityTypeDefault = (int)PersonalityType.Flirty;
        private const string PersonalityHowOftenKey = "personalityhowoften";
        private const int PersonalityHowOftenDefault = (int)TextInterval.HalfHour;
        private const string PersonalityPictureKey = "personalitypicture";
        private const string PersonalityPictureDefault = "";
        #endregion

        public static string UserName
        {
            get
            {
                return AppSettings.GetValueOrDefault(UserNameKey, UserNameDefault);
            }
            set
            {
                //if value has changed then save it!
                if (AppSettings.AddOrUpdateValue(UserNameKey, value))
                    AppSettings.Save();
            }
        }

        public static string UserLocation
        {
            get
            {
                return AppSettings.GetValueOrDefault(UserLocationKey, UserLocationDefault);
            }
            set
            {
                //if value has changed then save it!
                if (AppSettings.AddOrUpdateValue(UserLocationKey, value))
                    AppSettings.Save();
            }
        }

        public static string UserPicture
        {
            get
            {
                return AppSettings.GetValueOrDefault(UserPictureKey, UserPictureDefault);
            }
            set
            {
                //if value has changed then save it!
                if (AppSettings.AddOrUpdateValue(UserPictureKey, value))
                    AppSettings.Save();
            }
        }


        public static GenderType UserGender
        {
            get
            {
                return (GenderType)AppSettings.GetValueOrDefault(UserGenderKey, UserGenderDefault);
            }
            set
            {
                //if value has changed then save it!
                if (AppSettings.AddOrUpdateValue(UserGenderKey, (int)value))
                    AppSettings.Save();
            }
        }


        public static string PersonalityName
        {
            get
            {
                return AppSettings.GetValueOrDefault(PersonalityNameKey, PersonalityNameDefault);
            }
            set
            {
                //if value has changed then save it!
                if (AppSettings.AddOrUpdateValue(PersonalityNameKey, value))
                    AppSettings.Save();
            }
        }


        public static PersonalityType PersonalityType
        {
            get
            {
                return(PersonalityType) AppSettings.GetValueOrDefault(PersonalityTypeKey, PersonalityTypeDefault);
            }
            set
            {
                //if value has changed then save it!
                if (AppSettings.AddOrUpdateValue(PersonalityTypeKey, (int)value))
                    AppSettings.Save();
            }
        }


        public static TextInterval PersonalityHowOften
        {
            get
            {
                return (TextInterval)AppSettings.GetValueOrDefault(PersonalityHowOftenKey, PersonalityHowOftenDefault);
            }
            set
            {
                //if value has changed then save it!
                if (AppSettings.AddOrUpdateValue(PersonalityHowOftenKey, (int)value))
                    AppSettings.Save();
            }
        }

        public static string PersonalityPicture
        {
            get
            {
                return AppSettings.GetValueOrDefault(PersonalityPictureKey, PersonalityPictureDefault);
            }
            set
            {
                //if value has changed then save it!
                if (AppSettings.AddOrUpdateValue(PersonalityPictureKey, value))
                    AppSettings.Save();
            }
        }


    }
}
