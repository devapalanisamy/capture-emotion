using System;
using CaptureEmotion.Settings;
using Realms;

namespace CaptureEmotion.Models
{
    public class Answered : RealmObject
    {
        private string _emotion;

        public void SaveEmotion(Emotion emotion)
        {
            _emotion = emotion.ToString();
        }

        public Emotion GetEmotion()
        {
           return (Emotion) Enum.Parse(typeof(Emotion), _emotion);
        }

        public string MoreDetails { get; set; }
        public DateTimeOffset UpdatedTime { get; set; }
    }
}