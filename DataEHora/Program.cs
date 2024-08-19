/* O tipo Struct é semelhante a uma classe, mas é composto por outros tipos e métodos.
 * DataTime é o tipo usado para referenciar datas e horas no C#.
 * O DateTime tem o valor padrão de 01/01/0001 00:00:00 - (dd/mm/aaaa hh:mm:ss).
 */

//Data e hora atual
using System.Data;

DateTime data = DateTime.Now;

//Criar uma nova data
DateTime newData = new DateTime(2022, 01, 22);

//Criar uma nova data com horário (aaaa, mm, dd, hh, mm, ss)
DateTime newDataWithHours = new DateTime(2002, 01, 22, 11, 10, 20);

//Operações

//get
Console.WriteLine(data.Year);
Console.WriteLine(data.Month);
Console.WriteLine(data.Day);
Console.WriteLine(data.Minute);
Console.WriteLine(data.Second);
Console.WriteLine(data.Millisecond);

data.AddDays(11);
data.AddHours(10);
data.AddMinutes(10);
data.AddSeconds(10);
data.AddMonths(11);
data.AddYears(10);

//get day of week and year
Console.WriteLine(data.DayOfWeek);
Console.WriteLine(data.DayOfYear);

//data no formato longo e curto
Console.WriteLine(data.ToLongDateString());
Console.WriteLine(data.ToShortDateString());

//hora no formato longo e curto
Console.WriteLine(data.ToLongTimeString());
Console.WriteLine(data.ToShortTimeString());