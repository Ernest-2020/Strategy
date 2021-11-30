using UnityEngine;

public sealed class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelectable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Transform PivotPoint => _pivotPoint;
    public Sprite Icon => _icon;

    [SerializeField] private Transform _unitsParent;

    [SerializeField] private float _maxHealth = 1000;
    [SerializeField] private Sprite _icon;
    [SerializeField] private Transform _pivotPoint;

    private float _health = 1000;

    public override void ExecuteSpecificCommand(IProduceUnitCommand command)
        => Instantiate(command.UnitPrefab,
            new Vector3(Random.Range(-15, 13.7f), 5.255707f, Random.Range(-28, -9.5f)),
            Quaternion.identity,
            _unitsParent);
}