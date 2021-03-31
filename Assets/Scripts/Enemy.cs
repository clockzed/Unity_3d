using UnityEngine;

public class Enemy : NPCBase
{
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        Debug.Log($"{gameObject.name}: FIGHT! You will die {other.name} HAHAHA");
    }
}
