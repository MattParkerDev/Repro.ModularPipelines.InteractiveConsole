namespace Deploy.Modules;

[DependsOn<PublishWebApiModule>]
[DependsOn<DeployBicepModule>]
public class DeployWebApiModule : Module<CommandResult>
{
	protected override async Task<CommandResult?> ExecuteAsync(
		IPipelineContext context,
		CancellationToken cancellationToken
	)
	{
		await Task.Delay(2000, cancellationToken);
		return null;
	}
}
