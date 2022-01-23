using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.right * 10);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.left * 10);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0,0,10);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0, 0, -10);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale += new Vector3(0.5f,0.5f,0.5f) * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.localScale = new Vector3(2, 2, 2);
        }
    }
}
