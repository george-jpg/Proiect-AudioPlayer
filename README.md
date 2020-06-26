# Proiect-AudioPlayer

 Tema aleasa: Audio player
 Introducere - scopul proiectului : redarea fișierelor mp3 ; 
 Cerințe: implementare logging si Unit Test
 

 Tehnologii:
Limbaj folosit: C#
*Proiectul a fost creat cu Visual Studio 2019*

Librariile ce trebuiesc instalate :NLog, NLog.Config, NLog.Schema( pentru partea de logging)

Dupa a trebuit sa configurez tot ce am instalat ca si logging
Pentru asta am intrat in fisierul numit NLog.config si mi-am redenumit numele fisierului
EX:  <  target xsi:type="File" name="myAppLoggerTarget" fileName="${basedir}/logs/${shortdate}.log"
            layout="${longdate} ${uppercase:${level}} ${message}" />
   <logger name="myAppLoggerRules" minlevel="Debug" writeTo="myAppLoggerTarget" />

Fisierul log rezultat in urma rularii se poate gasi in "Proiect AudioPlayer\AudioPlayerApp\bin\Debug\logs".

Functionalitate:


Aplicatia are ca si scop redarea fisierelor mp3. Asta se poate verifica deschizand cu ajutorul butonului de Open din partea stanga fisiere de acest tip.
Am creat o clasă numită Mp3Player pe care o apelăm in Form1.
Am implementat o metoda de a se putea selecta mai multe melodii la un loc, iar apoi acestea se vor salva in lista din partea dreapta .

Am incercat sa creez si partea de Unit Test, dar nu e complet.

Aplicatia dispune si de un design creat pe baza de Windows Forms, anumite butoane fiind active ca cele de play, stop open si inchidere.


Altele:

Pentru a se opri de tot o melodie, dupa play, a trebuit sa adaug o conditie in Form1.Designer 
Ex:      if (disposing)
            {

                if (mp3Player != null) mp3Player.Dispose();
            }

A  fost nevoie si sa implementez o metoda in clasa Mp3Player:
Ex: public void Dispose()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

Inspiratie:

Aplicatia se bazeaza pe tutorialul C# - Designing an Mp3 Player in Winform App de la C# Ui Academy



