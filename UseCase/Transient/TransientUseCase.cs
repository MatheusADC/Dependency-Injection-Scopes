namespace DependencyInjectionTest.UseCase.Transient;

public class TransientUseCase
{
    public Guid Id { get; set; }

    public TransientUseCase()
    {
        Id = Guid.NewGuid();
    }

    public string Execute()
    {
        return $"From Transient with Id: {Id}";
    }
}
