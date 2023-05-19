﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
