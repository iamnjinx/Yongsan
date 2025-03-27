using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCanvas : MonoBehaviour
{
    [SerializeField] GameObject canvasPrefab;

    [SerializeField] Transform Object_UI_Transform;
    
    private void Start() {
        var tempCanvas = Instantiate(canvasPrefab, transform.GetChild(0).position, Quaternion.identity, Object_UI_Transform);
        ObjectController objectController = tempCanvas.GetComponent<ObjectController>();
        //objectController.objectDBEntity = GetComponent<ObjectData>().objectDBEntity;
        objectController.GiveData();
        //tempCanvas.GetComponent<LookAtPlayer>().objSize = transform.GetChild(0).GetComponent<ObjSize>().size;
    }
}
