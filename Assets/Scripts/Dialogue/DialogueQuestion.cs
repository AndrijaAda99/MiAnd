using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New question", menuName = "DialogueQuestion")]
public class DialogueQuestion : ScriptableObject
{
    [SerializeField]
    public string m_Text;

    [SerializeField]
    public List<string> m_Answers;

    [SerializeField]
    public int m_CorrentAnswerIndex;
}
