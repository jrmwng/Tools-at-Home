using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace Paste_Text_to_Columns_with_RegEx
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        Regex m_regexRowToColumns;
        IList<string> m_listRegexHistory = new List<string>();
        int m_nRegexHistoryIndex = -1;

        private void buttonCompileRegEx_Click(object sender, EventArgs e)
        {
            TextBox textboxRegEx = this.textBoxRegEx;

            try
            {
                string strRegEx = textboxRegEx.Text;

                Regex regexRowToColumns = new Regex(strRegEx, RegexOptions.Compiled);

                this.textBoxCompiledRegEx.Text = regexRowToColumns.ToString();
                this.m_regexRowToColumns = regexRowToColumns;
                while (/*0 <= this.m_nRegexHistoryIndex &&*/ this.m_nRegexHistoryIndex + 1 < this.m_listRegexHistory.Count)
                {
                    this.m_listRegexHistory.RemoveAt(this.m_nRegexHistoryIndex + 1);
                }
                if (m_listRegexHistory.Count == 0 ||
                    m_listRegexHistory.Last().Equals(strRegEx) == false)
                {
                    this.m_listRegexHistory.Add(strRegEx);
                    this.m_nRegexHistoryIndex++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {

            try
            {
                Regex regexRowToColumns = m_regexRowToColumns;

                string strRow = this.textBoxRow.Text;

                MatchCollection collectionRowMatch = regexRowToColumns.Matches(strRow);

                foreach (Match matchRow in collectionRowMatch) // for each row
                {
                    this.textBoxTable.AppendText(string.Join("\t", matchRow.Groups.Values.Where(g => g.Value.Contains('\r') == false).Select(g => g.Value)));
                    this.textBoxTable.AppendText("\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEscapeRegEx_Click(object sender, EventArgs e)
        {
            TextBox textboxRegEx = this.textBoxRegEx;

            string strRegEx = textBoxRegEx.Text;
            {
                foreach (char cEscapeChar in new char[] { '\\', ':', '(', ')', '-', '$', '+', '.' })
                {
                    strRegEx = strRegEx.Replace("" + cEscapeChar, "\\" + cEscapeChar);
                }
            }

            this.textBoxRegEx.Text = strRegEx;
        }

        private void buttonUndoRegex_Click(object sender, EventArgs e)
        {
            if (0 < this.m_nRegexHistoryIndex)
            {
                this.textBoxRegEx.Text = this.m_listRegexHistory[--this.m_nRegexHistoryIndex];
            }
        }

        private void buttonRedoRegEx_Click(object sender, EventArgs e)
        {
            if (this.m_nRegexHistoryIndex + 1 < this.m_listRegexHistory.Count)
            {
                this.textBoxRegEx.Text = this.m_listRegexHistory[++this.m_nRegexHistoryIndex];
            }
        }
    }
}
