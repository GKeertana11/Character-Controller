using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public Transform playerSpawnPoints; //Parent of the spawn points
    Transform[] spawnPositions;
    public bool isRespawn = false;
    public bool respawnToggle = false;
    int k;
   
    // Start is called before the first frame update
    void Start()
    {
        spawnPositions = playerSpawnPoints.GetComponentsInChildren<Transform>();
       // Debug.Log(spawnPositions.Length);
      //  RandomSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
        // int i = Random.Range(1, spawnPositions.Length);
        /*  if(respawnToggle!=isRespawn)
          {
              RandomSpawn();
              isRespawn = false;
          }
          else
          {
              respawnToggle = isRespawn;
          }*/

        if (Input.GetKeyDown(KeyCode.Space))
            {
          
              k =RandomSpawn();
        }
        this.transform.position = spawnPositions[k].transform.position;

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {

        }

    }
    public int RandomSpawn()
    {
        int i = Random.Range(1, spawnPositions.Length);
       Debug.Log(i);
        this.transform.position = spawnPositions[i].transform.position;
        return (i);
    }
}
