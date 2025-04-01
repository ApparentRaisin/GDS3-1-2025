using UnityEngine;

//basic bullet script
public class Bullet : MonoBehaviour
{
    Transform thisTrans;
    public Vector3 direction;
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisTrans = transform;
    }

    // Update is called once per frame
    void Update()
    {
        //moves bullet and then checks when to destroy it
        thisTrans.position += direction * Time.deltaTime;
        if(Vector3.Distance(thisTrans.position, player.position) > 1000)
        {
            Destroy(thisTrans);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(this.transform.position, direction);
    }
}
