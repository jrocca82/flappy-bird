using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform playerPosition;

    void Update()
    {
        this.gameObject.transform.position = new Vector3 (playerPosition.position.x + 4, playerPosition.position.y, this.gameObject.transform.position.z);
    }
}
