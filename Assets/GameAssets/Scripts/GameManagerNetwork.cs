using Unity.Netcode;
using UnityEngine;

public class GameManagerNetwork : NetworkBehaviour
{
    public NetworkVariable<int> lives = new NetworkVariable<int>(3); //Only the server can overwrite this variable
    
    void Start()
    {
        Debug.Log(lives.Value);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(lives.Value);
        }
    }

    public void LoseALife()
    {
        lives.Value--;
    }
}
