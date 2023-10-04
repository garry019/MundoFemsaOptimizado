using UnrealBuildTool;

public class VR_Project2Target : TargetRules
{
	public VR_Project2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("VR_Project2");
	}
}
