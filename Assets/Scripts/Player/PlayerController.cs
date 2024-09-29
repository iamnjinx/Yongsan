using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] CharacterController CC;

    [SerializeField] float Gravity = -7.5f;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        CC.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(!CC.isGrounded){
            velocity.y += Gravity * Time.deltaTime;

            CC.Move(velocity);
        }
    }
}
