


// Generic metotlar, derleme zamanında parametre tiplerini değiştirebildiniz metotlardır!!!




// Generic Metot Örneği : 

// 2 adet parametre alan geriye değer döndürmeyen bir metot örneği
// Generic metodu kullanalım

GenericMetot<int,string>(1,"Generic metot parametresi");


GenericMetot1<string,char,Personel>("Metot parametresi",'A',new Personel());


string returnValue = GenericMetot2<string,string>("Metot parametresi");
Console.WriteLine(returnValue);


// Generic olarak toplama işlemi yapan metodu kullanalım

int toplam = Toplama<int,int,int>(10,2);
Console.WriteLine(toplam);


// Toplama metonu string tipi ile deneyelim 

string stringToplama = Toplama<string,string,string>("merhaba","dünya");
Console.WriteLine(stringToplama);   



var enBuyuk = EnBuyuk<Ogrenci>(new Ogrenci(){   OgrenciId=19},new Ogrenci(){ OgrenciId=5});
Console.WriteLine("En Büyük : "+enBuyuk.OgrenciId);

// 2 tane geçeric parametre alan metot!!
static void GenericMetot<T,K>(T value1,K value2){

}

// 3 generic parametre alan metot!!
static void GenericMetot1<T,K,L>(T value1,K value2,L value3){

    
}

// bir parametre alıp geriye generic değeri döndüren metot!!

static T GenericMetot2<T,K>(K value){

  // T tipi bilinmediği için, nasıl geriye değer döndürürüz!!!

   //default(T) keyword'ü, T tipi yerine gelecek olan tipin default değerini döndürecektir.!!
  return default(T);
}

GenericMetot3<int,char>(1,'S');

// T K gibi ifadeler, metot yazım esnasında kullanılmaktadır!!
// T K gibi ifadeler, metotun kullanım zamanında, developer tarafından verilecek olan tiplerin yerine geçmektedir!!


// metot yazılma aşamasında, geneeric metot olduğu için metodun yazılma aşamasında hangi tip ile çalışacağı belli değildir!!

// bu sebeple tip yazılmak yerine tip yerine geçebilecek kısaltmalar kullanılmaktadır

//genelde T K L M N gibi kısaltmalar tavsiye edilir
// Ancak buralara verilecek olan kısaltma isimlerinde bir sınırlama yoktur!!

// T K L M gibi kısaltmalar vermek genelde  seöktör tavsiyesidir!!

// bazı kaynaklarda, T K LM gibi ifadeler yerine TKey TValue gibi ifadelerde görülebilir!!



// Kısaltma olarak Wissen Besiktas bile kullanabilirsiniz!!!

static void GenericMetot3<Wissen,Besiktas>(Wissen value1,Besiktas value2){

}


// toplama yapan ve geriye değer döndüren generic metot yazalım!!!
static L Toplama<T,K,L>(T value1,K value2){

    // yeni keyword'ümüz, dynamic!!!

    dynamic birinciSayi = value1;
    dynamic ikinciSayi = value2;
    return birinciSayi+ikinciSayi;

}

// Generic metotlarda gelecek generic parametrelere bazı kısıtlar uygulayablirsiniz!!!


// Where komutu ile , generic metotlarımıza kısıtlar ekleyebiliriz!!!

// T tipine, IComparable kısıtı koyduk!!

// bu şu demektir :  T yerine gelecek olan tip, kesinlikle karşılaştırma yapılabilecek bir tip olmalıdır

// IComparable interface'i karşılaştırma yapan bir interface'dir
static T EnBuyuk<T>(T a, T b)where T:IComparable
{

    return a.CompareTo(b)==-1?b:a;


}




