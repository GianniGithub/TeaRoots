using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameObject WinScreen;

    private void OnTriggerEnter2D()
    {
        WinScreen.SetActive(true);
    }
}
