using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float pow = 1;
    [SerializeField] float camRotPow = 1;
    [SerializeField] Vector3 camOffset = new Vector3(2, 5, 3);
    Rigidbody rb;
    Vector2 rot = new Vector2(0, 0);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        rot.x += mx;
        rot.y += my;
        
        rb.AddForce(new Vector3(v, 0, h) * pow);
        Vector3 offset = Quaternion.Euler(new Vector3(rot.y, rot.x, 0) * Mathf.PI * camRotPow) * camOffset;

        Camera.main.transform.position = this.transform.position + offset;
        Camera.main.transform.LookAt(this.transform);
    }
}
