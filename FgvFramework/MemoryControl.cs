using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FrameworkFGV.MemoryControl
{
    public class MemoryControl
    {
        [DllImport("kernel32.dll")]
        private static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

        public MemoryControl()
        {
        }

        // <summary>Método utilizado para limpar a memória.
        // Desenvolvido por: Fernando A. Vargas
        // Data: 18/04/2019
        // Solicitantes: MGN / FGV
        // Versão: 1.0
        // Todos os direitos reservados        
        // </summary>         
        public static void FlushMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
        }
    }
}
