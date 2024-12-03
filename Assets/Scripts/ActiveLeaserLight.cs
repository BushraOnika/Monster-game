using System;
using UnityEngine;

public class ActiveLeaserLight : MonoBehaviour
{
    public LeaserLight leaserLight;

    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            leaserLight.gameObject.SetActive(true);
        }
        else
        {
            leaserLight.gameObject.SetActive(false);
        }
    }
}