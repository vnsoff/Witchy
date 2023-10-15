using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Reference to the player character's Transform
    public float smoothTime = 0.3f; // Smoothing factor for camera movement
    public Vector3 offset; // Offset to control the camera's position relative to the player
    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position for the camera
            Vector3 targetPosition = target.position - target.forward * offset.z + Vector3.up * offset.y;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

            // Make the camera look at the player
            transform.LookAt(target);
        }
    }
}
