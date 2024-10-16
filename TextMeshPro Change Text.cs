using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeText : MonoBehaviour
{
    public TMP_Text theText;
    // Start is called before the first frame update
    void Start()
    {
        theText.text = "Some Text.";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
