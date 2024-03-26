namespace Deploy.Modules;

public class RestoreAndBuildModule : Module<CommandResult[]>
{
	protected override async Task<CommandResult[]?> ExecuteAsync(
		IPipelineContext context,
		CancellationToken cancellationToken
	)
	{
		await Task.Delay(2000, cancellationToken);
		return null;
	}
}
