using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, with a delay of 1 second between the instatietions 
        if (Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = 1;
        } else if(cooldown >= 0) 
        {
            cooldown -= Time.deltaTime;
        }
    }
}
