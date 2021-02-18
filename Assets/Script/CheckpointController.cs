using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Trigger Called");
        GameObject Player = GameObject.Find("Player");
        PlayerController playerScript = Player.GetComponent<PlayerController>();
        if(other.tag == "Player")
        {
            //Debug.Log("Player Recognised");
            playerScript.respawnPoint = ;
        }
    }
}
