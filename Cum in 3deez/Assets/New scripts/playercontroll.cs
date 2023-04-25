using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroll : MonoBehaviour
{
    public int hits = 0;
    [SerializeField] private float _movespeed = 5f; 
    [SerializeField] private float _sidespeed = 5f;
    private float _borderwall = 7f;

    void Start()
    {
        
    }

    void Update()
    {
        movement();
        if(hits == 3)
        {
            UiManager.Instantce.gameOverEvent();
        }
        
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("enemy"))
        {
            hits = hits + 1;
        }
    }
    public void movement()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.forward * _movespeed * Time.deltaTime);
        transform.Translate(Vector3.right * _sidespeed * Time.deltaTime *horizontalInput);
        if(transform.position.x > _borderwall)
        {
            transform.position = new Vector3(_borderwall, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -_borderwall)
        {
            transform.position = new Vector3(-_borderwall, transform.position.y, transform.position.z);
        }
    }
}
