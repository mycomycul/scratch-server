## Scratch
Pregressively more complicated .NET Core Servers showing layers being added as opposed to using scaffolding to start with the layers included 
- simple: Simplest possible .NET Core Server. Returns directly from the midleware.
- useandrun:  Sample of .use pre-processing and post-processing .run for middleware
- api: Simple Mvc API Controller with minimal overhead
- master: Mvc and API endpoints in one controller and a view
    If no local files need to be compiled during runtime be sure to set the preserveCompilationContext to false to reduce response time. Stting true is necessary for returning views.
