# Why I Created This Repository? :thinking::thinking:
The will to create this repository came from a job's project that I was working on. The problem I faced required using non-blocking code to run the Sql queries, because there was a part of the code, where it had to select a huge amount of data, that was taking longer to run the queries than it could. So, I'm using this repository to review the I/O-bound code from C#'s asynchronous programming model.

## But what kind of Project was that? 
The domain manages users and vacancies infos, allowing users to apply for jobs and the Employers to read the resumé of their candidates.


# What Created This Problem? :scream:
The business logic used to get the candidate's infos was blocking the code. Although the SELECT method was async, it was awaiting the query to finish, and as it was a lot of data to select, the application was taking longer to move to the next task thank it should.

# How To Solve It? :monocle_face:
To enhance the overall responsivennes of the application, avoiding performance bottlenecks, I used the C#'s Task Asynchronous Programming (TAP) Model, which provides a simplified approach for async programming. This approach retains a logical structure that resembles synchronous code.
<br>
<br>
Just like when you are cooking, there're some steps that you can do while other one is happening, like boiling the water and preparing the sauce for the pasta. You can start boiling the water and go prepare the sauce while it's boiling. When you're programming, there're some activities that you don't need to wait untill it finishes, too. To ilustrate how this non-blocking process can be done, the process to make coffee was used as an example. By running the application, you'll be able to see the difference between a blocking and a non-blocking code, observing the time spent and thread used to run it.
