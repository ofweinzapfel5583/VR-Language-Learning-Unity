//Script written by Jorge Blanco 
//www.youtube.com/watch?v=wBFsA7rzNMQ&t=79s

using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using System;

//This script triggers events in the conversation. For example, be able to open another UI box or play an animation.
namespace Helpers
{
    [Serializable]
    public class ScriptableEvent 
    {
        public string eventname;
        public UnityEvent unityEvent;
    }
}
