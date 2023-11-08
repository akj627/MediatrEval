using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers.Destroy
{
	[ApiController]
	[Route("[controller]")]
	public class ClientWithDeleteController : ControllerBase
	{
		private readonly IMediator _mediator;
		public ClientWithDeleteController(IMediator mediator)
		{
			_mediator = mediator;
		}

		public Task<string> UseMagic()
		{
			var response = _mediator.Send(new DeleteEverything());

			return response;
		}
	}
}
