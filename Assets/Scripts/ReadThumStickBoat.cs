using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ReadThumStickBoat : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] InputActionReference _thumstickAction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float thumbstickVal = _thumstickAction.action.ReadValue<Vector2>().y;
        Debug.Log("ThumbstickValue = " + thumbstickVal);
    }
}
