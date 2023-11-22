using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.Servicos
{
    public static class Validacao_Eventos
    {
        public static void PermitirCTRL_Letras(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = false;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.SuppressKeyPress = false; // Permitir teclas de seta
            }
            else
            {
                if (!char.IsLetter((char)e.KeyCode) && e.KeyCode != Keys.Back)
                {
                    e.SuppressKeyPress = true;
                }
            }
        }
        public static void PermitirCTRL_SemEspaco(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = false;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.SuppressKeyPress = false; // Permitir teclas de seta
            }
            else
            {
                if (e.KeyCode != Keys.Back && e.KeyCode == Keys.Space)
                {
                    e.SuppressKeyPress = true;
                }
            }
        }
        public static void PermitirCTRL_LetrasEspacos(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = false;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.SuppressKeyPress = false; // Permitir teclas de seta
            }
            else
            {
                if (!char.IsLetter((char)e.KeyCode) && e.KeyCode != Keys.Back && e.KeyCode != Keys.Space)
                {
                    e.SuppressKeyPress = true;
                }
            }
        }
        public static void PermitirCTRL_LetrasNumeros(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = false;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.SuppressKeyPress = false; // Permitir teclas de seta
            }
            else
            {
                if (!char.IsLetterOrDigit((char)e.KeyCode) && e.KeyCode != Keys.Back)
                {
                    e.SuppressKeyPress = true;
                }
            }
        }
        public static void PermitirCTRL_LetrasNumerosEspacos(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = false;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.SuppressKeyPress = false; // Permitir teclas de seta
            }
            else
            {
                if (!char.IsLetterOrDigit((char)e.KeyCode) && e.KeyCode != Keys.Back && e.KeyCode != Keys.Space)
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        public static void VerificarConteudoCampo_Letras(TextBox txtCampo)
        {
            string texto = txtCampo.Text;

            txtCampo.Text = string.Concat(texto.Where(char.IsLetter));
        }

        public static void VerificarConteudoCampo_SemEspacos(TextBox txtCampo)
        {
            string texto = txtCampo.Text;

            txtCampo.Text = string.Concat(texto.Where(c => !char.IsWhiteSpace(c)));
        }
        public static void VerificarConteudoCampo_LetrasEspacos(TextBox txtCampo)
        {
            string texto = txtCampo.Text;

            txtCampo.Text = string.Concat(texto.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)));
        }
        public static void VerificarConteudoCampo_LetrasNumeros(TextBox txtCampo)
        {
            string texto = txtCampo.Text;

            txtCampo.Text = string.Concat(texto.Where(char.IsLetterOrDigit));
        }
        public static void VerificarConteudoCampo_LetrasNumerosEspacos(TextBox txtCampo)
        {
            string texto = txtCampo.Text;

            txtCampo.Text = string.Concat(texto.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)));
        }
    }
}
