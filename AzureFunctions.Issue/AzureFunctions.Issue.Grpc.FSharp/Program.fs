module Program

open Microsoft.Extensions.Hosting

[<EntryPoint>]
let main _ =
    let host = HostBuilder().ConfigureFunctionsWorkerDefaults().Build()
    host.Run()
    0