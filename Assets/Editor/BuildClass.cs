using UnityEngine;
using UnityEditor;

public class BuildClass : MonoBehaviour
{
    public static void Build()
    {
        string[] sceneList =
        {
            "./Assets/Scene/setup.unity",
            "./Assets/Scene/main.unity",
        };

        string errorMessage = BuildPipeline.BuildPlayer
        (
            sceneList,
            "/Users/kawaguchikyouhei/My/WorkSpace/UnityProjects/out/ios/UnityTest",
            BuildTarget.iOS,
            BuildOptions.None
        );
    }
}
