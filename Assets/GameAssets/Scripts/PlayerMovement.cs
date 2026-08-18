using System;
using Unity.Netcode;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
    public float speed = 1.5f;
    public int health = 100;

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
        if (!Physics.Raycast(transform.position, direction, 0.4f))
            transform.Translate( Time.deltaTime * speed * direction);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoseHealth(20);
        }
    }

    public void LoseHealth(int healthLost)
    {
        health -= healthLost;
        if (health <= 0)
        {
            health = 100;
            LoseALifeServerRpc();
        }
    }
    
    [ServerRpc]
    public void LoseALifeServerRpc()
    {
        FindFirstObjectByType<GameManagerNetwork>().LoseALife();
    }
}
