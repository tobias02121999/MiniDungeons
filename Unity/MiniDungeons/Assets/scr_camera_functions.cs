using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_camera_functions : MonoBehaviour
{
    // Lerp towards a given target transform
    public void followTarget(Transform targetTransform, float followSpeed)
    {
        // 
        var dist = Vector3.Distance(transform.position, targetTransform.position);
        transform.position = Vector3.MoveTowards(transform.position, targetTransform.position, dist * followSpeed);
    }

    // 
    public void rotateToDegree(Vector3 targetRotation, float rotationSpeed)
    {
        
    }
}
