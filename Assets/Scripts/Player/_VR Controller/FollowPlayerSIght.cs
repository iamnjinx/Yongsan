using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerSight : MonoBehaviour
{
    public Transform cameraTransform;

    float yPos;
    [SerializeField] private float distance = 3.0f;

    public bool isCentered = false;

    private void Awake() {
        yPos = transform.position.y;
        cameraTransform = Camera.main.transform;
    }

    private void Start() {
        resetPosition();
    }

    private void Update()
    {
        resetPosition();
    }


    public void resetPosition(){
        float d = Vector3.Distance(cameraTransform.position, transform.position);
        //Debug.Log(d);
        if (!isCentered || d > distance)
        {
            // Find the position we need to be at
            Vector3 targetPosition = FindTargetPosition();

            // Move just a little bit at a time
            MoveTowards(targetPosition);

            // If we've reached the position, don't do anymore work
            if (ReachedPosition(targetPosition))
                isCentered = true;
        }
    }

    private Vector3 FindTargetPosition()
    {
        Vector3 target = cameraTransform.position + (cameraTransform.forward * distance);
        target = new Vector3(target.x, yPos, target.z);
        return target;
    }

    private void MoveTowards(Vector3 targetPosition)
    {
        transform.position += (targetPosition - transform.position) * 0.025f;
        //transform.LookAt(cameraTransform);
    }

    private bool ReachedPosition(Vector3 targetPosition)
    {
        return Vector3.Distance(targetPosition, transform.position) < 0.1f;
    }
}
