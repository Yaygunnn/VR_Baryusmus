using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPuzzleBG : MonoBehaviour
{
    [SerializeField] public bool dondur;
    [SerializeField] public float donmemiktari;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dondur)
        {
            //transform.Rotate(new Vector3(donmemiktari,donmemiktari,donmemiktari)*Time.deltaTime);

            transform.Rotate(new Vector3(0, donmemiktari, 0) * Time.deltaTime);
        }
    }
}
