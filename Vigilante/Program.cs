using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigilante
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string DirOrigen = @"\\128.84.0.67\op_eccu\00 Supply Chain\Reportes PS Software Temporis";
            //const string DirDestino = @"C:\Users\Administrator\Desktop\Backup - Carpeta Ntbacel";

            const string DirOrigen = @"C:\Users\ClaudioSergio\Desktop\Seguridad";
            const string DirDestino = @"C:\Users\ClaudioSergio\Desktop\Seguridad2";

            DateTime FechaOrigen = Directory.GetLastWriteTime(DirOrigen);
            DateTime FechaDestino = Directory.GetLastWriteTime(DirDestino);

            bool estaCorriendo = Process.GetProcessesByName("CopyApp").FirstOrDefault(p => p.MainModule.FileName.StartsWith(@"C:\Users\ClaudioSergio\Desktop\CopyApp\CopyApp\bin\Debug")) != default(Process);

            if (FechaDestino < FechaOrigen && estaCorriendo == false)
            {
                Process.Start(@"C:\Users\ClaudioSergio\Desktop\CopyApp\CopyApp\bin\Debug\CopyApp");
            }
        }
    }
}
