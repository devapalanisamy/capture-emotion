using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using CaptureEmotion.Settings;
using Prism.Navigation;
using Xamarin.Forms;

namespace CaptureEmotion.ViewModels
{
	public class QuotePageViewModel : BindableBase, INavigationAware
	{
        public List<Quote> Quotes = new List<Quote>();
	    private readonly int _randomColor;
	    private readonly int _randomQuote;
        public QuotePageViewModel()
        {
            CreateQuotes();
            Random rnd = new Random();
            _randomColor = rnd.Next(0, 14);
            _randomQuote = rnd.Next(0, 30);

        }

        private string[] colorsArray = new string[] { "#99D2CB", "#EBD494", "#D0F4E9", "#A4243B", "#E26D5A", "#BFB76F", "#46512C", "#F5D48B", "#A3844A", "#67905C", "#CE8B86", "#BB3F5A", "#EE5B5D", "#49B28A", "#6E7F85" };

        public Color RandomColor
	    {
	        get
	        {
                var converter = new ColorTypeConverter();
	            return (Color) converter.ConvertFromInvariantString(colorsArray[_randomColor]);
	        }
	    }

        public string QuoteText
        {
            get { return Quotes[_randomQuote].QuoteText; }
        }

	    public string Author
	    {
	        get { return Quotes[_randomQuote].Author; }
	    }

	    private void CreateQuotes()
	    {
	        Quotes.Add(new Quote{QuoteText = "The cost of starting over is being willing to let go.", Author = "Guy Finley" });
	        Quotes.Add(new Quote { QuoteText = "My psychiatrist told me I was crazy and I said I want a second opinion. He said okay, you're ugly too", Author = "Rodney Dangerfield" });
	        Quotes.Add(new Quote { QuoteText = "Age is of no importance unless you’re a cheese.", Author = "Billie Burke" });
	        Quotes.Add(new Quote { QuoteText = "Be nice to people on your way up because you meet them on your way down.", Author = "Jimmy Durante" });
	        Quotes.Add(new Quote { QuoteText = "If at first you don’t succeed, then skydiving definitely isn’t for you.   ", Author = "Steven Wright" });
	        Quotes.Add(new Quote { QuoteText = "Life is like a roll of toilet paper; hopefully long and useful, but it always ends at the wrong moment.", Author = "Rudyh" });
	        Quotes.Add(new Quote { QuoteText = "Laugh and the world laughs with you, snore and you sleep alone.", Author = "Anthony Burgess" });
	        Quotes.Add(new Quote { QuoteText = "People will laugh at anything, except their own moronic self.", Author = "Fakeer Ishavardas" });
	        Quotes.Add(new Quote { QuoteText = "You know you're getting old when the candles cost more than the cake", Author = "Bob Hope" });
	        Quotes.Add(new Quote { QuoteText = "Tolerance! The virtue that makes one bite his tongue so that he can tear out his hair.     ", Author = "Criss Jami" });
	        Quotes.Add(new Quote { QuoteText = "You are only young once, but you can be immature forever.", Author = "Hannah Marks" });
	        Quotes.Add(new Quote { QuoteText = "Life is funny, when you are young you want to be older and those that are older wish to be younger.", Author = "Karon Waddell" });
	        Quotes.Add(new Quote { QuoteText = "The fact that we're all different is the one thing we all have in common.", Author = "Justin Young" });
	        Quotes.Add(new Quote { QuoteText = "Opportunity does not knock, it presents itself when you beat down the door.", Author = "Kyle Chandler" });
	        Quotes.Add(new Quote { QuoteText = "Do not argue with an idiot. He will drag you down to his level and beat you with experience ", Author = "Mark Twain" });
	        Quotes.Add(new Quote { QuoteText = "I always wanted to be somebody, but now I realize I should have been more specific.", Author = "Lily Tomlin" });
	        Quotes.Add(new Quote { QuoteText = "You may not always end up where you thought you were going, But you will always end up where you were meant to be.     ", Author = "Jessica taylor" });
	        Quotes.Add(new Quote { QuoteText = "Before you judge a man, walk a mile in his shoes. After that who cares?… He`s a mile away and you’ve got his shoes!", Author = "Billy Connolly" });
	        Quotes.Add(new Quote { QuoteText = "Stop worrying about the world ending today. It's already tomorrow in Australia.  ", Author = "Charles M. Schulz" });
	        Quotes.Add(new Quote { QuoteText = "The first time I sang in the church choir; two hundred people changed their religion", Author = "Fred Allen" });
	        Quotes.Add(new Quote { QuoteText = "There are worse things in life than death. Have you ever spent an evening with an insurance salesman?", Author = "Woody Allen" });
	        Quotes.Add(new Quote { QuoteText = "Everyone has a sense of humor. If you don't laugh at jokes, you probably laugh at opinions.", Author = "Criss Jami" });
	        Quotes.Add(new Quote { QuoteText = "When life gives you lemons, squirt someone in the eye.", Author = "Cathy Guisewite" });
	        Quotes.Add(new Quote { QuoteText = "Once you can accept the universe as matter expanding into nothing that is something, wearing stripes with plaid comes easy.", Author = "Albert Einstein" });
	        Quotes.Add(new Quote { QuoteText = "If you're too open-minded; your brains will fall out.", Author = "Lawrence Ferlinghetti" });
	        Quotes.Add(new Quote { QuoteText = "The man who views the world at 50 the same as he did at 20 has wasted 30 years of his life.", Author = "Muhammed Ali, US boxer" });
	        Quotes.Add(new Quote { QuoteText = "If I had my life to live over again, I’d be a plumber.", Author = "Albert Einstein" });
	        Quotes.Add(new Quote { QuoteText = "Live life to the fullest... think of all the people on the Titanic who passed up chocolate dessert.", Author = "Unknown" });
	        Quotes.Add(new Quote { QuoteText = "Be yourself; everyone else is already taken.", Author = "Oscar Wilde" });
	    }

	    public void OnNavigatedFrom(NavigationParameters parameters)
	    {
            parameters.Add(Constants.GoBack, true);
	    }

	    public void OnNavigatedTo(NavigationParameters parameters)
	    {

	    }

	    public void OnNavigatingTo(NavigationParameters parameters)
	    {

	    }
	}

    public class Quote
    {
        public string QuoteText { get; set; }
        public string Author { get; set; }
    }
}
