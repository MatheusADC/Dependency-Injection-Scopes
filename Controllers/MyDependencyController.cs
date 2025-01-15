using DependencyInjectionTest.UseCase.Scoped;
using DependencyInjectionTest.UseCase.Singleton;
using DependencyInjectionTest.UseCase.Transient;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionTest.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MyDependencyController : ControllerBase
{
    [HttpGet("Singleton")]
    public IActionResult Singleton([FromServices] SingletonUseCase useCase)
    {
        var result = useCase.Execute();
        return Ok(result);
    }

    [HttpGet("Transient")]
    public IActionResult Transient([FromServices] TransientUseCase useCase)
    {
        var result = useCase.Execute();
        return Ok(result);
    }

    [HttpGet("Scoped")]
    public IActionResult Scoped([FromServices] ScopedUseCase useCaseA, [FromServices] ScopedUseCase useCaseB)
    {
        var resultA = useCaseA.Execute();
        var resultB = useCaseB.Execute();

        return Ok($"{resultA} - {resultB}");
    }
}
