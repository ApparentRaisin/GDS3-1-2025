using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Coroutines : MonoBehaviour
{
    public Weapon myItem;
    Transform thisTrans;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisTrans = this.transform;

        StartCoroutine(RandomMove());
    }

    IEnumerator RandomMove()
    {
        Debug.Log("start");
        yield return new WaitUntil(() => thisTrans.position.x > 4);
        Debug.Log("end");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class Item
{
    public string name;
    public string Description;
    public UnityEvent onUse;

    void Use()
    {
        onUse.Invoke();
    }
}

[System.Serializable]
public class Weapon : Item
{
    public int Damage;
}


