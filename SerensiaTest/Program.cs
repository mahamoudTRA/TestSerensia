using SerensiaTest;

var test = new IAmTheTest();
var siren = "12345678";
//var result = test.CheckSirenValidity(siren);
var res = test.ComputeFullSiren(siren);
Console.WriteLine(res);

Console.ReadKey();
