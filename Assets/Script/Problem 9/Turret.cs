using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform target;
    Vector3 dir;
    float angle;

    void Update()
    {
        float angle = 0;
          
        Vector3 relative = transform.InverseTransformPoint(target.position);
        angle = Mathf.Atan2(relative.x, relative.y)*Mathf.Rad2Deg;
        transform.Rotate(0,0, -angle);
    }
}
