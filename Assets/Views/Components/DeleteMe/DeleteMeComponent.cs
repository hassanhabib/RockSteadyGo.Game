using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMeComponent : MonoBehaviour
{
    [SerializeField]
    private PlayerBaseComponent playerBase;

    private void Start()
    {
        playerBase.PlayerName = "Hassan";
    }
}