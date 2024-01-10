using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegreScript : MonoBehaviour, IDegreElectronic
{
    [SerializeField] private GameObject Gosterge;
    private Renderer renderer;

    [SerializeField] private Material Green;

    [SerializeField] private Material Red;
    private void Start()
    {
        renderer = Gosterge.GetComponent<Renderer>();
    }
    public void DegreIs(float degre)
    {
        FindAScale(degre);
        Show();
        ChangeColorToRed();
    }

    public void InHackDegre()
    {
        //Debug.Log("hackable");
        ChangeColorToGreen();
    }

    public void Hide()
    {
        hide();
    }

    private void FindAScale(float degre)
    {
        float a = (360 - degre*10) / 360;
        SetScale(a);
    }
    private void SetScale(float fscale)
    {
        Gosterge.transform.localScale=new Vector3 (fscale, fscale, fscale);
    }

    private void ChangeColorToRed()
    {
        renderer.material = Red;
    }

    private void ChangeColorToGreen()
    {
        renderer.material=Green;
    }

    private void Show()
    {
        renderer.enabled = true;
    }

    private void hide()
    {
        renderer.enabled = false;
    }
}
