using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneCp : MonoBehaviour
{
  

    public GameObject objectToInstantiate;
    public CinemachineVirtualCamera virtualCamera;

    private void Start()
    {
        GameObject instantiatedObject = Instantiate(objectToInstantiate);
        virtualCamera.Follow = instantiatedObject.transform;
    }
}
