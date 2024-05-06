using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject canvasAutoStore;
    // Start is called before the first frame update
    void Start()
    {
        canvasAutoStore.SetActive(false);
    }
    public void OpenAutoStore(){
        canvasAutoStore.SetActive(true);
    }
    public void CloseAutoStore(){
        canvasAutoStore.SetActive(false);
    }
}
