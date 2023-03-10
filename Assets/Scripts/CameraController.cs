using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float yPos;
    
    private float _rootXPos;
    private float _distanceToRoot;
    
    // Start is called before the first frame update
    private void Start()
    {
        // get root x position and lock y position
        _rootXPos = player.transform.position.x;

        // get fixed distance to root (x component)
        _distanceToRoot = transform.position.x - _rootXPos;
    }

    // Update is called once per frame
    private void Update()
    {
        _rootXPos = player.transform.position.x;
        // lock the camera's x position to the delta between root and camera
        transform.position = new Vector3(_distanceToRoot + _rootXPos, yPos, -10f);
    }
}
