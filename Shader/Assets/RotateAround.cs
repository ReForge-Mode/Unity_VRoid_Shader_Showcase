using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public float rotate = 0.1f;

    private void Update()
    {
         transform.Rotate(0f, rotate, 0f, Space.World);
    }
}
