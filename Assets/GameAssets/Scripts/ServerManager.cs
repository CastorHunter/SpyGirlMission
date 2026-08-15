using UnityEngine;
using Unity.Netcode;

using TMPro;

public class ServerManager : MonoBehaviour
{
    
    public async void StartHost()
    {
        NetworkManager.Singleton.StartHost();
    }

    public async void StartClient()
    {
        NetworkManager.Singleton.StartClient();
    }
}
