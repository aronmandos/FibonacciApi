project FibonacciApi

Goal:
The project is meant as an implementation of a coding assesment with the following goals:
- Create an API in C#.
- This API needs to be a REST API or a GRPC API.
- This API needs to include at least an endpoint that can be called with a number that returns whether that number is part of the fibonacci sequence.
- An optional goal is to add a way to the API to return whether that number is a prime number.


initial setup plan:
1 create this simple documentation file
2 add solution to git
3 add projects to solution that form the base architecture, parts i imagine needing are listed below.
4 setup a initial REST over http API with 1 endpoint to get the project running and testable
5 extend API to cover the goals 


parts this simple API projects needs:
- A API layer
- A business logic layer
- A data models project (removed after implementation, not needed)
- A unittest project


notes:
- decided for a REST API as i know how to quickly set that up
- no DB needed to meet goals
- more research into fibonacci and prime numbers needed for better performance

growth goals for this project:
- caching could be used for performance
- more extensive exception handling
- more testing, currently using only a couple untitests
