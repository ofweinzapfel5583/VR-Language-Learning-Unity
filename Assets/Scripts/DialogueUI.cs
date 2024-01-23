//Script written by Jorge Blanco 
//www.youtube.com/watch?v=wBFsA7rzNMQ&t=79s

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Dialogue;
using TMPro;

namespace UIElements
{

    public class DialogueUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI npcNameText;
        [SerializeField] private TextMeshProUGUI sentenceText;

        private Button[] _buttons;
        private Queue<string> _sentences;
        private DialogueOption[] _DialogueOptions;
        private DialogueOption _defaultDialogueOption;
        // Start is called before the first frame update
        void Start()
        {
            _buttons = GetComponentsInChildren<Button>();
            _sentences = new Queue<string>();
            gameObject.SetActive(false);
        }


        public void SetNpcName(string npcName)
        {
            npcNameText.text = npcName;
        }

        public void SetSentences(IEnumerable<string> sentences)
        {
            _sentences.Clear();
            foreach(var sentence in sentences)
            {
                _sentences.Enqueue(sentence);
            }
        }

        public void SetDialogueOptions(DialogueOption[] DialogueOptions, DialogueOption defaultOption)
        {
            _DialogueOptions = DialogueOptions;
            _defaultDialogueOption = defaultOption;
        }

        public void ContinueDialogue()
        {
            gameObject.SetActive(true);
            if (DisplaySentence())
            {
                DisplayContinueDialogueButton();
            }
            else if(_DialogueOptions.Length > 0)
            {
                DisplayDialogueOptions();
            } else if(_defaultDialogueOption != null)
            {
                DisplayDefaultDialogueOption();
            } else
            {
                EndDialogue();
            }
        }

        public void EndDialogue()
        {
            gameObject.SetActive(false);
        }

        private bool DisplaySentence()
        {
            if(_sentences.Count <= 0)
            {
                return false;
            }

            sentenceText.text = _sentences.Dequeue();
            return _sentences.Count > 0;
        }

        private void DisplayContinueDialogueButton()
        {
            if (_buttons.Length <= 0)
            {
                return;
            }

            for(var i = 0; i < _buttons.Length; i++)
            {
                if (i == 0)
                {
    
                } else
                {
                    _buttons[i].gameObject.SetActive(false);
                }
            }
        }

        private void DisplayDefaultDialogueOption()
        {
            if(_buttons.Length <= 0)
            {
                return;
            }

            for (var i = 0; i < _buttons.Length; i++)
            {

            }
        }

        private void DisplayDialogueOptions()
        {
            var optionsCount = _DialogueOptions.Length;
            Debug.Log("This is the options count for buttons: " + optionsCount.ToString());
            for(var i = 0; i < _buttons.Length; i++)
            {
                if(i < optionsCount)
                {
                    var text = _buttons[i].GetComponentInChildren<Text>();
                    text.text = _DialogueOptions[i].buttonText;
                    _buttons[i].onClick.RemoveAllListeners();
                    _buttons[i].onClick.AddListener(_DialogueOptions[i].actionTrigger.Invoke);
                    _buttons[i].gameObject.SetActive(true);
                }
                else
                {
                    _buttons[i].gameObject.SetActive(false);
                }
            }
        }
    }
}
