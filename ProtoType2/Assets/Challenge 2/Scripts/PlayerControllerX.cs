using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private DateTime lastdogSpawned;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && lastdogSpawned.AddSeconds(.25f) < DateTime.Now)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastdogSpawned = DateTime.Now;
        }
    }
}
