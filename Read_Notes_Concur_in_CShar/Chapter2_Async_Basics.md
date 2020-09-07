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



