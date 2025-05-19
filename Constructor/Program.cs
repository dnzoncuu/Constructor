using Constructor;

Baby baby1= new Baby("deniz","öncü");//Nesne Tanımlama
Baby baby = new Baby();//nesne tanımlama

Console.WriteLine($"{baby1.Name} {baby1.lastName}  {baby1.BirthDay}");
Console.WriteLine($"{baby.BirthDay}");