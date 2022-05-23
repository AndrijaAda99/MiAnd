using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject m_Panel;

    [SerializeField]
    TextMeshProUGUI m_Answers1;

    [SerializeField]
    TextMeshProUGUI m_Answers2;


    [SerializeField]
    TextMeshProUGUI m_Title;

    [SerializeField]
    TextMeshProUGUI m_NPCname;

    private NPC m_NPC;

    private static UIController m_Instance;

    public static UIController Instance { get { return m_Instance; } }

    void Awake()
    {
        if (m_Instance != null && m_Instance != this)
        {
            Destroy(this.gameObject);
        } else {
            m_Instance = this;
        }
    }

    public void InitPanel(Dialogue dialogue, int index, NPC npc)
    {
        m_Panel.SetActive(true);

        m_Title.text = dialogue.m_Questions[index].m_Text;
        m_NPCname.text = dialogue.m_NPC;

        m_Answers1.text = dialogue.m_Questions[index].m_Answers[0];
        m_Answers2.text = dialogue.m_Questions[index].m_Answers[1];


        m_NPC = npc;
    }

    public void ClosePanel()
    {
        m_Panel.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        m_Answers1.transform.parent.GetComponent<Button>().onClick.AddListener(() => m_NPC.CheckAnswer(0));
        m_Answers2.transform.parent.GetComponent<Button>().onClick.AddListener(() => m_NPC.CheckAnswer(1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
