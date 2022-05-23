using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField]
    private Dialogue dialogue;

    private int m_LineIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckAnswer(int index)
    {
        Debug.Log("CheckAnswer " + index + " " + dialogue.m_Questions[m_LineIndex].m_CorrentAnswerIndex);
        if (index == dialogue.m_Questions[m_LineIndex].m_CorrentAnswerIndex)
        {
            ShowNextQuestion();
        }
        else
        {
            UIController.Instance.ClosePanel();
        }
    }

    void ShowNextQuestion()
    {
        m_LineIndex++;
        UIController.Instance.InitPanel(dialogue, m_LineIndex, this);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger enter");   
        UIController.Instance.InitPanel(dialogue, 0, this);
    }

    void OnTriggerExit(Collider other)
    {
        UIController.Instance.ClosePanel();
    }
}
