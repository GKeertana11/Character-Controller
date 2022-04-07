using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallHelicopter : MonoBehaviour
{
    AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>(); 
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
}
