// Shooter Nexus

using UnrealBuildTool;
using System.Collections.Generic;

public class ShooterNexusEditorTarget : TargetRules
{
	public ShooterNexusEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_6;
		ExtraModuleNames.Add("ShooterNexus");
	}
}
