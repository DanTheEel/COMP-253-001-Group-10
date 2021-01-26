using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class values : MonoBehaviour
{
    public int movement = 5000000;
    public GameObject up, down, left, right;
    // Start is called before the first frame update
    void Start()
    {
        up.SetActive(true);
        down.SetActive(true);
        left.SetActive(true);
        right.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w") && movement > 0)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + .77f, -20.74586f);
            movement -= 1;
        }
        if (Input.GetKeyDown("s") && movement > 0)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - .77f, -20.74586f);
            movement -= 1;
        }
        if (Input.GetKeyDown("a") && movement > 0)
        {
            this.transform.position = new Vector3(this.transform.position.x - .77f, this.transform.position.y, -20.74586f);
            movement -= 1;
        }
        if (Input.GetKeyDown("d") && movement > 0)
        {
            this.transform.position = new Vector3(this.transform.position.x + .77f, this.transform.position.y, -20.74586f);
            movement -= 1;
        }
    }
}
