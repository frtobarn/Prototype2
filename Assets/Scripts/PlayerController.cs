using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    private float xRange = 20.0f;
    private float zMinRange = -11.5f;
    private float zMaxRange = 16.5f;
    private float horizontalInput;
    private float verticalInput;
    private float speed = 20.0f;
    public Transform projectileSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, 1) * verticalInput * Time.deltaTime * speed);
        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z <= zMinRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMinRange);
        }
        else if (transform.position.z >= zMaxRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMaxRange);
        }
    }
}
