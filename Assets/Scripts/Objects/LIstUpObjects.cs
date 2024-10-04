using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListUpObjects : MonoBehaviour
{
    [SerializeField] List<Transform> YongsanObjects = new List<Transform>{};
    [SerializeField] ObjectDB objectDB;

    // Start is called before the first frame update
    void Awake()
    {
        int i = 0;
        foreach(Transform tr in transform){
            YongsanObjects.Add(tr);
            if(tr.GetComponent<ObjectData>() != null){
                tr.GetComponent<ObjectData>().objectDBEntity = objectDB.Entities[i];
            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
