using Itinero;
using Itinero.IO.Osm;
using Vehicle = Itinero.Osm.Vehicles.Vehicle;

namespace TemplateMethod;

public class CarRouter : MapRouter {
    protected override void LoadData(RouterDb routerDb, FileStream stream) {
        routerDb.LoadOsmData(stream, Vehicle.Car);
    }

    protected override Route CalculateRoute(Router router, float lat1, float lon1, float lat2, float lon2) {
        var start = router.Resolve(Vehicle.Car.Fastest(), lat1, lon1);
        var end = router.Resolve(Vehicle.Car.Fastest(), lat2, lon2);
        
        return router.Calculate(Vehicle.Car.Fastest(), start, end);
    }

    protected override string DescribeRoute(Route route) {
        var start = route.Stops.First().Coordinate;
        var end = route.Stops.Last().Coordinate;
        
        return $"Start:\nLat {start.Latitude:F5}\nLon {start.Longitude:F5}\n\n" +
               $"End:\nLat {end.Latitude:F5}\nLon {end.Longitude:F5}\n\n" +
               $"{(route.TotalDistance / 1000):F2}km, {(int) (route.TotalTime / 60)} minutes";
    }
}