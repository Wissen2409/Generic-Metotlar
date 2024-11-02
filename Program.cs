


// Generic metotlar, derleme zamanında parametre tiplerini değiştirebildiniz metotlardır!!!




// Generic Metot Örneği : 

// 2 adet parametre alan geriye değer döndürmeyen bir metot örneği
// Generic metodu kullanalım

GenericMetot<int, string>(1, "Generic metot parametresi");


GenericMetot1<string, char, Personel>("Metot parametresi", 'A', new Personel(1, "hamit"));


string returnValue = GenericMetot2<string, string>("Metot parametresi");
Console.WriteLine(returnValue);


// Generic olarak toplama işlemi yapan metodu kullanalım

int toplam = Toplama<int, int, int>(10, 2);
Console.WriteLine(toplam);


// Toplama metonu string tipi ile deneyelim 

string stringToplama = Toplama<string, string, string>("merhaba", "dünya");
Console.WriteLine(stringToplama);


// Generic enbüyük metoduna Öğrenci tipini gönderelim 
var enBuyuk = EnBuyuk<Ogrenci>(new Ogrenci() { OgrenciId = 19 }, new Ogrenci() { OgrenciId = 5 });
Console.WriteLine("En Büyük : " + enBuyuk.OgrenciId);


// Generic en büyük metoduna, int tipini gönderelim!!!
var enBuyukInt = EnBuyuk<int>(20, 66);
Console.WriteLine(enBuyukInt);


// Generic metodumuza Default Ctor kısıtı koyalım!!
//CtorKisit<Personel>(new Personel(1,"Kemal"));

// Generic metodumuza Kalıtım kısıtı koyalım 

// int bir baseclass değildildir!! Hata alındı
//Kalitim<int>(10);

// Ogrenci bir baseclass değildir !! Hata Alındı
//Kalitim<Ogrenci>(new Ogrenci());

//Personel sınıfı BaseClass sınıfından kalıtım aldığı için, Kalıtım kısıtı olan Kalitim metoduna 
// Parametre olarak gönderilebilir!!
Kalitim<Personel>(new Personel(1, "Nalan"));


// 2. deneme Personel sınıfı baseclass'tan kalıtıldığı için, aşağıdaki şekilde bir deneme de yapabildik!!
Kalitim<BaseClass>(new Personel(1, "Abdulkadir"));


// Generic Kısıt : Class yada Struct olma kısıtı : 

// String bir referans tipi olduğu için metoda parametre olarak gönderilebildik!!
SinifYadaStruct<string>("Deneme");

// int değeri değer tip olduğu için, referans tip kısıtı olan bir generic metoda parametre olarak gönderiledi
//SinifYadaStruct<int>(10);

// Wissen isimli struct değer tip olduğu için metoda parametre olarak gönderilmedi
//SinifYadaStruct<Wissen>(new Wissen());


// Personel sınıfı referans tip olduğu için referans tip kısıtı olan metoda parametre olarak gönderilebilir!!
SinifYadaStruct<Personel>(new Personel(1, "Keriman"));



// 2 tane geçeric parametre alan metot!!
static void GenericMetot<T, K>(T value1, K value2)
{

}

// 3 generic parametre alan metot!!
static void GenericMetot1<T, K, L>(T value1, K value2, L value3)
{


}

// bir parametre alıp geriye generic değeri döndüren metot!!

static T GenericMetot2<T, K>(K value)
{

    // T tipi bilinmediği için, nasıl geriye değer döndürürüz!!!

    //default(T) keyword'ü, T tipi yerine gelecek olan tipin default değerini döndürecektir.!!
    return default(T);
}

GenericMetot3<int, char>(1, 'S');

// T K gibi ifadeler, metot yazım esnasında kullanılmaktadır!!
// T K gibi ifadeler, metotun kullanım zamanında, developer tarafından verilecek olan tiplerin yerine geçmektedir!!


// metot yazılma aşamasında, geneeric metot olduğu için metodun yazılma aşamasında hangi tip ile çalışacağı belli değildir!!

// bu sebeple tip yazılmak yerine tip yerine geçebilecek kısaltmalar kullanılmaktadır

//genelde T K L M N gibi kısaltmalar tavsiye edilir
// Ancak buralara verilecek olan kısaltma isimlerinde bir sınırlama yoktur!!

// T K L M gibi kısaltmalar vermek genelde  seöktör tavsiyesidir!!

// bazı kaynaklarda, T K LM gibi ifadeler yerine TKey TValue gibi ifadelerde görülebilir!!



// Kısaltma olarak Wissen Besiktas bile kullanabilirsiniz!!!

static void GenericMetot3<Wissen, Besiktas>(Wissen value1, Besiktas value2)
{

}


// toplama yapan ve geriye değer döndüren generic metot yazalım!!!
static L Toplama<T, K, L>(T value1, K value2)
{

    // yeni keyword'ümüz, dynamic!!!

    dynamic birinciSayi = value1;
    dynamic ikinciSayi = value2;
    return birinciSayi + ikinciSayi;

}

// Generic metotlarda gelecek generic parametrelere bazı kısıtlar uygulayablirsiniz!!!


// Where komutu ile , generic metotlarımıza kısıtlar ekleyebiliriz!!!

// T tipine, IComparable kısıtı koyduk!!

// bu şu demektir :  T yerine gelecek olan tip, kesinlikle karşılaştırma yapılabilecek bir tip olmalıdır


// Generic Kısıtlar : Interface kısıtı
// IComparable interface'i karşılaştırma yapan bir interface'dir
static T EnBuyuk<T>(T a, T b) where T : IComparable
{
    // T hangi tip ? : T'yi c# daki tüm tipler olarak düşünmesi lazım

    // iki T değeri toplamak  :
    return a.CompareTo(b) == -1 ? b : a;
}

//Generic Kısıtlar : Default Ctor kısıtı
static void CtorKisit<T>(T a) where T : new()
{

}

// Generic Kısıtlar : Kalıtılma kısıtı 
// Kalıtım kısıtında, iki koşul vardır!! : Ya sınıftan kalıtılmak yada o sınıfı kullanmak diyebiliriz

// Aşağıda BaseClass isimli sınıftan kalıtım alma şartı yada baseclass sınıfının parametre olarak gelmne 
// şartı ekledim!!
static void Kalitim<T>(T a) where T : BaseClass
{

}

// Generic Kısıtlar : Class veya Struct olma kısıtı

static void SinifYadaStruct<T>(T value) where T : class
{

}
// Çoklu Kısıt : T tipi, hem referans tip olmalı hemde, IDisposable interface'inden implement olmalı
// K tipi, değer tipli olmalıdır!!
static void ClassOrStruct<T, K>(T value1, K value2) where T : class,IDisposable
where K : struct
{

}






