using Assets.Views.Bases;
using UnityEngine;

public class DeleteMeComponent : MonoBehaviour
{
    [SerializeField]
    private PlayerBaseComponent playerBase;

    [SerializeField]
    private TurnBaseComponent turnBase;

    private void Start()
    {
        playerBase.PlayerName = "Hassan";
        turnBase.On();
    }
}