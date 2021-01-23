using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NightLockedTextScript : MonoBehaviour
{

    public Text NotUnlocked;

    public void OnClick()
    {
        NotUnlocked = GetComponent<Text>();
        NotUnlocked.enabled = true;
        StartCoroutine(NotUnlockedText());
    }

    public IEnumerator NotUnlockedText()
    {
        yield return new WaitForSeconds(5);
        NotUnlocked.enabled = false;
    }
}
