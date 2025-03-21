using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerAttackData
{
    [field: SerializeField] public List<AttackInfoData> AttackInfoDatas { get; private set; }
    public int GetAttackInfoCount() => AttackInfoDatas.Count;
    public AttackInfoData GetAttackInfo(int index) => AttackInfoDatas[index];
}
