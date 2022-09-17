using System;

namespace UnderstandingTransientAndScopedAndSingleton.Services
{
    public interface ISingletonService {    
        Guid GetOperationID();
}
}
