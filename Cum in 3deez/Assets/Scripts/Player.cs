using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _movespeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Movement();
    }

    // Update is called once per frame
    void Update()
    {
    Movement();
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Win"))
        {
            GameManager.Instance.winner();
        }
    }
    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal")* _movespeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical")* _movespeed *Time.deltaTime;
        transform.Translate(xValue, 0f, zValue);
    }
}
