using Deploy;
using Deploy.Modules;
using Microsoft.Extensions.Configuration;
using ModularPipelines.Host;


await PipelineHostBuilder
	.Create()
	.ConfigureAppConfiguration(
		(context, builder) =>
		{
			builder
#if DEBUG
				.AddJsonFile("appsettings.Development.json", true)
#endif
				.AddUserSecrets<Program>()
				.AddEnvironmentVariables();
		}
	)
	.ConfigureServices(
		(context, collection) =>
		{
			
		}
	)
	.AddModule<RestoreAndBuildModule>()
	.AddModule<PublishWebApiModule>()
	.AddModule<PublishWebUiModule>()
	.AddModule<CreateResourceGroupModule>()
	.AddModule<DeployBicepModule>()
	.AddModule<DeployWebApiModule>()
	.AddModule<DeployWebUiModule>()
	.ConfigurePipelineOptions(
		(context, options) =>
		{
			options.ShowProgressInConsole = true; // change this to false to log the modules as they complete, vs failing to show the progress bar
			options.PrintLogo = false;
		}
	)
	.ExecutePipelineAsync();
