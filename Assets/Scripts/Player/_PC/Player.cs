using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController playerController;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move(){
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        playerController.Move(move * Time.deltaTime * speed);
    }

    
}
