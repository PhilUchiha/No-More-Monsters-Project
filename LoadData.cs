using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadData : MonoBehaviour
{
    public GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController.data.LoadPlayer();
    }

}
