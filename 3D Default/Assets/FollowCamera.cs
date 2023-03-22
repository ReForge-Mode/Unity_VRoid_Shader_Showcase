using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;
    public float distance;

    private void Awake()
    {
        distance = transform.position.x - player.position.x;
    }

    private void Update()
    {
        transform.position = new Vector3(player.position.x + distance, transform.position.y, transform.position.z);
    }
}
