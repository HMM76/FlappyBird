using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowLastScore : MonoBehaviour
{
    public TextMeshProUGUI textm;
    private void Start()
    {
        textm = GetComponent<TextMeshProUGUI>();
    }
}
