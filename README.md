# Sabapaymak .Net Sdk for rest Api

## راهنما
صبا پیامک یک سیستم ارسال پیامک است که از طریق پنل یا وب سرویس میتوانید از آن استفاده کنید.

برای نصب این sdk در پروژه ی خود میتوانید از دستورات زیر استفاده کنید :

##### Package Manager
```
Install-Package Sabapayamak -Version 1.0.0
```
##### .NET CLI
```
dotnet add package Sabapayamak --version 1.0.0
```


## نحوه استفاده در کد


```c#
try{
    Sabapayamak.SabaPayamakAPI service=new  Sabapayamak.SabaPayamakAPI("YOUR_API_URL");
    var result = service.SendMessage("YOUR_MESSAGE_TEXT", new string[]{ "NUMBER1","NUMBER2" },"YOUR_TOKEN");
    return result;
}
catch(Exception ex){
    throw ex;
}
   
```