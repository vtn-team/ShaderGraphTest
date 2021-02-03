using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderParam : MonoBehaviour
{
    Material mat;
    Vector4 uvVec = new Vector4();

    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        mat = renderer.materials[0];
    }

    // Update is called once per frame
    void Update()
    {
        uvVec.y += 0.01f;
        mat.SetVector("_ScrollUV", uvVec);
    }
}
