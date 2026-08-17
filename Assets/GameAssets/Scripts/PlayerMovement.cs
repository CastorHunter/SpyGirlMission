using System;
using Unity.Netcode;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
    public float speed = 1.5f;

    private void Start()
    {
        if (IsOwner)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }

    private void Update()
    {
        if (!IsOwner) return;
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        if (Physics.Raycast(transform.position, direction, 0.52f))
            print("There is something in front of the object!");
        else
            transform.Translate( Time.deltaTime * speed * direction);
    }
}