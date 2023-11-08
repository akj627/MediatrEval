using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers.WithMediatr
{
	[ApiController]
	[Route("[controller]")]
	public class ClientWithMediatrController : ControllerBase
	{
		private readonly IMediator _mediator;
		public ClientWithMediatrController(IMediator mediator)
		{
			_mediator = mediator;
		}

		public Task<string> UseMagic()
		{
			var response = _mediator.Send(new Magic());

			return response;
		}
	}
}
