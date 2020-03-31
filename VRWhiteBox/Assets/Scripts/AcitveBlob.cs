using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcitveBlob : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip blobsound;
    

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Light>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            GameMasterData.Instance.Blob1Active = true;
            Debug.Log("Blob1Active");
        }

        if (Input.GetKeyDown("3"))
        {
            GameMasterData.Instance.Blob1Active = false;
            Debug.Log("Blob1inactive");
        }        

        if(GameMasterData.Instance.Blob1Active == true)
        {
            
            Debug.Log("play audio");
            this.GetComponent<Light>().enabled = true;
            audioSource.PlayOneShot(blobsound, .1f);
            

        }

        if(GameMasterData.Instance.Blob1Active == false)
        {
            this.GetComponent<Light>().enabled = false;
            //
            Debug.Log("Stop audio");
            audioSource.Stop();
        }


    }
}
