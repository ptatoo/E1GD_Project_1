using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class Editor : EditorWindow
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private const string ScenePath = "Assets/Core/Scenes/MainScene.unity";
    void OnGUI()
    {
        // Or set the start Scene from code
        var scenePath = "Assets/Scenes/Startscene.unity";
        if (GUILayout.Button("Set start Scene: " + scenePath))
            SetPlayModeStartScene(scenePath);
    }

    void SetPlayModeStartScene(string scenePath)
    {
        SceneAsset myWantedStartScene = AssetDatabase.LoadAssetAtPath<SceneAsset>(scenePath);
        if (myWantedStartScene != null)
            EditorSceneManager.playModeStartScene = myWantedStartScene;
        else
            Debug.Log("Could not find Scene " + scenePath);
    }
}
