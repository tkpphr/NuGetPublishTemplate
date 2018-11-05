# NuGet Publish Template

## Overview
Template for publishing NuGet package.

## Installation
1. Open PackageManager then open settings.
2. Add a new package source.
3. Enter Name:"TestFeed" Source:"https://www.myget.org/F/tkpphr-test-feed/".
4. Close settings then select package-source:"TestFeed"
5. Select "NuGetPublishTemplate" then install it.

## Usage
```CSharp
using NuGetPublishTemplate;

new Greeter("foo").Hello();
```

## License
Released under the Apache 2.0 License.
See LICENSE File.