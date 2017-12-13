using System;

public static void Run(TimerInfo myTimer, ICollector<string> outputQueueItem, TraceWriter log)
{
    // Call CalledFunction by using queue
    outputQueueItem.Add("queue-string");
}
