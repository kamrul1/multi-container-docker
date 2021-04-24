

## Multiple Docker Container Creation in Visual Studio

Full Tutorial at site: [Tutorial: Create a multi-container app with Docker Compose](https://docs.microsoft.com/en-us/visualstudio/containers/tutorial-multicontainer?view=vs-2019)

I also found this Youtube tutorial really useful:
>[Using Docker Compose to run multicontainer dotnet applications](https://youtu.be/4GzIE5KbCOw)

Although the demo in video didn't really work.

---
This has been a useful learning exercise, as it shows how multiple containers can be used in developing in visual studio.  I have used docker-compose.yml in other projects without really going to basic to see how it should be created.  <br/><br/>
This is especially useful services need to run on their own environment and not on the shared host machine e.g. RabbitMQ/Event Bus.  It allows images to be pulled down into your container from the registery when needed for testing.

*****Noteable points about the solution:*****<br/>
This example uses two projects
> MultiContainerDocker.API

This is for back end

Not played about a lot with Razer pages before.  These are not very much different from Razer views in MVC, which I have used a lot.  Except the view and controller are grouped together in solution explorer.  A key point to note is that, public properties can be accessed in view as [model property](https://youtu.be/VI40Y3kFcNc?t=388) e.g. 
```
@Model.WeatherData. 
``` 
They do not need to passed into the view like in MVC, as in view(model) 
<br/><br/><br/>


> MultiContainerDocker.Web

This is for front-end

The back-end container is not set to https, as doing so will mean front-end can't talk to it using the service name **multicontainerdocker.api** associated with it in docker-compose.yml i.e. see BaseAddress in Startup.cs
```
http://multicontainerdocker.api
```
That's noted in docs because of: <br/>

>    "the .NET developer certificates used by Visual Studio are only supported for external-to-container requests, not for container-to-container requests"

### docker-compose
---

right-click the node and not the docker-compose.yml file, which didn't quite understand at first.  This brings up the docker-compose Property Pages. 
![](https://docs.microsoft.com/en-us/visualstudio/containers/media/tutorial-multicontainer/launch-action.png?view=vs-2019)
Where the launch application can be set, including url to start in browser.

