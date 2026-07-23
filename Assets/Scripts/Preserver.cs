using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preserver : MonoBehaviour
{
    public List<GameObject> objectsToPreserve;

    private void Start()
    {
        foreach (var go in objectsToPreserve)
        {
            DontDestroyOnLoad(go);
        }
        
        DestroyImmediate(gameObject);
    }
}
