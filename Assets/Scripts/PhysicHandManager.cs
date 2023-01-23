using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicHandManager : MonoBehaviour
{

    [SerializeField] private Transform[] _hands;

    [SerializeField] private bool _colliderActivated=true;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleColliders()
    {
        if (_colliderActivated)
        {
            foreach (var hand in _hands)
            {
                
                //desactive tous les colliders
                Collider[] _colliders = hand.GetComponentsInChildren<Collider>();
                foreach (var collider in _colliders)
                {
                    collider.enabled = false;
                }


            }

            _colliderActivated = true;
        }
        else
        {
            foreach (var hand in _hands)
            {
                
                //desactive tous les colliders
                Collider[] _colliders = hand.GetComponentsInChildren<Collider>();
                foreach (var collider in _colliders)
                {
                    Debug.Log("Activated Collider");
                    collider.enabled = true;
                }


            }

            _colliderActivated = false;
        }
    }

    public void DeactivateColliders()
    {
        foreach (var hand in _hands)
        {
                
            //desactive tous les colliders
            Collider[] _colliders = hand.GetComponentsInChildren<Collider>();
            foreach (var collider in _colliders)
            {
                collider.enabled = false;
            }


        }
    }
    
    public void ActivateColliders()
    {
        foreach (var hand in _hands)
        {
                
            //desactive tous les colliders
            Collider[] _colliders = hand.GetComponentsInChildren<Collider>();
            foreach (var collider in _colliders)
            {
                collider.enabled = true;
            }


        }
    }
}
