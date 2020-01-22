#!/bin/bash
dotnet refresh # update dependencies information, eg. via NuGet package manger
dotnet build # compiles the code
dotnet bin/Debug/netcoreapp3.1/GradeBook.dll # runs the binary representation assembly via dotnet runtime framework

# equivaelent operation to previous three lines is just
dotnet run