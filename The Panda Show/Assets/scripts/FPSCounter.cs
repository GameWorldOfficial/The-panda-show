using UnityEngine;

public class FPSCounter : MonoBehaviour
{

    public GameObject DynamicInfoText;
    public GameObject StaticInfoText;

    void Update()
    {
        if (Input.GetKeyDown("`"))
        {
            DynamicInfoText.SetActive(true);
            StaticInfoText.SetActive(true);
        }
        if (Input.GetKeyUp("`"))
        {
            DynamicInfoText.SetActive(false);
            StaticInfoText.SetActive(false);
        }
    }
}