using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroll : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("enemy"))
        {
            
        }
    }
}
