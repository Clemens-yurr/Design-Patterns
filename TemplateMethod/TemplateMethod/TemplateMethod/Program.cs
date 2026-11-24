namespace TemplateMethod;

class Program
{
    // Dauert a bissl
    static void Main(string[] args)
    {
        Console.WriteLine("=== Car Router ===\n");
        TryRouter(new CarRouter());
        Console.WriteLine("\n\n=== Pedestrian Router (Exception ist absichtlich) ===\n");
        TryRouter(new PedestrianRouter());
    }

    static void TryRouter(MapRouter router) {
        try {
            router.Route(
                47.32084083407117f,
                12.796368223478648f,
                47.3576522222231f,
                13.206415271277725f
            );
        } catch (Exception e) {
            Console.WriteLine($"An exception of type {e.GetType().Name} was thrown: {e.Message}");
        }
    }
}
