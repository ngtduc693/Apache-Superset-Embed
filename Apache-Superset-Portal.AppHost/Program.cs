var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Apache_Superset_Portal_ApiService>("apiservice");

builder.AddProject<Projects.Apache_Superset_Portal_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
