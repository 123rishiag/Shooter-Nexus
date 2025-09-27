// Shooter Nexus

using UnrealBuildTool;

public class MultiplayerSessions : ModuleRules
{
	public MultiplayerSessions(ReadOnlyTargetRules target) : base(target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange([]);
		
		PrivateIncludePaths.AddRange([]);
		
		PublicDependencyModuleNames.AddRange(
			[
				"Core",
				"OnlineSubsystem",
				"OnlineSubsystemSteam",
				"UMG",
				"Slate",
				"SlateCore"
			]
		);
		
		PrivateDependencyModuleNames.AddRange(
			[
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore"
			]
		);
		
		DynamicallyLoadedModuleNames.AddRange([]);
	}
}
