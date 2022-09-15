# NET6WithAngularElectronNET

NET6 with .NET Core with Angular Template in separate folders. <br>
The UI is separate from the webAPI core project however the configuration to running everything together is setup in the .CSproj

## 🚀 Start the Application

To start the application make sure you have installed the "[ElectronNET.CLI](https://www.nuget.org/packages/ElectronNET.CLI/)" packages as global tool:

```
dotnet tool install ElectronNET.CLI -g
```

At the first time, you need an Electron.NET project initialization. Type the following command in your ASP.NET Core folder:

```
electronize init
```

* Now a electronnet.manifest.json should appear in your ASP.NET Core project
* Now run the following:

```
electronize start
```
OR Using F5 by VS
![image](https://user-images.githubusercontent.com/14084041/190146983-c10a5908-a3ba-4aaa-a748-7832643e155e.png)


## ⛏ Build

Here you need the Electron.NET CLI as well. Type the following command in your ASP.NET Core folder:

```
electronize build /target win

Check out the result below
```

![image](https://user-images.githubusercontent.com/14084041/190147704-4a41cae7-c807-4161-9903-96ab862833da.png)


There are additional platforms available:

```
electronize build /target win
electronize build /target osx
electronize build /target osx-arm64
electronize build /target linux
```


