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
OR Usinf F5 by VS
![image](https://user-images.githubusercontent.com/14084041/190146812-3617deff-c1b3-4ce1-a003-6e5340c34ab4.png)


## ⛏ Build

Here you need the Electron.NET CLI as well. Type the following command in your ASP.NET Core folder:

```
electronize build /target win
```

There are additional platforms available:

```
electronize build /target win
electronize build /target osx
electronize build /target osx-arm64
electronize build /target linux
```


