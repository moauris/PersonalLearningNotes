# Introduction

This chapter deals with naturally asynchronous operations, such as

<span style="border-radius:5px;background:blue;color:white;padding:0px 5px">HTTP Requests</span>

<span style="border-radius:5px;background:blue;color:white;padding:0px 5px">Database Commands</span>

<span style="border-radius:5px;background:blue;color:white;padding:0px 5px">Web Service Calls</span>

# Pausing for a Period of Time

## Simple Implementation

Use the `Task.Delay()` static method. Takes timespan as its argument.

## Cancellation Token

Task Delay can also be used as a way to timeout a long running task.

```C#
public static Task Delay(TimeSpan delay, CancellationToken cancellationToken);
```

Build a Task type using this, when `CancellationToken` specify a `TimeSpan`. This object sends a Cancellation notification once that time is reached.

Build this delay with infinite time span, but with a timed cancellation token.

Await any this delay with the target task. Judge if the completed task is the timeout task, if true, return null, if false, return await target task.

### Limitations on using delay as cancellation token

Many async operations takes cancellation token as their native timeout timer. There is no need in many cases to use delay as a media.

# Returning Completed Tasks

Asynchronous programming as a "cap" that we can put around the normal classes.

How to use the `Task.FromResult()` and `Task.CompletedTask`

# Report Progress

Report Progress is a theme that I have explored many times. 

Here is another way to report progress in Asynchronous methods:

First, we need to implement the `IProgress<T>` type. As double, or integer is fine. 

Use it as an argument which is initialized as null by default to that method, within that method, when needed, report the progress using 

```c#
progress?.Report(percentComplete)
```

In the caller method, instantiate a new `Progress<T>` type, bind event to progress `ProgressChanged` event handler some sort of reporting actions, and await the async method using that instance.

# Wait for a set of Tasks to complete

Fire a collection of tasks using `Task.WaitAll(Task[])`. It simply blocks the main thread until all tasks are completed.

If the task returns uniformly a specific type, their results can be captured using an array of that type

# Wait for any of a set of tasks to complete

Pretty much the same usage as the Wait All version, but need to be careful about how they wrap.

`Task.WaitAny(Task[])` returns an always successful task to the caller. Inside of that task contains the one that first ran and completed.

By default, what happens to the loser Tasks is that they will still run to completion, but results discarded.

## Validation: Run tasks with Wait Any, and see results discarded

To perform this validation, we need 3 async tasks that writes to 3 files. 

```c#
class WriteToFile
    {
        public async Task<string> WriteToFileAsync(StreamWriter writer, byte[] bytes, string name)
        {
            Console.WriteLine("Initializing Task: {0} with Delay:", name);
            Random RandDelay = new Random();

            TimeSpan Delay = TimeSpan.FromMilliseconds(RandDelay.Next(30, 200));
            Console.WriteLine(Delay.Milliseconds + "ms");
            foreach (byte b in bytes)
            {
                await writer.WriteLineAsync(b.ToString("X2"));
                await Task.Delay(Delay);
                Console.WriteLine("{0} wrote: {1}"
                    , name
                    , b.ToString("X2"));
            }
            Console.WriteLine("{0} writting task completed.", name);
            writer.Close();
            return await Task.FromResult(writer.ToString());
        }
    }
```

This class has an `Async WriteToFileAsync` method which first initialize with a random millisecond delay, and try to write a stream.

The process should create 3 files even when one got the lucky draw and returns successfully first, but since the main process terminates immediately after the Wait Any method, the other two didn't get the chance to close the writer stream.

If we wait long enough in the main, the other two actually ends ok.

# Processing tasks as they complete

There isn't much to see about this one, use them as a task array object, and for each to fire them all off.

The interesting alternative is to use LINQ on the tasks, and hook the select delegate as the method we want to process.

There is a new method mentioned here: `Task.WhenAll(Task[])`, this blocks the thread that calls it until all is completed.

# Summary

For this chapter we looked at some basics with async solutions.

This is just one of the three key technologies.

We need to remember the point of async methods.

1. Classes cannot be async, only methods can.
2. the async key word means that it contains await keyword.
3. The Task type handles async methods, it can also fire action delegates.

An important idea in async method is blocking. In a normal thread, the main thread wait for each process step to complete and then move on to the next, so, in this view, it always wait for the next step, and therefore there is no need to use await.

In an async method, we need to manually set the block mechanism so that the process wait on the steps to complete before moving on to the next one. We can fire multiple tasks together.

Another thing to remember is that the Task type is a type that relates to future.

It contains methods that hasn't yet run, running, or is completed.

