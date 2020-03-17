COMP4870 ASSIGNMENT 2
---------------------
Authors:
Reneil Pascua   A01047816   reneilpascuatm@gmail.com
John Ham        A01041999   jham5@gmail.com

We believe we've completed 100% of the requirements for this assignment.


MAJOR CHALLENGES
----------------
We had a few colleagues test our docker-compose up. On both MacOS and Windows, for some people it worked perfectly, for some it did not (with various types of errors).
With that being said, if there is a build error, please contact us via email.


TESTING INSTRUCTIONS
--------------------
0) ensure no other containers / applications are using ports 8888, 6000, 6001, 1444
1) unzip the submission
2) in the root folder of the assignment, enter command "docker-compose up"
3) wait
3.5) in another command line window, use "docker ps" to see if all 3 services are running (api, db, client)
3.75) likely the api exited because the db took too long to start. use "docker start <api container name>" to revive it.
4) on a browser, enter localhost:8888 to be taken to the application
5) click View All Speakers to see the speakers and CRUD buttons
6) experiment with CRUD operations with the intuitive UI
7) check validation for each field, specifically the email address and phone number

Again, if there are any unresolved issues, please reach out to the authors.

