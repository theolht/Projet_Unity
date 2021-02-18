using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script : MonoBehaviour
{
    public Dialogue dialogue;
    public Titre titre;

    
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
            
        }
        
    }
}
