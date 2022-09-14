# NET6WithAngularElectronNET

NET6 with .NET Core with Angular Template in separate folders. <br>
The UI is separate from the webAPI core project however the configuration to running everything together is setup in the .CSproj

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


