using UnityEngine;
using UnityEditor;

public class BuildClass : MonoBehaviour 
{
	public static Build()
	{
		string[] sceneList =
		{
			"./Assets/Scene/setup.unity",
			"./Assets/Scene/main.unity",
		}
	}

	string errorMessage = BuildPipeline.BuildPlayer
	{
		sceneList,
		"/Users/kawaguchikyouhei/My/WorkSpace/Unity Projects/out/UnityTest.exe",
		BuildTarget.StandaloneWindows,
	}
}
