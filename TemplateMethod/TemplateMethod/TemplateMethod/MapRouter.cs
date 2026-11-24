using Itinero;

namespace TemplateMethod;

public abstract class MapRouter {
    // Das ist die Template Method
    public string Route(float lat1, float lon1, float lat2, float lon2) {
        var router = CreateRouter("./salzburg.osm.pbf");
        
        var route = CalculateRoute(router, lat1, lon1, lat2, lon2);

        ValidateRoute(route); // Wirft eine Exception wenn falsch

        Console.WriteLine(DescribeRoute(route));

        return GetGeoJson(route);
    }
    
    // Fix implementierter Schritt
    private Router CreateRouter(string filePath) {
        var routerDb = new RouterDb();

        using var stream = File.OpenRead(filePath);
        LoadData(routerDb, stream);

        return new Router(routerDb);
    }

    // Abstrakter Schritt
    protected abstract void LoadData(RouterDb routerDb, FileStream stream);

    // Abstrakter Schritt
    protected abstract Route CalculateRoute(Router router, float lat1, float lon1, float lat2, float lon2);

    // Optional implementierbarer Schritt (in diesem Fall ein Hook)
    protected virtual void ValidateRoute(Route route) { }
    
    // Abstrakter Schritt
    protected abstract string DescribeRoute(Route route);
    
    // Fix implementierter Schritt
    private string GetGeoJson(Route route) {
        return route.ToGeoJson();
    }
}