using System;

namespace GiveAwayShow
{
    class Program
    {
        public static void Main(string[] args)
        {

            int dogruCevap = 0;

            Console.WriteLine("Para Bizde Şöhret Sizde Yarışmasına Hoşgeldiniz\n");
            
            Console.WriteLine("Soru 1: Satrançta her yöne sadece 1 kare hareket edebilen taş hangisidir?\nA-) Piyon\nB-) Şah\n"); //Question 1
            Console.WriteLine("Cevabınızı tuşlayınız A - B ?\n");
            string cevap1 = Console.ReadLine().ToLower();

            if (cevap1 == "b")
            {
                dogruCevap++;
                Console.WriteLine("DOĞRU!\n");
            }
            else
            {
                Console.WriteLine("Şah olacaktı. Üzülmeyin 2 sorumuz daha var. 1 Milyon liranın sahibi olmak için 2 soru bilmeniz yeterli fakat 2. soruya da yanlış cevap verirseniz sizi köyünüze uğurlamak zorundayız\n");
            }

            Console.WriteLine("Soru 2: Uefa Kupasına sahip tek Türk Futbol takımı Hangisidir?\nA-)Galatasaray\nB-)Fenerbahçe\n"); //Question 2
            Console.WriteLine("Cevabınızı tuşlayınız A - B\n");
            string cevap2 = Console.ReadLine().ToLower();

            if (cevap2 == "a")
            {
                dogruCevap++;
                Console.WriteLine("DOĞRU!\n");

            }
            else 
            {
                Console.WriteLine("Futbolla pek aranız yok galiba, cevap Galatasaray olacaktı.\n");

            }
            if (dogruCevap == 1) // İlk iki sorudan birtanesine doğru cevap verilirse 3. soruyla devam ediyoruz.
            {
                Console.WriteLine("Soru 3: Meşhur tavaciğeri, Selimiye Camii ve köklü tarihiyle ünlü ilimiz hangisidir?\nA-)Edirne\nB-)Tekirdağ "); //Question 3
                Console.WriteLine("Cevabınızı tuşlayınız A - B");
                string cevap3 = Console.ReadLine().ToLower();

                if (cevap3 == "a")
                {
                    Console.WriteLine("Para Sizdeee Şöhret Sizdee, evet sayın seyirciler işte karşınız büyük ikramiyenin sahibi!");
                    dogruCevap++;
                }
                else 
                {
                    Console.WriteLine("Cevap Edirne olacaktı. Büyük ikramiyenin sahibi olmak için çok yaklaşmıştınız fakat malesef");

                }

            }

            if (dogruCevap >= 2) // İlk iki soruda ikisine de doğru veya yanlış cevap verilmesini denetliyoruz. 
            {
                Console.WriteLine("Para sizdeeeee Şöhret Sizzdeeee");

            }
            else 
            {
                Console.WriteLine("Üzülerek sizi eliniz boş gönderiyoruz");
            }



        }
    }
}