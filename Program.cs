using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string DirOrigen = @"\\128.84.0.67\op_eccu\00 Supply Chain\Reportes PS Software Temporis";
            //const string DirDestino = @"C:\Users\Administrator\Desktop\Backup - Carpeta Ntbacel";
            System.Threading.Thread.Sleep(20000);
            const string DirOrigen = @"C:\Users\ClaudioSergio\Desktop\Seguridad";
            const string DirDestino = @"C:\Users\ClaudioSergio\Desktop\Seguridad2";

            DateTime FechaOrigen = Directory.GetLastWriteTime(DirOrigen);
            DateTime FechaDestino = Directory.GetLastWriteTime(DirDestino);

            if (FechaDestino < FechaOrigen)
            {
           foreach (string dirPath in Directory.GetDirectories(DirOrigen, "*",
               SearchOption.AllDirectories))
               Directory.CreateDirectory(dirPath.Replace(DirOrigen, DirDestino));

           foreach (string newPath in Directory.GetFiles(DirOrigen, "*.*",
               SearchOption.AllDirectories))
               File.Copy(newPath, newPath.Replace(DirOrigen, DirDestino), true);
            }
        }
        
    }
}
