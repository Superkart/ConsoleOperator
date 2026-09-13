using UnityEngine;
using UnityEditor;

/// <summary>
/// Editor-only helper for spawning primitives into the open scene.
/// Lives in an Editor folder, so it is stripped from builds.
/// </summary>
public static class QuickSpawn
{
    [MenuItem("Tools/Quick Spawn/Cube At Origin")]
    private static void SpawnCubeAtOrigin()
    {
        var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        go.name = "Cube";
        go.transform.position = Vector3.zero;
        go.transform.rotation = Quaternion.identity;
        go.transform.localScale = Vector3.one;

        Undo.RegisterCreatedObjectUndo(go, "Spawn Cube At Origin");
        Selection.activeGameObject = go;
        EditorGUIUtility.PingObject(go);

        Debug.Log("[QuickSpawn] Created Cube at (0, 0, 0).", go);
    }
}
