# Baby Sınıfı ve Constructor Kullanımı (C#)

Bu basit C# projesinde, `Baby` (Bebek) sınıfı ile constructor ve property kullanımını gösteriyoruz.

## Proje Özeti

`Baby` sınıfı üç temel özelliğe sahiptir:

- `Name` (Ad)
- `lastName` (Soyad)
- `BirthDay` (Doğum Tarihi)

Sınıf içinde iki farklı constructor tanımlanmıştır:

1. **Parametresiz (Default) constructor:**  
   Nesne oluşturulduğunda `BirthDay` o anki tarih olarak atanır ve konsola `"Ingaaaaaaaaa"` yazısı yazdırılır.

2. **Parametreli constructor:**  
   Ad ve soyadı parametre olarak alır, `BirthDay` yine o anki tarih olur ve `"Ingaaaaaaaaa"` konsola yazdırılır.

## Sınıf Detayları

- Özel alanlar (field) veriyi tutar.
- Public property’ler veri erişimini sağlar.
- Constructorlar nesne ilk oluşturulurken başlangıç değerlerini atar.

## Kullanım Örneği

```csharp
Baby baby1 = new Baby("deniz", "öncü");  // Ad ve soyad ile nesne oluşturma
Baby baby = new Baby();                    // Parametresiz nesne oluşturma

Console.WriteLine($"{baby1.Name} {baby1.lastName} {baby1.BirthDay}");
Console.WriteLine($"{baby.BirthDay}");
