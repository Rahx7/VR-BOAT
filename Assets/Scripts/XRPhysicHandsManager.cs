using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRPhysicHandsManager : MonoBehaviour
{

    [SerializeField] private Collider[] _handColliders;

    [SerializeField] private bool _physicsHandsActivated = true;

    private bool _previousPhysicsHandsActivated;
    // Start is called before the first frame update
    void Start()
    {
        _handColliders = GetComponentsInChildren<Collider>();
        _physicsHandsActivated = _previousPhysicsHandsActivated;
    }

    // Update is called once per frame
    void Update()
    {
        if (_physicsHandsActivated != _previousPhysicsHandsActivated)
        {
            ToggleColliders();
            _previousPhysicsHandsActivated = _physicsHandsActivated;
        }
    }

    private void ToggleColliders()
    {
        if (_physicsHandsActivated)
        {
            foreach (var handcollider in _handColliders)
            {
                handcollider.enabled = true;
            }
        }
        else
        {
            foreach (var handcollider in _handColliders)
            {
                handcollider.enabled = true;
            }
        }
    }
}
