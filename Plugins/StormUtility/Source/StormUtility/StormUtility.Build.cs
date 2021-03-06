// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;
using System;

public class StormUtility : ModuleRules
{
	public StormUtility(TargetInfo Target)
	{

//         string vmDir = Path.GetFullPath(Path.Combine(ModuleDirectory, "..", "..", "..", "VMProtect2"));
// 
//         PublicSystemIncludePaths.Add(vmDir);
//         PublicAdditionalLibraries.Add(vmDir + "/VMProtectSDK64.lib");
//         PublicLibraryPaths.Add(vmDir + "");

        PublicIncludePaths.AddRange(
			new string[] {
				"StormUtility/Public"
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"StormUtility/Private",
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core", "VMProtectPlugin"
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
