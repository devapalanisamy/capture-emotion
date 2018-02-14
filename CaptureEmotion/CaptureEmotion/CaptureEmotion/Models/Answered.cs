using System;
using CaptureEmotion.Settings;
using CaptureEmotion.Utilities;
using Realms;

namespace CaptureEmotion.Models
{
    public class Answered : RealmObject
    {
        private string _emotion;

        public string MoreDetails { get; set; }
        public DateTimeOffset UpdatedTime { get; set; }
        public bool MoreDetailsEntered { get; set; }
        public string DateInfo
        {
            get { return DateUtility.GetPrettyDate(UpdatedTime.UtcDateTime); }
        }

        public string Emotion { get; set; }
        public string EmotionImage
        {
            get { return $"{Emotion}.png"; }
        }

        public bool IsDetailsVisible
        {
            get
            {
                if (String.IsNullOrEmpty(MoreDetails))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}