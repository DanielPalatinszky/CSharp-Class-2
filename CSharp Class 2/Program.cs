using System;

namespace CSharp_Class_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elágazás, mely akkor hajtódik végre, ha a feltétel igaz
            if (5 == 5)
            {

            }

            //Bármi lehet az elágazás feltétele, aminek a végeredménye egy bool
            if (Convert.ToBoolean(Console.ReadLine()))
            {

            }

            //Tetszőlegesen összetett feltételek
            if (5 > 6 || 4 < 5 && 3 > 2)
            {

            }
            //Opcionális else if, amelyet akkor vizsgálunk, ha az előtte levő if vagy else if feltétele hamis
            //Fentről lefele, a legelső igaz feltételű else if hajtódik végre, a maradékot átugorja
            else if (3 > 2)
            {

            }
            //Tetszőleges darab else if lehet
            else if (2 == 3)
            {

            }
            //Opcionálisan 1 darab else, amely akkor hajtódik végre, ha az if vagy egyik else if feltétele sem igaz
            else
            {
                
            }

            //Az előzőekből következik, hogy egy if-else if sorozat nem ugyanúgy viselkedik, mint egy if sorozat
            if (3 == 2)
            {

            }
            else if (2 == 2)
            {

            }


            if (3 == 2)
            {

            }
            if (2 == 2)
            {

            }

            //Három operandusú operátor
            //Lényegében egy 1 soros if-else
            //A kérdőjeltől bal oldalra a feltétel, a kérdőjel után az igaz ág, a kettőspont után a hamis ág
            //Értéket ad vissza, így legtöbb esetben értékadásnál alkalmazzuk
            var a = 2 == 2 ? "Igaz" : "Hamis";

            //Konkrét értékekre való szűréshez switch
            var jegy = 1;
            switch (jegy)
            {
                //Felsoroljuk a lehetséges eseteket (case majd érték)
                case 1:
                    Console.WriteLine("F");
                    //Kötelező break, hogy megszakítsuk a switch futását a legelső passzoló értéknél
                    break;
                case 2:
                    Console.WriteLine("D");
                    break;
                case 3:
                    Console.WriteLine("C");
                    break;
                case 4:
                    Console.WriteLine("B");
                    break;
                case 5:
                    Console.WriteLine("A");
                    break;
                //Opcionális default ág, ha a változó értéke egyik esetre sem passzol
                //Ha elhagyjuk és nem fut rá és nem passzol egyik case-re sem a változó értéke, akkor egyszerűen a switch után folytatódik a futtatás
                default:
                    Console.WriteLine("Nem jegy");
                    break;
            }

            //Előltesztelő ciklus, mely addig fut amíg a feltétele igaz
            //Általában akkor használjuk, ha nem tudjuk pontosan az ismétlések számát
            //Csakúgy mint az elágazásnál, bármi lehet a feltétel, ami bool típusú
            var i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);

                i++;
            }

            //Hátultesztelő ciklus, mely addig fut amíg a feltétele igaz
            //A ciklustörzs legalább egyszer biztosan lefut
            //Általában ellenőrzött adatbekérésnél használjuk
            //Csakúgy mint az elágazásnál, bármi lehet a feltétel, ami bool típusú
            var j = 0;
            do
            {
                Console.WriteLine(j);

                j++;
            } while (j < 10);

            //For ciklus, amely három részből áll
            //Addig fut amíg a feltétel igaz
            //A deklaráció a ciklus elindulása előtt fut le egyszer
            //A feltétel mindig lefut, mielőtt elindulna a ciklustörzs (a deklaráció után is rögtön). Ha hamis, kilépünk a ciklusból
            //A ciklustörzs utáni utasítás minden esetben lefut, amint a ciklustörzs befejeződik és mielőtt lefutna a feltétel
            //Általában akkor használjuk, ha pontosan tudjuk hányszor szeretnénk ismételni a törzset
            for (int k = 0 /*deklaráció*/; k < 10 /*feltétel*/; k++ /*ciklustörzs utáni utasítás*/)
            {
                Console.WriteLine(k);
            }

            //Valójában mindhárom rész opcionális
            //Ez egy végtelen ciklus
            for (;;)
            {
                
            }

            //Csakúgy mint az elágazásnál, bármi lehet a feltétel, ami bool típusú
            //A három rész tetszőleges kombinácioban használható/elhagyható, de jobb ha maradunk a hagyományos felhasználási módnál
            /*for (; Convert.ToBoolean(Console.ReadLine());)
            {
                
            }*/

            //Akár egyszerre több változót is deklarálhatunk
            //A ciklustörzs utáni utasítás is majdnem bármi lehet (kivétel pl. változó deklaráció)
            for (int v1, v2 = 0, v3, v4 = 0; v4 < 0; Console.WriteLine(v4))
            {
                
            }

            //A háromféle ciklus valójában ugyanazt képes kifejezni, azonban mindegyik más esetben kényelmes
            //Az alábbi három ciklus ekvivalens (ugyanazt csinálják)
            for (int b = 0; b < 10; b++)
            {
                Console.WriteLine(b);
            }

            var c = 0;
            while (c < 10)
            {
                Console.WriteLine(c);

                c++;
            }

            var d = 0;
            do
            {
                Console.WriteLine(d);

                d++;
            } while (d < 10);

            //A vezérlési szerkezetek tetszőlegesen kombinálhatóak, tetszőleges méylségben
            if (true)
            {
                for (int e = 0; e < 20; e++)
                {
                    switch (e)
                    {
                        case 5:
                            if (5 == 6)
                            {
                                e++;
                            }

                            break;
                    }
                }

                do
                {
                    while (false)
                    {
                        
                    }
                } while (false);
            }

            //Minden változónak van hatóköre, azaz azok a helyek, ahol a változó neve az adott változóra utal
            //A C# változói blokk szintűek

            //o blokkjának kezdete
            {
                var o = 0;

                //Jó, hiszen o++, az o-t tartalmazó blokkon belül van
                o++;

                {
                    //Jó, hiszen o++, az o-t tartalmazó blokkon belül van
                    o++;
                }
            }
            //o blokkjának vége

            //Nem jó, mert az o változó csak az őt tartalmazó kódblokkon belül érvényes
            //o++;

            //Nem jó, hisz p nem látszódik a while feltételében (illetve végtelen ciklus is lenne)
            /*do
            {
                var p = 0;
                p++;
            } while (p < 10);*/

            //Jó, hiszen p blokkja a Main, tehát látzsódik a while feltételében
            int p;
            do
            {
                p = int.Parse(Console.ReadLine());
            } while (p < 10);

            //A break kulcsszó segítségével bármikor megszakíthatjuk a ciklusok (for, while, do-while) futását
            //0-tól 4-ig kiíródnak a számok, majd s == 5 esetén befejezzók a ciklust:
            for (int s = 0; s < 10; s++)
            {
                if (s == 5)
                {
                    break;
                }

                Console.WriteLine(s);
            }

            //Mindig a break-et közvetlenül tartalmazó ciklus fejeződik be
            //Azaz a külső ciklus 10-szer le fog futni függetlenül a break-től
            for (int s = 0; s < 10; s++)
            {
                for (int f = 0; f < 20; f++)
                {
                    break;
                }
            }

            //continue segítségével a kulcsszót közvetlenül tartalmazó ciklus futását a következő iterációnál folytathatjuk
            //Kiírjuk a számokat 0-tól 9-ig az 5 kihagyásával:
            for (int s = 0; s < 10; s++)
            {
                if (s == 5)
                {
                    continue;
                }

                Console.WriteLine(s);
            }

            //Ha a vezérlési szerkezetben egyetlen utasítás van, akkor elhagyhatjuk a kapcsoszárójeleket
            if (5 == 5)
                Console.WriteLine("Hello");

            //Üres string (a memóriában van hely foglalva)
            string str1 = "";
            //Olyan string, amelynek nincsen értéke (az értéknek nincs hely foglalva a memóriában) (!= üres string)
            string str2 = null;

            //Ha üres a string vagy null:
            if (str2 == "" || str2 == null)
            {

            }

            //Egyszerűbben:
            if (string.IsNullOrEmpty(str2))
            {

            }
        }
    }
}
