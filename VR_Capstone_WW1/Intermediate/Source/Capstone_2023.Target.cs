using UnrealBuildTool;

public class Capstone_2023Target : TargetRules
{
	public Capstone_2023Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Capstone_2023");
	}
}
