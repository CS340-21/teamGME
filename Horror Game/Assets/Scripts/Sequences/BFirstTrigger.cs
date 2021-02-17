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

    void OnTriggerEnter() { 
        ThePlayer.GetComponent<FirstPersonController>() .enabled = false;
        StartCoroutine(ScenePlayer());
    }
    IEnumerator ScenePlayer() {
        TextBox.GetComponent<Text>().text = "Is that a weapon over there?";
        yield return new WaitForSeconds(2.5f);
        TextBox.GetComponent<Text>().text = "";
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        TheMarker.SetActive(true);
    
    }
}
