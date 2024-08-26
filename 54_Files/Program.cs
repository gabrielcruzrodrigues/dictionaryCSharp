string path = @"c:\dados\txt\arquivo.txt";
string directory = @"c:\dados\txt";

Directory.CreateDirectory(directory); //Classe com métodos estáticos para trabalhar com diretórios.
File.Create(path); //Classe com métodos estáticos para trabalhar com files.
var pathh = Path.DirectorySeparatorChar; //Classe com métodos estáticos para trabalhar com paths.
FileStream file = File.OpenRead(path); //Classe para manipular arquivos de forma mais granular, quando a memória pode ser um problema.

FileInfo fileInfo = new FileInfo(path); //obter informações sobre o arquivo.
DirectoryInfo directoryInfo = new DirectoryInfo(path); //ober informações vinculadas a um diretório.

Console.ReadKey();