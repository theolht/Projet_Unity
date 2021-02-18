using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    
    void Update()
    {
        StartCoroutine(DestroyIn3Second());
    }

    private IEnumerator DestroyIn3Second()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
