using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_camera_states : MonoBehaviour
{
    // Initialize the private variables
    scr_camera_stats cameraStats;
    scr_camera_functions cameraFunctions;

    // Run this code once
    void Start()
    {
        // Link the camera scripts to the initialized variables
        cameraStats = GetComponent<scr_camera_stats>();
        cameraFunctions = GetComponent<scr_camera_functions>();
    }

    // Run this code every frame
    void Update()
    {
        // Run the camera functions based on the current camera state
        switch (cameraStats.cameraState)
        {
            case scr_camera_stats.states.DEFAULT: // The default camera state
                cameraFunctions.followTarget(cameraStats.followTargetTransform, cameraStats.followSpeed);
                break;
        }
    }
}
