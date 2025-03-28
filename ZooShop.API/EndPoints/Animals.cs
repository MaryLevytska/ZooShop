using ZooShop.Application.Services;

namespace ZooShop.API.EndPoints
{
    public static class AnimalsEndPoints
    {
        public static void MapAnimalsEndPoints(this IEndpointRouteBuilder routeBuilder)
        {

            routeBuilder.MapGet("animals", (AnimalService animalService) => { return animalService.GetAll(); });

            routeBuilder.MapGet("animals/{id}", (Guid id, AnimalService animalService) => { return animalService.Get(id); });

        }
    }
}
