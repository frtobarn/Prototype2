using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //counter for seconds
    private float time = 3;

    // Update is called once per frame
    void Update()
    {
        //increase time
        time += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && time > 2)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //reset time
            time = 0;
        }
    }
}
