using System.IO;
namespace JustSomeCodes
{
    class Program
    {
        public static void Main()
        {
            #region Dosyaya veri yazdırma işlemi

            //1.Yöntem -Dizi elemanlarının satır satır text dosyasına yazdırılması
            //string url = @"C:\Users\levfi\OneDrive\Masaüstü\SomeCode\Yeni Klasör\Sadece.txt";
            //string[] lines = { "StudentName: Murat", "StudentNo:6699", "StudentSurname:KARA" };
            //System.IO.File.WriteAllLines(url, lines);

            //2.Yöntem -String bir değişkeni text dosyasına  yazdırma
            //var someCode = "The FileStream class in C# provides a stream for file operations. " + "\n" +
            //    "It can be used to perform both synchronous and asynchronous read and write operations." + "\n" +
            //    " With the help of FileStream class, we can easily read and write data into files.";

            //System.IO.File.WriteAllText(@"C:\Users\levfi\OneDrive\Masaüstü\SomeCode\Yeni Klasör\Sadece.txt", someCode);

            //3. Yöntem -String listede ki elemanlardan filtreleme yapma
            var url = @"C:\Users\levfi\OneDrive\Masaüstü\SomeCode\Yeni Klasör\sadece.txt";
            string[] persons = { "Müdür:Ahmet", "Müdür:Ayça", "Müdür Yardımcısı:Salih", "Yardımcısı:Kübra" };
            System.IO.StreamWriter dosyalar = new System.IO.StreamWriter(url);
            foreach (var item in persons)
            {
                if (item.Contains("Müdür"))
                {
                    dosyalar.WriteLine(item);
                }
            }
            #endregion





        }
    }
}


#region Klasör oluşturma ve içiçe klasör oluşturma işlemi

//var url = @"C: \Users\levfi\OneDrive\Masaüstü\SomeCodes";
//System.IO.Directory.CreateDirectory(url);
//var underFile = System.IO.Path.Combine(url, "c#");
//System.IO.Directory.CreateDirectory(underFile);
//Console.WriteLine("  \"sadece\" ");

#endregion

#region Alt klasör kotrolü ile alt klasörde dosya oluşturma


//var desktopUrl = @"C:\Users\levfi\OneDrive\Masaüstü\Okul\";

//Console.WriteLine("Student number:");
//var studentNo = Console.ReadLine();

//Console.WriteLine("Student class:");
//var studentClass = Console.ReadLine();

//var filePath = desktopUrl + studentClass;
//if (System.IO.Directory.Exists(filePath) == true)
//{
//    var createUnderFile = desktopUrl + studentClass + "\\" + studentNo;
//    System.IO.Directory.CreateDirectory(createUnderFile);
//    Console.WriteLine($"{studentNo}" + " numaralı öğrenci için klasör oluşturuldu");
//}
//else
//{
//    Console.WriteLine("Böyle bir kayıt bulunmamaktadır.");
//}
#endregion

#region Klasör silme işlemi

//var filePath = @"C:\Users\levfi\OneDrive\Masaüstü\Okul";
//if (System.IO.Directory.Exists(filePath))
//{
//    System.IO.Directory.Delete(filePath, true);
//    Console.WriteLine("Belirtilen dosya başarıyla silindi");
//}
//else
//{
//    Console.WriteLine("Belirtilen dosya buunamadı.");
//}


#endregion

#region Kopyalama işlemi

//var sourceFolder = @"C:\Users\levfi\OneDrive\Masaüstü\Yeni klasör";
//var endFolder = @"C:\Users\levfi\OneDrive\Masaüstü\SomeCode";
//string endFilePath;

//if (System.IO.Directory.Exists(sourceFolder))
//{
//    string[] files = System.IO.Directory.GetFiles(sourceFolder);
//    string? fileName;
//    foreach (string item in files)
//    {
//        fileName = System.IO.Path.GetFileName(item);
//        endFilePath = System.IO.Path.Combine(endFolder, fileName);
//        System.IO.File.Copy(item, endFilePath, true);
//        Console.WriteLine($"{item}" + "Kaynak dosyası başarıyla koplaylandı.");
//    }
//}
//else
//{
//    Console.WriteLine("Kaynak dosya bulunamadı.");
//}

#endregion

#region Klasör Taşıma İşlemi

//var sourceFolder = @"C:\Users\levfi\OneDrive\Masaüstü\Yeni klasör";
//var endFolder = @"C:\Users\levfi\OneDrive\Masaüstü\SomeCode\Yeni Klasör";//Taşınacak olan dosyanın yine adı yazılmalı

//System.IO.Directory.Move(sourceFolder, endFolder);

#endregion

