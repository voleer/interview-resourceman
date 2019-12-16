# Resource Management

The goal of this challenge is to implement a resource manager. The resource manager should take in
three parameters: the cloud provider, the memory size in GB of the instances that the cloud provider
provides, and the memory size in GB of the containers you want to place on the instances. It should
then respond to requests for new containers by managing a pool of available instances, tracking the
containers that have already been placed on them, and requesting new instances as necessary. Your
teammate has already implemented an interface for placing and unplacing containers on a single
instance.

## Instructions

1. Generate a new **private** repo using this template repo.
2. Provide your answers to your generated repo.
3. Once your repo is ready for review, add `voleer-dev` as a collaborator for your repo.
4. Wait for our response.

## Requirements

1. The resource manager should create the _minimal_ number of instances when placing multiple
   containers. For example, if the instance size is 60 GB and the container size is 6 GB, placing up
   to 10 containers should only result in a single new instance.

- The resource manager should NOT make any instance requests when there is enough space on an
  existing instance _or a pending instance (i.e., an instance that has been requested but has not
  yet been returned by the cloud provider)_. For example, if all instances are full and a user
  requests another container, the resource manager should request a new instance on which to
  place that container. If, while waiting for that new instance to become available, the resource
  manager receives another request to place a container, it should **not** request another
  instance, since it will eventually be able to place the container on the pending instance.

2. `PlaceContainers` should return within _constant time_ with respect to the _number of containers_
   requested by the call, the _number of new instances_ required to fullfil the call, and the _number of
   concurrent_ `PlaceContainers` _calls_. This constant time should be dominated by the time for the
   Cloud Provider to create one instance. You may assume that the Cloud Provider is scalable, i.e.
   the time for the Cloud Provider to create one instance is the same as the time to create multiple
   instances.
3. Your code should have good readability and modularity. It should be easy to understand what your
   code is doing and why.
4. Your implementation can be in any language. This skeleton is however, in C#.
5. We should be able to run your submission and verify that it works.

## Assumptions

1. There will be no failures when making requests to the cloud provider for instances.
2. The cloud provider creates instances in parallel, i.e., the time for the cloud provider to create
   one instance is the same as the time to create 10 instances.
3. The resource manager’s state (i.e., the instances and the containers objects) can fit in memory.
4. You will never have to handle more than 100 simultaneous requests across all of the resource
   manager’s methods.
5. You may assume that there will only be a single instance of the resource manager running at any
   given time.
6. The resource manager can hold onto instances from the cloud provider even after it has unplaced
   all containers from those instances.
7. Don’t worry about crash/recovery - you can assume that the every instance of CloudProvider
   starts with an empty state.
