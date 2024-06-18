using Oakton.Resources;
using Wolverine.Configuration;
using Wolverine.Runtime;
using Wolverine.Transports;

namespace Wolverine.Http.Transport;


/*
 * Notes
 * Will want a sub class of MessageRoute, or some marker on Endpoint that "tells" you that it can do request reply for you
 *
 *
 *
 * 
 */

public class TransportTypes
{
    
}

internal class HttpTransport : ITransport
{
    public string Protocol { get; set; }
    public string Name { get; set; }
    public Endpoint? ReplyEndpoint()
    {
        throw new NotImplementedException();
    }

    public Endpoint GetOrCreateEndpoint(Uri uri)
    {
        throw new NotImplementedException();
    }

    public Endpoint? TryGetEndpoint(Uri uri)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Endpoint> Endpoints()
    {
        throw new NotImplementedException();
    }

    public async ValueTask InitializeAsync(IWolverineRuntime runtime)
    {
        //var environment = runtime.
    }

    public bool TryBuildStatefulResource(IWolverineRuntime runtime, out IStatefulResource? resource)
    {
        throw new NotImplementedException();
    }
}

public static class HttpTransportExtensions
{
    public static void AddHttpTransport(this WolverineOptions options)
    {
        
    }
}