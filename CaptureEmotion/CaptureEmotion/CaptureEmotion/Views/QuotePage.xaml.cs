﻿using Xamarin.Forms;

namespace CaptureEmotion.Views
{
    public partial class QuotePage : ContentPage
    {
        public QuotePage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PopToRootAsync();
            return base.OnBackButtonPressed();
        }
    }
}
