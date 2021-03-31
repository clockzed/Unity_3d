using UnityEngine;

public class Item : MonoBehaviour
{
    private bool _isCanPickUp;

    void OnTriggerEnter(Collider other)
    {
        _isCanPickUp = true;
        Debug.Log("Press E to pick up item");
    }

    void OnTriggerExit(Collider other)
    {
        _isCanPickUp = false;
    }

    void Update() 
    {
        if (_isCanPickUp && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Now you have item");
            Destroy(gameObject);
        }
    }
}
