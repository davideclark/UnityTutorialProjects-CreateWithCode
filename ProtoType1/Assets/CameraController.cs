using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera rearCamera;
    public Camera frontCamera;
    public Camera topDownCamera;

    // Start is called before the first frame update
    void Start()
    {
        rearCamera.enabled = true;
        frontCamera.enabled = false;
        topDownCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        var spacePressed = Input.GetKeyDown(KeyCode.Space);
        if (spacePressed)
        {
            if (rearCamera.enabled)
            {
                rearCamera.enabled = false;
                frontCamera.enabled = true;
            }
            else if (frontCamera.enabled)
            {
                frontCamera.enabled = false;
                topDownCamera.enabled = true;
            }
            else if (topDownCamera.enabled)
            {
                topDownCamera.enabled = false;
                rearCamera.enabled = true;
            }
        }
    }
}
