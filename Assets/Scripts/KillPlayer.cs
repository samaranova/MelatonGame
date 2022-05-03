using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{

    public LevelManager levelManager;   //creates an empty levelManager of type LevelManager


    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();    //gets all objects in scene with "levelManager" attached
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            levelManager.RespawnPlayer();
        }
    }
}
