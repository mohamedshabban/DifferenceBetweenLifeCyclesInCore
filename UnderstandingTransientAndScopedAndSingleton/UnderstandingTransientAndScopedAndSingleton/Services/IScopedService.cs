using System;

namespace UnderstandingTransientAndScopedAndSingleton.Services
{
    public interface IScopedService {  
        Guid GetOperationID();
}
}
