using System;
using Zenject;

public class PatrolCommandCommandCreator : CommandCreatorBase<IPatrolCommand>
{
    [Inject] AssetsContext _context;
    protected override void classSpecificCommandCreation(Action<IPatrolCommand> creationCallback)
    {
        creationCallback?.Invoke(_context.Inject(new PatrolCommand()));
    }
}
