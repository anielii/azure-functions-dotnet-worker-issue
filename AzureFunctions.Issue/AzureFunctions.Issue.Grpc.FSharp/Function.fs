module Function

open Microsoft.Azure.Functions.Worker
open System.Collections.Generic
open System

[<Function("Func")>]
let run
    (
        [<TimerTrigger("0 0 0 * * *", RunOnStartup = true)>]
            timer: TimerInfo,
        [<CosmosDBInput(
            "%CosmosDbDatabase%",
            "%CosmosDbContainer%",
            Connection = "CosmosDbConnectionString",
            SqlQuery = "SELECT 1 FROM c")>]
            obj: IEnumerable<Object>,
        context: FunctionContext

    ) =
    printf "%s" (obj.ToString())