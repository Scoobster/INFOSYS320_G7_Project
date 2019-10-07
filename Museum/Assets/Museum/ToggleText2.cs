using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ToggleText2 : MonoBehaviour
{
    public TextMeshPro testText;
    public void ToggleTheText2()
    {
          if (testText.enabled == false)
        {
            testText.enabled = true;
        } else
        {
            testText.enabled = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        testText.enabled = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
