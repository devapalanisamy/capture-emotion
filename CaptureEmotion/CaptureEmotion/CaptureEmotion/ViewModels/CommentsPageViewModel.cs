using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using CaptureEmotion.Models;
using CaptureEmotion.Settings;
using Prism.Navigation;
using Xamarin.Forms;

namespace CaptureEmotion.ViewModels
{
	public class CommentsPageViewModel : BindableBase, INavigationAware
	{
	    private Answered _answered;
	    private readonly IRealmService _realmService;
	    private readonly INavigationService _navigationService;
        public CommentsPageViewModel(IRealmService realmService, INavigationService navigationService)
        {
            _realmService = realmService;
            _navigationService = navigationService;
        }

	    private string _title;

	    public string Title
	    {
	        get { return _title; }
	        set { SetProperty(ref _title, value); }
	    }

	    private string _comment;

	    public string Comment
	    {
	        get { return _comment; }
	        set { SetProperty(ref _comment, value); }
	    }

	    private DelegateCommand<ItemTappedEventArgs> _saveButtonTappedCommand;

	    public DelegateCommand<ItemTappedEventArgs> SaveButtonTappedCommand
	    {
	        get
	        {
	            if (_saveButtonTappedCommand == null)
	            {
	                _saveButtonTappedCommand = new DelegateCommand<ItemTappedEventArgs>(SaveEmotion);
	            }

	            return _saveButtonTappedCommand;
	        }
	    }

	    private async void SaveEmotion(ItemTappedEventArgs obj)
	    {
	        _answered.MoreDetails = Comment;
            _realmService.SaveAnswer(_answered);
	        await _navigationService.NavigateAsync(Constants.QuotePage);
	    }

	    public void OnNavigatedFrom(NavigationParameters parameters)
	    {
	    }

	    public async void OnNavigatedTo(NavigationParameters parameters)
	    {
	        if (parameters.ContainsKey(Constants.Answer))
	        {
	            _answered = (Answered) parameters[Constants.Answer];
	        }

	        if (parameters.ContainsKey(Constants.Title))
	        {
	            Title = (string) parameters[Constants.Title];
	        }

	        if (parameters.ContainsKey(Constants.GoBack))
	        {
	            if ((bool) parameters[Constants.GoBack])
	            {
	               await _navigationService.GoBackAsync();
	            }
	        }
	    }

	    public void OnNavigatingTo(NavigationParameters parameters)
	    {
	    }

	    private DelegateCommand<ItemTappedEventArgs> _cancelButtonTappedCommand;

	    public DelegateCommand<ItemTappedEventArgs> CancelButtonTappedCommand
	    {
	        get
	        {
	            if (_cancelButtonTappedCommand == null)
	            {
	                _cancelButtonTappedCommand = new DelegateCommand<ItemTappedEventArgs>(CancelComment);
	            }

	            return _cancelButtonTappedCommand;
	        }
	    }

	    private async void CancelComment(ItemTappedEventArgs obj)
	    {
	        await _navigationService.GoBackAsync();
	    }
    }
}
