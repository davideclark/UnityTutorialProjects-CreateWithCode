using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject propeller;

    private int rotateAmount = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3.forward * speed * Time.deltaTime
        propeller.transform.Rotate(0,0, rotateAmount);
    }
}
