// Para inibir o alerta de erro NullReferenceException usamos o Null Conditional Operator(?.).

string? name = null;
Console.WriteLine(name?.ToUpper());