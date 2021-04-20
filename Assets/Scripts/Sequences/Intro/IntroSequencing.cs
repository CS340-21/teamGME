using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSequencing : MonoBehaviour
{
    public GameObject textBox;
    public GameObject dateDisplay;
    public GameObject placeDisplay;
    public AudioSource thudSound;
    public GameObject allBlack;

    void Start()
    {
        StartCoroutine(SequenceBegin());
    }

    IEnumerator SequenceBegin() {
        yield return new WaitForSeconds(3);
        placeDisplay.SetActive(true);
        yield return new WaitForSeconds(1);
        dateDisplay.SetActive(true);
        yield return new WaitForSeconds(4);
        placeDisplay.SetActive(false);
        dateDisplay.SetActive(false);
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "I wish I never went into that shed...";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(6);
        allBlack.SetActive(true);
        thudSound.Play();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(3);
       
    }
   
}
