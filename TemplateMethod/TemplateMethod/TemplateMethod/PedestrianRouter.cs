using Itinero;
using Itinero.IO.Osm;
using Vehicle = Itinero.Osm.Vehicles.Vehicle;

namespace TemplateMethod;

public class PedestrianRouter : MapRouter {
    protected override void LoadData(RouterDb routerDb, FileStream stream) {
        routerDb.LoadOsmData(stream, Vehicle.Pedestrian);
    }

    protected override Route CalculateRoute(Router router, float lat1, float lon1, float lat2, float lon2) {
        var start = router.Resolve(Vehicle.Pedestrian.Shortest(), lat1, lon1);
        var end = router.Resolve(Vehicle.Pedestrian.Shortest(), lat2, lon2);

        return router.Calculate(Vehicle.Pedestrian.Shortest(), start, end);
    }

    protected override void ValidateRoute(Route route) {
        if (route.TotalDistance > 15000)
            throw new InvalidOperationException($"Calculated route is too long at {route.TotalDistance}m.");
    }
    
    protected override string DescribeRoute(Route route) {
        var start = route.Stops.First().Coordinate;
        var end = route.Stops.Last().Coordinate;
        
        return $"Start:\nLat {start.Latitude:F5}\nLon {start.Longitude:F5}\n\n" +
               $"End:\nLat {end.Latitude:F5}\nLon {end.Longitude:F5}\n\n" +
               $"{(int) route.TotalDistance}m, {((route.TotalDistance / 5000) * 60):F1} minutes";
    }
}