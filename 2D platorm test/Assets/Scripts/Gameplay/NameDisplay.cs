using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameDisplay : MonoBehaviour
{

    public TextMeshProUGUI NameText;
    // Start is called before the first frame update
    void Start()
    {
        NameText.text = PlayerPrefs.GetString("name");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
