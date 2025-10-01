using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Sphere;       // The ball to follow
    public Vector3 offset;         // Offset from the ball

    void LateUpdate()
    {
        if (Sphere != null)
        {
            transform.position = Sphere.position + offset;
        }
    }
}

