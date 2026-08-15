using System.Collections.Generic;
using UnityEngine;

public class SystemBehavior : MonoBehaviour
{
    public List<SystemBehavior> SystemsToActivate = new List<SystemBehavior>();
    public List<SystemBehavior> SystemsToDeactivate = new List<SystemBehavior>();
    
    public virtual void Activate()
    {
        Debug.Log("SystemActivated");
    }
    
    public virtual void Deactivate()
    {
        Debug.Log("SystemDeactivated");
    }

    public virtual void Interact()
    {
        Debug.Log("SystemInteract");
        foreach (SystemBehavior systemBehavior in SystemsToActivate)
        {
            systemBehavior.Activate();
        }
        foreach (SystemBehavior systemBehavior in SystemsToDeactivate)
        {
            systemBehavior.Deactivate();
        }
    }
}
