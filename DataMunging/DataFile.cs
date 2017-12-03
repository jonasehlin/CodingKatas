using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataMunging
{
	public class DataFile
	{
		public readonly List<string> Columns = new List<string>();
		public readonly	List<DataRow> Rows = new List<DataRow>();

		public void LoadFromString(string data)
		{
			Load(new StringReader(data));
		}

		public void Load(TextReader reader)
		{
			if (reader.Peek() == 0)
				return;

			ReadColumns(reader.ReadLine());
			ReadRows(reader);
		}

		private void ReadColumns(string line)
		{
			Columns.Clear();
			while (ReadText(line, out string column))
			{
				Columns.Add(column.Trim());
				line = line.Substring(column.Length);
			}
		}

		private void ReadRows(TextReader reader)
		{
			Rows.Clear();
			while (reader.Peek() >= 0)
			{
				var dataRow = ReadRow(reader.ReadLine());
				if (dataRow != null && dataRow.Values.Count > 0)
					Rows.Add(dataRow);
			}
		}

		private DataRow ReadRow(string line)
		{
			var dataRow = new DataRow();
			while (ReadText(line, out string row))
			{
				dataRow.Values.Add(row.Trim());
				line = line.Substring(row.Length);
			}
			return dataRow;
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
					if (leadingWhitespace)
						sb.Append(ch);
					else
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
