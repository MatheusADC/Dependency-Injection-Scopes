namespace DependencyInjectionTest.UseCase.Scoped;

public class UseCaseA
{
    private readonly ScopedUseCase _scopedUse;

    public UseCaseA(ScopedUseCase scopedUseCase)
    {
        _scopedUse = scopedUseCase;
    }

    public string Execute()
    {
        return _scopedUse.Execute();
    }
}
