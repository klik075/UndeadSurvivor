using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public static float Speed
    {
        get { return GameManager.Instance.playerId == 0 ? 1.1f : 1f; }
    }
    public static float weaponSpeed
    {
        get { return GameManager.Instance.playerId == 0 ? 1f : 1.1f; }
    }
}
