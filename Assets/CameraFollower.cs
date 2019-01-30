using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{

    [SerializeField]
    Transform target;
    public float smoothSpeed = 0.125f; 
    public Vector3 offSet;
    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offSet;
        Vector3 smoothedPosition = Vector3.SmoothDamp(target.position, desiredPosition, ref velocity, (smoothSpeed * Time.deltaTime));

    }
}
