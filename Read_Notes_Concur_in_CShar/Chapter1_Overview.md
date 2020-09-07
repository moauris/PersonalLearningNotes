# Terminologies in Concurrency

It is somewhat important to understand what C# concurrency is, what it can do, and why we should learn it. From the basics such as terminology, we can see the overarching structure of concurrent programming in C#, and it's utilizations.

In the book C# in a Nutshell 7.0 the Definitive Guide, the chapter on concurrency not only introduces Thread in large length (perhaps attachment from the author for being reluctant to throw them away?), the part on the late technology Task felt ill-elaborated.

This book focuses solely on concurrency and their examples.

Of course this is not the first time I read this book, but about 2 years ago, my understand of C# is not as good as now. Let's see what I can fetch from reading this book now.

<span style="border-radius:5px;background:brown;color:white;padding:5px 10px">Concurrency</span>

Doing more than one thing at a time.

<span style="border-radius:5px;background:brown;color:white;padding:5px 10px">Multithreading</span>

A form of concurrency that uses multiple threads of execution.

In C#, Thread is old technology.

<span style="border-radius:5px;background:brown;color:white;padding:5px 10px">Parallel Processing</span>

Doing lots of work by dividing it up among multiple threads that run concurrently.

<span style="border-radius:5px;background:brown;color:white;padding:5px 10px">Asynchronous Programming</span>

A form of concurrency that uses futures or callbacks to avoid unnecessary threads. 

- <span style="border-radius:5px;background:lightgreen;color:purple;padding:0px 5px">Future</span> is a type that represents some operation that will happen in the future. The modern C# types `Task` and `Task<TResult>` are future types.

- <span style="border-radius:5px;background:lightgreen;color:purple;padding:0px 5px">Blocking</span> is the act of a busy operation in one thread that prevent the thread from doing anything else. The main thread that fires the Task, will not be blocked by the Task.

<span style="border-radius:5px;background:brown;color:white;padding:5px 10px">Reactive Programming</span>

A declarative style of programming where the application reacts to events

# Introduction to Asynchronous Programming

There are two keyword important to Asynchronous Programming in C#

<span style="border-radius:5px;background:brown;color:white;padding:5px 10px">Keyword: async</span>

The `async` keyword is added to the method declaration. It does 2 things:

1. Enables `await` to be added to the method somewhere, similar to `yield return` in iterations.
2. Return type must be a `Task`, which is like void type, and a `Task<TResult>` which is like a returning a type.
3. It also returns `IAsyncEnumerable<T>` and `IAsyncEnumerator<T>` types for returning multiple values.

# Problem: How to start an async method from Main

It is entirely possible to call tasks from a normal class. Use the `Task.WaitAll(Task[])` or `Task.WaitAny(Task[])` methods. They a collection of tasks, and wait on all of, or any of them respectively.

Or, you can start actions by using `Task.Run(Action)`, but this one takes an Action Delegate.

# Dime Tour of three technologies

There are three technologies introduced:

1. Asynchronous Programming, the use of async and await keyword.
2. Parallel Programming, for data and tasks.
3. Reactive Programming, where events are treated like streams.