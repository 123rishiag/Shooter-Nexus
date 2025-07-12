// Shooter Nexus

using UnrealBuildTool;

public class ShooterNexus : ModuleRules
{
	public ShooterNexus(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ShooterNexus",
			"ShooterNexus/Variant_Platforming",
			"ShooterNexus/Variant_Combat",
			"ShooterNexus/Variant_Combat/AI",
			"ShooterNexus/Variant_SideScrolling",
			"ShooterNexus/Variant_SideScrolling/Gameplay",
			"ShooterNexus/Variant_SideScrolling/AI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
