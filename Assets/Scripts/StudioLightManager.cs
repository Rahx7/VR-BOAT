using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudioLightManager : MonoBehaviour
{
    private Transform[] _children;
    // Start is called before the first frame update
    void Start()
    {
        _children = transform.GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleLights()
    {
        foreach (var child in _children)
        {
            GameObject gm = child.gameObject;
            if (gm.activeSelf)
            {
                gm.SetActive(false);
            }
            else
            {
                gm.SetActive(true); 
            }
        }

    }
}
