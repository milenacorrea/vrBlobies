using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        GameMasterData.Instance.Door1Unlock = true;
       // Debug.Log("Door 1 Unlocked");
        /*
        if (other.tag == "BlobFriend1"){
            GameMasterData.Instance.Door1Unlock = true;
            Debug.Log("Door 1 Unlocked");
                       
        }
        */
    }
}
