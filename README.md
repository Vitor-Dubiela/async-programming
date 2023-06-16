# Why I Created This Repository?
The will to create this repository came from a job's project that I was working on. The problem that I faced on required reducing the time spent to run the queries that we were sending to Sql Server.

## But What Project Was That? :thinking::thinking:
* .NET Framework Project.
* Domain-Driven Design (DDD).
* Sql Server.

The Domain manages users and vacancies infos, allowing users to apply for jobs and the Employers to read the resumé of their candidates.


# What Created This Problem? :scream:
We had to SELECT a huge amount of data from different tables, although we were using async programming on the queries, we were awaiting the query to finish for the code to keep running, so it was blocking the execution of the code.

# How To Solve It? :monocle_face:
Since we had a problem with asynchronous programming, I decided that it would be a good idea to review what I studied from asynchronous programming, so I hope this repository works for me - and you - as a studying object.


