using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public GameObject Player;
    private Vector3 Vectorpt;
    public float Deadbound;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Player.transform.position = Vectorpt;
            Player.transform.rotation = new Quaternion(0,0 , 0, 0);

        }
        else if (Player.transform.position.y < Deadbound)
        {
            Player.transform.position = Vectorpt + new Vector3(5,5,5);
            Player.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            Vectorpt = Player.transform.position;
        }

      
        
        
    }
}
