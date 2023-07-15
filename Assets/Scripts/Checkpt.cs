using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpt : MonoBehaviour
{
    public GameObject CP;
    public GameObject Cp2;




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CP.SetActive(false);
            Cp2.SetActive(true);
        }
       
    }


}
