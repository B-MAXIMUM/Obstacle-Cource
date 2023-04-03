using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Player") && !this.gameObject.CompareTag("Hit"))
        {
            gameObject.tag = "Hit";
            GameManager.Instance.healthLoss();
        }

    }
}
