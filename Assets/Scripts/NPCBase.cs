using UnityEngine;

public abstract class NPCBase : MonoBehaviour
{
    private Player _player;

    void Awake()
    {
        _player = FindObjectOfType<Player>();
    }
    
    protected virtual void OnTriggerEnter(Collider other) 
    {
        _player.Stop();
    }
}
