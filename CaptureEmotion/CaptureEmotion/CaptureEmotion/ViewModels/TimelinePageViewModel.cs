using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CaptureEmotion.Models;
using Prism.Navigation;

namespace CaptureEmotion.ViewModels
{
	public class TimelinePageViewModel : BindableBase
	{
	    private readonly IRealmService _realmService;
        public TimelinePageViewModel(IRealmService realmService)
        {
            _realmService = realmService;
            AnswersCollection = new ObservableCollection<Answered>(_realmService.GetAllAnswers());
        }

	    private ObservableCollection<Answered> _answersCollection;

	    public ObservableCollection<Answered> AnswersCollection
	    {
	        get { return _answersCollection; }
	        set { SetProperty(ref _answersCollection, value); }
	    }


	}
}
