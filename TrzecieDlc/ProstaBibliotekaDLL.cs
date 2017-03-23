using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IAplikacji.InterfejsApli;

namespace TrzecieDlc
{
    //miniatutowe dll jako dodatek uzupełniający do projektu zabawaNapisy. 
    // kod projektu znajduje sie na stronie https://github.com/dkopos/OpostDane
    // a za zadanie pokazać jak tworzyć proste dll, z urzyciem mes. Mając jedynie informacjie o urzywanym interfejsie.
    //Oraz posiadając DLL z jedo implementacją
    [Export(typeof(IOpreracji))]
    [ExportMetadata("Symbol", "A")]
    class innaSuma : IOpreracji
    {
        public String Operacja(string lewy, string prawy)
        {
            return prawy + lewy + prawy;
        }
    }
}
