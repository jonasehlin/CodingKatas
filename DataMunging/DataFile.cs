using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataMunging
{
	public class DataFile
	{
		public List<string> Columns => new List<string>();
		public List<DataRow> Rows => new List<DataRow>();

		public void LoadFromString(string data)
		{
			Load(new StringReader(data));
		}

		public void Load(TextReader reader)
		{
			while (reader.Peek() >= 0)
			{
				ReadColumns(reader.ReadLine());
			}
		}

		private void ReadColumns(string line)
		{
			Columns.Clear();
			while (ReadText(line, out string column))
			{
				Columns.Add(column);
				line = line.Substring(column.Length);
			}
		}

		private bool ReadText(string line, out string column)
		{
			column = null;

			if (line == null)
				return false;

			var sb = new StringBuilder();
			bool leadingWhitespace = true;
			foreach (var ch in line)
			{
				if (char.IsWhiteSpace(ch))
				{
					if (!leadingWhitespace)
						break;
				}
				else
				{
					sb.Append(ch);
					leadingWhitespace = false;
				}
			}

			if (sb.Length > 0)
				column = sb.ToString();

			return column != null;
		}
	}
}
