using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcitveBlob : MonoBehaviour
{
    public AudioSource audioSource;
    

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
        else
        {
            GameMasterData.Instance.Blob1Active = false;
            //this.GetComponent<Light>().enabled = false;
        }

        if(GameMasterData.Instance.Blob1Active == true)
        {
            audioSource.Play();
            this.GetComponent<Light>().enabled = true;
        }
    }
}
