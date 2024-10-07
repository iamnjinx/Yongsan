using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapPin : MonoBehaviour
{
    private Minimap minimap;
    private GameObject childObj;

    public int id;

    private void Awake() {
        minimap = transform.parent.parent.GetComponent<Minimap>();
        childObj = transform.GetChild(0).gameObject;
    }

    public void hoverIn(){
        //Debug.Log("why");
        minimap.hovered_pin(id);
        childObj.SetActive(true);
    }

    public void hoverOut(){
        minimap.no_hovered_pin();
        childObj.SetActive(false);
    }
}
