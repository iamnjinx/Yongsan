using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData : MonoBehaviour
{
    public ObjectController objectController;

    void Awake()
    {
        objectController = transform.GetChild(0).GetChild(0).GetComponent<ObjectController>();
    }
}
