using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameMasterData : MonoBehaviour
{

    // use GameMasterData.Instance.whatever we want to reference specific variable in any script

    public static GameMasterData Instance;

    public bool Door1Unlock;

    public bool Blob1Active;
    


    // Start is called before the first frame update
    void Start()
    {
        Door1Unlock = false;
        Blob1Active = false;
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void Awake()
    {
        Instance = this;
    }

}
