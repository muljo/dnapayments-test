Summary

Welcome to my submission for the DNA Payments Software Engineer role.

This project is a REST API that allows a client to manage bank accounts.
The user can create, retrieve, freeze and unfreeze accounts.

The bank account supports an account type of Current, and Savings.

The account type is represented as an Enum:
Current = 1,
Savings = 2

Installation

To run the project, you need .NET 9 installed.
https://dotnet.microsoft.com/en-us/download/dotnet/9.0

Running the project via an IDE

I developed and tested the project on Linux in JetBrains Rider.
You can also try using Visual Studio

To open the project in an IDE, open the DNA_Payments.sln file
You can then run the DNA_Payments.csproj project

Running the project via command line

Run the following command
dotnet DNA_Payments/DNA_Payments.csproj

API

The API has four endpoints

You can use a API client like Postman or Yaak to test the API. 
You specify the params for the API using the params tab in your API client.

GET /bankaccount

Retrieves a bank account from the system
Takes an account number as parameter

If no bank account is found, then it will return null

POST /bankaccount

Takes a name as a parameter
Takes an account type as parameter
For a current account, specify the bankAccountType parameter as the number below
    Current = 1
    Savings = 2

Creates (and retrieves) a new bank account

PUT /bankaccount/freeze

Freezes a bank account

Takes an account number as parameter
Will throw an exception for a bank account that doesn't exist

PUT /bankaccount/unfreeze

Unfreezes a bank account
Will throw an exception for a bank account that doesn't exist

Takes an account number as parameter
