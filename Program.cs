


// Generic metotlar, derleme zamanında parametre tiplerini değiştirebildiniz metotlardır!!!




// Generic Metot Örneği : 

// 2 adet parametre alan geriye değer döndürmeyen bir metot örneği
// Generic metodu kullanalım

GenericMetot<int,string>(1,"Generic metot parametresi");


GenericMetot1<string,char,Personel>("Metot parametresi",'A',new Personel());


string returnValue = GenericMetot2<string,string>("Metot parametresi");
Console.WriteLine(returnValue);








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