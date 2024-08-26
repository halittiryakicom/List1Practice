//Burada davetli listesi oluşturuyoruz
List<string> davetliler = new List<string>()
{
    "Bülent Ersoy",
    "Ajda Pekkan",
    "Ebru Gündeş",
    "Hadise",
    "Hande Yener",
    "Tarkan",
    "Funda Arar",
    "Demet Akalın"
};

//Davetli listesine ekleme yapıyoruz.
davetliler.Add("Cimilli İbo");
davetliler.Add("Anastasios Bakasetas");
davetliler.Add("Fatih Tekke");
davetliler.Add("Alexander Sörloth");


//Burada davetli listesini ekrana yazdırıyoruz.
Console.WriteLine("---------- Patika Plus Davetli Listesi ----------");
for(int i = 0; i < davetliler.Count; i++)
{
    Console.WriteLine($"{i+1}. davetli {davetliler[i]}");
}