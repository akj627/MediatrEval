using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers.WithoutMediatr
{
	[ApiController]
	[Route("[controller]")]
	public class ClientWithoutMediatrController : ControllerBase
	{
		private readonly ISimple _simple;
		public ClientWithoutMediatrController(ISimple simple)
		{
			_simple = simple;
		}

		public Task<string> UseSimple()
		{
			var response = _simple.IsThisMagic();

			return response;
		}
	}
}
