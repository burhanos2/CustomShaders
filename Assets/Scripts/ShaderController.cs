using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderController : MonoBehaviour
{
    [SerializeField]
    private Renderer rend;
    private Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mat = rend.material;
        mat.SetFloat("_Amount", 0);
    }
}
