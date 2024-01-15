using SuperSystems.ImageEffects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderOpen : MonoBehaviour
{
    public static ShaderOpen Instance;

    private void Awake()
    {
        Instance = this;
    }
    public void OpenShaderMode()
    {
        this.gameObject.GetComponent<WireframeImageEffect>().enabled = true;
    }

    public void CloseShaderMode()
    {
        this.gameObject.GetComponent<WireframeImageEffect>().enabled = false;
    }
}
