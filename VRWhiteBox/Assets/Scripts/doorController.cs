using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            GameMasterData.Instance.Door1Unlock = true;

        }
        else
        {
            GameMasterData.Instance.Door1Unlock = false;
        }

        if (GameMasterData.Instance.Door1Unlock == true)
        {
            Debug.Log("Door 1 Unlocked");
            anim.Play("Open door");
        }
    }
}
