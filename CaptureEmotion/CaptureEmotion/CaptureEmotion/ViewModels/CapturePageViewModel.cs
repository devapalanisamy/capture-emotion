using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;

namespace CaptureEmotion.ViewModels
{
	public class CapturePageViewModel : BindableBase
	{
        public CapturePageViewModel()
        {

        }

	    private DelegateCommand<ItemTappedEventArgs> _emotionTappedCommand;

	    public DelegateCommand<ItemTappedEventArgs> EmotionTappedCommand
	    {
	        get
	        {
	            if (_emotionTappedCommand == null)
	            {
	                _emotionTappedCommand = new DelegateCommand<ItemTappedEventArgs>(EmotionTapped);
	            }
	            return _emotionTappedCommand;
	        }
	    }

	    private void EmotionTapped(ItemTappedEventArgs obj)
	    {
            Debug.WriteLine("Emotion Tapped");
	    }
	}
}
