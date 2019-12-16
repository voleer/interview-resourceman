using System;
using System.Collections.Generic;
using System.Text;

using ContainerId = System.Guid;

using InstanceId = System.Guid;

namespace ResourceManager
{
    /// <summary>
    /// The resource manager should create the minimal number of instances when placing multiple containers.
    /// For example of the instance size is 60 GB and the container size is 6 GB, placing up to 10 containers
    /// should only result in a single new instance.
    ///
    /// The resource manager should NOT make any instance requests when there is enough space on an existing
    /// instance or a pending instance (i.e. an instance that has been requested but has not yet been returned
    /// by the cloud provider). For example, if all instances are full and a user requests another container,
    /// the resource manager should request a new instance on which to place that container. If, while waiting
    /// for that new instance to become available, the resource manager receives another request to place a
    /// container, it should not request another instance, since it will eventually be able to place the container
    /// on the pending instance.
    /// </summary>
    public class ResourceManager
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ResourceManager"/>.
        /// </summary>
        /// <param name="provider">The cloud provider that we request instances from.</param>
        /// <param name="instanceSizeGB">The size of an instance that is provided by the cloud provider.</param>
        /// <param name="containerSizeGB">The size of a container we want to place on instances.</param>
        public ResourceManager(ICloudProvider provider, double instanceSizeGB, double containerSizeGB)
        {
            // ADD YOUR CODE HERE.
        }

        /// <summary>
        /// Places numContainers containers onto instances. If there are not enough resources with the
        /// instances we currently have, request from the cloud provider for more instances. This method
        /// should only return once all containers have been successfully placed. This method is thread-safe.
        /// </summary>
        /// <param name="numContainers">The number of containers to place.</param>
        /// <returns>The list of placed containers' ids.</returns>
        public List<ContainerId> PlaceContainers(int numContainers)
        {
            // ADD YOUR CODE HERE.
        }

        /// <summary>
        /// Gets the id of the instance where the input container is placed on.
        /// This method is thread-safe.
        /// </summary>
        /// <param name="containerId">The container id.</param>
        /// <returns>The id of the instance where container resides.</returns>
        public InstanceId GetInstanceId(ContainerId containerId)
        {
            // ADD YOUR CODE HERE.
        }

        /// <summary>
        /// Unplaces a container from its host instance. This method is thread-safe.
        /// </summary>
        /// <param name="containerId">The container id.</param>
        /// <returns>The id of the instance where the container resided.</returns>
        public InstanceId UnplaceContainer(ContainerId containerId)
        {
            // ADD YOUR CODE HERE.
        }
    }
}
