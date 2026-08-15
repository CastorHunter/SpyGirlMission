using UnityEngine;

public class Door : SystemBehavior
{
    public override void Activate()
    {
        Debug.Log("Door opened");
        base.Activate();
        //Temporary :
        gameObject.SetActive(false);
    }
}
