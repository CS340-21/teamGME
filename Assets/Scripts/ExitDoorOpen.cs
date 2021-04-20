using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ExitDoorOpen : MonoBehaviour
{
  public float TheDistance;
  public GameObject ActionDisplay;
  public GameObject ActionText;
  public GameObject ExtraCross;
  public GameObject FadeOut;

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver() {
        if (TheDistance <= 2) {
            ActionText.GetComponent<Text>().text = "Open Door";
            ExtraCross.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action")) {
            if (TheDistance <= 2) {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                FadeOut.SetActive(true);
                StartCoroutine(FadeToExit());
            }
        }
        IEnumerator FadeToExit() {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(5);
        }
    }

    void OnMouseExit() {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
