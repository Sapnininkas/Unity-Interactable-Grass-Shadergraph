using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassInteract : MonoBehaviour
{
    public Shader shader;

    void Update()
    {
        Shader.SetGlobalVector("_Player", transform.position + Vector3.up);
    }
}
