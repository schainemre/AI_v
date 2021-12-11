using System;

namespace AI_vize
{
    class Program
    {
        static void Main(string[] args)
        {
            string Country_or_Area;
            int Year;
            string Area;
            string Month;
            string Record_Type;
            string Reliability;

            Console.WriteLine("Ülke ya da Bölge giriniz: ");
            Country_or_Area = Console.ReadLine();

            Console.WriteLine("Yil Giriniz: ");
            Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bölge Giriniz: ");
            Area = Console.ReadLine();

            Console.WriteLine("Ay Giriniz: ");
            Month = Console.ReadLine();

            Console.WriteLine("Kayıt Tipi Giriniz: ");
            Record_Type = Console.ReadLine();

            Console.WriteLine("Güvenilirllk Giriniz: ");
            Reliability = Console.ReadLine();







            MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                Country_or_Area = Country_or_Area,
                Year = Year,
                Area = Area,
                Month = Month,
                Record_Type = Record_Type,
                Reliability = Reliability,
            };



            var NumberofBirth = MLModel1.Predict(sampleData);





            Console.WriteLine($" Country_or_Area: { Country_or_Area}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Record_Type: {Record_Type}");
            Console.WriteLine($"Reliability: {Reliability}");




            Console.WriteLine($"\n\nToplam DOGUM SAYISI: {NumberofBirth.Score}\n\n");
            Console.WriteLine(" islem bitti, bitirmek için bir tusa basin ");
            Console.ReadKey();
        }
    }
}
