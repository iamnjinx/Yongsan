using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minimap : MonoBehaviour
{
    [SerializeField] List<Transform> pins = new List<Transform>();
    private minimap_tp minimap_Tp;

    private float curSize = 0.38f;

    private void Awake() {
        minimap_Tp = FindObjectOfType<minimap_tp>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //curSize = transform.localScale.x;
        //Debug.Log(curSize);
    }

    private void Update() {
        transform.LookAt(Camera.main.transform.position);
    }

    public void hovered_pin(int id){
        for (int i = 0; i < pins.Count; i++){
            if(id == i) raiseSize(true, pins[i]);
            else raiseSize(false, pins[i]); 
        } 
    }

    public void no_hovered_pin(){
        foreach(Transform tr in pins){
            tr.localScale = new Vector3(curSize, curSize, curSize);
            tr.GetComponent<Image>().color = new Color32(255,255,255,255);
        }
    }

    public void raiseSize(bool is_raised, Transform pin){
        Vector3 tempSize = new Vector3(curSize, curSize, curSize) * 1.5f;
        if(is_raised){
            // 사이즈 커짐
            pin.localScale = tempSize;
        }
        else{
            // 반투명
            pin.GetComponent<Image>().color = new Color32(255,255,255,100);
        }
    }
}
