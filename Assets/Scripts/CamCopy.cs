using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCopy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.rotation = Camera.main.transform.rotation;
        this.transform.position = Camera.main.transform.position;
    }
}
