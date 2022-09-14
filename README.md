# NET6WithAngularElectronNET

NET6 with .NET Core with Angular Template in separate folders. <br>
The is separate from the webAPI core project however the configuration to running everything together is setup in the .CSproj

![image](https://user-images.githubusercontent.com/14084041/190109784-b61b74b9-073b-4617-b8bc-32b4ba273c20.png)


![image](https://user-images.githubusercontent.com/14084041/189996722-40af7b33-ecca-406b-b418-d28dab7f199c.png)


⛏ Build
<hr>
Here you need the Electron.NET CLI as well. Type the following command in your ASP.NET Core folder:

electronize build /target win
There are additional platforms available:

electronize build /target win
electronize build /target osx
electronize build /target osx-arm64
electronize build /target linux



