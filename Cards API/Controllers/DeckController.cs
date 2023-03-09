using System;
using Microsoft.AspNetCore.Mvc;
using Cards_API.Services;
using Cards_API.Helpers;

namespace Cards_API.Controllers
{
	[Route("api/deck/new")]
	public class DeckController : ControllerBase
	{

		DeckService _deckService;
		// constructor
		public DeckController(DeckService deckService)
		{
			_deckService = deckService;
		}

		[HttpGet]
		public string drawNewDecks(){
			return _deckService.GetDeckId();
		}

		[HttpGet("id:string" , Name = "GetCards")]
		public List<Card> getAllCards(string Id){
			return HelpersFunc.allCards;
		}
	
	}
}

