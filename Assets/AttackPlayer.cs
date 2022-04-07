using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public bool isPlayerNear = false;
    public float radius;
    public Animator animator;
    public GameObject player;

    public GameObject helicopter;

    public float MovementSpeed;

   
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
       // animator.SetTrigger("Idle");
       
      /*  Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
        foreach (var hitCollider in hitColliders)
        {
            Debug.Log(hitCollider);
            if (hitCollider.gameObject.CompareTag("Player"))
            {
                // isPlayerNear= true;


               
                animator.SetTrigger("RoundKick");

            }*/
           /* if (isPlayerNear==true)
            {
                Debug.Log(isPlayerNear);
               
               
               //  transform.position = Vector3.MoveTowards(transform.position, player.transform.position, MovementSpeed);
             }

            if(isPlayerNear==false)
            {
                animator.SetTrigger("Idle");
            }
         
        }*/





    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            animator.SetTrigger("RoundKick");
            Debug.Log("Save me");
            helicopter.GetComponent<CallHelicopter>().SavePlayer();


        }

    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetTrigger("Walk");
    }
}
