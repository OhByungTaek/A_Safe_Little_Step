using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class panelController : MonoBehaviour
{
    public GameObject Clearpanel;
    public GameObject Failpanel;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Truck" || collision.gameObject.tag == "police")
        {
            Failpanel.SetActive(true);
        }

        if (collision.gameObject.tag == "portal")
        {
            Clearpanel.SetActive(true);
        }
    }

}
