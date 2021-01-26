using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonagain : MonoBehaviour
{
    public GameObject area;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        // this object was clicked - do something
        area.SetActive(true);
        this.gameObject.SetActive(false);

    }
}
