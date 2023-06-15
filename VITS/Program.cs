// See https://aka.ms/new-console-template for more information
using VITS;

var responseAllModules = await Helper.Get(
    new HttpRequestMessage
    {
        Method = HttpMethod.Post,
        RequestUri = new Uri("http://soundai.natapp1.cc/sys/loginByC?account=3518634279&code=8b445fff-f666-44eb-a19e-fed54ce7654e"),
    }) ;
var r = await responseAllModules.Content.ReadAsStringAsync();
Console.WriteLine(r);
