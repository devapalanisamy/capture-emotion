using System.Linq;
using CaptureEmotion.Models;

namespace CaptureEmotion
{
    public interface IRealmService
    {
        IQueryable<Answered> GetAllAnswers();
        void SaveAnswer(Answered answer);
    }
}