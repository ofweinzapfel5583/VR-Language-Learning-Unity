//Script written by Jorge Blanco 
//www.youtube.com/watch?v=wBFsA7rzNMQ&t=79s

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This handles which NPC is talking and the State the NPC is speaking
namespace Dialogue
{
    public class DialogueState : MonoBehaviour
    {

        public Dictionary<string, string> stateDictionary;

        // Update is called once per frame
        void Start()
        {
            stateDictionary = new Dictionary<string, string>();
        }
    }
}
