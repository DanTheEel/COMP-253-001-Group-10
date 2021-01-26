using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowUp : MonoBehaviour
{
    public Transform parent;
    public GameObject bean;
    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown("w") && this.name == "Up" && bean.GetComponent<values>().movement > 0)
        {
            parent.position = new Vector3(parent.position.x, parent.position.y + .77f, -20.74586f);
            bean.GetComponent<values>().movement -= 1;
        }*/
        if (bean.GetComponent<values>().movement == 0)
        {
            this.gameObject.SetActive(false);
        }
    }
    void OnMouseDown()
    {
        // this object was clicked - do something
        if (this.name == "Up" && bean.GetComponent<values>().movement > 0)
        {
            parent.position = new Vector3(parent.position.x, parent.position.y + .77f, -20.74586f);
            bean.GetComponent<values>().movement -= 1;
        }
        if (this.name == "Down" && bean.GetComponent<values>().movement > 0)
        {
            parent.position = new Vector3(parent.position.x, parent.position.y - .77f, -20.74586f);
            bean.GetComponent<values>().movement -= 1;
        }
        if (this.name == "Left" && bean.GetComponent<values>().movement > 0)
        {
            parent.position = new Vector3(parent.position.x - .77f, parent.position.y, -20.74586f);
            bean.GetComponent<values>().movement -= 1;
        }
        if (this.name == "Right" && bean.GetComponent<values>().movement > 0)
        {
            parent.position = new Vector3(parent.position.x + .77f, parent.position.y, -20.74586f);
            bean.GetComponent<values>().movement -= 1;
        }
    }
}
