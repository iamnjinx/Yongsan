using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class UiCube : MonoBehaviour
{

    public FollowPlayerSight followPlayerSIght;

    private void OnBecameInvisible()
    {
        followPlayerSIght.isCentered = false;
        //Debug.Log($"a");
    }
}
