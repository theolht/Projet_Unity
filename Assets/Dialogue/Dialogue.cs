using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewDialogue",
menuName = "Dialogue")]

public class Dialogue : ScriptableObject
{
    public Queue<string> dialogue;

    [TextArea(3,10)]
    public string[] phrases;
}
