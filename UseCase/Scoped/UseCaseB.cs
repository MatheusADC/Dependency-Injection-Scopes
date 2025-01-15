namespace DependencyInjectionTest.UseCase.Scoped;

public class UseCaseB
{
    private readonly ScopedUseCase _scopedUse;

    public UseCaseB(ScopedUseCase scopedUseCase)
    {
        _scopedUse = scopedUseCase;
    }

    public string Execute()
    {
        return _scopedUse.Execute();
    }
}
