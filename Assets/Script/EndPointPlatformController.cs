using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPointPlatformController : MonoBehaviour
{
    void Awake()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject Player = GameObject.Find("Player");
        PlayerController playerScript = Player.GetComponent<PlayerController>();
        if (other.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            playerScript.PlayerRigidbody.MovePosition(new Vector3(0f,1f,0f));
        }
    }
}
