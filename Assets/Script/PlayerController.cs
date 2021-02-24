using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidbody;
    public Rigidbody PlayerRigidbody => playerRigidbody;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Transform BulletSpawnerTransform;

    private float camSpeed = 0.5f;
    private float camSens = 0.5f;
    private float playerSpeed = 0.2f;
    private float jumpHeight = 5.0f;
    private float bulletSpeed = 3000f;

    public Vector3 respawnPoint;
    public int counterJump = 0;

    void Awake()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        respawnPoint = new Vector3(0.0f, 1.0f, 0.0f);
    }

    void Update()
    {
        MovePlayer();
        RotateCamera();
        PlayerJump();
        Shoot();
    }
    
    private void MovePlayer()
    {
        Vector3 camRight = cameraTransform.right;
        Vector3 camForward = cameraTransform.forward;

        Vector3 deltaPosition = new Vector3(camRight.x,0f,camRight.z) * Input.GetAxis("Horizontal") + new Vector3(camForward.x, 0f, camForward.z) * Input.GetAxis("Vertical");
        
        playerRigidbody.MovePosition(playerRigidbody.position + deltaPosition * playerSpeed);
    }

    private void RotateCamera()
    {
        float pitch = -Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch,-90f, 90f);

        float yawn = Input.GetAxis("Mouse X");
        
        yawn += yawn * camSens;
        pitch += pitch * camSpeed;
        cameraTransform.localEulerAngles += new Vector3(pitch, yawn, 0f);
    }
    
    private void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (counterJump < 2)
            {
                //Debug.Log("Function called");
                Vector3 jump = new Vector3(0.0f, 2.0f, 0.0f);
                playerRigidbody.GetComponent<Rigidbody>().AddForce(jump * jumpHeight, ForceMode.Impulse);
                counterJump++;
                GetComponent<AudioSource>().Play();
                //Debug.Log("jump !");
            }
        }
    }
    
    private void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 rot = cameraTransform.rotation.eulerAngles;
            rot = new Vector3(rot.x,rot.y-90,rot.z);
          
            GameObject bullet = (GameObject) Instantiate(Resources.Load("Bullet"),BulletSpawnerTransform.position,Quaternion.Euler(rot));
            bullet.GetComponent<Rigidbody>().AddForce(cameraTransform.forward * bulletSpeed);
            
            BulletSpawnerTransform.GetComponent<AudioSource>().Play();
        }
    }
}
