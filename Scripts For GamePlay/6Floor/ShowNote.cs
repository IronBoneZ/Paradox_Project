using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowNote : MonoBehaviour
{
    [SerializeField] private GameObject note;

    [SerializeField] private GameObject Text1;

    [SerializeField] private GameObject Text2;

    [SerializeField] private GameObject Text3;

    [SerializeField] private GameObject Text4;

    [SerializeField] private GameObject Text5;

    [SerializeField] private GameObject Text6;
    [SerializeField] private AudioSource Altert;

    
    

    int ClickN = 2;
    int Playertrig = 1;
    

    void Start()
    {
        note.gameObject.SetActive(false);
        Text1.gameObject.SetActive(false);
        Text2.gameObject.SetActive(false);
        Text3.gameObject.SetActive(false);
        Text4.gameObject.SetActive(false);
        Text5.gameObject.SetActive(false);
        Text6.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        noteShow();
        // noteHide();

    }
    void noteShow()
    {
        if(Input.GetKeyDown(KeyCode.N))
        {
            switch (ClickN)
             {
                case 1 :
                ClickN = 2;
                Altert.Play();
                note.gameObject.SetActive(false);

                 break;

                case 2 :
                ClickN = 1;
                Altert.Play();
                note.gameObject.SetActive(true);

                 break;


             }
        }  
    }

    void noteHide()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            note.gameObject.SetActive(false);
        }

    }

    
    
}
