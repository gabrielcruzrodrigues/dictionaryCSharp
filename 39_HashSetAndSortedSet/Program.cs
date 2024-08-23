/* Uma coleção que contém apenas itens distintos é conhecida pelo comjunto de termos ou SET.
 * 
 * HashSet - Contém uma lista não ordenada de itens distintos;
 * SortedSet - Contém uma lista ordenada de itens distintos;
 * 
 * São dois conjuntos ou sets definitos como coleções genéricas usadas para armazenar e manipular
 * conjuntos de dados não duplicados e estão presentes no namespace Generics.
 */

// ---------------------------- hashSet ------------------------------------------

var nums = new HashSet<int> { 1, 2, 3, 4, 5 };
var nums1 = new HashSet<int> { 1, 2 };
var nums2 = new HashSet<int> { 3, 4 };

if (!nums.Contains(6))
    nums.Add(6);

var result = nums.Remove(8); // false because 8 not exists

//verifica se nums1 é um subconjunto de nums (se os itens de nums1 existem em nums)
var verifySub = nums1.IsSubsetOf(nums); //true porque todos os elementos de nums1 existem em nums

//verifica se nums é um superconjunto de nums1(se nuns contem todos os itens de nuns 1)
var verifySuperSub = nums.IsSupersetOf(nums1); //true porque todos os elemtos de num1 existem em nuns

//verifica se existem itens comuns
var verifyEquals = nums.Overlaps(nums1);

//verifica se dois conjuntos tem o mesmo elemento
var VerifyAllEquals = nums.SetEquals(nums1);

//unindo valores
nums1.UnionWith(nums2);

//apaga todos os elementos
nums.Clear();

// ---------------------------- sortedSet ------------------------------------------

//ordenando elementos
var allNumbers = new SortedSet<int>(nums);