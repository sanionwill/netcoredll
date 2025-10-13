### NetCoreDll
This is a basic tool project, includes some util files which provide basic & common functions to use, developers only need to focus on incomming params and get results out directly.

### Project Goals
Save time and share common util functions for all C# devlopers.

### Requirements
Supported .NetCore version over 6.0

### Installation Guidelines
Use git clone https://github.com/sanionwill/netcoredll.git

```git
$ git clone https://github.com/sanionwill/netcoredll.git
```
Directory and files

```text
├── LICENSE
├── NetCoreDLL.csproj
├── Program.cs
├── README.md
└── Utils
    ├── ArrayHelper.cs
    ├── Des3Helper.cs
    ├── DesHelper.cs
    ├── IPHelper.cs
    └── Md5Helper.cs
```

Copy `/Utils/` directory or a special file（such as `/Utils/Des3Helper.cs`） and add to your own project

Use file to finish your requirement

```C#
using DES3Helper.cs;
{
    DES3Helper des3Helper = new DES3Helper();
    var yourStr = "Hello World";
    var des3Result = des3Helper.DES3Encrypt(yourStr);
    Console.WriteLine($"3des encrypt result is {des3Result}");
    var des3Plain = des3Helper.DES3Decrypt(des3Result);
    Console.WriteLine($"3des decrypt result is {des3Plain}");
}
```

### Documentation

All demos list

```C#
#region Md5 Demo
{
    Md5Helper md5Helper = new Md5Helper();
    var yourStr = "Hello World";
    var md5Result = md5Helper.Compute(yourStr);
    Console.WriteLine($"md5 encrypt result is {md5Result}");
}
#endregion

#region Des Demo
{
    DesHelper desHelper = new DesHelper();
    var yourStr = "Hello World";
    var desResult = desHelper.DESEncrypt(yourStr, "01234567");
    Console.WriteLine($"des encrypt result is {desResult}");
}
#endregion

#region 3Des Demo
{
    DES3Helper des3Helper = new DES3Helper();
    var yourStr = "Hello World";
    var des3Result = des3Helper.DES3Encrypt(yourStr);
    Console.WriteLine($"3des encrypt result is {des3Result}");
    var des3Plain = des3Helper.DES3Decrypt(des3Result);
    Console.WriteLine($"3des decrypt result is {des3Plain}");
}
#endregion

#region IP Demo
{
    IPHelper iPHelper = new IPHelper();
    var listIPV4 = iPHelper.GetLocalIp(IPVModel.IPv4);
    Console.WriteLine($"IPV4 result is {listIPV4}");
}
#endregion

#region getRange int Demo
{
    var list = new List<int> { 0, 1, 2 };
    var result = new ArrayHelper().getRange(list, 0, 2);
    Console.WriteLine($"getRange result is {result}");
}
#endregion

#region getRange string Demo
{
    var list = new List<string> { "0", "1", "2" };
    var result = new ArrayHelper().getRange(list, 0, 2);
    Console.WriteLine($"getRange result is {result}");
}
#endregion

#region getRange float Demo
{
    var list = new List<float> { 0f, 1f, 2f };
    var result = new ArrayHelper().getRange(list, 0, 2);
    Console.WriteLine($"getRange result is {result}");
}
#endregion

#region getRange double Demo
{
    var list = new List<double> { 0f, 1f, 2f };
    var result = new ArrayHelper().getRange(list, 0, 2);
    Console.WriteLine($"getRange result is {result}");
}
#endregion

#region getRange long Demo
{
    var list = new List<long> { 0f, 1f, 2f };
    var result = new ArrayHelper().getRange(list, 0, 2);
    Console.WriteLine($"getRange result is {result}");
}
#endregion

#region getRange object Demo
{
    var list = new List<object> { 0, 1, 2 };
    var result = new ArrayHelper().getRange(list, 0, 2);
    Console.WriteLine($"getRange result is {result}");
}
#endregion

#region GetCurrentDateTime Demo
{
    DateTimeHelper dateTimeHelper = new DateTimeHelper();
    var datetimeString = dateTimeHelper.GetCurrentDateTime();
    Console.WriteLine($"GetCurrentDateTime result is {datetimeString}");
}
#endregion

#region GetCurrentDate Demo
{
    DateTimeHelper dateTimeHelper = new DateTimeHelper();
    var dateString = dateTimeHelper.GetCurrentDate();
    Console.WriteLine($"GetCurrentDate result is {dateString}");
}
#endregion

#region GetCurrentTime Demo
{
    DateTimeHelper dateTimeHelper = new DateTimeHelper();
    var timeString = dateTimeHelper.GetCurrentTime();
    Console.WriteLine($"GetCurrentTime result is {timeString}");
}
#endregion
```
