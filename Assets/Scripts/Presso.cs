using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presso : MonoBehaviour
{
    public Renderer rend;
    private Material mat;

    private void Awake()
    {
        mat = rend.material;    
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            mat.SetVector("_Color", new Vector4(0f,0f,0f,0f));
        }
    }
}
