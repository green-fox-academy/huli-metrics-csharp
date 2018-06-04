# huli-metrics-csharp

A C# library for posting json with respective data.

You can choose to install the package via the built-in NuGet Pacakage Manager, to do so enter:
```
Install-Package HuliMetrics -Version 1.0.0
```
or alternatively you can install it using the .NET cli, to do so open your console and enter:
```
dotnet add package HuliMetrics --version 1.0.0
```

After installation you can refer to the package like so:
```
using HuliMetrics;

```

After referring to the package you can instanciate the class:
```
MetricsPoster poster = new MetricsPoster();

```

Now you can call the function:
```
poster.SendJson("serviceName", "level");

```

This will post a json to Huli's server, and place it carefully in a log file so that the DevOps team can collect valuable intel on the project.



