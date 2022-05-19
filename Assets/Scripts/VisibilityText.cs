using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityText : MonoBehaviour
{

    public GameObject player;
    public float visibilityDistance = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        TextMesh textMesh = gameObject.GetComponent<TextMesh>();
        float dist = Vector3.Distance(transform.position, player.transform.position);

        if (dist > visibilityDistance)
        {
            textMesh.text = "";
        }

    }
}
