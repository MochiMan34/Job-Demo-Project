# Job-Demo-Project
A coding project from a C# programming class I had to do recently. The project had 4 parts, hence there are 4 different applications here. 

Here's what I had to code: 

1.) An application named "JobDemo" that use "Job" objects that basically hold job information for a home repair service. The Job class had to have 5 different properties which were: 
job number, customer name, job description, estimated hours, and price for job. A constructor is needed to require parameters for all except the price for a job. All properties were
to be auto-implemented for all except house or price. 

Methods such as Equals() , GetHashCode() , ToString() had to have been overridden. 
Equals() method had to determine if two given Job objects have the same job number. GetHashCode() returns the Job number. ToString() had to return a string 
containing all job information. 

2.) Create an application named "JobDemo2" that creates an array of 5 Job objects. A prompt had to made for a user to fill the objects with data. 
When all data has been entered, a total of the prices for each job must be displayed. 

3.) Create an application named "JobDemo3" that uses another class named "RushJob"; which derives from the "Job" class, and tacks on $150.00 premium to the 
normal price price of a given Job. Make sure the application doesn't allow any duplicate job numbers, and like JobDemo2, display the total price of a job. 

4.) Make an application called JobDemo4 which sorts Job objects by Job number. Make changes to the RushJob class to accomodate for this new functionality. 
