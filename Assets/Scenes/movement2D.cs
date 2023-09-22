using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2D : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
       // transform.position = new Vector3(0,1,0);
        // Debug.Log("1");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))

        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime; 


        }
        if (Input.GetKey(KeyCode.D))

        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime; 


        }
        if (Input.GetKey(KeyCode.Space))

        {
            transform.position += new Vector3(0, 3, 0) * Time.deltaTime; 


        }
    }
}
