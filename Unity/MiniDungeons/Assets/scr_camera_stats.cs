using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_camera_stats : MonoBehaviour
{
    // Initialize the states enum variable type
    public enum states { DEFAULT, TURNLEFT, TURNRIGHT };

    // Initialize the public variables
    public states cameraState = states.DEFAULT;
    public float followSpeed;
    public Transform followTargetTransform;
}
