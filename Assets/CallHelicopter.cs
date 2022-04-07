using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallHelicopter : MonoBehaviour
{
    AudioSource audiosource;

    public float speed;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        //target = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Heli"))
        {
            Debug.Log("Calling Helicopter");
            audiosource.Play();
         
        }
    }

    public void SavePlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        Debug.Log(transform.position);
    }
  
}
      
