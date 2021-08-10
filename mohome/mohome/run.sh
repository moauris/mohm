#!/bin/bash
dotnet run &
/dev/null 2>&1 &
disown %1
