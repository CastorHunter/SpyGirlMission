using UnityEngine;

public class PressurePlate : SystemBehavior
{
    public override void Interact()
    {
        Debug.Log("Pressure Plate Interact");
        base.Interact();
    }
}
