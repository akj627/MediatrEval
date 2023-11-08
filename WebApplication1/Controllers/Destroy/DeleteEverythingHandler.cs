using MediatR;

public class DeleteEverythingHandler : IRequestHandler<DeleteEverything, string>
{
	public Task<string> Handle(DeleteEverything request, CancellationToken cancellationToken)
	{
		return Task.FromResult("You asked to delete everything. Its Done!!!");
	}
}
