var builder = DistributedApplication.CreateBuilder(args);

var ollama = builder.AddOllama("ollama").WithDataVolume();

var llamaModel = ollama.AddHuggingFaceModel("llama",
    "bartowski/Llama-3.2-1B-Instruct-GGUF:IQ4_XS");


var apiService = builder.AddProject<Projects.Wio_Aspire_Chat_ApiService>("apiservice");

builder.AddProject<Projects.Wio_Aspire_Chat_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WithReference(llamaModel)
    .WaitFor(apiService);

builder.Build().Run();
