#!/bin/bash

dotnet restore
dotnet build --no-restore
git push -u github master










