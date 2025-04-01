using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(NPC))]
public class EditorNPC : Editor
{
    SerializedProperty name;
    SerializedProperty description;
    SerializedProperty portrait;
    SerializedProperty routeArray;
    private void OnEnable()
    {
        name = serializedObject.FindProperty("name");
        description = serializedObject.FindProperty("description");
        portrait = serializedObject.FindProperty("portrait");
        routeArray = serializedObject.FindProperty("route");
    }

    public override void OnInspectorGUI()
    {
        //serializedObject.Update();

        //name.stringValue = EditorGUILayout.TextField(name.stringValue);
        //base.DrawDefaultInspector();

        //serializedObject.ApplyModifiedProperties();
    }

    private void OnSceneGUI()
    {
        serializedObject.Update();
        EditorGUI.BeginChangeCheck();
        for (int i = 0; i < routeArray.arraySize; i++)
        {
            Vector3 currentRoutePosition = routeArray.GetArrayElementAtIndex(i).vector3Value;
            currentRoutePosition = Handles.PositionHandle(currentRoutePosition, Quaternion.identity);
            routeArray.GetArrayElementAtIndex(i).vector3Value = currentRoutePosition;
        }

        Event currentEvent = Event.current;

        if(currentEvent.type == EventType.MouseDown && currentEvent.button == 0)
        {
            Debug.Log("Click");
        }
        
        serializedObject.ApplyModifiedProperties();
    }
}
