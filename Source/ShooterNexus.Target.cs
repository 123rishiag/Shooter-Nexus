// Shooter Nexus

using UnrealBuildTool;

public class ShooterNexusTarget : TargetRules
{
	public ShooterNexusTarget(TargetInfo target) : base(target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_6;
		ExtraModuleNames.Add("ShooterNexus");
	}
}
