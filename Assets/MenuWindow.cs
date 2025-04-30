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

    bool start, quit, settings, volume, color;
    private void OnGUI()
    {
        start = EditorGUILayout.Toggle("Add Start Button", start);
        quit = EditorGUILayout.Toggle("Add Quit Button", quit);
        settings = EditorGUILayout.Toggle("Add Settings Button", settings);
        
        if (settings)
        {
            EditorGUI.indentLevel++;
            volume = EditorGUILayout.Toggle("Volume Controls", volume);
        }
        

        if (GUILayout.Button("Spawn Menu GameObject"))
        {
            GameObject canvas = Resources.Load("Canvas") as GameObject;
            GameObject button = Resources.Load("Button") as GameObject;
            GameObject canvasObject = Instantiate(canvas);
            GameObject MainMenu = new GameObject();
            MainMenu.transform.parent = canvasObject.transform;
            MainMenu.name = "MainMenu";
            MainMenu.AddComponent<RectTransform>();
            MainMenu.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            if (start)
            {
                GameObject startBut = Instantiate(button);
                startBut.transform.parent = MainMenu.transform;
                startBut.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                startBut.name = "StartGame";
            }

            if (quit)
            {
                GameObject quitBut = Instantiate(button);
                quitBut.transform.parent = MainMenu.transform;
                quitBut.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                quitBut.name = "Quit";
            }
        }
    }
}
