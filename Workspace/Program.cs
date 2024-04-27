using Business.Concrete;
using Entities.Concrete;

Degiskenler();

Kisi kisi1 = new Kisi();

SelamVer(isim: "Ceylan");
SelamVer(isim: "Enis");
SelamVer(isim: "Can");

int sonuc = Topla(5);

//Diziler / Arrays
string[] ogrenciler = new String[3];
ogrenciler[0] = "Ela";
ogrenciler[1] = "Su";
ogrenciler[2] = "Melis";
Console.WriteLine(ogrenciler[1]);

ogrenciler = new string[4]; //reference tipler
ogrenciler[3] = "Ceylan";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] ogrenciler2 = { "Ayşe", "fatma", "ahmet" };
Console.WriteLine(ogrenciler2[2]);

//Diziler aşağıdaki 3 şekildeki gibi de tanımlanabilir.

string[] sehirler1 = new[] { "Ankara","İstanbul","Bursa"};
string[] sehirler2 = { "Bursa","Samsun","Ordu" };
string[] sehirler3 = new string[3];
sehirler3[0] = "Antalya";
sehirler3[1] = "Adana";
sehirler3[2] = "Mersin";

sehirler2 = sehirler1; //değer atamak değil sehirler2 nin reference değeri artık sehirler1 in reference değeri oluyor. Yani s1 de s2 de artık "Ankara","İstanbul","Bursa" heap teki bu şehirleri tutuyor.
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

//foreach döngüsü ile dizi formatındaki verileri dönüyoruz.

//generic collection (dizi yerine List<> yapısını kullanıyoruz.) Eleman sayısını vermiyoruz. 
List<string> yeniSehirler1 = new List<string> {"Eskişehir","Malatya","Balıkesir" }; //List bir sınıf yani reference tiptir.
yeniSehirler1.Add("Isparta"); //Add ile direkt ekliyor.

foreach (string sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

Person person1 = new Person();
person1.FirstName = "CEYLAN";
person1.LastName = "CANSARAN";
person1.NationalIdentity = 453;
person1.DateOfBirthYear = 1995;


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);


Console.ReadLine();

static void SelamVer(string isim="isimsiz") //default parametre tanımlama
{
    Console.WriteLine("merhaba" + isim);
}

static int Topla(int sayi1, int sayi2=10) //dönüş tipi int olan bir metot(fonksiyon)
    //ilk parametreye değer atayıp son parametreye default olarak değer atamama gibi bir durum doğru bir kullanım değil
{
    int sonuc = sayi1 + sayi2; //local değişkeni bu blok içerisinde tanımladığımız için bu blok içerisinde geçerli olur.
    Console.WriteLine("Toplam:" + sonuc.ToString());
    return sonuc;

}

static void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000.5;
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Ceylan";
    string soyad = "Cansaran";
    int dogumYili = 1995;
    long tcNo = 12345678910;

    Console.WriteLine(tutar * 1.18);
    Console.WriteLine(tutar * 1.18);
    Console.WriteLine(tutar * 1.18);
}

public class Kisi 
{
    public int Id { get; set; }
    public long TcNo { get; set; }
    public int Ad { get; set; }
    public int Soyad { get; set; }
    public int DogumYili { get; set; }
}