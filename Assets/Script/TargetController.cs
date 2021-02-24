using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    [SerializeField] private Material TouchedTargetMaterial;
    [SerializeField] private GameObject EndPointPlatform;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("On trigger entered");
        GetComponent<Renderer>().material = TouchedTargetMaterial;
        gameObject.GetComponent<ParticleSystem>().Play();
        GetComponent<AudioSource>().Play();
        EndPointPlatform.SetActive(true);
    }
}
