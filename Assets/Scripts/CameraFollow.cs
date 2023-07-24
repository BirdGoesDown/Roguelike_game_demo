using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 offset;
    //Transform player;

    public float _camSize;
    private Camera cam;

    public float maxSize;
    public float minSize;


    private void Start()
    {
        cam = GetComponent<Camera>();
        _camSize = cam.orthographicSize;
    }

    private void Update()
    {
        //transform.position = player.position + offset;
        transform.position = GameObject.FindWithTag("Player").transform.position + offset;
        Zoom();
    }
    void Zoom()
    {
        if (Mathf.Abs(cam.orthographicSize - _camSize) > 0.05)
        {
            float changer = Mathf.Lerp(cam.orthographicSize, _camSize, Time.deltaTime * 2);
            cam.orthographicSize = changer;
        }
        

        if (Input.mouseScrollDelta.y > 0 && _camSize > minSize)
        {
            _camSize -= 0.25f;
        }
        else if (Input.mouseScrollDelta.y < 0 && _camSize < maxSize)
        {
            _camSize += 0.25f;
        }
    }
}
