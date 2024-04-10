using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int jumpableCount = 2;
    [SerializeField] private float jumpForce = 10f;

    private Rigidbody2D rb;

    void Start()
    {
        if (!rb) rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D (Collision2D other) 
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            jumpableCount = 2;
        }    
    }
}
