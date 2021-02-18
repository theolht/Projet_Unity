using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script : MonoBehaviour
{
    public Dialogue dialogue;
    public Titre titre;

    [SerializeField] private GameObject textBox;
    int index = 0;
    [SerializeField]  private TextMeshProUGUI dialogueTextComponant;
    [SerializeField]  private TextMeshProUGUI TitreTextComponant;
    public void HandleClick(){
        if (index != dialogue.phrases.Length)
        {
            dialogueTextComponant.text = dialogue.phrases[index];
            TitreTextComponant.text = $"{titre.Title} : {index + 1}/{dialogue.phrases.Length}";
            index++;
        }
        else
        {
            textBox.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
        
    }
}
