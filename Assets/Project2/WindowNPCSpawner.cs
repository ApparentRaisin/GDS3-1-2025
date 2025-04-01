using UnityEngine;
using UnityEditor;

public class WindowNPCSpawner : EditorWindow
{
    [MenuItem("Window/Spawner")]
    static void Initilize()
    {
        WindowNPCSpawner window = EditorWindow.GetWindow(typeof(WindowNPCSpawner)) as WindowNPCSpawner;
        window.Show();
    }

    Object npcObject;

    private void OnGUI()
    {
        npcObject = EditorGUILayout.ObjectField(npcObject, typeof(NPC), false);
        if(npcObject != null)
        {
            NPC currentObject = npcObject as NPC;
            EditorGUILayout.LabelField(currentObject.name);
        }
    }
}
