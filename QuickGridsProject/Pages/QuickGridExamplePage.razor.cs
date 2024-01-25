using QuickGridsProject.Models;

namespace QuickGridsProject.Pages
{
    public partial class QuickGridExamplePage
    {
        const string test = "a";
        private IQueryable<Car> CreateCarList()
        {
            List<Car> myCarList = [];

            for (int i = 0; i < 10000; i++)
            {
                var car = new Car()
                {
                    Id = Guid.NewGuid(),
                    Name = $"Car {i}",
                    Cost = i * 77 + 105
                };
                myCarList.Add(car);
            }

            return myCarList.AsQueryable();
        }
    }
}