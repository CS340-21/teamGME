using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Opening_001 : MonoBehaviour
{

    public GameObject ThePlayer;
    public GameObject FadeScreenIn;
    public GameObject TextBox;

    // Start is called before the first frame update
    void Start()
    {
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer() {
        yield return new WaitForSeconds(1.5f);
        FadeScreenIn.SetActive(false);
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        TextBox.GetComponent<Text>().text = "I need to get out of here...";
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<Text>().text = "";
        
    }

}
