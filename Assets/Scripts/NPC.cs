using UnityEngine;

public class NPC : NPCBase
{
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        Debug.Log($"{gameObject.name}: Hello, {other.name}! Let's chat!");
    }
}
