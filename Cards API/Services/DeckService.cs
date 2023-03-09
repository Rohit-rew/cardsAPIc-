using System;
using Cards_API.Helpers;

namespace Cards_API.Services
{
	public class DeckService
	{

		public string GetDeckId()
		{
			string deckId = HelpersFunc.DeckIdGenerator();
			return deckId;
		}

		public List<Card> GetallCards(){
			return HelpersFunc.allCards;
		}
	}
}

