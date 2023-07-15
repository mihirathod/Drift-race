using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carspawner : MonoBehaviour
{
    public GameObject chetakPrefab; 
    public GameObject porsce;
    public GameObject arcade;
    public bool gotimer =false;
  



    public void chettakON() 
    {
        chetakPrefab.gameObject.SetActive(true);
        gotimer = true;
    }
    public void porsceON()
    {
        porsce.gameObject.SetActive(true);
        gotimer = true;


    }
    public void ArcadeON()
    {
        arcade.gameObject.SetActive(true);
        gotimer = true;

    }
}
