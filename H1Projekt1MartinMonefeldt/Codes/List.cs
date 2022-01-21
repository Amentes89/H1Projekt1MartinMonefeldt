using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Projekt1MartinMonefeldt.Codes;

    internal class MyGenericList
    {
        public List<List<List<string>>> AllHovedforløbCources { get; set; }

        public MyGenericList()
        {
            // Programmeringslinje kopieret fra forige øvelse.
            List<string> h1Prog = new List<string>() { "Grundl. Prog.", "Datab. prog.", "Studieteknik", "OOP", "Computertek.", "Clientside prog." };
            List<string> h2Prog = new List<string>() { "Db Server.", "Clinet. prog. 2", "Server sikkerhed", "OOP2", "Datab. prog. 2", "GUI prog." };
            List<List<string>> allProgCourses = new List<List<string>>() { h1Prog, h2Prog };

            // Support linje kopiert over fra forie øvelse
            List<string> h1Support = new List<string>() { "Grund. Server Opsætninger", "Db Server", "Web Server", "Linux Server", "Netværk", "OS" };
            List<string> h2Support = new List<string>() { "LAN Netværk", "WAN Netværk", "Db Admin.", "Web Admin.", "Linux Cluster Admin", "Hypervisor" };
            List<List<string>> allSupportCourses = new List<List<string>>() { h1Support, h2Support };

            AllHovedforløbCources = new List<List<List<string>>>() { allProgCourses, allSupportCourses };
        }

        public string GetCourseInfo(string courseName)
        {
            string returnText = "";

            for (int x = 0; x < AllHovedforløbCources.Count; x++)
            {

                for (int y = 0; y < AllHovedforløbCources[x].Count; y++)
                {

                    for (int z = 0; z < AllHovedforløbCources[x][y].Count; z++)
                    {
                        string s = AllHovedforløbCources[x][y][z];
                        if (s == courseName)
                        {
                            if (x == 0)
                                returnText = "Programmeringslinje";
                            else if (y == 1)
                                returnText = "Supportlinje";

                            if (y == 0)
                                returnText = returnText + ", H1";
                            else if (y == 1)
                                returnText = returnText + ", H2";

                            break;
                        }
                    }
                }
            }

            return returnText;
        }
    }
