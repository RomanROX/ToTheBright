using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCInteraction : Interactables
{
    public Sprite dialogueBoxSprite;
    public GameObject dialogueBox;
    //public AudioSource audioSource;

    //public AudioClip dialogueSound;

    public Dialog dialogue;
    public bool isDialogueTrigger = false;



    private void Start()
    {
        //audioSource = GetComponent<AudioSource>();
    }

    
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerInRange = false;
        
        FindObjectOfType<DialogueManager>().animator.SetBool("IsOpen", false);
        //audioSource.Stop();
        isDialogueTrigger = false;
    }

    private void Update()
    {
        if (isPlayerInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
               
                if (isDialogueTrigger)
                {
                    FindObjectOfType<DialogueManager>().DisplayNextSentence();
                }
                else
                {
                    dialogueBox.transform.GetComponent<Image>().sprite = dialogueBoxSprite;
                    TriggerDialogue();
                    isDialogueTrigger = true;
                }
            }
            
        }

    }


    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
