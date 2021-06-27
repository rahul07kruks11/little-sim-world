using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DIALOGUEMANAGER : MonoBehaviour
{
    public TextMeshProUGUI textdisplay;
    public string[] sentences;
    private int index;
    public GameObject continuebutton;
    public GameObject panel;

    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(Type());                             // call rcoroutine
    }

    // Update is called once per frame
    void Update()
    {
        if (textdisplay.text == sentences[index])      // check if text is having current sentence or not if yes then go ahead
        {
            continuebutton.SetActive(true);                //yes then show button
        }
    }
    IEnumerator Type()                                        //coroutine
    {
        foreach (char letter in sentences[index].ToCharArray())//for all sentence
        {
            textdisplay.text += letter;                          //display letter
            yield return new WaitForSeconds(0.02f);                  // wait for that amount of time for display
        }
    }
   
    public void nextsentence()                                //function
    {
        continuebutton.SetActive(false);                        //continue button is not active
        if (index < sentences.Length - 1)                       //checking dialogue
        {
            index++;                                              // dialogue increase by 1
            textdisplay.text = "";                             //reset text
            StartCoroutine(Type());
            if (index == 3)
            {
               
                Debug.Log("index2");
                panel.SetActive(true);
                continuebutton.SetActive(false);

            }
            //display sentence slowly
        }

        else {
            textdisplay.text = "";                                 //reset text 
            continuebutton.SetActive(false);                        //button ia not active once dialogue is completed
        }
    }
   
   

}
