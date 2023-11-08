using MediatR;

public class MagicHandler : IRequestHandler<Magic, string>
{
	public Task<string> Handle(Magic request, CancellationToken cancellationToken)
	{
		return Task.FromResult("Abracadabra");
	}
}
