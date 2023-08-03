using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchMovement : MonoBehaviour
{
    void Update()
    {
        Vector3 Direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float Angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(Angle, Vector3.forward);
        transform.Rotate(new Vector3(0.0f, 0.0f, -90.0f));
    }
}
