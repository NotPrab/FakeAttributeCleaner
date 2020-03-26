using System;
using dnlib.DotNet;

namespace FakeAttributeCleaner
{
    class FakeAttribute
    {
        public static void Execute(ModuleDefMD module)
        {
            int j = 0;
            for (int i = 0; i < module.CustomAttributes.Count; i++)
            {
				CustomAttribute attribute = module.CustomAttributes[i];
                bool flag = attribute == null;
                if (!flag)
                {
					TypeDef type = attribute.AttributeType.ResolveTypeDef();
					bool flag2 = type == null;
                    if (!flag2)
                    {
                        bool flag3 = type.FullName == "ConfusedByAttribute";
                        if (flag3)
                        {
                            module.Types.Remove(type);
                            module.CustomAttributes.Remove(attribute);
                            j++;
                        }
						bool flag4 = type.FullName == "ZYXDNGuarder";
						if (flag4)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag5 = type.FullName == "YanoAttribute";
						if (flag5)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag6 = type.FullName == "Xenocode.Client.Attributes.AssemblyAttributes.ProcessedByXenocode";
						if (flag6)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag7 = type.FullName == "SmartAssembly.Attributes.PoweredByAttribute";
						if (flag7)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag8 = type.FullName == "SecureTeam.Attributes.ObfuscatedByAgileDotNetAttribute";
						if (flag8)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag9 = type.FullName == "SecureTeam.Attributes.ObfuscatedByCliSecureAttribute";
						if (flag9)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag10 = type.FullName == "ObfuscatedByGoliath";
						if (flag10)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag11 = type.FullName == "NineRays.Obfuscator.SoftwareWatermarkAttribute";
						if (flag11)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag12 = type.FullName == "NineRays.Obfuscator.Evaluation";
						if (flag12)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag13 = type.FullName == "EMyPID_8234_";
						if (flag13)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag14 = type.FullName == "DotfuscatorAttribute";
						if (flag14)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag15 = type.FullName == "CryptoObfuscator.ProtectedWithCryptoObfuscatorAttribute";
						if (flag15)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag16 = type.FullName == "BabelObfuscatorAttribute";
						if (flag16)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag17 = type.FullName == ".NETGuard";
						if (flag17)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag18 = type.FullName == "OrangeHeapAttribute";
						if (flag18)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						bool flag19 = type.FullName == "<ObfuscatedByDotNetPatcher>";
						if (flag19)
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
					}
                }
            }
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("[+] Removed Fake Attribute {0}", j);
			Console.ForegroundColor = ConsoleColor.Yellow;
		}
    }
}
