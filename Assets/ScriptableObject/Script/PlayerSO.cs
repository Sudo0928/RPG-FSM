using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Character/Player")]
public class PlayerSO : ScriptableObject
{
    [field: SerializeField] public PlayerGroundData GroundData { get; private set; }
    [field: SerializeField] public PlayerAirborneData AirboneData { get; private set; }
    [field: SerializeField] public PlayerAttackData AttackData { get; private set; }
}
