using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    public GameObject player;
    public float interpSpeed;
    private Vector3 targetPos;

    void LateUpdate() {
        targetPos = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, targetPos, interpSpeed);
    }
}
