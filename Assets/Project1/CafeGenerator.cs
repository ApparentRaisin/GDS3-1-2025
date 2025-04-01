using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class CafeGenerator : MonoBehaviour
{
    public List<string> namesList = new List<string>();
    public List<string> DescList = new List<string>();
    public List<string> BuildList = new List<string>();
    public List<string> ObjList = new List<string>();
    public List<Color> ColorList = new List<Color>();

    public List<string> cafeNameSentences = new List<string>();

    public TextMeshProUGUI cafeText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cafeText.text = cafeNameSentences[Random.Range(0, cafeNameSentences.Count)];
        cafeText.text = cafeText.text.Replace("[Name]", namesList[Random.Range(0,namesList.Count)]);
        cafeText.text = cafeText.text.Replace("[Desc]", DescList[Random.Range(0, DescList.Count)]);
        cafeText.text = cafeText.text.Replace("[Build]", BuildList[Random.Range(0, BuildList.Count)]);
        cafeText.text = cafeText.text.Replace("[Obj]", ObjList[Random.Range(0, ObjList.Count)]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Start();
        }
    }
}
