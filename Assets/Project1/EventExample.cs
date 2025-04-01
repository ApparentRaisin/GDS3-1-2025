using UnityEngine;
using UnityEngine.Events;

public class EventExample : MonoBehaviour
{
    public UnityEvent OnMouseDownEvent = new UnityEvent();

    public delegate void working();

    public working workFunc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        workFunc = delegate { Debug.Log("working but a delegate now"); }; 
        OnMouseDownEvent.AddListener(workFunc.Invoke); 
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
