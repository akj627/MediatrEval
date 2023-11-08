namespace WebApplication1.Controllers.WithoutMediatr
{
	public class SimpleImpl : ISimple
	{
		public Task<string> IsThisMagic()
		{
			return Task.FromResult("No magic here!");
		}
	}
}