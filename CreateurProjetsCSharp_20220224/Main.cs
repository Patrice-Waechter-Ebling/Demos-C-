using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace CreateurProjetsCSharp_V1._014
{
    public partial class Main : Form
    {
        public static string sDate() 
        {
            string jour = null;
            string mois = null;
            if (DateTime.Now.Day < 10){jour = "0"+DateTime.Now.Day;}else{jour = DateTime.Now.Day.ToString();}
            if (DateTime.Now.Month < 10){mois = "0"+DateTime.Now.Month;}else{mois = DateTime.Now.Month.ToString();}
            return jour+"/"+mois+"/"+DateTime.Now.Year;
        }
        private void EcrireProjetVS2008()
        {
            string fileName = textBox3.Text + textBox1.Text + "_VS2008.csproj";
            toolStripStatusLabel1.Text = "Écriture de " + fileName + " commencée " + DateTime.Today;
            FileStream fs = null;
            try
            {

                fs = new FileStream(fileName, FileMode.OpenOrCreate);
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 512))
                {
                    writer.WriteLine("	<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                    writer.WriteLine("<Project ToolsVersion=\"3.5\" DefaultTargets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">");
                    writer.WriteLine("  <PropertyGroup>");
                    writer.WriteLine("    <Configuration Condition=\" '$(Configuration)' == '' \">Debug</Configuration>");
                    writer.WriteLine("    <Platform Condition=\" '$(Platform)' == '' \">AnyCPU</Platform>");
                    writer.WriteLine("    <ProductVersion>9.0.21022</ProductVersion>");
                    writer.WriteLine("    <SchemaVersion>2.0</SchemaVersion>");
                    writer.WriteLine("    <ProjectGuid>{6FBE3CE0-B772-436E-A9C0-81090C8CBE93}</ProjectGuid>");
                    writer.WriteLine("    <OutputType>Exe</OutputType>");
                    writer.WriteLine("    <AppDesignerFolder>Properties</AppDesignerFolder>");
                    writer.WriteLine("    <RootNamespace>" + textBox1.Text + "</RootNamespace>");
                    writer.WriteLine("    <AssemblyName>" + textBox1.Text + "</AssemblyName>");
                    writer.WriteLine("    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>");
                    writer.WriteLine("    <FileAlignment>512</FileAlignment>");
                    writer.WriteLine("  </PropertyGroup>");
                    writer.WriteLine("  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' \">");
                    writer.WriteLine("    <DebugSymbols>true</DebugSymbols>");
                    writer.WriteLine("    <DebugType>full</DebugType>");
                    writer.WriteLine("    <Optimize>false</Optimize>");
                    writer.WriteLine("    <OutputPath>Debug\\</OutputPath>");
                    writer.WriteLine("    <DefineConstants>DEBUG;TRACE</DefineConstants>");
                    writer.WriteLine("    <ErrorReport>prompt</ErrorReport>");
                    writer.WriteLine("    <WarningLevel>4</WarningLevel>");
                    writer.WriteLine("  </PropertyGroup>");
                    writer.WriteLine("  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' \">");
                    writer.WriteLine("    <DebugType>pdbonly</DebugType>");
                    writer.WriteLine("    <Optimize>true</Optimize>");
                    writer.WriteLine("    <OutputPath>Release\\</OutputPath>");
                    writer.WriteLine("    <DefineConstants>TRACE</DefineConstants>");
                    writer.WriteLine("    <ErrorReport>prompt</ErrorReport>");
                    writer.WriteLine("    <WarningLevel>4</WarningLevel>");
                    writer.WriteLine("  </PropertyGroup>");
                    writer.WriteLine("  <ItemGroup>");
                    writer.WriteLine("    <Reference Include=\"System\" />");
                    writer.WriteLine("    <Reference Include=\"System.Core\">");
                    writer.WriteLine("      <RequiredTargetFramework>3.5</RequiredTargetFramework>");
                    writer.WriteLine("    </Reference>");
                    writer.WriteLine("    <Reference Include=\"System.Xml.Linq\">");
                    writer.WriteLine("      <RequiredTargetFramework>3.5</RequiredTargetFramework>");
                    writer.WriteLine("    </Reference>");
                    writer.WriteLine("    <Reference Include=\"System.Data.DataSetExtensions\">");
                    writer.WriteLine("      <RequiredTargetFramework>3.5</RequiredTargetFramework>");
                    writer.WriteLine("    </Reference>");
                    writer.WriteLine("    <Reference Include=\"System.Data\" />");
                    writer.WriteLine("    <Reference Include=\"System.Xml\" />");
                    writer.WriteLine("  </ItemGroup>");
                    writer.WriteLine("  <ItemGroup>");
                    writer.WriteLine("    <Compile Include=\"" + textBox1.Text + ".cs\" />");
                    writer.WriteLine("    <Compile Include=\"AssemblyInfo.cs\" />");
                    writer.WriteLine("  </ItemGroup>");
                    writer.WriteLine("  <Import Project=\"$(MSBuildToolsPath)\\Microsoft.CSharp.targets\" />");
                    writer.WriteLine("  <!-- Créé par CreateurProjetsCSharp Développé par Patrice Waechter-Ebling v:1.01c. 2022");
                    writer.WriteLine("  <Target Name=\"BeforeBuild\">");
                    writer.WriteLine("  </Target>");
                    writer.WriteLine("  <Target Name=\"AfterBuild\">");
                    writer.WriteLine("  </Target>");
                    writer.WriteLine("  -->");
                    writer.WriteLine("</Project>");

                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
            toolStripStatusLabel1.Text = "Écriture de " + fileName + " terminée " + DateTime.Today;

        }
        private void EcrireProjet()//VS2019 && VS2022
        {
            string fileName = textBox3.Text + textBox6.Text;
            toolStripStatusLabel1.Text = "Écriture de " + fileName + " commencée " + DateTime.Today;
            FileStream fs = null;
            try
            {

                fs = new FileStream(fileName, FileMode.OpenOrCreate);
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 512))
                {
                    writer.WriteLine("<Project Sdk =\"Microsoft.NET.Sdk\">");
                    writer.WriteLine("   <PropertyGroup>");
                    writer.WriteLine("     <OutputType>Exe</OutputType>");
                    writer.WriteLine("     <TargetFramework>netcoreapp3.1</TargetFramework>");
                    writer.WriteLine("        <RootNamespace>"+textBox1.Text.ToUpper()+"</RootNamespace>");
                    writer.WriteLine("      </PropertyGroup>");
                    writer.WriteLine("    </Project>");
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
            toolStripStatusLabel1.Text = "Écriture de " + fileName + " terminée " + DateTime.Today;

        }
        private void EcrireSolution()
        {
            string fileName = textBox3.Text + textBox5.Text;
            toolStripStatusLabel1.Text = "Écriture de "+fileName+" commencée "+DateTime.Today;
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate);
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 512))
                {
                    writer.WriteLine("Microsoft Visual Studio Solution File, Format Version 12.00"); //respect compatibilité Visual Studio 2008 a 2015
	                writer.WriteLine("# Visual Studio Version 17");
	                writer.WriteLine("VisualStudioVersion = 17.0.32014.148");
	                writer.WriteLine("MinimumVisualStudioVersion = 10.0.40219.1"); // rejete VS2005 bug erreur CS3125
	                writer.WriteLine("Project(\"{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}\") =\""+textBox1.Text+"\",\""+textBox6.Text+"\",\"{FCAFFB1D-BA84-45B7-931E-2BD709407AB4}\"");
	                writer.WriteLine("EndProject");
	                writer.WriteLine("Global");
	                writer.WriteLine("	GlobalSection(SolutionConfigurationPlatforms) = preSolution");
	                writer.WriteLine("		Debug|Any CPU = Debug|Any CPU");
	                writer.WriteLine("		Release|Any CPU = Release|Any CPU");
	                writer.WriteLine("	EndGlobalSection");
	                writer.WriteLine("	GlobalSection(ProjectConfigurationPlatforms) = postSolution");
	                writer.WriteLine("		{FCAFFB1D-BA84-45B7-931E-2BD709407AB4}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
	                writer.WriteLine("		{FCAFFB1D-BA84-45B7-931E-2BD709407AB4}.Debug|Any CPU.Build.0 = Debug|Any CPU");
	                writer.WriteLine("		{FCAFFB1D-BA84-45B7-931E-2BD709407AB4}.Release|Any CPU.ActiveCfg = Release|Any CPU");
	                writer.WriteLine("		{FCAFFB1D-BA84-45B7-931E-2BD709407AB4}.Release|Any CPU.Build.0 = Release|Any CPU");
	                writer.WriteLine("	EndGlobalSection");
	                writer.WriteLine("	GlobalSection(SolutionProperties) = preSolution");
	                writer.WriteLine("		HideSolutionNode = FALSE");
	                writer.WriteLine("	EndGlobalSection");
	                writer.WriteLine("	GlobalSection(ExtensibilityGlobals) = postSolution");
	                writer.WriteLine("		SolutionGuid = {49FF3C34-C87E-414D-8C59-13E9D9BB8D4A}");
	                writer.WriteLine("	EndGlobalSection");
	                writer.WriteLine("EndGlobal");
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
            toolStripStatusLabel1.Text = "Écriture de "+fileName+" terminée "+DateTime.Today;

        }
        private void EcrireCodeCS()
        {
            string fileName = textBox3.Text + textBox4.Text;
            toolStripStatusLabel1.Text = "Écriture de " + fileName + " commencée " + DateTime.Today;
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate);
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 512))
                {
                    writer.WriteLine("/*********************************************");
                    writer.WriteLine("*");
                    writer.WriteLine("* Projet généré avec " + Application.ProductName + " v:" + Application.ProductVersion);
                    writer.WriteLine("*  Module:  " + textBox1.Text + "");
                    writer.WriteLine("* Développé par Patrice Waechter-Ebling 2022");
                    writer.WriteLine("*");
                    writer.WriteLine(" **********************************************/\n");
                    writer.WriteLine("using System;");
                    writer.WriteLine("using System.Collections.Generic;");
                    writer.WriteLine("using System.Linq;");
                    writer.WriteLine("using System.Text;");
                    writer.WriteLine("namespace " + textBox1.Text.ToUpper() + "\n{");
                    writer.WriteLine("    internal class Program  \n{");
                    writer.WriteLine("        static void Main(string[] args)\n{");
                    writer.WriteLine(this.richTextBox1.Text);
                    writer.WriteLine("		 Console.WriteLine(\"Appuyez une touche pour quitter\");Console.Read(); // informe l'utilisateur de presser une touche pour fermer la console");
                    writer.WriteLine("		}");
                    writer.WriteLine("    }");
                    writer.WriteLine("}");
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
            toolStripStatusLabel1.Text = "Écriture de " + fileName + " terminée " + DateTime.Today;
        }
        private void EcrireCodeCSV2()
        {
            string fileName = textBox3.Text + textBox4.Text;
            toolStripStatusLabel1.Text = "Écriture de " + fileName + " commencée " + DateTime.Today;
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate);
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 512))
                {
                    writer.WriteLine("/*********************************************");
                    writer.WriteLine("*");
                    writer.WriteLine("* Projet généré avec " + Application.ProductName + " v:" + Application.ProductVersion);
                    writer.WriteLine("*  Module:  " + textBox1.Text + "");
                    writer.WriteLine("* Développé par Patrice Waechter-Ebling 2022\t beta ");
                    writer.WriteLine("*");
                    writer.WriteLine(" **********************************************/\n");
                    writer.WriteLine("using System;");
                    writer.WriteLine("using System.Collections.Generic;");
                    writer.WriteLine("using System.Linq;");
                    writer.WriteLine("using System.Text;");
                    writer.WriteLine("using System.Reflection;");
                    writer.WriteLine("using System.Runtime.CompilerServices;");
                    writer.WriteLine("using System.Runtime.InteropServices;");
                    writer.WriteLine("\n[assembly: AssemblyTitle(\"" + textBox1.Text + "\")]");
                    writer.WriteLine("[assembly: AssemblyDescription(\"Code Généré par CreateurProjetsCSharp 1.01c\")]");
                    writer.WriteLine("[assembly: AssemblyConfiguration(\"\")]");
                    writer.WriteLine("[assembly: AssemblyCompany(\"patrice@divano.dev\")]");
                    writer.WriteLine("[assembly: AssemblyProduct(\"" + textBox1.Text + "\")]");
                    writer.WriteLine("[assembly: AssemblyCopyright(\"Copyright © Patrice Waechter-Ebling 2022\")]");
                    writer.WriteLine("[assembly: AssemblyTrademark(\"Patrice Waechter-Ebling\")]");
                    writer.WriteLine("[assembly: AssemblyCulture(\"\")]");
                    writer.WriteLine("[assembly: ComVisible(false)]");
                    writer.WriteLine("[assembly: Guid(\"bc2e14b6-ee71-43bc-ab30-470be23cc3c1\")]");
                    writer.WriteLine("[assembly: AssemblyVersion(\"1.0.1.3\")]");
                    writer.WriteLine("[assembly: AssemblyFileVersion(\"1.0.1.3\")]");
                    writer.WriteLine("\nnamespace " + textBox1.Text.ToUpper() + "\n{");
                    writer.WriteLine("    internal class Program  \n\t{");
                    writer.WriteLine("        static void Main(string[] args)\n\t\t{");
                    writer.WriteLine(this.richTextBox1.Text);
                    writer.WriteLine("		 Console.WriteLine(\"Appuyez une touche pour quitter\");Console.Read(); // informe l'utilisateur de presser une touche pour fermer la console");
                    writer.WriteLine("		}");
                    writer.WriteLine("    }");
                    writer.WriteLine("}");
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
            toolStripStatusLabel1.Text = "Écriture de " + fileName + " terminée " + DateTime.Today;
        }
        private void EcrireAssembly()
        {
            string fileName = textBox3.Text + "AssemblyInfo.cs";
            toolStripStatusLabel1.Text = "Écriture de "+fileName+" commencée "+DateTime.Today;
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate);
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 512))
                {
                    writer.WriteLine("using System.Reflection;");
                    writer.WriteLine("using System.Runtime.CompilerServices;");
                    writer.WriteLine("using System.Runtime.InteropServices;");
                    writer.WriteLine("[assembly: AssemblyTitle(\""+textBox1.Text+"\")]");
                    writer.WriteLine("[assembly: AssemblyDescription(\"Code Généré par CreateurProjetsCSharp 1.01c\")]");
                    writer.WriteLine("[assembly: AssemblyConfiguration(\"\")]");
                    writer.WriteLine("[assembly: AssemblyCompany(\"patrice@divano.dev\")]");
                    writer.WriteLine("[assembly: AssemblyProduct(\""+textBox1.Text+"\")]");
                    writer.WriteLine("[assembly: AssemblyCopyright(\"Copyright © Patrice Waechter-Ebling 2022\")]");
                    writer.WriteLine("[assembly: AssemblyTrademark(\"Patrice Waechter-Ebling\")]");
                    writer.WriteLine("[assembly: AssemblyCulture(\"\")]");
                    writer.WriteLine("[assembly: ComVisible(false)]");
                    writer.WriteLine("[assembly: Guid(\"bc2e14b6-ee71-43bc-ab30-470be23cc3c1\")]");
                    writer.WriteLine("[assembly: AssemblyVersion(\"1.0.1.3\")]");
                    writer.WriteLine("[assembly: AssemblyFileVersion(\"1.0.1.3\")]");
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
            toolStripStatusLabel1.Text = "Écriture de "+fileName+" terminée "+DateTime.Today;
        }
        public static string DossiersVisualStudio()
        {
           return  "C:\\Users\\" + Environment.UserName+"\\source\\repos";
        }
        public Main()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            linkLabel1.Text =Convert.ToString(DateTime.Now).Replace(":","").Replace("-","").Replace(" ","_") ;
            toolStripStatusLabel2.Text =sDate() ;
            this.Text = "Créateur de projets CSharp ["+linkLabel1.Text+"]";
            textBox3.Text = Environment.CurrentDirectory;
            linkLabel2.Enabled = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Êtes vous sur de vouloir quiter ce programme?";
            DialogResult result = MessageBox.Show(message, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (char.IsDigit(textBox1.Text[0]) == true)
                {
                    textBox2.Text = "C_" + textBox1.Text + "_" + linkLabel1.Text;
                }
                textBox2.Text = textBox1.Text + "_" + linkLabel1.Text;
                textBox4.Text = textBox1.Text + ".cs";
                textBox6.Text = textBox1.Text + ".csproj";
                textBox5.Text = textBox1.Text + ".sln";
                this.Text = "Créateur de projets CSharp ["+linkLabel1.Text+"] ["+textBox1.Text+"]";
                textBox3.Text = Environment.CurrentDirectory + "\\" + textBox2.Text + "\\";
                button2.Enabled = true;
            }
            else {
                button2.Enabled = false; //evite de creer des projets sans titre
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            const string message = "Petit comique me cliquer sur la figure\nce n'est pas ici la surprise";
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = textBox3.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0) 
            {
                const string message = "Le contenu de la zone de saisie est vide\nEst ce volontaire?";
                DialogResult result = MessageBox.Show(message, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    richTextBox1.Text = "// Zone de saisie vide conformément à votre choix";
                }
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox3.Text = DossiersVisualStudio() + "\\" + textBox2.Text + "\\";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string compilerFileName = Environment.CurrentDirectory + "\\Compilateur\\csc.exe";
            string compilerArguments = "/r:System.dll /out:" + textBox2.Text + ".exe " + textBox3.Text + textBox4.Text;
            CreateurProjetsCSharp_V1._014.MonProcessus.ShellExecute(compilerFileName, compilerArguments);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Application.AllowQuit) Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = Application.ProductName + " a été codé en CSharp\nVersion: 1.0.1.4 (C)\n© Patrice Waechter-Ebling 2022\nÉtudiant\tAEC Soutient Informatique\n\n.NET version " +
            Environment.Version + "\n Utilisateur: " + Environment.UserName + "@" + Environment.UserDomainName;
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(textBox3.Text);
            EcrireProjet();
            EcrireSolution();
            EcrireCodeCS();
            EcrireAssembly();
            button4.Enabled = true;
            linkLabel2.Enabled = true;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateurProjetsCSharp_V1._014.MonProcessus.ShellExecute(textBox3.Text + textBox6.Text);
        }
    }
    class MonProcessus  //basé sur un exemple de Microsoft
    {
        public static void ShellExecute(string fichier, string arguments)
        {
            try
            {
                using (Process MonProcessus = new Process())
                {
                    MonProcessus.StartInfo.UseShellExecute = true;
                    MonProcessus.StartInfo.FileName = fichier;
                    MonProcessus.StartInfo.Arguments = arguments;
                    MonProcessus.StartInfo.CreateNoWindow = false ;
                    MonProcessus.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void ShellExecute(string fichier)
        {
            try
            {
                using (Process MonProcessus = new Process())
                {
                    MonProcessus.StartInfo.UseShellExecute = true;
                    MonProcessus.StartInfo.FileName = fichier;
                    MonProcessus.StartInfo.CreateNoWindow = false;
                    MonProcessus.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}
