using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject canvasAutoStore;
    public GameController gameController;

    public GameObject AutoBought1;
    public GameObject AutoBought2;
    public GameObject AutoBought3;
    public GameObject AutoBought4;
    public GameObject AutoBought5;
    public GameObject AutoBought6;
    

    
    // Start is called before the first frame update
    void Start()
    {
        canvasAutoStore.SetActive(false);

        AutoBought1.SetActive(false);
        AutoBought2.SetActive(false);
        AutoBought3.SetActive(false);
        AutoBought4.SetActive(false);
        AutoBought5.SetActive(false);
        AutoBought6.SetActive(false);

    }

    public void autoBought1()
    {
    AutoBought1.SetActive(true);
    }

    public void autoBought2()
    {
    AutoBought2.SetActive(true);
    }

    public void autoBought3()
    {
    AutoBought3.SetActive(true);
    }
    
    public void autoBought4()
    {
    AutoBought4.SetActive(true);
    }

    public void autoBought5()
    {
    AutoBought5.SetActive(true);
    }
    
    public void autoBought6()
    {
    AutoBought6.SetActive(true);
    }

    public void OpenAutoStore(){
        canvasAutoStore.SetActive(true);

        if (gameController.data.u1Auto == true)
        {
            AutoBought1.SetActive(true);
        }

        if (gameController.data.u2Auto == true)
        {
            AutoBought2.SetActive(true);
        }

        if (gameController.data.u3Auto == true)
        {
            AutoBought3.SetActive(true);
        }
        else
        {
            AutoBought3.SetActive(false);
        }


        if (gameController.data.u4Auto == true)
        {
            AutoBought4.SetActive(true);
        }
        else
        {
            AutoBought4.SetActive(false);
        }


        if (gameController.data.u5Auto == true)
        {
            AutoBought5.SetActive(true);
        }
        else
        {
            AutoBought5.SetActive(false);
        }


        if (gameController.data.u6Auto == true)
        {
            AutoBought6.SetActive(true);
        }
        else
        {
            AutoBought6.SetActive(false);
        }

    }
    public void CloseAutoStore(){
        canvasAutoStore.SetActive(false);
    }

}
