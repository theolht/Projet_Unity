using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GameObject Player = GameObject.Find("Player");
        PlayerController playerScript = Player.GetComponent<PlayerController>();
        playerScript.counterJump = 0;
    }
}
