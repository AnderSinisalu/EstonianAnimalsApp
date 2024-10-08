using EstonianAnimalsApp.Models;

namespace EstonianAnimalsApp.Services
{
    internal class AnimalsService
    {
        private static List<Animal> animals = new()
        {
            new()
            {
                Name = "Barn Swallow",
                Subtitle = "National bird",
                HeroImage = "barnswallow.png",
                Description = "The barn swallow (Hirundo rustica) is the most widespread species of swallow in the world, occurring on all continents, with vagrants reported even in Antarctica. It appears to have the largest natural distribution of any of the world's passerines, ranging over 251 million square kilometres globally. ",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/3/33/%D0%94%D0%B5%D1%80%D0%B5%D0%B2%D0%B5%D0%BD%D1%81%D0%BA%D0%B0%D1%8F_%D0%BB%D0%B0%D1%81%D1%82%D0%BE%D1%87%D0%BA%D0%B0_%28Hirundo_rustica%29%2C_%D0%9C%D0%B5%D0%BB%D0%B8%D1%85%D0%BE%D0%B2%D0%BE.jpg"
                }
            },
        };

        public static List<Animal> GetFeaturedAnimals()
        {
            var random = new Random();
            var randomizeAnimals = animals
                .OrderBy(item => random.Next());

            return randomizeAnimals
                .Take(2)
                .ToList();
        }

        public static List<Animal> GetAllAnimals()
            => animals;
    }
}