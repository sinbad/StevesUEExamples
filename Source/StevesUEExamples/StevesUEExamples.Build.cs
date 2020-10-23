// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class StevesUEExamples : ModuleRules
{
	public StevesUEExamples(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });


		// Add Steve's Helper plugin
		AddStevesUEHelpers();
		
	}

	private string PluginsPath
	{
		get { return Path.GetFullPath( Path.Combine( ModuleDirectory, "../../Plugins/" ) ); }
	}

	protected void AddStevesUEHelpers() {
		// Linker
		PrivateDependencyModuleNames.AddRange(new string[] { "StevesUEHelpers" });
		// Headers
		PublicIncludePaths.Add(Path.Combine( PluginsPath, "StevesUEHelpers", "Source", "StevesUEHelpers", "Public"));
	}
	
	
}
