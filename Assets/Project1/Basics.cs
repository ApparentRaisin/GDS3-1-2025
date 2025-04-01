using UnityEngine;

public class Basics : MonoBehaviour
{
    float highScore = 10;
    public Animator boxAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        highScore = 0;
        Debug.Log(highScore);
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetButtonDown("Fire1"))
        {
            boxAnimator.SetTrigger("Jump");
        }
    }
}
