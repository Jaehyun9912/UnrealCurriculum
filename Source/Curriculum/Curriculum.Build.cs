// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Curriculum : ModuleRules
{
	public Curriculum(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
