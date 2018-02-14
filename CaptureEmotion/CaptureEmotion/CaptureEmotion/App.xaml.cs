using CaptureEmotion.Services;
using Prism;
using Prism.Ioc;
using CaptureEmotion.ViewModels;
using CaptureEmotion.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CaptureEmotion
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("RootPage/CapturePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<HomeTabPage>();
            containerRegistry.RegisterForNavigation<CapturePage>();
            containerRegistry.RegisterForNavigation<QuotePage>();

            containerRegistry.Register<IRealmService,RealmService>();
            containerRegistry.RegisterForNavigation<CommentsPage>();
            containerRegistry.RegisterForNavigation<TimelinePage>();
            containerRegistry.RegisterForNavigation<RootPage>();
        }
    }

    class RootPage : NavigationPage
    {
        public RootPage()
        {
                BarBackgroundColor = Color.BlueViolet;
                BarTextColor = Color.White;
        }
    }
}
