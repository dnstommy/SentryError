using System;
using Sentry;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SentrySdk.Init(o =>
            {
                // Tells which project in Sentry to send events to:
                o.Dsn = "https://6650da350516457ba17840fb4cf8c641@o92137.ingest.sentry.io/6208998";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
            }))
            {
                throw new Exception("Console App");
            }

        }
    }
}
