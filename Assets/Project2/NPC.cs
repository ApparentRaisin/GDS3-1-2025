using UnityEngine;

public class NPC : MonoBehaviour
{
    public string name;
    public string description;
    public Texture2D portrait;
    public Vector3[] route;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(this.transform.position, 0.1f);
        for(int i = 0; i < route.Length; i++)
        {
            Gizmos.DrawLine(route[i], route[(i + 1) % route.Length]);
        }
    }
}
