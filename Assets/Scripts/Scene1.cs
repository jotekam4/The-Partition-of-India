using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scene1 : MonoBehaviour
{
    public Image bag;
    public Sprite bagOpen;
    public Sprite bagClose;




    // Start is called before the first frame update
    void Start()
    {

    }



    public void ImageChanger()
    {
        if(bag.sprite == bagOpen)
        {
            bag.sprite = bagClose;
        }
        else
        {
            bag.sprite = bagOpen;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
