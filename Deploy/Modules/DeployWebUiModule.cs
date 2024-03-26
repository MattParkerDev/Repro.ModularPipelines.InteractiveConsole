namespace Deploy.Modules;


[DependsOn<DeployBicepModule>]
[DependsOn<PublishWebUiModule>]
public class DeployWebUiModule : Module<CommandResult>
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
