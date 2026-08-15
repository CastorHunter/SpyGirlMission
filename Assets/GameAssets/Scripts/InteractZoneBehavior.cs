using Unity.VisualScripting;
using UnityEngine;

public class InteractZoneBehavior : MonoBehaviour
{
    public SystemBehavior SystemToTrigger;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SystemToTrigger.Interact();
        }
    }
}
