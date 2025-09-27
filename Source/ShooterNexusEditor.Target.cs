// Shooter Nexus

using UnrealBuildTool;

public class ShooterNexusEditorTarget : TargetRules
{
	public ShooterNexusEditorTarget( TargetInfo target) : base(target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_6;
		ExtraModuleNames.Add("ShooterNexus");
	}
}
