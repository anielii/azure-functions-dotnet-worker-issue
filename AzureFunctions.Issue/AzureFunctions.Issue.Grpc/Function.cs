

using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AzureFunctions.Issue.Grpc
{
    public class CosmosFunction
    {
        [Function(nameof(CosmosFunction))]
        public void Run(
            [TimerTrigger("0 0 0 * * *", RunOnStartup = true)] TimerInfo timerInfo,
            [CosmosDBInput(
                databaseName: "%CosmosDbDatabase%",
                containerName: "%CosmosDbContainer%",
                Connection = "CosmosDbConnectionString",
                SqlQuery = "SELECT 1 FROM c")]
                IReadOnlyList<Object> obj,
            FunctionContext context)
        {
            Console.WriteLine("abc");
        }
    }
}
