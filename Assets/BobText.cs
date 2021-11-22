using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobText : MonoBehaviour
{
    public GameObject bobText;
    
    // Start is called before the first frame update
    public void Start()
    {
        bobText.SetActive(false);
    }

    // Update is called once per frame
    public void OnMouseOver()
    {
        bobText.SetActive(true);
    }

    public void OnMouseExit()
    {
      bobText.SetActive(false);
    }
}
