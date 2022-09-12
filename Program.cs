// See https://aka.ms/new-console-template for more information
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
}
#endregion