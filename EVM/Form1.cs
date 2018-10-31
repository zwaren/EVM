using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Collections;

namespace EVM
{
	public partial class Form1 : Form
	{
		HashSet<string> terms;
		static string[] ABCD = { "A", "B", "C", "D" };

		public Form1()
		{
			InitializeComponent();
		}

		string createTerm(string[] raw_term)
		{
			var term = "----".ToArray();
			foreach (var j in raw_term)
			{
				switch (j)
				{
					case "A":
						term[0] = '1';
						break;
					case "(-A)":
						term[0] = '0';
						break;
					case "B":
						term[1] = '1';
						break;
					case "(-B)":
						term[1] = '0';
						break;
					case "C":
						term[2] = '1';
						break;
					case "(-C)":
						term[2] = '0';
						break;
					case "D":
						term[3] = '1';
						break;
					case "(-D)":
						term[3] = '0';
						break;
				}
			}
			return new string(term);
		}

		private void buttonDNF_Click(object sender, EventArgs e)
		{
			terms = new HashSet<string>();
			var raw_terms = textBox.Text.Split('+').Select(x => x.Trim()).ToArray();
			for (var i = 0; i < raw_terms.Length; i++)
			{
				terms.Add(createTerm(raw_terms[i].ToUpper().Split('*')));
				
			}
			draw(true);
		}

		private void buttonKNF_Click(object sender, EventArgs e)
		{
			terms = new HashSet<string>();
			var raw_terms = textBox.Text.Split('*').Select(x => x.Substring(1, x.Length-3)).ToArray();
			for (var i = 0; i < raw_terms.Length; i++)
			{
				terms.Add(createTerm(raw_terms[i].ToUpper().Split('+').Select(x => x.Trim()).ToArray()));

			}
			draw(false);
		}

		void draw(bool actionType)
		{
			Bitmap bmp = new Bitmap(pictureBoxScheme.Width, pictureBoxScheme.Height);
			Graphics gr = Graphics.FromImage(bmp);

			Pen p = new Pen(Color.FromArgb(0, 0, 255));
			Brush b = new SolidBrush(Color.FromArgb(0, 0, 255));

			
			for (int i = 10; i < 80; i += 20) // Делает линии А B C D
			{
				gr.DrawLine(p, i, 20, i, pictureBoxScheme.Height);
				gr.DrawString(ABCD[(i - 10) / 20], new Font("Arial", 10), b, i - 5, 5);
			}

			for (int i = 20; i < 90; i += 20) // Делает линии -А -B -C -D
			{
				gr.DrawLine(p, i - 10, 25, i, 25);
				gr.DrawLine(p, i, 25, i, 35);
				gr.DrawLine(p, i, 50, i, pictureBoxScheme.Height);
				gr.DrawRectangle(p, i - 5, 35, 10, 10);
				gr.DrawEllipse(p, i - 3, 45, 5, 5);
			}

			int h = 60; // Высота линии
			List<int> ps = new List<int>(); // Список высот линий для вентилей

			foreach (string s in terms) // Для каждого терма в списке
			{

				for (int i = 0; i < 4; i++) // Для каждого значения в терме рисуется линия в сторону вентиля
				{
					if (s[i] == '0')
					{
						gr.DrawLine(p, 20 + i * 20, h, 100, h);
						h += 5;
					}
					if (s[i] == '1')
					{
						gr.DrawLine(p, 10 + i * 20, h, 100, h);
						h += 5;
					}
				}

				// Рисует вентиль:
				b = new SolidBrush(Color.FromArgb(255, 255, 0));
				gr.FillRectangle(b, 100, h - 20, 20, 20);
				b = new SolidBrush(Color.FromArgb(0, 0, 255));
				if (actionType)
					gr.DrawString("&", new Font("Arial", 10), b, 100, h - 20);
				else gr.DrawString("1", new Font("Arial", 10), b, 100, h - 20);
				
				ps.Add(h - 10);
				h += 30;
			}

			foreach (int i in ps) // Делает линии для обьединяющего вентиля
			{
				gr.DrawLine(p, 120, i, 140, i);
			}
			gr.DrawLine(p, 140, ps[0], 140, ps[ps.Count - 1]);
			gr.DrawLine(p, 140, ps[ps.Count / 2], 150, ps[ps.Count / 2]);

			// Рисует обьединяющий вентиль:
			b = new SolidBrush(Color.FromArgb(255, 255, 0));
			gr.FillRectangle(b, 150, ps[ps.Count / 2] - 10, 20, 20);
			b = new SolidBrush(Color.FromArgb(0, 0, 255));
			gr.DrawLine(p, 170, ps[ps.Count / 2], 180, ps[ps.Count / 2]);
			if (actionType)
				gr.DrawString("1", new Font("Arial", 10), b, 150, ps[ps.Count / 2] - 10);
			else gr.DrawString("&", new Font("Arial", 10), b, 150, ps[ps.Count / 2] - 10);

			pictureBoxScheme.Image = bmp;

		}
	}
}
