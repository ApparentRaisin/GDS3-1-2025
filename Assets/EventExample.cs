using UnityEngine;
using UnityEngine.Events;

public class EventExample : MonoBehaviour
{
    public UnityEvent OnMouseDownEvent = new UnityEvent();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnMouseDownEvent.AddListener(delegate { Debug.Log("working but a delegate now"); }); 
    }

    private void OnMouseDown()
    {
        OnMouseDownEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
