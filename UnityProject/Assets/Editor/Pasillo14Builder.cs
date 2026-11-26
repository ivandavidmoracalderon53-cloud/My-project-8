using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public static class Pasillo14Builder
{
    [MenuItem("Pasillo14/Crear escena jugable")]
    public static void Build()
    {
        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        var root = new GameObject("Pasillo 14");
        var game = root.AddComponent<Pasillo14Game>();
        game.BuildWorld();
        Directory.CreateDirectory("Assets/Scenes");
        EditorSceneManager.SaveScene(scene, "Assets/Scenes/Pasillo14.unity");
        Selection.activeGameObject = root;
        Debug.Log("Pasillo 14 listo. Pulsa Play para iniciar.");
    }
}
