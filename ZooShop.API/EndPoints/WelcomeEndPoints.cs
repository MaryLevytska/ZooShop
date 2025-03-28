using Microsoft.AspNetCore.Mvc;

namespace ZooShop.API.EndPoints
{
    public static class WelcomeEndPoints
    {
        public static void Welcome(this IEndpointRouteBuilder routeBuilder)
        {
            routeBuilder.MapGet("welcome", () => { return "Welcome"; });

            routeBuilder.MapGet("welcome/{name}", (string name) => { return $"Welcome {name}"; });

            routeBuilder.MapGet("hi", ([FromQuery]string name, [FromQuery]int age) => { return $"hi my name is {name}.I am {age}"; });
        }
    }
}
