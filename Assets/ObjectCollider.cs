using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollider : MonoBehaviour
{
    public bool isCollided = false;
    public GameObject collided = null;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        collided = other.gameObject;
        isCollided = true;
    }
    private void OnTriggerExit(Collider other)
    {
        collided = null;
        isCollided = false;
    }

}
