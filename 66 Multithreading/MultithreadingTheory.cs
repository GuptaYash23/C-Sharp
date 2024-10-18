/* MultiThreading in C#

-> Multitasking

Multitasking refers to the capability of an operating system (OS) to run multiple tasks (processes) concurrently. In modern computing, multitasking is a core concept that allows better utilization of CPU resources and ensures that system performance remains optimal even when multiple programs are running.

-> Key Components of Multitasking:

1. Operating System (OS):

The Operating System is responsible for managing multitasking by scheduling processes and threads, allocating resources, and ensuring that tasks don’t interfere with each other. It uses scheduling algorithms to determine the order in which tasks are executed.

-> Types of multitasking:

(i) Preemptive Multitasking: The OS can interrupt a running task to start another higher-priority task (common in modern OSes like Windows, Linux, etc.).

(ii) Cooperative Multitasking: Tasks voluntarily give up control to allow other tasks to run (older systems like early versions of Windows and macOS).

2. Process:

A process is an instance of a program that is running in the OS. Each process operates in its own memory space, isolated from other processes to prevent interference.

A process can contain one or more threads.

The OS schedules processes using techniques like time slicing (giving each process a small amount of CPU time) or priority-based scheduling.

Key attributes of a process:

Process ID (PID): A unique identifier for each process.

Memory Space: Each process has its own address space in memory.

Resources: Processes can have their own file handles, network connections, etc.

3. Thread:

A thread is the smallest unit of execution within a process. A process can have multiple threads (multithreading), which share the same memory and resources but can run independently.

Multithreading allows a single process to perform multiple tasks simultaneously or in parallel, improving efficiency and responsiveness.

Each thread within a process shares:

(i) Memory: Threads within the same process share the process's address space.

(ii) Resources: Threads have access to the same file handles, network connections, etc., as other threads in the same process.

-> Multitasking Breakdown:

Single Tasking: Only one process is running at a time (old systems like MS-DOS).

Multitasking: Multiple processes are run concurrently by the OS, giving the illusion that they run simultaneously (even on single-core processors, processes switch so fast that it appears simultaneous).

Multithreading: Within a single process, multiple threads can be executed concurrently, sharing the process’s resources but working independently.

-> Example in Everyday Use:

Multitasking: You have a web browser open, a music player running, and a document editor open at the same time. The OS ensures that all of these applications (processes) receive enough CPU time to perform their tasks.

Multithreading: In the web browser, you might have multiple tabs open, each running as a separate thread or process. While one tab is loading, you can still interact with other tabs without delay.

-> Summary:

Multitasking (OS): The ability of the OS to run multiple processes concurrently.

Process: A running instance of a program with its own memory and resources.

Thread: A smaller unit of execution within a process, allowing concurrent execution of tasks within the same process.

-----------------------------------------------------------

In multitasking every application has a single thread by default to execute a program and that single thread is known as MAIN THREAD.

Every application follows a single threaded model.

To use threading we use System.Threading namespace

-> Example - Using System.Threading Namespace

Code:

-----------------------------------------------------------
---------------------
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_Intro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Stores the Current Thread(Main Thread in variable t)
            Thread t = Thread.CurrentThread;

            // Giving a name to thread T
            t.Name = "Main Thread";

            Console.WriteLine($"Current Executing Thread is: " + Thread.CurrentThread.Name);
            
        }
    }
}
-----------------------------------------------------------
---------------------

Output:

-----------------------------------------------------------
---------------------
Current Executing Thread is Main Thread
-----------------------------------------------------------
---------------------

Expanation:

Threading: The program accesses the main thread using Thread.CurrentThread, which gives a handle to the thread in which the code is running (the main thread).

Thread Name: The Name property of the thread is set to "Main Thread", which helps identify the thread, especially when debugging or working with multiple threads.

-> Example: Single Threading in C#

Code:

-----------------------------------------------------------
---------------------
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SingleThreading_Demo
{
    public class Program
    {
        public static void func1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Func1: {i}");
            }
        }

        public static void func2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Func2: {i}");
                if(i == 2)
                {
                Console.WriteLine($"Sending Thread of Func2 to sleep for 4 seconds");
                
                // Sending the thread to sleep for 4 seconds
                  Thread.Sleep(4000);
                }
            }
        }

        public static void func3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Func3: {i}");
            }
        }

        public static void Main(string[] args)
        {
            // Using Program class to call static functions

            Program.func1();
            Program.func2();
            Program.func3();
        }
    }
}
-----------------------------------------------------------
---------------------

Output:

-----------------------------------------------------------
---------------------
Func1: 1
Func1: 2
Func1: 3
Func1: 4
Func1: 5
Func2: 1
Func2: 2
Sending Thread of Func2 to sleep for 4 seconds 
Func2: 3 // (After delay of 4 seconds)
Func2: 4
Func2: 5
Func3: 1
Func3: 2
Func3: 3
Func3: 4
Func3: 5
-----------------------------------------------------------
---------------------

Explanation:

Thread.Sleep: The Thread.Sleep(4000) causes the main thread to pause for 4 seconds during func2, delaying the rest of its execution.

Sequential Execution: Although the program involves multiple functions, they are executed sequentially in a single thread, one after the other. Therefore execution of func3 stops when main thread is paused for 4 seconds during func2 execution.

----------------------------------------------------------------

Multithreading

Threads are executed by the operating system using time-sharing.

Threads are executed simultaneously

In above code we can use multiple threads so that in case a single thread if blocked won't stop the execution of the program as another thread will run

Thread 1 -> Func1()
Thread 2 -> Func2()
Thread 3 -> Func3()

Using time-sharing, the operating system allocates a limited amount of time (random time decided by OS) to each thread for execution before transitioning to the next thread giving equal priority to all the threads. This process occurs regardless of whether the current thread has completed its execution.

Example - Multithreading in C# 

Code :

-----------------------------------------------------------
---------------------
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading_Demo
{
    public class Program
    {
        public static void func1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Func1: {i}");
            }
        }

        public static void func2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Func2: {i}");
                if(i == 2)
                {
                Console.WriteLine($"Sending Thread of Func2 to sleep for 4 seconds");
                
                // Sending the thread to sleep for 4 seconds
                  Thread.Sleep(4000);
                }
            }
        }

        public static void func3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Func3: {i}");
            }
        }

        public static void Main(string[] args)
        {
            // Creating multiple threads and passing reference to the different functions

            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);

            // Starting various threads

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
-----------------------------------------------------------
---------------------

Output:

-----------------------------------------------------------
---------------------
Func2: 1
Func2: 2
Sending Thread of Func2 to sleep for 4 seconds
Func1: 1
Func1: 2
Func1: 3
Func1: 4
Func1: 5
Func3: 1
Func3: 2
Func3: 3
Func3: 4
Func3: 5
Func2: 3
Func2: 4
Func2: 5
-----------------------------------------------------------
---------------------

Explanation:

(i) Concurrency: The program uses multiple threads, meaning each method (func1, func2, func3) runs concurrently. The output of these methods can interleave depending on how the operating system schedules the threads.

(ii) Thread.Sleep: The Thread.Sleep(4000) in func2 pauses execution of func2's thread for 4 seconds but does not affect the other threads (t1 and t3). This demonstrates how individual threads can be controlled independently.

(iii) Unpredictable Output Order: Since all threads are running concurrently, the exact order of the output will be different on each execution, depending on how the threads are scheduled by the OS.

(iv) No Thread Joining: After starting the threads, the main thread does not Join the threads, which means the main thread might finish before the spawned threads complete execution. However, since there's no work in Main after starting the threads, all threads will likely finish before the main thread exits.

-----------------------------------------------------------

-> Threading

Threads are lightweight processes.

A thread is defined as the execution path of a program.

Each thread defines a unique flow of control.

If your application involves complicated and time consuming operations, then it is often helpful to set different execution paths or threads, with each thread performing a particular job.

In C#, the System.Threading.Thread class is used for working with threads.

It allows creating and accessing individual threads in a multithreaded application.

The first thread to be executed in a process is called the main thread.

When a C# program starts execution, the main thread is automatically created.

The threads created using the Thread class are called the child threads of the main thread.

You can access a thread using the CurrentThread properties of the Thread class.

The following are the most commonly used static members of the System.Thread class:

(i) CurrentThread(): Gives a reference to the currently executing thread

(ii) Thread.Sleep(): Causes the currently executing thread to pause temporarily for the specified amount of time

-> Multi-Threading

Multithreading is a feature provided by the operating system that enables your application to have more than one execution path at the same time.

Technically, multithreaded programming requires a multitasking operating system.

Multithreading in c# is a process in which multiple threads work simultaneously

It is a process to achiever multitasking.

It saves times because multiple tasks are being executed at at time.

To create multithreaded application in C#, we need to use System System.Threading namespace.

*/