namespace DependencyInjectionTest.UseCase.Scoped;

public class ScopedUseCase
{
    public Guid Id { get; set; }

    public ScopedUseCase()
    {
        Id = Guid.NewGuid();
    }

    public string Execute()
    {
        return $"From Scoped with Id: {Id}";
    }
}
