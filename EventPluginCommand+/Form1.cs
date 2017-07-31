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
using System.Xml.Linq;

namespace EventPluginCommand_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, List<string>> pluginsCommands = new Dictionary<string, List<string>>();

        List<PluginModule> pluginsM = new List<PluginModule>();

        List<Label> labelNames = new List<Label>();
        List<TextBox> textboxContents = new List<TextBox>();

        PluginModule plugin
        {
            get
            {
                return this.pluginsM.Find(p => { return p.name == this.comboBoxPlugin.Text; });
            }
        }
        CommandModule command
        {
            get
            {
                return this.plugin.content.Find(c => { return c.name == this.comboBoxCommand.Text; });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] inf = dir.GetFiles();
            foreach (FileInfo finf in inf)
            {
                
                if (finf.Extension.Equals(".xml"))
                {
                    XElement xe = XElement.Load(finf.FullName);
                    IEnumerable<XElement> plugins = from ele in xe.Elements("plugin") select ele;

                    foreach(XElement pe in plugins)
                    {
                        PluginModule p = new PluginModule();
                        p.name = pe.Attribute("name").Value;
                        p.note = pe.Attribute("note").Value;
                        p.text = pe.Attribute("text").Value;

                        IEnumerable<XElement> commands = from ele in pe.Elements("command") select ele;
                        foreach(XElement ce in commands)
                        {
                            CommandModule c = new CommandModule();
                            c.name = ce.Attribute("name").Value;
                            c.note = ce.Attribute("note").Value;
                            c.text = ce.Attribute("text").Value;

                            IEnumerable<XElement> parameters = from ele in ce.Elements("parameter") select ele;
                            foreach(XElement pae in parameters)
                            {
                                ParameterModule pa = new ParameterModule();
                                pa.name = pae.Attribute("name").Value;
                                pa.note = pae.Attribute("note").Value;

                                c.content.Add(pa);
                            }

                            p.content.Add(c);
                        }

                        this.pluginsM.Add(p);
                    }
                }
            }

            List<string> splugins = new List<string>();
            this.comboBoxPlugin.Items.Clear();
            this.pluginsM.ForEach(p => this.comboBoxPlugin.Items.Add(p.name));

        }

        private void comboBoxPlugin_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxCommand.Items.Clear();
            this.plugin.content.ForEach(c => this.comboBoxCommand.Items.Add(c.name));
            
        }

        private void comboBoxCommand_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.labelNames.Clear();
            this.textboxContents.Clear();
            this.groupBoxParameters.Controls.Clear();
            for(int i=0;i<command.content.Count;i++)
            {
                ParameterModule parameter = command.content[i];
                Label labelName = new Label();
                TextBox textboxContent = new TextBox();

                this.groupBoxParameters.Controls.Add(labelName);
                labelName.Text = command.content[i].name;
                labelName.Location = new Point(20, 20 + i * (textboxContent.Height + 5));
                labelName.Show();

                this.labelNames.Add(labelName);

                

                this.groupBoxParameters.Controls.Add(textboxContent);
                textboxContent.TextChanged += (object senderT, EventArgs eT) =>
                  {
                      parameter.content = (senderT as TextBox).Text;
                  };
                textboxContent.Location = new Point(20+ labelName.Width + 5, 20 + i * (textboxContent.Height + 5));
                textboxContent.Show();

                this.textboxContents.Add(textboxContent);
            }

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            string scommand = @"[{""code"":356,""indent"":0,""parameters"":[""" + this.plugin.text + @" " + this.command.text;
            //+ this.Parameter1.Text;

            foreach(TextBox tb in this.textboxContents)
            {
                scommand += @" ";
                scommand += tb.Text;
            }

            scommand += @"""]}]";

            byte[] t = System.Text.Encoding.ASCII.GetBytes(scommand);

            MemoryStream b = new MemoryStream(t);
            Clipboard.SetData("application/rpgmv-EventCommand", b);

        }
    }
}
