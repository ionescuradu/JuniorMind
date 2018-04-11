using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TcpApp1
{
    class TextBoxStreamWriter : TextWriter
    {
        TextBox output = null;

        public TextBoxStreamWriter(TextBox output)
        {
            this.output = output;
        }

        public override void Write(char value)
        {
            base.Write(value);
            output.AppendText(value.ToString());
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}
