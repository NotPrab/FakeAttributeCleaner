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
                        if (type.FullName == "ConfusedByAttribute")
                        {
                            module.Types.Remove(type);
                            module.CustomAttributes.Remove(attribute);
                            j++;
                        }
						if (type.FullName == "ZYXDNGuarder")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "YanoAttribute")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "Xenocode.Client.Attributes.AssemblyAttributes.ProcessedByXenocode")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "SmartAssembly.Attributes.PoweredByAttribute")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "SecureTeam.Attributes.ObfuscatedByAgileDotNetAttribute")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "SecureTeam.Attributes.ObfuscatedByCliSecureAttribute")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "ObfuscatedByGoliath")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "NineRays.Obfuscator.SoftwareWatermarkAttribute")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "NineRays.Obfuscator.Evaluation")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "EMyPID_8234_")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "DotfuscatorAttribute")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "CryptoObfuscator.ProtectedWithCryptoObfuscatorAttribute")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "BabelObfuscatorAttribute")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == ".NETGuard")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "OrangeHeapAttribute")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "<ObfuscatedByDotNetPatcher>")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "BabelObfuscatorAttribute")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "ProtectedWithCryptoObfuscatorAttribute")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "ObfuscatedByGoliath")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "YanoAttribute")
						{
							module.Types.Remove(type);
							module.CustomAttributes.Remove(attribute);
							j++;
						}
						if (type.FullName == "ZYXDNGuarder")
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
