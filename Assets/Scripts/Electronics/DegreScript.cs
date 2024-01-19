using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegreScript : MonoBehaviour, IDegreElectronic
{
    [SerializeField] private GameObject Gosterge;
    private Renderer renderer;

    [SerializeField] private Material Green;

    [SerializeField] private Material Blue;

    [SerializeField] private Material Red;
    private void Start()
    {
        //renderer = Gosterge.GetComponent<Renderer>();
        renderer = GetComponent<Renderer>();
    }
    public void DegreIs(float degre)
    {
        FindAScale(degre);
        Show();
        ChangeColorToBlue();
    }

    public void InHackDegre()
    {
        //Debug.Log("hackable");
        ChangeColorToGreen();
    }

    public void OutOfDistance()
    {
        ChangeColorToRed();
    }
    public void Hide()
    {
        hide();
    }

    private void FindAScale(float degre)
    {
        float a = (360 - degre*5) / 360;
        SetScale(a);
    }
    private void SetScale(float fscale)
    {
        transform.localScale = new Vector3(fscale, fscale, fscale) / 3;
    }

    private void ChangeColorToRed()
    {
        renderer.material = Red;
    }
    private void ChangeColorToBlue()
    {
        renderer.material = Blue;
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
