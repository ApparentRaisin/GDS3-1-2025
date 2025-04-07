using UnityEngine;
using UnityEditor;


public class MenuWindow : EditorWindow
{
    [MenuItem("Window/Menu Spawner")]
    static void Initilize()
    {
        MenuWindow menu = EditorWindow.CreateWindow<MenuWindow>();
        menu.Show();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool start, quit, settings;
    private void OnGUI()
    {
        start = EditorGUILayout.Toggle(start);
        quit = EditorGUILayout.Toggle(quit);
        settings = EditorGUILayout.Toggle(settings);
        if (GUILayout.Button("Spawn Menu GameObject"))
        {
            GameObject canvas = Resources.Load("Canvas") as GameObject;
            GameObject button = Resources.Load("Button") as GameObject;
            GameObject canvasObject = Instantiate(canvas);
            GameObject MainMenu = new GameObject();
            MainMenu.transform.parent = canvasObject.transform;
            MainMenu.name = "MainMenu";
            if (start)
            {
                GameObject startBut = Instantiate(button);
                startBut.transform.parent = MainMenu.transform;
                startBut.transform.position = Vector3.zero;
                startBut.name = "StartGame";
            }

            if (start)
            {
                GameObject quitBut = Instantiate(button);
                quitBut.transform.parent = MainMenu.transform;
                quitBut.transform.position = Vector3.zero;
                quitBut.name = "Quit";
            }
        }
    }
}
