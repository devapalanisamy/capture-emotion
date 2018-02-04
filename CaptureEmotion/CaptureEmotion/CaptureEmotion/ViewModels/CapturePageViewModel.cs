using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CaptureEmotion.Models;
using CaptureEmotion.Settings;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;

namespace CaptureEmotion.ViewModels
{
	public class CapturePageViewModel : BindableBase
	{
	    private readonly IRealmService _realmService;
	    private readonly IPageDialogService _pageDialogService;
	    private readonly INavigationService _navigationService;
        public CapturePageViewModel(IRealmService realmService, IPageDialogService pageDialogService, INavigationService navigationService)
        {
            _realmService = realmService;
            _pageDialogService = pageDialogService;
            _navigationService = navigationService;
        }

	    private DelegateCommand<string> _emotionTappedCommand;

	    public DelegateCommand<string> EmotionTappedCommand
	    {
	        get
	        {
	            if (_emotionTappedCommand == null)
	            {
	                _emotionTappedCommand = new DelegateCommand<string>(EmotionTapped);
	            }
	            return _emotionTappedCommand;
	        }
	    }

	    private async void EmotionTapped(string obj)
	    {
	        var answer = new Answered();
	        answer.Emotion = obj;
            answer.UpdatedTime = DateTimeOffset.UtcNow;
            Debug.WriteLine($"Emotion Tapped : {obj}");
	        var moreDetailsEntered = await _pageDialogService.DisplayAlertAsync($"Feeling {obj}", "Would you like to add more details?", "Yes", "No");
	        answer.MoreDetailsEntered = moreDetailsEntered;
	        if (moreDetailsEntered)
	        {
                var parameters = new NavigationParameters{{Constants.Answer, answer},{Constants.Title,$"Feeling {obj}. Because..."}};
	            await _navigationService.NavigateAsync(Constants.CommentsPage, parameters);
	        }
	        else
	        {
	            _realmService.SaveAnswer(answer);
	            await _navigationService.NavigateAsync(Constants.QuotePage);
	        }
            
        }

	    private DelegateCommand<ItemTappedEventArgs> _timelineTappedCommand;

	    public DelegateCommand<ItemTappedEventArgs> TimelineTappedCommand
	    {
	        get
	        {
	            if (_timelineTappedCommand == null)
	            {
                    _timelineTappedCommand = new DelegateCommand<ItemTappedEventArgs>(ShowTimeline);
	            }

	            return _timelineTappedCommand;
	        }
	    }

	    private async void ShowTimeline(ItemTappedEventArgs obj)
	    {
	        await _navigationService.NavigateAsync(Constants.TimelinePage);
	    }
	}
}
