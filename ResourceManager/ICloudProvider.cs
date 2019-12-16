using System.Collections.Generic;

namespace ResourceManager
{
    /// <summary>
    /// Represents the contract for a cloud provider to create a VM instance.
    /// </summary>
    public interface ICloudProvider
    {
        /// <summary>
        /// Synchronously requests a new instance. The size of the instance will depend on the classes
        /// that implement this interface. Note that this call may be blocked for a long period of time
        /// before it is fulfilled (i.e. a few minutes). The implentation of this method must be thread-safe.
        /// </summary>
        /// <returns>The requested <see cref="Instance"/>.</returns>
        Instance RequestInstance();

        /// <summary>
        /// The implementation of this method must be thread-safe.
        /// </summary>
        /// <returns>The set of all existing <see cref="Instance"/>.</returns>
        ISet<Instance> GetAllInstances();
    }
}
