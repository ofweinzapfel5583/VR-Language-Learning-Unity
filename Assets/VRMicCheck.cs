using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VRMicCheck : MonoBehaviour
{
    //[SerializeField] private Button recordButton;
    [SerializeField] private TMP_Text message;
    //[SerializeField] private TMP_Text message2;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var device in Microphone.devices)
        {
            message.text = Microphone.devices.Length.ToString();
            //message.text = device.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
