using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New dialogue", menuName = "Dialogue")]
public class Dialogue : ScriptableObject
{
    [SerializeField]
    public string m_NPC;

    [SerializeField]
    public List<DialogueQuestion> m_Questions;
    
}
