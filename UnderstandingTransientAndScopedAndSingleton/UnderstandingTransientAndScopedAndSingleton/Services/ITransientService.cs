using System;

namespace UnderstandingTransientAndScopedAndSingleton.Services
{
    public interface ITransientService {    
        Guid GetOperationID();
      }
}
