using ExtensionBoxing;

var asClass = new PersonC { Name = "Alec Class" };
var asStruct = new PersonS { Name = "Laurence Struct" };

Console.WriteLine(asClass);
Console.WriteLine(asStruct);

asClass.Ennoble();
asStruct.Ennoble();

Console.WriteLine();

Console.WriteLine(asClass);
Console.WriteLine(asStruct);