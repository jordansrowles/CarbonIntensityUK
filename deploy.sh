#!/bin/bash

LATEST=$(find . | sort -dr | grep nupkg | head -1)

dotnet nuget push $LATEST --api-key ${TOKEN_NUGET}










