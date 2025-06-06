using System;
using UnityEngine;

[Serializable]
public class PlayerAirborneData
{
    [field: Header("JumpData")]
    [field: SerializeField][field: Range(0f, 25f)] public float JumpForce { get; private set; } = 5f;
}
