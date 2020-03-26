using System;
using System.IO;
using System.Reflection;
using dnlib.DotNet;
using dnlib.DotNet.Writer;

namespace FakeAttributeCleaner
{
    class Program
    {
        public static bool veryVerbose = false;
        public static string Asmpath;
        public static ModuleDefMD module;
        public static Assembly asm;
        static void Main(string[] args)
        {
            Console.Title = "FakeAttribute Cleaner";
            Console.ForegroundColor = ConsoleColor.Yellow;
            string directory = args[0];

            try
            {
                Program.module = ModuleDefMD.Load(directory);
                Program.asm = Assembly.LoadFrom(directory);
                Program.Asmpath = directory;
            }
            catch (Exception)
            {
                Console.WriteLine("Not a .NET assembly");
                Console.ReadKey();
                Environment.Exit(0);
            }

            AssemblyDef assembly = AssemblyDef.Load(directory);
            try { FakeAttribute.Execute(module); }
            catch (Exception e) { Console.WriteLine($"Error while trying to remove FakeAttribute ." + e); }

            string text = Path.GetDirectoryName(directory);
            if (!text.EndsWith("\\"))
            {
                text += "\\";
            }
            string filename = string.Format("{0}{1}_Rem{2}", text, Path.GetFileNameWithoutExtension(directory), Path.GetExtension(directory));
            ModuleWriterOptions writerOptions = new ModuleWriterOptions(module);
            writerOptions.MetaDataOptions.Flags |= MetaDataFlags.PreserveAll;
            writerOptions.Logger = DummyLogger.NoThrowInstance;
            NativeModuleWriterOptions NativewriterOptions = new NativeModuleWriterOptions(module);
            NativewriterOptions.MetaDataOptions.Flags |= MetaDataFlags.PreserveAll;
            NativewriterOptions.Logger = DummyLogger.NoThrowInstance;
            if (module.IsILOnly) { module.Write(filename, writerOptions); } else { module.NativeWrite(filename, NativewriterOptions); }

            Console.WriteLine($"File Saved at : {filename}");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
