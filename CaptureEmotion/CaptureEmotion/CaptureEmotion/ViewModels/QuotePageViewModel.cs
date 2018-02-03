using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CaptureEmotion.ViewModels
{
	public class QuotePageViewModel : BindableBase
	{
        public List<Quote> Quotes = new List<Quote>();
        public QuotePageViewModel()
        {
            CreateQuotes();
        }

	    private void CreateQuotes()
	    {
	        Quotes.Add(new Quote{QuoteText = "The cost of starting over is being willing to let go.", Author = "Guy Finley" });
	        Quotes.Add(new Quote { QuoteText = "Let others lead small lives, but not you. Let others argue over small things, but not you. Let others cry over small hurts, but not you. Let others leave their future in someone else’s hands, but not you.", Author = "Jim Rohn" });
	        Quotes.Add(new Quote { QuoteText = "If you don't know anything about computers, just remember that they are machines that do exactly what you tell them but often surprise you in the result", Author = "Richard Dawkins" });
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
	        Quotes.Add(new Quote { QuoteText = "Live life to the fullest... think of all the people on the Titanic who passed up chocolate dessert.", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "Tell a man there are 300 billion stars in the universe and he'll believe you. Tell him a bench has wet paint on it and he'll have to touch it to be sure. ", Author = "Murphy's Law" });
	        Quotes.Add(new Quote { QuoteText = "Be yourself; everyone else is already taken.", Author = "Oscar Wilde" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
	        Quotes.Add(new Quote { QuoteText = "", Author = "" });
        }
	}

    public class Quote
    {
        public string QuoteText { get; set; }
        public string Author { get; set; }
    }
}
