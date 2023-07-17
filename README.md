# Why I Created This Repository? :thinking::thinking:
The will to create this repository came from a job's project that I was working on. The problem I faced required using non-blocking code to run the Sql queries, which I solved using asynchronous programming, and then, I decided that it would be a good idea to review what I studied from async programming. I hope this repository works for me - and you - as a studying object.

## But what kind of Project was that? 
* .NET Framework Project.
* Domain-Driven Design (DDD).
* Sql Server.

The Domain manages users and vacancies infos, allowing users to apply for jobs and the Employers to read the resumé of their candidates.


# What Created This Problem? :scream:
The business logic used to get the candidates infos was blocking the code. Although the SELECT method was async, it was awaiting the query to finish, and as it was a lot of data to select, the code was being blocked.

# How To Solve It? :monocle_face:
To enhance the overall responsivennes of the application, avoiding performance bottlenecks, I used the C#'s Task Asynchronous Programming (TAP) Model, which provides a simplified approach for async programming. This approach retains a logical structure that resembles synchronous code.
<br>
<br>
Just like when you are cooking, there're some steps that you can do while other one is happening, like boiling the water and preparing the sauce for the pasta, you can start boiling the water and go prepare the sauce while it's boiling. When you're programming, there're some activities that you don't need to wait untill it finishes, too. To ilustrate how this non-blocking process can be done, it was used a cooking recipe as an example.
