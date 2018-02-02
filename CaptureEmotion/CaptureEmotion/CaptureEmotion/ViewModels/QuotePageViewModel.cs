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
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
	        Quotes.Add(new Quote { QuoteText = "hello 1", Author = "super 1" });
        }
	}

    public class Quote
    {
        public string QuoteText { get; set; }
        public string Author { get; set; }
    }
}
