namespace DependencyInjectionTest.UseCase.Singleton;

public class SingletonUseCase
{
    public Guid Id { get; set; }

    public SingletonUseCase() 
    {
        Id = Guid.NewGuid();
    }

    public string Execute()
    {
        return $"From Singleton with Id: {Id}";
    }
}
