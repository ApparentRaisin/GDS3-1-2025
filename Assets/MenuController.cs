using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Button start, quit, settings;
    public string gameSceneName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        start = this.transform.Find("MainMenu").Find("StartGame").GetComponent<Button>();
        quit = this.transform.Find("MainMenu").Find("Quit").GetComponent<Button>();

        quit.onClick.AddListener(Application.Quit);

        start.onClick.AddListener(delegate { SceneManager.LoadScene(gameSceneName); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
