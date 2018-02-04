using System.Linq;
using CaptureEmotion.Models;
using Realms;

namespace CaptureEmotion.Services
{
    public class RealmService : IRealmService
    {
        private readonly Realm _realm;

        public RealmService()
        {
                _realm = Realm.GetInstance();
        }

        public IQueryable<Answered> GetAllAnswers()
        {
            return _realm.All<Answered>();
        }

        public void SaveAnswer(Answered answer)
        {
            _realm.Write(() =>
            {
                _realm.Add(answer);
            });
        }
    }
}