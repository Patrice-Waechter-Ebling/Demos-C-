using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreateurProjetsCSharp
{
    public partial class Form1 : Form
    {
        public static string sDate() {
            string jour = null;
            string mois = null;
            if (DateTime.Now.Day < 10)
            {
                jour = $"0{DateTime.Now.Day}";
            }
            else
            {
                jour = $"{DateTime.Now.Day}";

            }
            if (DateTime.Now.Month < 10)
            {
                mois = $"0{DateTime.Now.Month}";
            }
            else
            {
                mois = $"{DateTime.Now.Month}";

            }
            return $"{DateTime.Now.Year}{mois}{jour}";
        } 
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = sDate();
            this.Text = $"Créateur de projets CSharp [{linkLabel1.Text}]";
            textBox3.Text = Environment.CurrentDirectory;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
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
                this.Text = $"Créateur de projets CSharp [{linkLabel1.Text}] [{textBox1.Text}]";
                textBox3.Text = Environment.CurrentDirectory + "\\" + textBox2.Text + "\\";
                linkLabel2.Enabled = true;
            }
            else {
                linkLabel2.Enabled = false; //evite de creer des projets sans titre
            }
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.AllowQuit) Application.Exit();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Directory.CreateDirectory(textBox3.Text);
            EcrireProjet();
            EcrireSolution();
            EcrireCodeCS();
            EcrireAssembly();

        }
        private void EcrireProjet()
        {
            string fileName = textBox3.Text + textBox6.Text;
            toolStripStatusLabel1.Text = $"Écriture de {fileName} commencée {DateTime.Today}";
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.CreateNew);
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 512))
                {
                    writer.Write("	<?xml version=\"1.0\" encoding=\"utf-8\"?>\n");
                    writer.Write("<Project ToolsVersion=\"3.5\" DefaultTargets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">\n");
                    writer.Write("  <PropertyGroup>\n");
                    writer.Write("    <Configuration Condition=\" '$(Configuration)' == '' \">Debug</Configuration>\n");
                    writer.Write("    <Platform Condition=\" '$(Platform)' == '' \">AnyCPU</Platform>\n");
                    writer.Write("    <ProductVersion>9.0.21022</ProductVersion>\n");
                    writer.Write("    <SchemaVersion>2.0</SchemaVersion>\n");
                    writer.Write("    <ProjectGuid>{6FBE3CE0-B772-436E-A9C0-81090C8CBE93}</ProjectGuid>\n");
                    writer.Write("    <OutputType>Exe</OutputType>\n");
                    writer.Write("    <AppDesignerFolder>Properties</AppDesignerFolder>\n");
                    writer.Write("    <RootNamespace>" + textBox1.Text + "</RootNamespace>\n");
                    writer.Write("    <AssemblyName>" + textBox1.Text + "</AssemblyName>\n");
                    writer.Write("    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>\n");
                    writer.Write("    <FileAlignment>512</FileAlignment>\n");
                    writer.Write("  </PropertyGroup>\n");
                    writer.Write("  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' \">\n");
                    writer.Write("    <DebugSymbols>true</DebugSymbols>\n");
                    writer.Write("    <DebugType>full</DebugType>\n");
                    writer.Write("    <Optimize>false</Optimize>\n");
                    writer.Write("    <OutputPath>Debug\\</OutputPath>\n");
                    writer.Write("    <DefineConstants>DEBUG;TRACE</DefineConstants>\n");
                    writer.Write("    <ErrorReport>prompt</ErrorReport>\n");
                    writer.Write("    <WarningLevel>4</WarningLevel>\n");
                    writer.Write("  </PropertyGroup>\n");
                    writer.Write("  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' \">\n");
                    writer.Write("    <DebugType>pdbonly</DebugType>\n");
                    writer.Write("    <Optimize>true</Optimize>\n");
                    writer.Write("    <OutputPath>Release\\</OutputPath>\n");
                    writer.Write("    <DefineConstants>TRACE</DefineConstants>\n");
                    writer.Write("    <ErrorReport>prompt</ErrorReport>\n");
                    writer.Write("    <WarningLevel>4</WarningLevel>\n");
                    writer.Write("  </PropertyGroup>\n");
                    writer.Write("  <ItemGroup>\n");
                    writer.Write("    <Reference Include=\"System\" />\n");
                    writer.Write("    <Reference Include=\"System.Core\">\n");
                    writer.Write("      <RequiredTargetFramework>3.5</RequiredTargetFramework>\n");
                    writer.Write("    </Reference>\n");
                    writer.Write("    <Reference Include=\"System.Xml.Linq\">\n");
                    writer.Write("      <RequiredTargetFramework>3.5</RequiredTargetFramework>\n");
                    writer.Write("    </Reference>\n");
                    writer.Write("    <Reference Include=\"System.Data.DataSetExtensions\">\n");
                    writer.Write("      <RequiredTargetFramework>3.5</RequiredTargetFramework>\n");
                    writer.Write("    </Reference>\n");
                    writer.Write("    <Reference Include=\"System.Data\" />\n");
                    writer.Write("    <Reference Include=\"System.Xml\" />\n");
                    writer.Write("  </ItemGroup>\n");
                    writer.Write("  <ItemGroup>\n");
                    writer.Write("    <Compile Include=\"" + textBox1.Text + ".cs\" />\n");
                    writer.Write("    <Compile Include=\"AssemblyInfo.cs\" />\n");
                    writer.Write("  </ItemGroup>\n");
                    writer.Write("  <Import Project=\"$(MSBuildToolsPath)\\Microsoft.CSharp.targets\" />\n");
                    writer.Write("  <!-- Créé par CreateurProjetsCSharp Développé par Patrice Waechter-Ebling v:1.01c. 2022\n");
                    writer.Write("  <Target Name=\"BeforeBuild\">\n");
                    writer.Write("  </Target>\n");
                    writer.Write("  <Target Name=\"AfterBuild\">\n");
                    writer.Write("  </Target>\n");
                    writer.Write("  -->\n");
                    writer.Write("</Project>\n");
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
            toolStripStatusLabel1.Text = $"Écriture de {fileName} terminée {DateTime.Today}";

        }
        private void EcrireSolution()
        {
            string fileName = textBox3.Text + textBox5.Text;
            toolStripStatusLabel1.Text = $"Écriture de {fileName} commencée {DateTime.Today}";
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.CreateNew);
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 512))
                {
                    writer.Write("Microsoft Visual Studio Solution File, Format Version 12.00\n"); //respect compatibilité Visual Studio 2008 a 2015
	                writer.Write("# Visual Studio Version 17\n");
	                writer.Write("VisualStudioVersion = 17.0.32014.148\n");
	                writer.Write("MinimumVisualStudioVersion = 10.0.40219.1\n"); // rejete VS2005 bug erreur CS3125
	                writer.Write("Project(\"{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}\") =\""+textBox1.Text+"\",\""+textBox6.Text+"\",\"{FCAFFB1D-BA84-45B7-931E-2BD709407AB4}\"\n");
	                writer.Write("EndProject\n");
	                writer.Write("Global\n");
	                writer.Write("	GlobalSection(SolutionConfigurationPlatforms) = preSolution\n");
	                writer.Write("		Debug|Any CPU = Debug|Any CPU\n");
	                writer.Write("		Release|Any CPU = Release|Any CPU\n");
	                writer.Write("	EndGlobalSection\n");
	                writer.Write("	GlobalSection(ProjectConfigurationPlatforms) = postSolution\n");
	                writer.Write("		{FCAFFB1D-BA84-45B7-931E-2BD709407AB4}.Debug|Any CPU.ActiveCfg = Debug|Any CPU\n");
	                writer.Write("		{FCAFFB1D-BA84-45B7-931E-2BD709407AB4}.Debug|Any CPU.Build.0 = Debug|Any CPU\n");
	                writer.Write("		{FCAFFB1D-BA84-45B7-931E-2BD709407AB4}.Release|Any CPU.ActiveCfg = Release|Any CPU\n");
	                writer.Write("		{FCAFFB1D-BA84-45B7-931E-2BD709407AB4}.Release|Any CPU.Build.0 = Release|Any CPU\n");
	                writer.Write("	EndGlobalSection\n");
	                writer.Write("	GlobalSection(SolutionProperties) = preSolution\n");
	                writer.Write("		HideSolutionNode = FALSE\n");
	                writer.Write("	EndGlobalSection\n");
	                writer.Write("	GlobalSection(ExtensibilityGlobals) = postSolution\n");
	                writer.Write("		SolutionGuid = {49FF3C34-C87E-414D-8C59-13E9D9BB8D4A}\n");
	                writer.Write("	EndGlobalSection\n");
	                writer.Write("EndGlobal\n");
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
            toolStripStatusLabel1.Text = $"Écriture de {fileName} terminée {DateTime.Today}";

        }
        private void EcrireCodeCS()
        {
            string fileName = textBox3.Text + textBox4.Text; 
            toolStripStatusLabel1.Text = $"Écriture de {fileName} commencée {DateTime.Today}";
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.CreateNew);
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 512))
                {
                    writer.Write("/*********************************************\n");
                    writer.Write("*\n");
                    writer.Write($"* Projet généré avec {Application.ProductName} v:{Application.ProductVersion}\n");
                    writer.Write("*  Module:  "+textBox1.Text+"\n");
                    writer.Write("* Développé par Patrice Waechter-Ebling 2022\n");
                    writer.Write("*\n");
                    writer.Write(" **********************************************/\n");
                    writer.Write("using System;\n");
                    writer.Write("using System.Collections.Generic;\n");
                    writer.Write("using System.Linq;\n");
                    writer.Write("using System.Text;\n");
                    writer.Write("namespace "+textBox1.Text.ToUpper()+"{");
                    writer.Write("    internal class Program  {\n");
                    writer.Write("        static void Main(string[] args){\n");
                    writer.WriteLine(this.richTextBox1.Text);
                    writer.Write("		 Console.WriteLine(\"Appuyez une touche pour quitter\");Console.Read(); // informe l'utilisateur de presser une touche pour fermer la console\n");
                    writer.Write("		}\n");
                    writer.Write("    }\n");
                    writer.Write("}\n");
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
            toolStripStatusLabel1.Text = $"Écriture de {fileName} terminée {DateTime.Today}";
        }
        private void EcrireAssembly()
        {
            string fileName = textBox3.Text + "AssemblyInfo.cs";
            toolStripStatusLabel1.Text = $"Écriture de {fileName} commencée {DateTime.Today}";
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.CreateNew);
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 512))
                {
                    writer.Write("");
                    writer.Write("using System.Reflection;\n");
                    writer.Write("using System.Runtime.CompilerServices;\n");
                    writer.Write("using System.Runtime.InteropServices;\n");
                    writer.Write("[assembly: AssemblyTitle(\""+textBox1.Text+"\")]\n");
                    writer.Write("[assembly: AssemblyDescription(\"Code Généré par CreateurProjetsCSharp 1.01c\")]\n");
                    writer.Write("[assembly: AssemblyConfiguration(\"\")]\n");
                    writer.Write("[assembly: AssemblyCompany(\"patrice@divano.dev\")]\n");
                    writer.Write("[assembly: AssemblyProduct(\""+textBox1.Text+"\")]\n");
                    writer.Write("[assembly: AssemblyCopyright(\"Copyright © Patrice Waechter-Ebling 2022\")]\n");
                    writer.Write("[assembly: AssemblyTrademark(\"Patrice Waechter-Ebling\")]\n");
                    writer.Write("[assembly: AssemblyCulture(\"\")]\n");
                    writer.Write("[assembly: ComVisible(false)]\n");
                    writer.Write("[assembly: Guid(\"bc2e14b6-ee71-43bc-ab30-470be23cc3c1\")]\n");
                    writer.Write("[assembly: AssemblyVersion(\"1.0.1.3\")]\n");
                    writer.Write("[assembly: AssemblyFileVersion(\"1.0.1.3\")]\n");
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
            toolStripStatusLabel1.Text = $"Écriture de {fileName} terminée {DateTime.Today}";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = textBox2.Text;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = textBox3.Text;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Êtes vous sur de vouloir quiter ce programme?";
            DialogResult result = MessageBox.Show(message, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            const string message = "Petit comique me cliquer sur la figure\nce n'est pas ici la surprise";
            DialogResult result = MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = $"{Application.ProductName} a été codé en CSharp\nVersion: 1.0.1.3 (C)\n© Patrice Waechter-Ebling 2022\nÉtudiant\tAEC Soutient Informatique";
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
    }
}
