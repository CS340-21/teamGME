using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class BFirstTrigger : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject TextBox;
    public GameObject TheMarker;
    public AudioSource line03;

    void OnTriggerEnter() { 
        ThePlayer.GetComponent<FirstPersonController>() .enabled = false;
        StartCoroutine(ScenePlayer());
    }
    IEnumerator ScenePlayer() {
        TextBox.GetComponent<Text>().text = "Looks like there's a weapon on that table.";
        line03.Play();
        yield return new WaitForSeconds(1.0f);
        TextBox.GetComponent<Text>().text = "";
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        this.GetComponent<BoxCollider>().enabled = false;
        TheMarker.SetActive(true);
    
    }
}
